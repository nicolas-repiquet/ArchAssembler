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
using System.IO;

namespace ArchAssembler.Elements
{
    /// <summary>
    /// Bulk data as an array of bytes
    /// </summary>
    public sealed class ByteArrayElement : ConcreteElement
    {
        private readonly byte[] m_bytes;

        public ByteArrayElement(Byte[] bytes)
        {
            if (bytes == null) throw new ArgumentException("bytes");

            m_bytes = bytes;
        }

        public byte[] Bytes { get { return m_bytes; } }

        internal override uint ComputeSize(IAssemblingContext context)
        {
            return (uint) m_bytes.Length;
        }

        internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_bytes, 0, m_bytes.Length);
        }
    }
}