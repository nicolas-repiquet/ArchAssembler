// ****************************************************************************
// * Copyright (c) 2011 Nicolas Repiquet
// *
// * Permission is hereby granted, free of charge, to any person obtaining a
// * copy of this software and associated documentation files (the "Software"),
// * to deal in the Software without restriction, including without limitation
// * the rights to use, copy, modify, merge, publish, distribute, sublicense,
// * and/or sell copies of the Software, and to permit persons to whom the
// * Software is furnished to do so, subject to the following conditions:
// *
// * The above copyright notice and this permission notice shall be included in
// * all copies or substantial portions of the Software.
// *
// * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// * DEALINGS IN THE SOFTWARE.
// *
// ****************************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using ArchAssembler.Elements;

namespace ArchAssembler
{
    /// <summary>
    /// Assemble elements
    /// </summary>
    public sealed class Assembler
    {
        private static void CreateTags(IDictionary<Element, Tag> tagMap, ICollection<Tag> tagList,
                                       AssemblingContext context, Element element, BeginningTag parent)
        {
            if (element is ConcreteElement)
            {
                ElementTag tag = new ElementTag(tagList.Count, context, parent, (ConcreteElement) element);
                tagMap.Add(element, tag);
                tagList.Add(tag);
            }
            else if (element is CompositeElement)
            {
                CompositeElement compositeElement = (CompositeElement) element;

                BeginningTag beginningTag = new BeginningTag(tagList.Count, context, parent, compositeElement);
                tagMap.Add(element, beginningTag);
                tagList.Add(beginningTag);

                foreach (Element e in compositeElement.GetElements())
                {
                    CreateTags(tagMap, tagList, context, e, beginningTag);
                }

                EndTag endTag = new EndTag(tagList.Count, context, parent, beginningTag);
                tagList.Add(endTag);
            }
        }

        /// <summary>
        /// Assemble, that is measure, arrange, and write elements in the given BinaryWriter
        /// </summary>
        /// <param name="element">Element to assemble</param>
        /// <param name="baseMemoryAddress">Memory address at which the program will be loaded</param>
        /// <param name="pointerSize">Size of a memory address</param>
        /// <param name="writer">Writer to write the result to</param>
        public void Assemble(Element element, ulong baseMemoryAddress, PointerSize pointerSize, BinaryWriter writer)
        {
            Dictionary<Element, Tag> tagMap = new Dictionary<Element, Tag>();
            List<Tag> tagList = new List<Tag>();
            AssemblingContext context = new AssemblingContext(tagMap, baseMemoryAddress, pointerSize);

            CreateTags(tagMap, tagList, context, element, null);

            foreach (Tag tag in tagList)
            {
                tag.RegisterDependencies();
            }

            uint fileAddress = 0;
            uint relativeMemoryAddress = 0;

            for (int i = 0; i < tagList.Count; i++)
            {
                Tag tag = tagList[i];

                if (tag.SetAddresses(fileAddress, relativeMemoryAddress) && tag.Observers != null)
                {
                    int index = int.MaxValue;

                    foreach (ElementTag observer in tag.Observers)
                    {
                        observer.InvalidateMeasure();

                        if (observer.Index < i && observer.Measure())
                        {
                            index = Math.Min(index, observer.Index);
                        }
                    }

                    if (index < i)
                    {
                        i = index;
                        tag = tagList[i];
                        fileAddress = tag.FileAddress;
                        relativeMemoryAddress = tag.RelativeMemoryAddress;
                    }
                }

                tag.Measure();

                fileAddress += tag.RealFileSize;
                relativeMemoryAddress += tag.RealMemorySize;
            }

            long baseStreamPosition = writer.BaseStream.Position;

            foreach (Tag tag in tagList)
            {
                tag.WriteTo(writer);

                baseStreamPosition += tag.RealFileSize;

                if (baseStreamPosition != writer.BaseStream.Position)
                {
                    throw new Exception();
                }
            }

            writer.Flush();
        }

        #region Nested type: AssemblingContext

