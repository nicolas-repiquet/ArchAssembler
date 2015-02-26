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

using System.IO;

namespace ArchAssembler.Elements
{
    /// <summary>
    /// Align the next element on a boundary
    /// </summary>
    public sealed class AlignmentElement : ConcreteElement
    {
        private readonly uint m_fileAlignment;
        private readonly uint m_memoryAlignment;
        private readonly byte m_padding;

        public AlignmentElement(uint fileAlignment, uint memoryAlignment, byte padding)
        {
            m_fileAlignment = fileAlignment;
            m_memoryAlignment = memoryAlignment;
            m_padding = padding;
        }

        public uint FileAlignment { get { return m_fileAlignment; } }
        public uint MemoryAlignment { get { return m_memoryAlignment; } }
        public byte Padding { get { return m_padding; } }

        internal override bool SizeDependsOnAddress
        {
            get { return true; }
        }

        internal override uint ComputeFileSize(IAssemblingContext context)
        {
            uint modulo = context.GetFileAddress(this)%m_fileAlignment;

            if (modulo == 0)
            {
                return 0;
            }

            return m_fileAlignment - modulo;
        }

        internal override uint ComputeMemorySize(IAssemblingContext context)
        {
            uint modulo = context.GetRelativeMemoryAddress(this)%m_memoryAlignment;

            return modulo == 0 ? 0 : m_memoryAlignment - modulo;
        }

        internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            uint size = context.GetFileSize(this);

            for (int i = 0; i < size; i++)
            {
                writer.Write(m_padding);
            }
        }
    }
}