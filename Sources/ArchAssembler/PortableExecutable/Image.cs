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

namespace ArchAssembler.PortableExecutable
{
    /// <summary>
    /// Base class for a PE image
    /// </summary>
    public abstract class Image
    {
        // ********************************************************************

        private const uint c_signature = 0x00004550; // PE\0\0

        private static readonly byte[] s_dosHeader = {
                                                         0x4d, 0x5a, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00,
                                                         0x00, 0x00, 0xff, 0xff, 0x00, 0x00,
                                                         0xb8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00,
                                                         0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                         0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                         0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                         0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                         0x00, 0x00
                                                     };

        private static readonly byte[] s_dosStub = {
                                                       0x0e, 0x1f, 0xba, 0x0e, 0x00, 0xb4, 0x09, 0xcd, 0x21, 0xb8, 0x01,
                                                       0x4c, 0xcd, 0x21, 0x54, 0x68,
                                                       0x69, 0x73, 0x20, 0x70, 0x72, 0x6f, 0x67, 0x72, 0x61, 0x6d, 0x20,
                                                       0x63, 0x61, 0x6e, 0x6e, 0x6f,
                                                       0x74, 0x20, 0x62, 0x65, 0x20, 0x72, 0x75, 0x6e, 0x20, 0x69, 0x6e,
                                                       0x20, 0x44, 0x4f, 0x53, 0x20,
                                                       0x6d, 0x6f, 0x64, 0x65, 0x2e, 0x0d, 0x0d, 0x0a, 0x24, 0x00, 0x00,
                                                       0x00, 0x00, 0x00, 0x00, 0x00
                                                   };

        private readonly ImageDirectories m_directories;
        private readonly Element[] m_directoryElements;
        private readonly List<ImageSection> m_sections;

        private Element m_entryPoint;
        private uint m_fileAlignment;

        private ulong m_imageBase;
        private uint m_sectionAlignment;
        private ulong m_sizeOfHeapCommit;
        private ulong m_sizeOfHeapReserve;
        private ulong m_sizeOfStackCommit;
        private ulong m_sizeOfStackReserve;
        private ImageSubsystem m_subsystem;
        private ImageType m_type;

        // ********************************************************************

        internal Image()
        {
            m_directoryElements = new Element[16];
            m_directories = new ImageDirectories(this);
            m_sections = new List<ImageSection>();

            m_type = ImageType.Executable;
            m_subsystem = ImageSubsystem.Console;

            m_entryPoint = null;

            m_imageBase = 0;
            m_sectionAlignment = 0x1000;
            m_fileAlignment = 0x200;
            m_sizeOfStackReserve = 0x40000;
            m_sizeOfStackCommit = 0x1000;
            m_sizeOfHeapReserve = 0x100000;
            m_sizeOfHeapCommit = 0x1000;
        }

        // ********************************************************************

        /// <summary>
        /// PE Directories
        /// </summary>
        public IImageDirectories Directories
        {
            get { return m_directories; }
        }

        /// <summary>
        /// PE Sections
        /// </summary>
        public IList<ImageSection> Sections
        {
            get { return m_sections; }
        }

        /// <summary>
        /// Type of image
        /// </summary>
        public ImageType Type
        {
            get { return m_type; }
            set
            {
                if (value != null)
                {
                    m_type = value;
                }
            }
        }

        /// <summary>
        /// Target subsystem
        /// </summary>
        public ImageSubsystem Subsystem
        {
            get { return m_subsystem; }
            set
            {
                if (value != null)
                {
                    m_subsystem = value;
                }
            }
        }

        /// <summary>
        /// Image entry point
        /// </summary>
        public Element EntryPoint
        {
            get { return m_entryPoint; }
            set { m_entryPoint = value; }
        }

        /// <summary>
        /// Memory address at which the image will be loaded
        /// </summary>
        public ulong ImageBase
        {
            get { return m_imageBase; }
            set { m_imageBase = value; }
        }

        /// <summary>
        /// Alignment of sections in memory
        /// </summary>
        public uint SectionAlignment
        {
            get { return m_sectionAlignment; }
            set { m_sectionAlignment = value; }
        }

        /// <summary>
        /// Alignment of sections within the file
        /// </summary>
        public uint FileAlignment
        {
            get { return m_fileAlignment; }
            set { m_fileAlignment = value; }
        }

        /// <summary>
        /// Reserved memory for the stack
        /// </summary>
        public ulong SizeOfStackReserve
        {
            get { return m_sizeOfStackReserve; }
            set { m_sizeOfStackReserve = value; }
        }

        /// <summary>
        /// Commited memory for the stack
        /// </summary>
        public ulong SizeOfStackCommit
        {
            get { return m_sizeOfStackCommit; }
            set { m_sizeOfStackCommit = value; }
        }

        /// <summary>
        /// Reserved memory for the heap
        /// </summary>
        public ulong SizeOfHeapReserve
        {
            get { return m_sizeOfHeapReserve; }
            set { m_sizeOfHeapReserve = value; }
        }