        private sealed class AssemblingContext : IAssemblingContext
        {
            private readonly ulong m_baseMemoryAddress;
            private readonly PointerSize m_pointerSize;
            private readonly Dictionary<Element, Tag> m_tagMap;

            public AssemblingContext(Dictionary<Element, Tag> tagMap, ulong baseMemoryAddress, PointerSize pointerSize)
            {
                m_tagMap = tagMap;
                m_baseMemoryAddress = baseMemoryAddress;
                m_pointerSize = pointerSize;
            }

            #region IAssemblingContext Members

            public CompositeElement GetParent(Element element)
            {
                Tag tag = GetTag(element);

                if (tag == null)
                {
                    return null;
                }

                return tag.Parent == null ? null : tag.Parent.CompositeElement;
            }

            public uint GetFileAddress(Element element)
            {
                Tag tag = GetTag(element);

                return tag == null ? 0 : tag.FileAddress;
            }

            public uint GetFileSize(Element element)
            {
                Tag tag = GetTag(element);

                return tag == null ? 0 : tag.FileSize;
            }

            public uint GetRelativeMemoryAddress(Element element)
            {
                Tag tag = GetTag(element);

                return tag == null ? 0 : tag.RelativeMemoryAddress;
            }

            public uint GetMemorySize(Element element)
            {
                Tag tag = GetTag(element);

                return tag == null ? 0 : tag.MemorySize;
            }

            public ulong GetAbsoluteMemoryAddress(Element element)
            {
                return GetRelativeMemoryAddress(element) + m_baseMemoryAddress;
            }

            public PointerSize GetPointerSize()
            {
                return m_pointerSize;
            }

            public bool IsPositioned(Element element)
            {
                Tag tag = GetTag(element);

                return tag == null ? true : tag.IsPositioned;
            }

            #endregion

            public Tag GetTag(Element element)
            {
                Tag tag;

                return m_tagMap.TryGetValue(element, out tag) ? tag : null;
            }
        }

        #endregion

        #region Nested type: BeginningTag

        private sealed class BeginningTag : Tag
        {
            private readonly CompositeElement m_compositeElement;

            public BeginningTag(int index, AssemblingContext context, BeginningTag parent,
                                CompositeElement compositeElement)
                : base(index, context, parent)
            {
                m_compositeElement = compositeElement;
            }

            public override Element Element
            {
                get { return m_compositeElement; }
            }

            public CompositeElement CompositeElement
            {
                get { return m_compositeElement; }
            }

            public uint ContentFileSize { private get; set; }
            public uint ContentMemorySize { private get; set; }

            public override uint FileSize
            {
                get { return ContentFileSize; }
            }

            public override uint MemorySize
            {
                get { return ContentMemorySize; }
            }

            public override uint RealFileSize
            {
                get { return 0; }
            }

            public override uint RealMemorySize
            {
                get { return 0; }
            }

            public override bool Measure()
            {
                return false;
            }

            public override void RegisterDependencies()
            {
            }

            public override void WriteTo(BinaryWriter writer)
            {
            }
        }

        #endregion

        #region Nested type: ElementTag

        private sealed class ElementTag : Tag, IDependencyCollection
        {
            private readonly ConcreteElement m_concreteElement;
            private uint m_fileSize;
            private bool m_isMeasureValid;
            private uint m_memorySize;

            public ElementTag(int index, AssemblingContext context, BeginningTag parent, ConcreteElement concreteElement)
                : base(index, context, parent)
            {
                m_concreteElement = concreteElement;
                m_isMeasureValid = false;
            }

            public override Element Element
            {
                get { return m_concreteElement; }
            }

            public override uint FileSize
            {
                get { return m_fileSize; }
            }

            public override uint MemorySize
            {
                get { return m_memorySize; }
            }

            public override uint RealFileSize
            {
                get { return m_fileSize; }
            }

            public override uint RealMemorySize
            {
                get { return m_memorySize; }
            }

            #region IDependencyCollection Members

            public void Add(Element element)
            {
                Context.GetTag(element).AddObserver(this);
            }

            #endregion

            public void InvalidateMeasure()
            {
                m_isMeasureValid = false;
            }

