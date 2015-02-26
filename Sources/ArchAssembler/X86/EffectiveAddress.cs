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
using ArchAssembler.Elements;

namespace ArchAssembler.X86
{
    public struct EffectiveAddress
    {
        private readonly Register32 m_base;
        private readonly Register32 m_index;
        private readonly Element m_offsetElement;
        private readonly Int32 m_offsetValue;
        private readonly byte m_indexScaleFactor;

        public EffectiveAddress(Register32 _base)
        {
            m_base = _base;
            m_index = null;
            m_indexScaleFactor = 1;
            m_offsetElement = null;
            m_offsetValue = 0;
        }

        public EffectiveAddress(Register32 _base, Register32 index)
        {
            m_base = _base;
            m_index = index;
            m_indexScaleFactor = 1;
            m_offsetElement = null;
            m_offsetValue = 0;
        }

        public EffectiveAddress(Register32 _base, Register32 index, byte indexScaleFactor)
        {
            m_base = _base;
            m_index = index;
            m_indexScaleFactor = indexScaleFactor;
            m_offsetElement = null;
            m_offsetValue = 0;
        }

        public EffectiveAddress(Element offsetElement)
        {
            m_base = null;
            m_index = null;
            m_indexScaleFactor = 1;
            m_offsetElement = offsetElement;
            m_offsetValue = 0;
        }

        public EffectiveAddress(Element offsetElement, Register32 index)
        {
            m_base = null;
            m_index = index;
            m_indexScaleFactor = 1;
            m_offsetElement = offsetElement;
            m_offsetValue = 0;
        }

        public EffectiveAddress(Element offsetElement, Register32 index, byte indexScaleFactor)
        {
            m_base = null;
            m_index = index;
            m_indexScaleFactor = indexScaleFactor;
            m_offsetElement = offsetElement;
            m_offsetValue = 0;
        }

        public EffectiveAddress(Element offsetElement, Int32 offsetValue)
        {
            m_base = null;
            m_index = null;
            m_indexScaleFactor = 1;
            m_offsetElement = offsetElement;
            m_offsetValue = offsetValue;
        }

        public EffectiveAddress(Register32 _base, Register32 index, byte indexScaleFactor, Element offsetElement, Int32 offsetValue)
        {
            m_base = _base;
            m_index = index;
            m_indexScaleFactor = indexScaleFactor;
            m_offsetElement = offsetElement;
            m_offsetValue = offsetValue;
        }

        public Register32 Base { get { return m_base; } }
        public Register32 Index { get { return m_index; } }
        public byte IndexScaleFactor { get { return m_indexScaleFactor; } }
        public Element OffsetElement { get { return m_offsetElement; } }
        public Int32 OffsetValue { get { return m_offsetValue; } }
    }
}
