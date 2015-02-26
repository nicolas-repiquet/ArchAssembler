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
    /// A string of ASCII characters with a fixed size. If value is longer than length, it is chopped. If it is
    /// shorter, it is padded with null characters
    /// </summary>
    public sealed class VariableSizeStringElement : ConcreteElement
    {
        private readonly string m_value;

        public VariableSizeStringElement(string value)
        {
            m_value = value;
        }

        public string Value { get { return m_value; } }

        internal override uint ComputeSize(IAssemblingContext context)
        {
            return (uint) m_value.Length + 1;
        }

        internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            foreach (char c in m_value)
            {
                writer.Write((byte) c);
            }

            writer.Write((byte) 0);
        }
    }
}