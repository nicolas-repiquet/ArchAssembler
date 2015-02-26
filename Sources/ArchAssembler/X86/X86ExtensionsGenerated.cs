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

// ****************************************************************************
// *              /!\   GENERATED FILE - DO NOT EDIT   /!\
// ****************************************************************************

using System;
using ArchAssembler.Elements;

namespace ArchAssembler.X86
{
    public static partial class X86Extensions
    {

        /// <summary>
        /// ASCII Adjust After Addition
        /// </summary>
        public static Element Aaa(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x37, null));
        }


        /// <summary>
        /// ASCII Adjust AX Before Division
        /// </summary>
        public static Element Aad(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd5, new OpcodeInstruction(0xa, null)));
        }


        /// <summary>
        /// ASCII Adjust AX Before Division
        /// </summary>
        public static Element Aad(this ElementCollection collection, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xd5, new ImmediateUInt8Instruction(value, null)));
        }


        /// <summary>
        /// ASCII Adjust AX After Multiply
        /// </summary>
        public static Element Aam(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd4, new OpcodeInstruction(0xa, null)));
        }


        /// <summary>
        /// ASCII Adjust AX After Multiply
        /// </summary>
        public static Element Aam(this ElementCollection collection, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xd4, new ImmediateUInt8Instruction(value, null)));
        }


        /// <summary>
        /// ASCII Adjust AL After Subtraction
        /// </summary>
        public static Element Aas(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x3f, null));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x10, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x10, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x11, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x11, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x11, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x11, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x12, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x13, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x13, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x2, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x2, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x2, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x2, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x2, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x2, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x2, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x2, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x2, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x2, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x14, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x15, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Add with Carry
        /// </summary>
        public static Element Adc32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x15, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x0, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x0, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x1, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x1, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x1, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x1, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x2, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x3, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x3, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x0, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x0, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x0, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x0, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x0, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x0, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x0, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x0, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x0, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x0, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x4, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x5, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Add32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x5, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x20, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x20, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x21, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x21, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x21, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x21, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x22, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x23, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x23, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x4, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x4, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x4, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x4, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x4, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x4, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x4, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x4, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x4, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x4, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x24, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x25, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Logical AND
        /// </summary>
        public static Element And32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x25, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Bit Scan Forward
        /// </summary>
        public static Element Bsf16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbc, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Bit Scan Forward
        /// </summary>
        public static Element Bsf16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbc, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Bit Scan Forward
        /// </summary>
        public static Element Bsf32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbc, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Bit Scan Forward
        /// </summary>
        public static Element Bsf32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbc, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Bit Scan Reverse
        /// </summary>
        public static Element Bsr16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbd, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Bit Scan Reverse
        /// </summary>
        public static Element Bsr16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbd, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Bit Scan Reverse
        /// </summary>
        public static Element Bsr32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbd, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Bit Scan Reverse
        /// </summary>
        public static Element Bsr32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbd, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Byte Swap
        /// </summary>
        public static Element Bswap(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa3, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa3, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa3, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa3, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test
        /// </summary>
        public static Element Bt32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbb, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbb, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbb, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbb, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x7, register, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x7, address, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x7, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test and Complement
        /// </summary>
        public static Element Btc32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x7, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb3, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb3, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb3, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb3, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x6, register, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x6, address, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x6, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test and Reset
        /// </summary>
        public static Element Btr32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x6, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xab, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xab, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xab, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xab, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x5, register, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x5, address, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModORInstruction(0x5, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Bit Test and Set
        /// </summary>
        public static Element Bts32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xba, new ModOMInstruction(0x5, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModORInstruction(0x2, register, null))));
        }


        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModOMInstruction(0x2, address, null))));
        }


        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call16(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xe8, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call32(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xe8, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Convert Byte to Word
        /// </summary>
        public static Element Cbw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x98, null)));
        }


        /// <summary>
        /// Convert Word to Doubleword
        /// </summary>
        public static Element Cwd(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x99, null)));
        }


        /// <summary>
        /// Convert Doubleword to Quadword
        /// </summary>
        public static Element Cdq(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x99, null));
        }


        /// <summary>
        /// Convert Word to Doubleword
        /// </summary>
        public static Element Cwde(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x98, null));
        }


        /// <summary>
        /// Clear Carry Flag
        /// </summary>
        public static Element Clc(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf8, null));
        }


        /// <summary>
        /// Clear Direction Flag
        /// </summary>
        public static Element Cld(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xfc, null));
        }


        /// <summary>
        /// Complement Carry Flag
        /// </summary>
        public static Element Cmc(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf5, null));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovb16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x42, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovb16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x42, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovb32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x42, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovb32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x42, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovbe16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x46, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovbe16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x46, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovbe32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x46, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovbe32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x46, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovl16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4c, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovl16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4c, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovl32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4c, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovl32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4c, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovle16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4e, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovle16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4e, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovle32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4e, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovle32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4e, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnb16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x43, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnb16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x43, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnb32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x43, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnb32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x43, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnbe16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x47, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnbe16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x47, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnbe32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x47, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnbe32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x47, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnl16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4d, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnl16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4d, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnl32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4d, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnl32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4d, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnle16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4f, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnle16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4f, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnle32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4f, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnle32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4f, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovno16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x41, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovno16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x41, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovno32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x41, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovno32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x41, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnp16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4b, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnp16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4b, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnp32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4b, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnp32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4b, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovns16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x49, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovns16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x49, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovns32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x49, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovns32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x49, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnz16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x45, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnz16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x45, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnz32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x45, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovnz32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x45, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovo16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x40, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovo16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x40, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovo32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x40, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovo32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x40, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovp16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4a, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovp16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4a, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovp32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4a, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovp32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x4a, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovs16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x48, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovs16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x48, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovs32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x48, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovs32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x48, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovz16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x44, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovz16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x44, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovz32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x44, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Conditional Move
        /// </summary>
        public static Element Cmovz32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x44, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x38, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x39, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x39, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x39, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x39, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x3a, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x3b, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x3b, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x7, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x7, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x7, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x7, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x7, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x7, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x7, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x7, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x7, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x7, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x3c, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x3d, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Compare Two Operands
        /// </summary>
        public static Element Cmp32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x3d, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Compare Byte String
        /// </summary>
        public static Element Cmpsb(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xa6, null));
        }


        /// <summary>
        /// Compare Word String
        /// </summary>
        public static Element Cmpsw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xa7, null)));
        }


        /// <summary>
        /// Compare Doubleword String
        /// </summary>
        public static Element Cmpsd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xa7, null));
        }


        /// <summary>
        /// Compare and Exchange
        /// </summary>
        public static Element Cmpxchg8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb0, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Compare and Exchange
        /// </summary>
        public static Element Cmpxchg8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb0, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Compare and Exchange
        /// </summary>
        public static Element Cmpxchg16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb1, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Compare and Exchange
        /// </summary>
        public static Element Cmpxchg16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb1, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Compare and Exchange
        /// </summary>
        public static Element Cmpxchg32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb1, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Compare and Exchange
        /// </summary>
        public static Element Cmpxchg32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb1, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// CPU Identification
        /// </summary>
        public static Element Cpuid(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa2, null)));
        }


        /// <summary>
        /// Decimal Adjust AL after Addition
        /// </summary>
        public static Element Daa(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x27, null));
        }


        /// <summary>
        /// Decimal Adjust AL after Subtraction
        /// </summary>
        public static Element Das(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x2f, null));
        }


        /// <summary>
        /// Decrement by 1
        /// </summary>
        public static Element Dec16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeRInstruction(0x48, register, null)));
        }


        /// <summary>
        /// Decrement by 1
        /// </summary>
        public static Element Dec32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeRInstruction(0x48, register, null));
        }


        /// <summary>
        /// Decrement by 1
        /// </summary>
        public static Element Dec8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xfe, new ModORInstruction(0x1, register, null)));
        }


        /// <summary>
        /// Decrement by 1
        /// </summary>
        public static Element Dec8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xfe, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Decrement by 1
        /// </summary>
        public static Element Dec16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModOMInstruction(0x1, address, null))));
        }


        /// <summary>
        /// Decrement by 1
        /// </summary>
        public static Element Dec32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Unsigned Divide
        /// </summary>
        public static Element Div8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x6, register, null)));
        }


        /// <summary>
        /// Unsigned Divide
        /// </summary>
        public static Element Div8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Unsigned Divide
        /// </summary>
        public static Element Div16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x6, register, null))));
        }


        /// <summary>
        /// Unsigned Divide
        /// </summary>
        public static Element Div16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x6, address, null))));
        }


        /// <summary>
        /// Unsigned Divide
        /// </summary>
        public static Element Div32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x6, register, null)));
        }


        /// <summary>
        /// Unsigned Divide
        /// </summary>
        public static Element Div32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Make Stack Frame for Procedure Parameters
        /// </summary>
        public static Element Enter(this ElementCollection collection, UInt16 value0, Byte value1)
        {
            return Add(collection, new OpcodeInstruction(0xc8, new ImmediateUInt16Instruction(value0, new ImmediateUInt8Instruction(value1, null))));
        }


        /// <summary>
        /// ST0 = pow(2, ST0 – 1)
        /// </summary>
        public static Element F2xm1(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf0, null)));
        }


        /// <summary>
        /// Absolute: ST0 = abs(ST0)
        /// </summary>
        public static Element Fabs(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xe1, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Fadd32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Fadd64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Fadd80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Fadd80_ToST0(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Fadd80_ST0To(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Faddp80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Add
        /// </summary>
        public static Element Faddp80_ST0To(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Load Binary Coded Decimal
        /// </summary>
        public static Element Fbld(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Store BCD Integer and Pop
        /// </summary>
        public static Element Fbstp(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Change Sign: ST0 = -ST0
        /// </summary>
        public static Element Fchs(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xe0, null)));
        }


        /// <summary>
        /// Clear Exceptions
        /// </summary>
        public static Element Fclex(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x9b, new OpcodeInstruction(0xdb, new OpcodeInstruction(0xe2, null))));
        }


        /// <summary>
        /// Clear Exceptions
        /// </summary>
        public static Element Fnclex(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeInstruction(0xe2, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if below (CF=1)
        /// </summary>
        public static Element Fcmovb(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xda, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if below or equal (CF=1 or ZF=1)
        /// </summary>
        public static Element Fcmovbe(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xda, new OpcodeRInstruction(0xd0, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if equal (ZF=1)
        /// </summary>
        public static Element Fcmove(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xda, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if not below (CF=0)
        /// </summary>
        public static Element Fcmovnb(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Fcmovnbe(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeRInstruction(0xd0, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if not equal (ZF=0)
        /// </summary>
        public static Element Fcmovne(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if not unordered (PF=0)
        /// </summary>
        public static Element Fcmovnu(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeRInstruction(0xd8, register, null)));
        }


        /// <summary>
        /// Floating-Point Conditional Move: Move if unordered (PF=1)
        /// </summary>
        public static Element Fcmovu(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xda, new OpcodeRInstruction(0xd8, register, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcom32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcom64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcom80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xd0, register, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcomp32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcomp64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcomp80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xd8, register, null)));
        }


        /// <summary>
        /// Compare Floating Point Values
        /// </summary>
        public static Element Fcompp(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeInstruction(0xd9, null)));
        }


        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS
        /// </summary>
        public static Element Fcomi(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeRInstruction(0xf0, register, null)));
        }


        /// <summary>
        /// Compare Floating Point Values and Set EFLAGS
        /// </summary>
        public static Element Fcomip(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new OpcodeRInstruction(0xf0, register, null)));
        }


        /// <summary>
        /// Cosine: ST0 = cos(ST0)
        /// </summary>
        public static Element Fcos(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xff, null)));
        }


        /// <summary>
        /// Decrement Stack-Top Pointer
        /// </summary>
        public static Element Fdecstp(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf6, null)));
        }


        /// <summary>
        /// Divide
        /// </summary>
        public static Element Fdiv32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Divide
        /// </summary>
        public static Element Fdiv64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Divide
        /// </summary>
        public static Element Fdiv80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xf0, register, null)));
        }


        /// <summary>
        /// Divide
        /// </summary>
        public static Element Fdiv80_ST0(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new OpcodeRInstruction(0xf8, register, null)));
        }


        /// <summary>
        /// Reverse Divide
        /// </summary>
        public static Element Fdivr32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Reverse Divide
        /// </summary>
        public static Element Fdivr64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Reverse Divide
        /// </summary>
        public static Element Fdivr80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xf8, register, null)));
        }


        /// <summary>
        /// Reverse Divide
        /// </summary>
        public static Element Fdivr80_ST0(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new OpcodeRInstruction(0xf0, register, null)));
        }


        /// <summary>
        /// Reverse Divide
        /// </summary>
        public static Element Fdivp(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xf8, register, null)));
        }


        /// <summary>
        /// Reverse Divide
        /// </summary>
        public static Element Fdivrp(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xf0, register, null)));
        }


        /// <summary>
        /// Free Floating-Point Register
        /// </summary>
        public static Element Ffree(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Add Integer
        /// </summary>
        public static Element Fiadd16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Add Integer
        /// </summary>
        public static Element Fiadd32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Compare Integer
        /// </summary>
        public static Element Ficom16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Compare Integer
        /// </summary>
        public static Element Ficom32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Compare Integer
        /// </summary>
        public static Element Ficomp16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Compare Integer
        /// </summary>
        public static Element Ficomp32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Divide Integer
        /// </summary>
        public static Element Fidiv16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Divide Integer
        /// </summary>
        public static Element Fidiv32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Reverse Divide Integer
        /// </summary>
        public static Element Fidivr16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Reverse Divide Integer
        /// </summary>
        public static Element Fidivr32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Load Integer
        /// </summary>
        public static Element Fild16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Load Integer
        /// </summary>
        public static Element Fild32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Load Integer
        /// </summary>
        public static Element Fild64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Store Integer
        /// </summary>
        public static Element Fist16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Store Integer
        /// </summary>
        public static Element Fist32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Store Integer
        /// </summary>
        public static Element Fistp16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Store Integer
        /// </summary>
        public static Element Fistp32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Store Integer
        /// </summary>
        public static Element Fistp64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Multiply Integer
        /// </summary>
        public static Element Fimul16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Multiply Integer
        /// </summary>
        public static Element Fimul32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Increment Stack-Top Pointer
        /// </summary>
        public static Element Fincstp(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf7, null)));
        }


        /// <summary>
        /// Initialize Floating-Point Unit
        /// </summary>
        public static Element Finit(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9b, new OpcodeInstruction(0xdb, new OpcodeInstruction(0xe3, null))));
        }


        /// <summary>
        /// Initialize Floating-Point Unit
        /// </summary>
        public static Element Fninit(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeInstruction(0xe3, null)));
        }


        /// <summary>
        /// Substract Integer
        /// </summary>
        public static Element Fisub16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Substract Integer
        /// </summary>
        public static Element Fisub32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Substract Integer
        /// </summary>
        public static Element Fisubr16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xde, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Substract Integer
        /// </summary>
        public static Element Fisubr32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xda, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Load Floating Point Value
        /// </summary>
        public static Element Fld32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Load Floating Point Value
        /// </summary>
        public static Element Fld64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Load Floating Point Value
        /// </summary>
        public static Element Fld80(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Load Floating Point Value
        /// </summary>
        public static Element Fld80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeRInstruction(0xc0, register, null)));
        }


        /// <summary>
        /// Load Constant : Push +1.0 onto the FPU register stack
        /// </summary>
        public static Element Fld1(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xe8, null)));
        }


        /// <summary>
        /// Load Constant : Push log2 e onto the FPU register stack
        /// </summary>
        public static Element Fldl2e(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xea, null)));
        }


        /// <summary>
        /// Load Constant : Push log2 10 onto the FPU register stack
        /// </summary>
        public static Element Fldl2t(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xe9, null)));
        }


        /// <summary>
        /// Load Constant : Push log10 2 onto the FPU register stack
        /// </summary>
        public static Element Fldlg2(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xec, null)));
        }


        /// <summary>
        /// Load Constant : Push loge 2 onto the FPU register stack
        /// </summary>
        public static Element Fldln2(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xed, null)));
        }


        /// <summary>
        /// Load Constant : Push pi onto the FPU register stack
        /// </summary>
        public static Element Fldpi(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xeb, null)));
        }


        /// <summary>
        /// Load Constant : Push +0.0 onto the FPU register stack
        /// </summary>
        public static Element Fldz(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xee, null)));
        }


        /// <summary>
        /// Load x87 FPU Control Word
        /// </summary>
        public static Element Fldcw(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Load x87 FPU Environment
        /// </summary>
        public static Element Fldenv(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Multiply
        /// </summary>
        public static Element Fmul32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Multiply
        /// </summary>
        public static Element Fmul64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Multiply
        /// </summary>
        public static Element Fmul80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// Multiply
        /// </summary>
        public static Element Fmul80_ST0(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// Multiply
        /// </summary>
        public static Element Fmulp(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// No Operation
        /// </summary>
        public static Element Fnop(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xd0, null)));
        }


        /// <summary>
        /// Partial Arctangent
        /// </summary>
        public static Element Fpatan(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf3, null)));
        }


        /// <summary>
        /// Partial Tangent
        /// </summary>
        public static Element Fptan(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf2, null)));
        }


        /// <summary>
        /// Partial Remainder
        /// </summary>
        public static Element Fprem(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf8, null)));
        }


        /// <summary>
        /// Partial Remainder
        /// </summary>
        public static Element Fprem1(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf5, null)));
        }


        /// <summary>
        /// Round to Integer
        /// </summary>
        public static Element Frndint(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xfc, null)));
        }


        /// <summary>
        /// Store x87 FPU State
        /// </summary>
        public static Element Fsave(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x9b, new OpcodeInstruction(0xdd, new ModOMInstruction(0x6, address, null))));
        }


        /// <summary>
        /// Store x87 FPU State
        /// </summary>
        public static Element Fnsave(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Restore x87 FPU State
        /// </summary>
        public static Element Frstor(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Scale
        /// </summary>
        public static Element Fscale(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xfd, null)));
        }


        /// <summary>
        /// Sine : ST0 = sin(ST0)
        /// </summary>
        public static Element Fsin(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xfe, null)));
        }


        /// <summary>
        /// Sine and Cosine
        /// </summary>
        public static Element Fsincos(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xfb, null)));
        }


        /// <summary>
        /// Square Root : ST0 = sqrt(ST0)
        /// </summary>
        public static Element Fsqrt(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xfa, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fst32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fst64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fst80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new OpcodeRInstruction(0xd0, register, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fstp32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fstp64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fstp80(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Store Floating Point Value
        /// </summary>
        public static Element Fstp80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new OpcodeRInstruction(0xd8, register, null)));
        }


        /// <summary>
        /// Store x87 FPU Control Word
        /// </summary>
        public static Element Fstcw(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x9b, new OpcodeInstruction(0xd9, new ModOMInstruction(0x7, address, null))));
        }


        /// <summary>
        /// Store x87 FPU Control Word
        /// </summary>
        public static Element Fnstcw(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Store x87 FPU Environment
        /// </summary>
        public static Element Fstenv(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x9b, new OpcodeInstruction(0xd9, new ModOMInstruction(0x6, address, null))));
        }


        /// <summary>
        /// Store x87 FPU Environment
        /// </summary>
        public static Element Fnstenv(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Store x87 FPU Status Word
        /// </summary>
        public static Element Fstsw_AX(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x9b, new OpcodeInstruction(0xdf, new OpcodeInstruction(0xe0, null))));
        }


        /// <summary>
        /// Store x87 FPU Status Word
        /// </summary>
        public static Element fstsw(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x9b, new OpcodeInstruction(0xdd, new ModOMInstruction(0x7, address, null))));
        }


        /// <summary>
        /// Store x87 FPU Status Word
        /// </summary>
        public static Element Fnstsw_AX(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new OpcodeInstruction(0xe0, null)));
        }


        /// <summary>
        /// Store x87 FPU Status Word
        /// </summary>
        public static Element Fnstsw(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Fsub32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Fsub64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Fsub80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xe0, register, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Fsub80_ST0(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new OpcodeRInstruction(0xe8, register, null)));
        }


        /// <summary>
        /// Reverse Subtract
        /// </summary>
        public static Element Fsubr32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Reverse Subtract
        /// </summary>
        public static Element Fsubr64(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Reverse Subtract
        /// </summary>
        public static Element Fsubr80(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd8, new OpcodeRInstruction(0xe8, register, null)));
        }


        /// <summary>
        /// Reverse Subtract
        /// </summary>
        public static Element Fsubr80_ST0(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdc, new OpcodeRInstruction(0xe0, register, null)));
        }


        /// <summary>
        /// Reverse Subtract
        /// </summary>
        public static Element Fsubp(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xe8, register, null)));
        }


        /// <summary>
        /// Reverse Subtract
        /// </summary>
        public static Element Fsubrp(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xde, new OpcodeRInstruction(0xe0, register, null)));
        }


        /// <summary>
        /// Test
        /// </summary>
        public static Element Ftst(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xe4, null)));
        }


        /// <summary>
        /// Unordered Compare Floating Point Values
        /// </summary>
        public static Element Fucom(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new OpcodeRInstruction(0xe0, register, null)));
        }


        /// <summary>
        /// Unordered Compare Floating Point Values
        /// </summary>
        public static Element Fucomp(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdd, new OpcodeRInstruction(0xe8, register, null)));
        }


        /// <summary>
        /// Unordered Compare Floating Point Values
        /// </summary>
        public static Element Fucomi(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdb, new OpcodeRInstruction(0xe8, register, null)));
        }


        /// <summary>
        /// Unordered Compare Floating Point Values
        /// </summary>
        public static Element Fucomip(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xdf, new OpcodeRInstruction(0xe8, register, null)));
        }


        /// <summary>
        /// Unordered Compare Floating Point Values
        /// </summary>
        public static Element Fucompp(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xda, new OpcodeInstruction(0xe9, null)));
        }


        /// <summary>
        /// Examine
        /// </summary>
        public static Element Fxam(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xe5, null)));
        }


        /// <summary>
        /// Exchange Register Contents
        /// </summary>
        public static Element Fxch(this ElementCollection collection, Register80 register)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeRInstruction(0xc8, register, null)));
        }


        /// <summary>
        /// Extract Exponent and Significand
        /// </summary>
        public static Element Fxtract(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf4, null)));
        }


        /// <summary>
        /// Compute y * log2 x
        /// </summary>
        public static Element Fyl2x(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf1, null)));
        }


        /// <summary>
        /// Compute y * log2 (x+1)
        /// </summary>
        public static Element Fyl2xp1(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd9, new OpcodeInstruction(0xf9, null)));
        }


        /// <summary>
        /// Signed Divide
        /// </summary>
        public static Element Idiv8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x7, register, null)));
        }


        /// <summary>
        /// Signed Divide
        /// </summary>
        public static Element Idiv8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Signed Divide
        /// </summary>
        public static Element Idiv16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x7, register, null))));
        }


        /// <summary>
        /// Signed Divide
        /// </summary>
        public static Element Idiv16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x7, address, null))));
        }


        /// <summary>
        /// Signed Divide
        /// </summary>
        public static Element Idiv32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x7, register, null)));
        }


        /// <summary>
        /// Signed Divide
        /// </summary>
        public static Element Idiv32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x5, register, null)));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x5, register, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x5, address, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x5, register, null)));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xaf, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xaf, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xaf, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xaf, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x6b, new ModRRInstruction(register, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x69, new ModRRInstruction(register, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x6b, new ModRRInstruction(register, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x69, new ModRRInstruction(register, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register0, Register16 register1, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x6b, new ModRRInstruction(register0, register1, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x6b, new ModRMInstruction(register, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register0, Register16 register1, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x69, new ModRRInstruction(register0, register1, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul16(this ElementCollection collection, Register16 register, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x69, new ModRMInstruction(register, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register0, Register32 register1, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x6b, new ModRRInstruction(register0, register1, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x6b, new ModRMInstruction(register, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register0, Register32 register1, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x69, new ModRRInstruction(register0, register1, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Signed Multiply
        /// </summary>
        public static Element Imul32(this ElementCollection collection, Register32 register, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x69, new ModRMInstruction(register, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Increment by 1
        /// </summary>
        public static Element Inc16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeRInstruction(0x40, register, null)));
        }


        /// <summary>
        /// Increment by 1
        /// </summary>
        public static Element Inc32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeRInstruction(0x40, register, null));
        }


        /// <summary>
        /// Increment by 1
        /// </summary>
        public static Element Inc8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xfe, new ModORInstruction(0x0, register, null)));
        }


        /// <summary>
        /// Increment by 1
        /// </summary>
        public static Element Inc8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xfe, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Increment by 1
        /// </summary>
        public static Element Inc16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Increment by 1
        /// </summary>
        public static Element Inc32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Call to Interrupt Procedure
        /// </summary>
        public static Element Int3(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xcc, null));
        }


        /// <summary>
        /// Call to Interrupt Procedure
        /// </summary>
        public static Element Int1(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf1, null));
        }


        /// <summary>
        /// Jump if CX register is 0
        /// </summary>
        public static Element Jcxz(this ElementCollection collection, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x67, new OpcodeInstruction(0xe3, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Jump if ECX register is 0
        /// </summary>
        public static Element Jecxz(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xe3, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Jb(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x72, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Jb(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x82, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Jb(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x82, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if above or equal (CF=0)
        /// </summary>
        public static Element Jbe(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x76, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if above or equal (CF=0)
        /// </summary>
        public static Element Jbe(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x86, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if above or equal (CF=0)
        /// </summary>
        public static Element Jbe(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x86, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if less (SF<>OF)
        /// </summary>
        public static Element Jl(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x7c, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if less (SF<>OF)
        /// </summary>
        public static Element Jl(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8c, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if less (SF<>OF)
        /// </summary>
        public static Element Jl(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8c, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Jle(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x7e, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Jle(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8e, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Jle(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8e, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not below (CF=0)
        /// </summary>
        public static Element Jnb(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x73, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not below (CF=0)
        /// </summary>
        public static Element Jnb(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x83, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not below (CF=0)
        /// </summary>
        public static Element Jnb(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x83, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Jnbe(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x77, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Jnbe(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x87, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Jnbe(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x87, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not less (SF=OF)
        /// </summary>
        public static Element Jnl(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x7d, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not less (SF=OF)
        /// </summary>
        public static Element Jnl(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8d, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not less (SF=OF)
        /// </summary>
        public static Element Jnl(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8d, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Jnle(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x7f, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Jnle(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8f, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Jnle(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8f, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not overflow (OF=0)
        /// </summary>
        public static Element Jno(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x71, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not overflow (OF=0)
        /// </summary>
        public static Element Jno(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x81, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not overflow (OF=0)
        /// </summary>
        public static Element Jno(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x81, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not parity (PF=0)
        /// </summary>
        public static Element Jnp(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x7b, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not parity (PF=0)
        /// </summary>
        public static Element Jnp(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8b, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not parity (PF=0)
        /// </summary>
        public static Element Jnp(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8b, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not sign (SF=0)
        /// </summary>
        public static Element Jns(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x79, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not sign (SF=0)
        /// </summary>
        public static Element Jns(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x89, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not sign (SF=0)
        /// </summary>
        public static Element Jns(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x89, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if not zero (ZF=0)
        /// </summary>
        public static Element Jnz(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x75, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if not zero (ZF=0)
        /// </summary>
        public static Element Jnz(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x85, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if not zero (ZF=0)
        /// </summary>
        public static Element Jnz(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x85, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if overflow (OF=1)
        /// </summary>
        public static Element Jo(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x70, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if overflow (OF=1)
        /// </summary>
        public static Element Jo(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x80, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if overflow (OF=1)
        /// </summary>
        public static Element Jo(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x80, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if parity (PF=1)
        /// </summary>
        public static Element Jp(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x7a, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if parity (PF=1)
        /// </summary>
        public static Element Jp(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8a, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if parity (PF=1)
        /// </summary>
        public static Element Jp(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x8a, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if sign (SF=1)
        /// </summary>
        public static Element Js(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x78, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if sign (SF=1)
        /// </summary>
        public static Element Js(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x88, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if sign (SF=1)
        /// </summary>
        public static Element Js(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x88, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump if zero (ZF = 1)
        /// </summary>
        public static Element Jz(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x74, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump if zero (ZF = 1)
        /// </summary>
        public static Element Jz(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0x84, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Jump if zero (ZF = 1)
        /// </summary>
        public static Element Jz(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x84, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp8(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xeb, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp16(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xe9, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp32(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xe9, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModORInstruction(0x4, register, null))));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModOMInstruction(0x4, address, null))));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Load Status Flags into AH Register
        /// </summary>
        public static Element Lahf(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9f, null));
        }


        /// <summary>
        /// Load Effective Address
        /// </summary>
        public static Element Lea16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x8d, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Load Effective Address
        /// </summary>
        public static Element Lea32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x8d, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// High Level Procedure Exit
        /// </summary>
        public static Element Leave(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xc9, null));
        }


        /// <summary>
        /// Load String
        /// </summary>
        public static Element Lodsb(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xac, null));
        }


        /// <summary>
        /// Load String
        /// </summary>
        public static Element Lodsw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xad, null)));
        }


        /// <summary>
        /// Load String
        /// </summary>
        public static Element Lodsd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xad, null));
        }


        /// <summary>
        /// Decrement count, jump if count != 0
        /// </summary>
        public static Element Loop_CX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x67, new OpcodeInstruction(0xe2, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Decrement count, jump if count != 0
        /// </summary>
        public static Element Loop_ECX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xe2, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loope_CX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x67, new OpcodeInstruction(0xe1, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loope_ECX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xe1, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loopz_CX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x67, new OpcodeInstruction(0xe1, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loopz_ECX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xe1, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopne_CX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x67, new OpcodeInstruction(0xe0, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopne_ECX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xe0, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopnz_CX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x67, new OpcodeInstruction(0xe0, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopnz_ECX(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xe0, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x88, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x88, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x89, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x89, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x89, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x89, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x8a, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x8b, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x8b, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeRInstruction(0xb0, register, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeRInstruction(0xb8, register, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeRInstruction(0xb8, register, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xc6, new ModOMInstruction(0x0, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc7, new ModOMInstruction(0x0, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xc7, new ModOMInstruction(0x0, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Move Data from String to String
        /// </summary>
        public static Element Movsb(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xa4, null));
        }


        /// <summary>
        /// Move Data from String to String
        /// </summary>
        public static Element Movsw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xa5, null)));
        }


        /// <summary>
        /// Move Data from String to String
        /// </summary>
        public static Element Movsd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xa5, null));
        }


        /// <summary>
        /// Move with Sign-Extension
        /// </summary>
        public static Element Movsx16_8(this ElementCollection collection, Register16 register0, Register8 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbe, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Move with Sign-Extension
        /// </summary>
        public static Element Movsx16_8(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbe, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Move with Sign-Extension
        /// </summary>
        public static Element Movsx32_8(this ElementCollection collection, Register32 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbe, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Move with Sign-Extension
        /// </summary>
        public static Element Movsx32_8(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbe, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Move with Sign-Extension
        /// </summary>
        public static Element Movsx32_16(this ElementCollection collection, Register32 register0, Register16 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbf, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Move with Sign-Extension
        /// </summary>
        public static Element Movsx32_16(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xbf, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Move with Zero-Extend
        /// </summary>
        public static Element Movzx16_8(this ElementCollection collection, Register16 register0, Register8 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb6, new ModRRInstruction(register0, register1, null)))));
        }


        /// <summary>
        /// Move with Zero-Extend
        /// </summary>
        public static Element Movzx16_8(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb6, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Move with Zero-Extend
        /// </summary>
        public static Element Movzx32_8(this ElementCollection collection, Register32 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb6, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Move with Zero-Extend
        /// </summary>
        public static Element Movzx32_8(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb6, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Move with Zero-Extend
        /// </summary>
        public static Element Movzx32_16(this ElementCollection collection, Register32 register0, Register16 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb7, new ModRRInstruction(register0, register1, null))));
        }


        /// <summary>
        /// Move with Zero-Extend
        /// </summary>
        public static Element Movzx32_16(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xb7, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Unsigned Multiply
        /// </summary>
        public static Element Mul8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Unsigned Multiply
        /// </summary>
        public static Element Mul8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Unsigned Multiply
        /// </summary>
        public static Element Mul16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x4, register, null))));
        }


        /// <summary>
        /// Unsigned Multiply
        /// </summary>
        public static Element Mul16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x4, address, null))));
        }


        /// <summary>
        /// Unsigned Multiply
        /// </summary>
        public static Element Mul32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Unsigned Multiply
        /// </summary>
        public static Element Mul32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Two's Complement Negation
        /// </summary>
        public static Element Neg8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x3, register, null)));
        }


        /// <summary>
        /// Two's Complement Negation
        /// </summary>
        public static Element Neg8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Two's Complement Negation
        /// </summary>
        public static Element Neg16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x3, register, null))));
        }


        /// <summary>
        /// Two's Complement Negation
        /// </summary>
        public static Element Neg16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x3, address, null))));
        }


        /// <summary>
        /// Two's Complement Negation
        /// </summary>
        public static Element Neg32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x3, register, null)));
        }


        /// <summary>
        /// Two's Complement Negation
        /// </summary>
        public static Element Neg32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// One's Complement Negation
        /// </summary>
        public static Element Not8(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// One's Complement Negation
        /// </summary>
        public static Element Not8(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// One's Complement Negation
        /// </summary>
        public static Element Not16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x2, register, null))));
        }


        /// <summary>
        /// One's Complement Negation
        /// </summary>
        public static Element Not16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x2, address, null))));
        }


        /// <summary>
        /// One's Complement Negation
        /// </summary>
        public static Element Not32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// One's Complement Negation
        /// </summary>
        public static Element Not32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// No Operation
        /// </summary>
        public static Element Nop(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x90, null));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x8, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x8, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x9, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x9, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x9, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x9, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xa, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xb, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xb, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x1, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x1, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x1, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x1, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x1, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x1, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x1, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x1, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x1, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x1, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xc, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Logical Inclusive OR
        /// </summary>
        public static Element Or32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xd, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Pop a Value from the Stack
        /// </summary>
        public static Element Pop16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeRInstruction(0x58, register, null)));
        }


        /// <summary>
        /// Pop a Value from the Stack
        /// </summary>
        public static Element Pop32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeRInstruction(0x58, register, null));
        }


        /// <summary>
        /// Pop a Value from the Stack
        /// </summary>
        public static Element Pop16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x8f, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Pop a Value from the Stack
        /// </summary>
        public static Element Pop32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x8f, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Pop All General-Purpose Registers
        /// </summary>
        public static Element Popa(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x61, null));
        }


        /// <summary>
        /// Pop All General-Purpose Registers
        /// </summary>
        public static Element Popaw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x61, null)));
        }


        /// <summary>
        /// Pop All General-Purpose Registers
        /// </summary>
        public static Element Popad(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x61, null));
        }


        /// <summary>
        /// Pop Stack into EFLAGS Register
        /// </summary>
        public static Element Popf(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9d, null));
        }


        /// <summary>
        /// Pop Stack into EFLAGS Register
        /// </summary>
        public static Element Popfw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x9d, null)));
        }


        /// <summary>
        /// Pop Stack into EFLAGS Register
        /// </summary>
        public static Element Popfd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9d, null));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push16(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeRInstruction(0x50, register, null)));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push32(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeRInstruction(0x50, register, null));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push16(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xff, new ModOMInstruction(0x6, address, null))));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push32(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xff, new ModOMInstruction(0x6, address, null)));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push8(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x6a, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push16(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x68, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        public static Element Push32(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x68, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Push All General-Purpose Registers
        /// </summary>
        public static Element Pusha(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x60, null));
        }


        /// <summary>
        /// Push All General-Purpose Registers
        /// </summary>
        public static Element Pushaw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x60, null)));
        }


        /// <summary>
        /// Push All General-Purpose Registers
        /// </summary>
        public static Element Pushad(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x60, null));
        }


        /// <summary>
        /// Push EFLAGS Register onto the Stack
        /// </summary>
        public static Element Pushf(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9c, null));
        }


        /// <summary>
        /// Push EFLAGS Register onto the Stack
        /// </summary>
        public static Element Pushfw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x9c, null)));
        }


        /// <summary>
        /// Push EFLAGS Register onto the Stack
        /// </summary>
        public static Element Pushfd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9c, null));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x2, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x2, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x2, register, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x2, address, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x2, register, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x2, address, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x2, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x2, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x2, register, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x2, address, null)));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x2, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate Left with Carry
        /// </summary>
        public static Element Rcl32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x2, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x3, register, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x3, register, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x3, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x3, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x3, register, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x3, address, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x3, register, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x3, address, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x3, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x3, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x3, register, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x3, register, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x3, address, null)));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x3, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right with carry
        /// </summary>
        public static Element Rcr32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x3, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Read Performance-Monitoring Counters
        /// </summary>
        public static Element Rdpmc(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x33, null)));
        }


        /// <summary>
        /// Read Time-Stamp Counter
        /// </summary>
        public static Element Rdtsc(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x31, null)));
        }


        /// <summary>
        /// Return from Procedure
        /// </summary>
        public static Element Ret(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xc3, null));
        }


        /// <summary>
        /// Return from Procedure
        /// </summary>
        public static Element Ret(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new OpcodeInstruction(0xc2, new ImmediateInt16Instruction(value, null)));
        }


        /// <summary>
        /// Return from Procedure
        /// </summary>
        public static Element Retf(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xcb, null));
        }


        /// <summary>
        /// Return from Procedure
        /// </summary>
        public static Element Retf(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new OpcodeInstruction(0xca, new ImmediateInt16Instruction(value, null)));
        }


        /// <summary>
        /// Return from Procedure
        /// </summary>
        public static Element Retn(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xc3, null));
        }


        /// <summary>
        /// Return from Procedure
        /// </summary>
        public static Element Retn(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new OpcodeInstruction(0xc2, new ImmediateInt16Instruction(value, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x0, register, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x0, register, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x0, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x0, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x0, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x0, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x0, register, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x0, register, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x0, address, null)));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x0, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate left
        /// </summary>
        public static Element Rol32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x0, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x1, register, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x1, register, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x1, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x1, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x1, register, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x1, address, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x1, register, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x1, address, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x1, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x1, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x1, register, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x1, register, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x1, address, null)));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x1, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Rotate right
        /// </summary>
        public static Element Ror32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x1, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Store AH into Flags
        /// </summary>
        public static Element Sahf(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0x9e, null));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x4, register, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x4, address, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x4, register, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x4, address, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Left
        /// </summary>
        public static Element Sal32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x7, register, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x7, register, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x7, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x7, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x7, register, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x7, address, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x7, register, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x7, address, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x7, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x7, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x7, register, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x7, register, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x7, address, null)));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x7, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift Right (preserve sign)
        /// </summary>
        public static Element Sar32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x7, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x18, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x18, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x19, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x19, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x19, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x19, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x1a, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x1b, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x1b, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x3, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x3, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x3, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x3, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x3, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x3, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x3, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x3, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x3, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x3, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x1c, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x1d, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Integer Subtraction with Borrow
        /// </summary>
        public static Element Sbb32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x1d, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Scan String
        /// </summary>
        public static Element Scasb(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xae, null));
        }


        /// <summary>
        /// Scan String
        /// </summary>
        public static Element Scasw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xaf, null)));
        }


        /// <summary>
        /// Scan String
        /// </summary>
        public static Element Scasd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xaf, null));
        }


        /// <summary>
        /// Set byte if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Seta(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x97, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Seta(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x97, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if above or equal (CF=0)
        /// </summary>
        public static Element Setae(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x93, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if above or equal (CF=0)
        /// </summary>
        public static Element Setae(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x93, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if below (CF=1)
        /// </summary>
        public static Element Setb(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x92, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if below (CF=1)
        /// </summary>
        public static Element Setb(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x92, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if below or equal (CF=1 or ZF=1)
        /// </summary>
        public static Element Setbe(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x96, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if below or equal (CF=1 or ZF=1)
        /// </summary>
        public static Element Setbe(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x96, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set if carry (CF=1)
        /// </summary>
        public static Element Setc(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x92, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set if carry (CF=1)
        /// </summary>
        public static Element Setc(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x92, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if equal (ZF=1)
        /// </summary>
        public static Element Sete(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x94, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if equal (ZF=1)
        /// </summary>
        public static Element Sete(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x94, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if greater (ZF=0 and SF=OF)
        /// </summary>
        public static Element Setg(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9f, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if greater (ZF=0 and SF=OF)
        /// </summary>
        public static Element Setg(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9f, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if greater or equal (SF=OF)
        /// </summary>
        public static Element Setge(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9d, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if greater or equal (SF=OF)
        /// </summary>
        public static Element Setge(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9d, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if less (SF<>OF)
        /// </summary>
        public static Element Setl(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9c, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if less (SF<>OF)
        /// </summary>
        public static Element Setl(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9c, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Setle(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9e, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Setle(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9e, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not above (CF=1 or ZF=1)
        /// </summary>
        public static Element Setna(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x96, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not above (CF=1 or ZF=1)
        /// </summary>
        public static Element Setna(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x96, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not above or equal (CF=1)
        /// </summary>
        public static Element Setnae(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x92, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not above or equal (CF=1)
        /// </summary>
        public static Element Setnae(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x92, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not below (CF=0)
        /// </summary>
        public static Element Setnb(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x93, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not below (CF=0)
        /// </summary>
        public static Element Setnb(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x93, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Setnbe(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x97, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Setnbe(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x97, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not carry (CF=0)
        /// </summary>
        public static Element Setnc(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x93, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not carry (CF=0)
        /// </summary>
        public static Element Setnc(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x93, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not equal (ZF=0)
        /// </summary>
        public static Element Setne(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x95, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not equal (ZF=0)
        /// </summary>
        public static Element Setne(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x95, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not greater (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Setng(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9e, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not greater (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Setng(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9e, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set if not greater or equal (SF<>OF)
        /// </summary>
        public static Element Setnge(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9c, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set if not greater or equal (SF<>OF)
        /// </summary>
        public static Element Setnge(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9c, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not less (SF=OF)
        /// </summary>
        public static Element Setnl(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9d, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not less (SF=OF)
        /// </summary>
        public static Element Setnl(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9d, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Setnle(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9f, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Setnle(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9f, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not overflow (OF=0)
        /// </summary>
        public static Element Setno(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x91, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not overflow (OF=0)
        /// </summary>
        public static Element Setno(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x91, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not parity (PF=0)
        /// </summary>
        public static Element Setnp(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9b, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not parity (PF=0)
        /// </summary>
        public static Element Setnp(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9b, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not sign (SF=0)
        /// </summary>
        public static Element Setns(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x99, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not sign (SF=0)
        /// </summary>
        public static Element Setns(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x99, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if not zero (ZF=0)
        /// </summary>
        public static Element Setnz(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x95, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if not zero (ZF=0)
        /// </summary>
        public static Element Setnz(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x95, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if overflow (OF=1)
        /// </summary>
        public static Element Seto(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x90, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if overflow (OF=1)
        /// </summary>
        public static Element Seto(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x90, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if parity (PF=1)
        /// </summary>
        public static Element Setp(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9a, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if parity (PF=1)
        /// </summary>
        public static Element Setp(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9a, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if parity even (PF=1)
        /// </summary>
        public static Element Setpe(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9a, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if parity even (PF=1)
        /// </summary>
        public static Element Setpe(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9a, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if parity odd (PF=0)
        /// </summary>
        public static Element Setpo(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9b, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if parity odd (PF=0)
        /// </summary>
        public static Element Setpo(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x9b, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if sign (SF=1)
        /// </summary>
        public static Element Sets(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x98, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if sign (SF=1)
        /// </summary>
        public static Element Sets(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x98, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Set byte if zero (ZF=1)
        /// </summary>
        public static Element Setz(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x94, new ModORInstruction(0x0, register, null))));
        }


        /// <summary>
        /// Set byte if zero (ZF=1)
        /// </summary>
        public static Element Setz(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0x94, new ModOMInstruction(0x0, address, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x4, register, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x4, address, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x4, register, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x4, address, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x4, register, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x4, address, null)));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x4, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift left
        /// </summary>
        public static Element Shl32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x4, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr8_1(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModORInstruction(0x5, register, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr8_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd0, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr8_CL(this ElementCollection collection, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModORInstruction(0x5, register, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr8_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd2, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr8(this ElementCollection collection, Register8 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModORInstruction(0x5, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr8(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc0, new ModOMInstruction(0x5, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr16_1(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModORInstruction(0x5, register, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr16_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd1, new ModOMInstruction(0x5, address, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr16_CL(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModORInstruction(0x5, register, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr16_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xd3, new ModOMInstruction(0x5, address, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr16(this ElementCollection collection, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModORInstruction(0x5, register, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr16(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xc1, new ModOMInstruction(0x5, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr32_1(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModORInstruction(0x5, register, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr32_1(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd1, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr32_CL(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModORInstruction(0x5, register, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr32_CL(this ElementCollection collection, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0xd3, new ModOMInstruction(0x5, address, null)));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr32(this ElementCollection collection, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModORInstruction(0x5, register, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Shift right
        /// </summary>
        public static Element Shr32(this ElementCollection collection, EffectiveAddress address, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xc1, new ModOMInstruction(0x5, address, new ImmediateUInt8Instruction(value, null))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld(this ElementCollection collection, Register16 register0, Register16 register1, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa4, new ModRRInstruction(register1, register0, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld(this ElementCollection collection, EffectiveAddress address, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa4, new ModRMInstruction(register, address, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld(this ElementCollection collection, Register32 register0, Register32 register1, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa4, new ModRRInstruction(register1, register0, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld(this ElementCollection collection, EffectiveAddress address, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa4, new ModRMInstruction(register, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld_CL(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa5, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld_CL(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa5, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld_CL(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa5, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Double Precision Shift Left
        /// </summary>
        public static Element Shld_CL(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xa5, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd(this ElementCollection collection, Register16 register0, Register16 register1, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xac, new ModRRInstruction(register1, register0, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd(this ElementCollection collection, EffectiveAddress address, Register16 register, Byte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xac, new ModRMInstruction(register, address, new ImmediateUInt8Instruction(value, null))))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd(this ElementCollection collection, Register32 register0, Register32 register1, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xac, new ModRRInstruction(register1, register0, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd(this ElementCollection collection, EffectiveAddress address, Register32 register, Byte value)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xac, new ModRMInstruction(register, address, new ImmediateUInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd_CL(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xad, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd_CL(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xad, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd_CL(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xad, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Double Precision Shift Right
        /// </summary>
        public static Element Shrd_CL(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xad, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Set Carry Flag
        /// </summary>
        public static Element Stc(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xf9, null));
        }


        /// <summary>
        /// Set Direction Flag
        /// </summary>
        public static Element Std(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xfd, null));
        }


        /// <summary>
        /// Store String
        /// </summary>
        public static Element Stosb(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xaa, null));
        }


        /// <summary>
        /// Store String
        /// </summary>
        public static Element Stosw(this ElementCollection collection)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xab, null)));
        }


        /// <summary>
        /// Store String
        /// </summary>
        public static Element Stosd(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xab, null));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x28, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x28, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x29, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x29, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x29, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x29, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x2a, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x2b, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x2b, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x5, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x5, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x5, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x5, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x5, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x5, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x5, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x5, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x5, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x5, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x2c, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x2d, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Subtract
        /// </summary>
        public static Element Sub32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x2d, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x84, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x84, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x85, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x85, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x85, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x85, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModORInstruction(0x0, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xf6, new ModOMInstruction(0x0, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModORInstruction(0x0, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf7, new ModOMInstruction(0x0, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModORInstruction(0x0, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xf7, new ModOMInstruction(0x0, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0xa8, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xa9, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Logical Compare
        /// </summary>
        public static Element Test32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0xa9, new ImmediateInt32Instruction(value, null)));
        }


        /// <summary>
        /// Exchange and Add
        /// </summary>
        public static Element Xadd8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xc0, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Exchange and Add
        /// </summary>
        public static Element Xadd8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xc0, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Exchange and Add
        /// </summary>
        public static Element Xadd16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xc1, new ModRRInstruction(register1, register0, null)))));
        }


        /// <summary>
        /// Exchange and Add
        /// </summary>
        public static Element Xadd16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0xf, new OpcodeInstruction(0xc1, new ModRMInstruction(register, address, null)))));
        }


        /// <summary>
        /// Exchange and Add
        /// </summary>
        public static Element Xadd32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xc1, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Exchange and Add
        /// </summary>
        public static Element Xadd32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0xf, new OpcodeInstruction(0xc1, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x86, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x86, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x87, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x87, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x87, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x87, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg16_AX(this ElementCollection collection, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeRInstruction(0x90, register, null)));
        }


        /// <summary>
        /// Exchange
        /// </summary>
        public static Element Xchg32_EAX(this ElementCollection collection, Register32 register)
        {
            return Add(collection, new OpcodeRInstruction(0x90, register, null));
        }


        /// <summary>
        /// Table Look-up Translation
        /// </summary>
        public static Element Xlatb(this ElementCollection collection)
        {
            return Add(collection, new OpcodeInstruction(0xd7, null));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor8(this ElementCollection collection, Register8 register0, Register8 register1)
        {
            return Add(collection, new OpcodeInstruction(0x30, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor8(this ElementCollection collection, EffectiveAddress address, Register8 register)
        {
            return Add(collection, new OpcodeInstruction(0x30, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, Register16 register0, Register16 register1)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x31, new ModRRInstruction(register1, register0, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, EffectiveAddress address, Register16 register)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x31, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, Register32 register0, Register32 register1)
        {
            return Add(collection, new OpcodeInstruction(0x31, new ModRRInstruction(register1, register0, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, EffectiveAddress address, Register32 register)
        {
            return Add(collection, new OpcodeInstruction(0x31, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor8(this ElementCollection collection, Register8 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x32, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, Register16 register, EffectiveAddress address)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x33, new ModRMInstruction(register, address, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, Register32 register, EffectiveAddress address)
        {
            return Add(collection, new OpcodeInstruction(0x33, new ModRMInstruction(register, address, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor8(this ElementCollection collection, Register8 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModORInstruction(0x6, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor8(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x80, new ModOMInstruction(0x6, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, Register16 register, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModORInstruction(0x6, register, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, EffectiveAddress address, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x81, new ModOMInstruction(0x6, address, new ImmediateInt16Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, Register32 register, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModORInstruction(0x6, register, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, EffectiveAddress address, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x81, new ModOMInstruction(0x6, address, new ImmediateInt32Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, Register16 register, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModORInstruction(0x6, register, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x83, new ModOMInstruction(0x6, address, new ImmediateInt8Instruction(value, null)))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, Register32 register, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModORInstruction(0x6, register, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32(this ElementCollection collection, EffectiveAddress address, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x83, new ModOMInstruction(0x6, address, new ImmediateInt8Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor8_AL(this ElementCollection collection, SByte value)
        {
            return Add(collection, new OpcodeInstruction(0x34, new ImmediateInt8Instruction(value, null)));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor16_AX(this ElementCollection collection, Int16 value)
        {
            return Add(collection, new PrefixInstruction(0x66, new OpcodeInstruction(0x35, new ImmediateInt16Instruction(value, null))));
        }


        /// <summary>
        /// Logical Exclusive OR
        /// </summary>
        public static Element Xor32_EAX(this ElementCollection collection, Int32 value)
        {
            return Add(collection, new OpcodeInstruction(0x35, new ImmediateInt32Instruction(value, null)));
        }


    }
}