        /// <summary>
        /// Commited memory for the heap
        /// </summary>
        public ulong SizeOfHeapCommit
        {
            get { return m_sizeOfHeapCommit; }
            set { m_sizeOfHeapCommit = value; }
        }

        // ********************************************************************
        // ********************************************************************

        internal abstract UInt16 GetMachine();
        internal abstract UInt16 GetMagic();
        internal abstract bool IsBaseOfDataRequired();
        internal abstract PointerSize GetPointerSize();

        private ulong GetImageBase()
        {
            return m_imageBase == 0 ? m_type.DefaultImageBase : m_imageBase;
        }

        /// <summary>
        /// Assemble the image, and write it to the given BinaryWriter
        /// </summary>
        /// <param name="writer"Writer to write the image to></param>
        public void Assemble(BinaryWriter writer)
        {
            uint now = (uint) (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

            ElementCollection image = new ElementCollection();
            ElementCollection headers = image.ElementCollection();
            ElementCollection headersDos = headers.ElementCollection();
            ElementCollection headersNt = headers.ElementCollection();
            ElementCollection headersNtSignature = headersNt.ElementCollection();
            ElementCollection headersNtFile = headersNt.ElementCollection();
            ElementCollection headersNtOptional = headersNt.ElementCollection();
            ElementCollection headersSections = headers.ElementCollection();
            ElementCollection sections = image.ElementCollection();

            // IMAGE > HEADERS > DOS
            headersDos.ByteArray(s_dosHeader);
            headersDos.FileAddress32(headersNt);
            headersDos.ByteArray(s_dosStub);
            headersDos.Alignment(8, 0);

            // IMAGE > HEADERS > NT > SIGNATURE
            headersNtSignature.UInt32(c_signature);

            // IMAGE > HEADERS > NT > FILE
            headersNtFile.UInt16(GetMachine()); // Machine
            headersNtFile.UInt16((UInt16) m_sections.Count); // NumberOfSection
            headersNtFile.UInt32(now); // TimeDateStamp
            headersNtFile.UInt32(0); // PointerToSymbolTable
            headersNtFile.UInt32(0); // NumberOfSymbols
            headersNtFile.FileSize16(headersNtOptional); // SizeOfOptionalHeader
            headersNtFile.UInt16(0x010F); // Characteristics

            // IMAGE > HEADERS > NT > OPTIONAL
            headersNtOptional.UInt16(GetMagic());
            headersNtOptional.UInt8(0); // MajorLinkerVersion
            headersNtOptional.UInt8(0); // MinorLinkerVersion
            headersNtOptional.Elements.Add(new SizeOfCodeSectionsElement(m_sections)); // SizeOfCode
            headersNtOptional.Elements.Add(new SizeOfInitializedDataSectionsElement(m_sections));
            // SizeOfInitializedData
            headersNtOptional.Elements.Add(new SizeOfUninitializedDataSectionsElement(m_sections));
            // SizeOfUninitializedData
            headersNtOptional.RelativeMemoryAddress32(m_entryPoint); // AddressOfEntryPoint

            headersNtOptional.Elements.Add(new BaseOfCodeSectionsElement(m_sections)); // BaseOfCode

            if (IsBaseOfDataRequired())
            {
                headersNtOptional.Elements.Add(new BaseOfInitializedDataSectionsElement(m_sections)); // BaseOfData
            }

            headersNtOptional.UIntP(GetImageBase()); // ImageBase
            headersNtOptional.UInt32(m_sectionAlignment); // SectionAlignment
            headersNtOptional.UInt32(m_fileAlignment); // FileAlignment

            headersNtOptional.UInt16(0); // MajorOperatingSystemVersion
            headersNtOptional.UInt16(0); // MinorOperatingSystemVersion

            headersNtOptional.UInt16(0); // MajorImageVersion
            headersNtOptional.UInt16(0); // MinorImageVersion

            headersNtOptional.UInt16((UInt16) m_subsystem.Major); // MajorSubsystemVersion
            headersNtOptional.UInt16((UInt16) m_subsystem.Minor); // MinorSubsystemVersion

            headersNtOptional.UInt32(0); // Win32VersionValue

            headersNtOptional.MemorySize32(image); // SizeOfImage
            headersNtOptional.FileSize32(headers); // SizeOfHeaders

            headersNtOptional.UInt32(0); // CheckSum

            headersNtOptional.UInt16((UInt16) m_subsystem.Id); // Subsystem
            headersNtOptional.UInt16(0x0400); // DllCharacteristics

            headersNtOptional.UIntP(m_sizeOfStackReserve); // SizeOfStackReserve
            headersNtOptional.UIntP(m_sizeOfStackCommit); // SizeOfStackCommit
            headersNtOptional.UIntP(m_sizeOfHeapReserve); // SizeOfHeapReserve
            headersNtOptional.UIntP(m_sizeOfHeapCommit); // SizeOfHeapCommit

            headersNtOptional.UInt32(0x00000000); // LoaderFlags
            headersNtOptional.UInt32((UInt32) m_directoryElements.Length); // NumberOfRvaAndSizes

            foreach (Element directoryElement in m_directoryElements)
            {
                if (directoryElement == null)
                {
                    headersNtOptional.UInt32(0); // VirtualAddress
                    headersNtOptional.UInt32(0); // Size
                }
                else
                {
                    headersNtOptional.RelativeMemoryAddress32(directoryElement); // VirtualAddress
                    headersNtOptional.MemorySize32(directoryElement); // Size
                }
            }

            // IMAGE > HEADERS > SECTIONS

            foreach (ImageSection section in m_sections)
            {
                headersSections.FixedSizeString(section.Name, 8);
                headersSections.MemorySize32(section); // VirtualSize
                headersSections.RelativeMemoryAddress32(section); // VirtualAddress
                headersSections.FileSize32(section); // SizeOfRawData
                headersSections.FileAddress32(section); // PointerToRawData
                headersSections.UInt32(0); // PointerToRelocations
                headersSections.UInt32(0); // PointerToLinenumbers
                headersSections.UInt16(0); // NumberOfRelocations
                headersSections.UInt16(0); // NumberOfLinenumbers
                headersSections.UInt32(section.Type.Characteristics); // Characteristics
            }

            // IMAGE > SECTIONS
            foreach (ImageSection section in m_sections)
            {
                sections.Alignment(m_fileAlignment, m_sectionAlignment, 0);
                sections.Elements.Add(section);
            }


            (new Assembler()).Assemble(image, GetImageBase(), GetPointerSize(), writer);
        }

        #region Nested type: BaseOfCodeSectionsElement

        private sealed class BaseOfCodeSectionsElement : BaseOfSectionsElement
        {
            public BaseOfCodeSectionsElement(List<ImageSection> sections)
                : base(sections)
            {
            }

            protected override bool Match(ImageSection section)
            {
                return section.Type.ContainsCode;
            }
        }

        #endregion

        #region Nested type: BaseOfInitializedDataSectionsElement

        private sealed class BaseOfInitializedDataSectionsElement : BaseOfSectionsElement
        {
            public BaseOfInitializedDataSectionsElement(List<ImageSection> sections)
                : base(sections)
            {
            }

            protected override bool Match(ImageSection section)
            {
                return section.Type.ContainsInitializedData;
            }
        }

        #endregion

        #region Nested type: BaseOfSectionsElement

        private abstract class BaseOfSectionsElement : ConcreteElement
        {
            private readonly List<ImageSection> m_sections;

            protected BaseOfSectionsElement(List<ImageSection> sections)
            {
                m_sections = sections;
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                return 4;
            }

            protected abstract bool Match(ImageSection section);

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                uint value = 0;

                foreach (ImageSection section in m_sections)
                {
                    if (Match(section))
                    {
                        value = value == 0
                                      ? context.GetRelativeMemoryAddress(section)
                                      : Math.Min(value, context.GetRelativeMemoryAddress(section));
                    }
                }

                writer.Write(value);
            }
        }