            protected override void AddressesHaveChanged()
            {
                if (m_concreteElement.SizeDependsOnAddress)
                {
                    InvalidateMeasure();
                }
            }

            public override bool Measure()
            {
                if (!m_isMeasureValid)
                {
                    uint oldFileSize = m_fileSize;
                    uint oldMemorySize = m_memorySize;

                    m_fileSize = m_concreteElement.ComputeFileSize(Context);
                    m_memorySize = m_concreteElement.ComputeMemorySize(Context);

                    m_isMeasureValid = true;

                    return oldFileSize != m_fileSize || oldMemorySize != m_memorySize;
                }

                return false;
            }

            public override void RegisterDependencies()
            {
                m_concreteElement.RegisterDependencies(this);
            }

            public override void WriteTo(BinaryWriter writer)
            {
                m_concreteElement.WriteTo(writer, Context);
            }
        }

        #endregion

        #region Nested type: EndTag

        private sealed class EndTag : Tag
        {
            private readonly BeginningTag m_beginningTag;

            public EndTag(int index, AssemblingContext context, BeginningTag parent, BeginningTag beginningTag)
                : base(index, context, parent)
            {
                m_beginningTag = beginningTag;
            }

            public override Element Element
            {
                get { return m_beginningTag.Element; }
            }

            public override uint FileSize
            {
                get { throw new Exception(); }
            }

            public override uint MemorySize
            {
                get { throw new Exception(); }
            }

            public override uint RealFileSize
            {
                get { return 0; }
            }

            public override uint RealMemorySize
            {
                get { return 0; }
            }

            public override bool SetAddresses(uint fileAddress, uint relativeMemoryAddress)
            {
                bool result = base.SetAddresses(fileAddress, relativeMemoryAddress);

                m_beginningTag.ContentFileSize = fileAddress - m_beginningTag.FileAddress;
                m_beginningTag.ContentMemorySize = relativeMemoryAddress - m_beginningTag.RelativeMemoryAddress;

                return result;
            }

            public override bool Measure()
            {
                return false;
            }

            public override void RegisterDependencies()
            {
            }

            public override void WriteTo(BinaryWriter writer)
            {
            }
        }

        #endregion

        #region Nested type: Tag

        private abstract class Tag
        {
            private readonly AssemblingContext m_context;
            private readonly int m_index;
            private readonly BeginningTag m_parent;

            protected Tag(int index, AssemblingContext context, BeginningTag parent)
            {
                m_index = index;
                m_context = context;
                m_parent = parent;
            }

            public int Index
            {
                get { return m_index; }
            }

            protected AssemblingContext Context
            {
                get { return m_context; }
            }

            public BeginningTag Parent
            {
                get { return m_parent; }
            }

            public abstract Element Element { get; }

            public abstract uint FileSize { get; }
            public abstract uint MemorySize { get; }
            public abstract uint RealFileSize { get; }
            public abstract uint RealMemorySize { get; }

            public uint FileAddress { get; private set; }
            public uint RelativeMemoryAddress { get; private set; }
            public bool IsPositioned { get; private set; }
            public List<ElementTag> Observers { get; private set; }

            public virtual bool SetAddresses(uint fileAddress, uint relativeMemoryAddress)
            {
                if (!IsPositioned || fileAddress != FileAddress || relativeMemoryAddress != RelativeMemoryAddress)
                {
                    IsPositioned = true;

                    FileAddress = fileAddress;
                    RelativeMemoryAddress = relativeMemoryAddress;

                    AddressesHaveChanged();

                    return true;
                }

                return false;
            }

            protected virtual void AddressesHaveChanged()
            {
            }

            public abstract bool Measure();

            public abstract void RegisterDependencies();

            public void AddObserver(ElementTag observer)
            {
                if (Observers == null)
                {
                    Observers = new List<ElementTag>();
                }

                Observers.Add(observer);
            }

            public override string ToString()
            {
                return string.Format("{0}: {1}", m_index, Element);
            }

            public abstract void WriteTo(BinaryWriter writer);
        }

        #endregion
    }
}