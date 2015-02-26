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
    /// File size of an element as a 16 bits unsigned integer
    /// </summary>
    public sealed class FileSize16Element : ConcreteElement
    {
        private readonly Element m_target;

        public FileSize16Element(Element target)
        {
            m_target = target;
        }

        public Element Target { get { return m_target; } }

        internal override uint ComputeSize(IAssemblingContext context)
        {
            return 2;
        }

        internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            if (m_target != null)
            {
                writer.Write((UInt16) context.GetFileSize(m_target));
            }
            else
            {
                writer.Write((UInt16) 0);
            }
        }
    }
}