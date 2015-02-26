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
using ArchAssembler.Elements;


namespace ArchAssembler.X86
{
    internal abstract class Instruction : ConcreteElement
    {
        private readonly Instruction m_next;

        protected internal Instruction(Instruction next)
        {
            m_next = next;
        }

        internal override uint ComputeSize(IAssemblingContext context)
        {
            return m_next == null ? InternalComputeSize(context) : m_next.ComputeSize(context) + InternalComputeSize(context);
        }

        protected internal abstract uint InternalComputeSize(IAssemblingContext context);

        internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            InternalWriteTo(writer, context);

            if(m_next != null)
            {
                m_next.WriteTo(writer, context);
            }
        }

        protected internal abstract void InternalWriteTo(BinaryWriter writer, IAssemblingContext context);

        internal override void RegisterDependencies(IDependencyCollection dependencies)
        {
            InternalRegisterDependencies(dependencies);

            if(m_next != null)
            {
                m_next.RegisterDependencies(dependencies);
            }
        }

        protected internal abstract void InternalRegisterDependencies(IDependencyCollection dependencies);

    }

    internal sealed class PrefixInstruction : Instruction
    {
        private readonly Byte m_prefix;

        internal PrefixInstruction(Byte prefix, Instruction instruction)
            : base(instruction)
        {
            m_prefix = prefix;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_prefix);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateUInt8Instruction : Instruction
    {
        private readonly Byte m_immediate;

        internal ImmediateUInt8Instruction(Byte immediate, Instruction instruction)
            : base(instruction)
        {
            m_immediate = immediate;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_immediate);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateUInt16Instruction : Instruction
    {
        private readonly UInt16 m_immediate;

        internal ImmediateUInt16Instruction(UInt16 immediate, Instruction instruction)
            : base(instruction)
        {
            m_immediate = immediate;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 2;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_immediate);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateUInt32Instruction : Instruction
    {
        private readonly Element m_reference;
        private readonly UInt32 m_immediate;

        internal ImmediateUInt32Instruction(Element reference, UInt32 immediate, Instruction instruction)
            : base(instruction)
        {
            m_reference = reference;
            m_immediate = immediate;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 4;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            UInt32 value = m_immediate;

            if(m_reference != null)
            {
                value += (UInt32)context.GetAbsoluteMemoryAddress(m_reference);
            }

            writer.Write(value);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateInt8Instruction : Instruction
    {
        private readonly SByte m_immediate;

        internal ImmediateInt8Instruction(SByte immediate, Instruction instruction)
            : base(instruction)
        {
            m_immediate = immediate;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_immediate);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateInt16Instruction : Instruction
    {
        private readonly Int16 m_immediate;

        internal ImmediateInt16Instruction(Int16 immediate, Instruction instruction)
            : base(instruction)
        {
            m_immediate = immediate;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 2;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_immediate);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateAbsoluteMemoryAddress32Instruction : Instruction
    {
        private readonly Element m_element;
        private readonly Int32 m_displacement;

        internal ImmediateAbsoluteMemoryAddress32Instruction(Element element, Int32 displacement, Instruction instruction)
            : base(instruction)
        {
            m_element = element;
            m_displacement = displacement;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 4;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            Int32 value = m_displacement;

            if (m_element != null)
            {
                value += (Int32)context.GetAbsoluteMemoryAddress(m_element);
            }

            writer.Write(value);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ImmediateInt32Instruction : Instruction
    {
        private readonly Int32 m_immediate;

        internal ImmediateInt32Instruction(Int32 immediate, Instruction instruction)
            : base(instruction)
        {
            m_immediate = immediate;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 4;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_immediate);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class OpcodeInstruction : Instruction
    {
        private readonly Byte m_opcode;

        internal OpcodeInstruction(Byte opcode, Instruction instruction)
            : base(instruction)
        {
            m_opcode = opcode;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write(m_opcode);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class OpcodeRInstruction : Instruction
    {
        private readonly Byte m_opcode;
        private readonly Register m_register;

        internal OpcodeRInstruction(Byte opcode, Register register, Instruction instruction)
            : base(instruction)
        {
            m_opcode = opcode;
            m_register = register;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            writer.Write((byte)(m_opcode + m_register.Id));
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal abstract class ModInstruction : Instruction
    {
        protected internal ModInstruction(Instruction next)
            : base(next)
        {

        }

        protected void WriteModRM(BinaryWriter writer, int mode, int complement, int rm)
        {
            writer.Write((byte)((mode << 6) | (complement << 3) | rm));
        }
    }

    internal sealed class ModORInstruction : ModInstruction
    {
        private readonly Byte m_opcode;
        private readonly Register m_register;

        internal ModORInstruction(Byte opcode, Register register, Instruction instruction)
            : base(instruction)
        {
            m_opcode = opcode;
            m_register = register;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            WriteModRM(writer, 3, m_register.Id, m_opcode);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal sealed class ModRRInstruction : ModInstruction
    {
        private readonly Register m_register0;
        private readonly Register m_register1;

        internal ModRRInstruction(Register register0, Register register1, Instruction instruction)
            : base(instruction)
        {
            m_register0 = register0;
            m_register1 = register1;
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            return 1;
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            WriteModRM(writer, 3, m_register1.Id, m_register0.Id);
        }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {

        }
    }

    internal abstract class ModMInstruction : ModInstruction
    {
        private readonly EffectiveAddress m_address;
        
        internal protected ModMInstruction(EffectiveAddress address, Instruction instruction)
            : base(instruction)
        {
            m_address = address;
        }

        protected internal abstract int Complement { get; }

        protected internal override void InternalRegisterDependencies(IDependencyCollection dependencies)
        {
            if (m_address.OffsetElement != null)
            {
                dependencies.Add(m_address.OffsetElement);
            }
        }

        private int GetDisplacementValue(IAssemblingContext context)
        {
            if (m_address.OffsetElement == null)
            {
                return m_address.OffsetValue;
            }
            else
            {
                int reference = (int)context.GetAbsoluteMemoryAddress(m_address.OffsetElement);

                return reference + m_address.OffsetValue;
            }
        }

        private static uint GetDisplacementCode(int displacementValue)
        {
            if (displacementValue == 0)
            {
                return 0;
            }
            else if (displacementValue >= -128 && displacementValue <= 127)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private static uint GetDisplacementSize(uint displacementCode)
        {
            if (displacementCode == 2)
            {
                return 4;
            }
            else
            {
                return displacementCode;
            }
        }

        protected internal override uint InternalComputeSize(IAssemblingContext context)
        {
            if (m_address.OffsetElement != null && !context.IsPositioned(m_address.OffsetElement))
            {
                return 6; // max size
            }

            int dispValue = GetDisplacementValue(context);
            uint dispCode = GetDisplacementCode(dispValue);
            uint dispSize = GetDisplacementSize(dispCode);

            if (m_address.Base == null)
            {
                if (m_address.Index == null)
                {
                    return 5; // modrm + disp32
                }
                else
                {
                    return 6; // modrm + sib + disp32
                }
            }
            else
            {
                if (m_address.Base == Register32.ESP)
                {
                    return 2 + dispSize; // modrm + sib + ?
                }
                else
                {
                    if (m_address.Base == Register32.EBP)
                    {
                        if (dispCode == 0)
                        {
                            return 3; // modrm + sib + disp8
                        }
                        else
                        {
                            return 2 + dispSize; // modrm + sib + ?
                        }
                    }
                    else
                    {
                        if (m_address.Index == null)
                        {
                            return 1 + dispSize; // modrm + ?
                        }
                        else
                        {
                            return 2 + dispSize; // modrm + sib + ?
                        }
                    }
                }
            }
        }

        private void WriteModRM(BinaryWriter writer, int mod, int rm )
        {
            WriteModRM(writer, mod, Complement, rm);
        }

        private static void WriteSib(BinaryWriter writer, int scale, int rindex, int rbase)
        {
            writer.Write((byte)((scale << 6) | (rindex << 3) | rbase));
        }

        private static void WriteDisp(BinaryWriter writer, int value, int code)
        {
            if (code == 1)
            {
                writer.Write((sbyte)value);
            }
            else if (code == 2)
            {
                writer.Write(value);
            }
        }

        protected internal override void InternalWriteTo(BinaryWriter writer, IAssemblingContext context)
        {
            int dispValue = GetDisplacementValue(context);
            int dispCode = (int)GetDisplacementCode(dispValue);

            if (m_address.Base == null)
            {
                if (m_address.Index == null)
                {
                    WriteModRM(writer, 0, 5);
                    WriteDisp(writer, dispValue, 2);
                }
                else
                {
                    WriteModRM(writer, 0, 4);
                    WriteSib(writer, m_address.IndexScaleFactor, m_address.Index.Id, 5);
                    WriteDisp(writer, dispValue, 2);
                }
            }
            else
            {
                if (m_address.Base == Register32.ESP)
                {
                    if (m_address.Index == null)
                    {
                        WriteModRM(writer, dispCode, 4);
                        WriteSib(writer, 0, 4, m_address.Base.Id);
                        WriteDisp(writer, dispValue, dispCode);
                    }
                    else
                    {
                        WriteModRM(writer, dispCode, 4);
                        WriteSib(writer, m_address.IndexScaleFactor, m_address.Index.Id, m_address.Base.Id);
                        WriteDisp(writer, dispValue, dispCode);
                    }
                }
                else
                {
                    if (m_address.Base == Register32.EBP)
                    {
                        if (dispCode == 0)
                        {
                            if (m_address.Index == null)
                            {
                                WriteModRM(writer, 1, 4);
                                WriteSib(writer, 0, 4, 5);
                                WriteDisp(writer, 0, 1);
                            }
                            else
                            {
                                WriteModRM(writer, 1, 4);
                                WriteSib(writer, m_address.IndexScaleFactor, m_address.Index.Id, 5);
                                WriteDisp(writer, 0, 1);
                            }
                        }
                        else
                        {
                            if (m_address.Index == null)
                            {
                                WriteModRM(writer, dispCode, 4);
                                WriteSib(writer, 0, 4, 5);
                                WriteDisp(writer, dispValue, dispCode);
                            }
                            else
                            {
                                WriteModRM(writer, dispCode, 4);
                                WriteSib(writer, m_address.IndexScaleFactor, m_address.Index.Id, 5);
                                WriteDisp(writer, dispValue, dispCode);
                            }
                        }
                    }
                    else
                    {
                        if (m_address.Index == null)
                        {
                            WriteModRM(writer, dispCode, m_address.Base.Id);
                            WriteDisp(writer, dispValue, dispCode);
                        }
                        else
                        {
                            WriteModRM(writer, dispCode, 4);
                            WriteSib(writer, m_address.IndexScaleFactor, m_address.Index.Id, m_address.Base.Id);
                            WriteDisp(writer, dispValue, dispCode);
                        }
                    }
                }
            }
        }
    }

    internal sealed class ModRMInstruction : ModMInstruction
    {
        private readonly Register m_register;


        internal ModRMInstruction(Register register, EffectiveAddress address, Instruction instruction)
            : base(address, instruction)
        {
            m_register = register;
        }

        protected internal override int Complement
        {
            get { return m_register.Id; }
        }
    }

    internal sealed class ModOMInstruction : ModMInstruction
    {
        private readonly byte m_opcode;

        internal ModOMInstruction(byte opcode, EffectiveAddress address, Instruction instruction)
            : base(address, instruction)
        {
            m_opcode = opcode;
        }

        protected internal override int Complement
        {
            get { return m_opcode; }
        }
    }
}
