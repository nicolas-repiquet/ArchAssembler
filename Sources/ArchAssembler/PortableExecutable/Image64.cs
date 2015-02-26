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


namespace ArchAssembler.PortableExecutable
{
    /// <summary>
    /// PE32+ image, aka Windows 64bit executable
    /// </summary>
    public sealed class Image64 : Image
    {
        private const UInt16 c_imageFileMachineAmd64 = 0x8664;
        private const UInt16 c_magicPe32Plus = 0x20b;

        internal override UInt16 GetMachine()
        {
            return c_imageFileMachineAmd64;
        }

        internal override ushort GetMagic()
        {
            return c_magicPe32Plus;
        }

        internal override bool IsBaseOfDataRequired()
        {
            return false;
        }

        internal override PointerSize GetPointerSize()
        {
            return PointerSize.P64;
        }
    }
}