        #endregion

        #region Nested type: ImageDirectories

        private sealed class ImageDirectories : IImageDirectories
        {
            private readonly Image m_image;

            internal ImageDirectories(Image image)
            {
                m_image = image;
            }

            #region IImageDirectories Members

            public Element this[ImageDirectory directory]
            {
                get { return directory != null ? m_image.m_directoryElements[directory.Index] : null; }
                set
                {
                    if (directory != null)
                    {
                        m_image.m_directoryElements[directory.Index] = value;
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Nested type: SizeOfCodeSectionsElement

        private sealed class SizeOfCodeSectionsElement : SizeOfSectionsElement
        {
            public SizeOfCodeSectionsElement(List<ImageSection> sections)
                : base(sections)
            {
            }

            protected override bool Match(ImageSection section)
            {
                return section.Type.ContainsCode;
            }
        }

        #endregion

        #region Nested type: SizeOfInitializedDataSectionsElement

        private sealed class SizeOfInitializedDataSectionsElement : SizeOfSectionsElement
        {
            public SizeOfInitializedDataSectionsElement(List<ImageSection> sections)
                : base(sections)
            {
            }

            protected override bool Match(ImageSection section)
            {
                return section.Type.ContainsInitializedData;
            }
        }

        #endregion

        #region Nested type: SizeOfSectionsElement

        private abstract class SizeOfSectionsElement : ConcreteElement
        {
            private readonly List<ImageSection> m_sections;

            protected SizeOfSectionsElement(List<ImageSection> sections)
            {
                m_sections = sections;
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                return 4;
            }

            protected abstract bool Match(ImageSection section);

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                uint value = 0;

                foreach (ImageSection section in m_sections)
                {
                    if (Match(section))
                    {
                        value += context.GetFileSize(section);
                    }
                }

                writer.Write(value);
            }
        }

        #endregion

        #region Nested type: SizeOfUninitializedDataSectionsElement

        private sealed class SizeOfUninitializedDataSectionsElement : SizeOfSectionsElement
        {
            public SizeOfUninitializedDataSectionsElement(List<ImageSection> sections)
                : base(sections)
            {
            }

            protected override bool Match(ImageSection section)
            {
                return section.Type.ContainsUninitializedData;
            }
        }

        #endregion
    }
}