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


namespace ArchAssembler.X86
{
    public abstract class Register
    {
        private readonly int m_id;
        private readonly string m_name;

        internal Register(int id, string name)
        {
            m_id = id;
            m_name = name;
        }

        public int Id
        {
            get { return m_id; }
        }

        public string Name
        {
            get { return m_name; }
        }

        public override string ToString()
        {
            return m_name;
        }
    }

    /// <summary>
    /// X86 8bits general purpose registers
    /// </summary>
    public sealed class Register8 : Register
    {
        public static readonly Register8 AL = new Register8(0, "AL");
        public static readonly Register8 CL = new Register8(1, "CL");
        public static readonly Register8 DL = new Register8(2, "DL");
        public static readonly Register8 BL = new Register8(3, "BL");
        public static readonly Register8 AH = new Register8(4, "AH");
        public static readonly Register8 CH = new Register8(5, "CH");
        public static readonly Register8 DH = new Register8(6, "DH");
        public static readonly Register8 BH = new Register8(7, "BH");

        private Register8(int id, string name)
            : base(id, name)
        {
        }
    }

    /// <summary>
    /// X86 16bits general purpose registers
    /// </summary>
    public sealed class Register16 : Register
    {
        public static readonly Register16 AX = new Register16(0, "AX");
        public static readonly Register16 CX = new Register16(1, "CX");
        public static readonly Register16 DX = new Register16(2, "DX");
        public static readonly Register16 BX = new Register16(3, "BX");
        public static readonly Register16 SP = new Register16(4, "SP");
        public static readonly Register16 BP = new Register16(5, "BP");
        public static readonly Register16 SI = new Register16(6, "SI");
        public static readonly Register16 DI = new Register16(7, "DI");

        private Register16(int id, string name)
            : base(id, name)
        {
        }
    }

    /// <summary>
    /// X86 32bits general purpose registers
    /// </summary>
    public sealed class Register32 : Register
    {
        public static readonly Register32 EAX = new Register32(0, "EAX");
        public static readonly Register32 ECX = new Register32(1, "ECX");
        public static readonly Register32 EDX = new Register32(2, "EDX");
        public static readonly Register32 EBX = new Register32(3, "EBX");
        public static readonly Register32 ESP = new Register32(4, "ESP");
        public static readonly Register32 EBP = new Register32(5, "EBP");
        public static readonly Register32 ESI = new Register32(6, "ESI");
        public static readonly Register32 EDI = new Register32(7, "EDI");

        private Register32(int id, string name)
            : base(id, name)
        {
        }
    }

    /// <summary>
    /// X87 80bits floating point registers
    /// </summary>
    public sealed class Register80 : Register
    {
        public static readonly Register80 ST0 = new Register80(0, "ST0");
        public static readonly Register80 ST1 = new Register80(1, "ST1");
        public static readonly Register80 ST2 = new Register80(2, "ST2");
        public static readonly Register80 ST3 = new Register80(3, "ST3");
        public static readonly Register80 ST4 = new Register80(4, "ST4");
        public static readonly Register80 ST5 = new Register80(5, "ST5");
        public static readonly Register80 ST6 = new Register80(6, "ST6");
        public static readonly Register80 ST7 = new Register80(7, "ST7");

        private Register80(int id, string name)
            : base(id, name)
        {
        }
    }
}