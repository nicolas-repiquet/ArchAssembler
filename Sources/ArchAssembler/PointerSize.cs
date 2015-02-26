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

namespace ArchAssembler
{
    /// <summary>
    /// Size of a memory address
    /// </summary>
    public abstract class PointerSize
    {
        /// <summary>
        /// 32 bits memory addresses
        /// </summary>
        public static readonly PointerSize P32 = new PointerSize32();

        /// <summary>
        /// 64 bits memory addresses
        /// </summary>
        public static readonly PointerSize P64 = new PointerSize64();

        // ********************************************************************

        private readonly uint m_bits;
        private readonly uint m_bytes;

        private PointerSize(uint bits, uint bytes)
        {
            m_bits = bits;
            m_bytes = bytes;
        }

        /// <summary>
        /// Number of bits
        /// </summary>
        public uint Bits
        {
            get { return m_bits; }
        }

        /// <summary>
        /// Number of bytes
        /// </summary>
        public uint Bytes
        {
            get { return m_bytes; }
        }

        internal abstract void WriteTo(BinaryWriter writer, ulong value);

        #region Nested type: PointerSize32

        private sealed class PointerSize32 : PointerSize
        {
            public PointerSize32()
                : base(32, 4)
            {
            }

            internal override void WriteTo(BinaryWriter writer, ulong value)
            {
                writer.Write((uint) value);
            }
        }

        #endregion

        #region Nested type: PointerSize64

        private sealed class PointerSize64 : PointerSize
        {
            public PointerSize64()
                : base(64, 8)
            {
            }

            internal override void WriteTo(BinaryWriter writer, ulong value)
            {
                writer.Write(value);
            }
        }

        #endregion
    }
}