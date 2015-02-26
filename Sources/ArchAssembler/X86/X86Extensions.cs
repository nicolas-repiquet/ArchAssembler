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
    public static partial class X86Extensions
    {

        // ********************************************************************

        private sealed class JmpInstruction : ConcreteElement
        {
            private readonly Element m_offsetElement;
            private readonly Int32 m_offsetValue;

            public JmpInstruction(Element offsetElement, Int32 offsetValue)
            {
                m_offsetElement = offsetElement;
                m_offsetValue = offsetValue;
            }

            internal override bool SizeDependsOnAddress
           { get { return true; }
            }

            internal override void RegisterDependencies(IDependencyCollection dependencies)
            {
                dependencies.Add(m_offsetElement);
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                if (!context.IsPositioned(this) || !context.IsPositioned(m_offsetElement))
                {
                    return 5;
                }

                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -126 && diff <= 129)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -126 && diff <= 129)
                {
                    writer.Write((Byte)0xeb);
                    writer.Write((SByte)(diff - 2));
                }
                else
                {
                    writer.Write((Byte)0xe9);
                    writer.Write((Int32)(diff - 5));
                }             
            }
        }

        private sealed class JccInstruction : ConcreteElement
        {
            private readonly byte m_shortOpcode;
            private readonly byte m_nearOpcode;
            private readonly Element m_offsetElement;
            private readonly Int32 m_offsetValue;


            public JccInstruction(byte shortOpcode, byte nearOpcode, Element offsetElement, Int32 offsetValue)
            {
                m_shortOpcode = shortOpcode;
                m_nearOpcode = nearOpcode;
                m_offsetElement = offsetElement;
                m_offsetValue = offsetValue;
            }

            internal override bool SizeDependsOnAddress
            {
                get { return true; }
            }

            internal override void RegisterDependencies(IDependencyCollection dependencies)
            {
                dependencies.Add(m_offsetElement);
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                if (!context.IsPositioned(this) || !context.IsPositioned(m_offsetElement))
                {
                    return 6;
                }

                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -126 && diff <= 129)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -126 && diff <= 129)
                {
                    writer.Write(m_shortOpcode);
                    writer.Write((SByte)(diff - 2));
                }
                else
                {
                    writer.Write((Byte)0x0f);
                    writer.Write(m_nearOpcode);
                    writer.Write((Int32)(diff - 6));
                }
            }
        }

        private sealed class JcxzInstruction : ConcreteElement
        {
            private readonly Element m_offsetElement;
            private readonly Int32 m_offsetValue;

            public JcxzInstruction(Element offsetElement, Int32 offsetValue)
            {
                m_offsetElement = offsetElement;
                m_offsetValue = offsetValue;
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                return 3;
            }

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -125 && diff <= 130)
                {
                    writer.Write((Byte)0x67);
                    writer.Write((Byte)0xe3);
                    writer.Write((SByte)(diff - 3));
                }
                else
                {
                    throw new Exception("Invalid jcxz range");
                }
            }
        }

        private sealed class JecxzInstruction : ConcreteElement
        {
            private readonly Element m_offsetElement;
            private readonly Int32 m_offsetValue;

            public JecxzInstruction(Element offsetElement, Int32 offsetValue)
            {
                m_offsetElement = offsetElement;
                m_offsetValue = offsetValue;
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                return 2;
            }

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -126 && diff <= 129)
                {
                    writer.Write((Byte)0xe3);
                    writer.Write((SByte)(diff - 2));
                }
                else
                {
                    throw new Exception("Invalid jecxz range");
                }
            }
        }

        private sealed class LoopCXInstruction : ConcreteElement
        {
            private readonly byte m_opcode;
            private readonly Element m_offsetElement;
            private readonly Int32 m_offsetValue;

            public LoopCXInstruction(byte opcode, Element offsetElement, Int32 offsetValue)
            {
                m_opcode = opcode;
                m_offsetElement = offsetElement;
                m_offsetValue = offsetValue;
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                return 3;
            }

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -125 && diff <= 130)
                {
                    writer.Write((Byte)0x67);
                    writer.Write(m_opcode);
                    writer.Write((SByte)(diff - 3));
                }
                else
                {
                    throw new Exception("Invalid loop range");
                }
            }
        }

        private sealed class LoopECXInstruction : ConcreteElement
        {
            private readonly byte m_opcode;
            private readonly Element m_offsetElement;
            private readonly Int32 m_offsetValue;

            public LoopECXInstruction(byte opcode, Element offsetElement, Int32 offsetValue)
            {
                m_opcode = opcode;
                m_offsetElement = offsetElement;
                m_offsetValue = offsetValue;
            }

            internal override uint ComputeSize(IAssemblingContext context)
            {
                return 2;
            }

            internal override void WriteTo(BinaryWriter writer, IAssemblingContext context)
            {
                UInt32 jmpAddress = context.GetRelativeMemoryAddress(this);
                UInt32 refAddress = context.GetRelativeMemoryAddress(m_offsetElement);

                int diff = (int)(refAddress - jmpAddress) + m_offsetValue;

                if (diff >= -126 && diff <= 129)
                {
                    writer.Write(m_opcode);
                    writer.Write((SByte)(diff - 2));
                }
                else
                {
                    throw new Exception("Invalid loop range");
                }
            }
        }

        // ********************************************************************

        private static T Add<T>(ElementCollection collection, T element) where T : Element
        {
            collection.Elements.Add(element);
            return element;
        }

        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        /// <param name="value"></param>
        public static Element Push32(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new OpcodeInstruction(0x68, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, offsetValue, null)));
        }

        /// <summary>
        /// Push a Value onto the Stack
        /// </summary>
        /// <param name="value"></param>
        public static Element Push32(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new OpcodeInstruction(0x68, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, 0, null)));
        }

        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JmpInstruction(offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump
        /// </summary>
        public static Element Jmp(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JmpInstruction(offsetElement, 0));
        }

        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, Register32 register, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new OpcodeRInstruction(0xb8, register, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, offsetValue, null)));
        }

        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, Register32 register, Element offsetElement)
        {
            return Add(collection, new OpcodeRInstruction(0xb8, register, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, 0, null)));
        }

        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, EffectiveAddress address, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new OpcodeInstruction(0xc7, new ModOMInstruction(0x0, address, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, offsetValue, null))));
        }

        /// <summary>
        /// Move
        /// </summary>
        public static Element Mov32(this ElementCollection collection, EffectiveAddress address, Element offsetElement)
        {
            return Add(collection, new OpcodeInstruction(0xc7, new ModOMInstruction(0x0, address, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, 0, null))));
        }

        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call32(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new OpcodeInstruction(0xe8, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, offsetValue, null)));
        }

        /// <summary>
        /// Call Procedure
        /// </summary>
        public static Element Call32(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new OpcodeInstruction(0xe8, new ImmediateAbsoluteMemoryAddress32Instruction(offsetElement, 0, null)));
        }

        /// <summary>
        /// Jump if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Jb(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x72, 0x82, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if above (CF=0 and ZF=0)
        /// </summary>
        public static Element Jb(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x72, 0x82, offsetElement, 0));
        }

        /// <summary>
        /// Jump if above or equal (CF=0)
        /// </summary>
        public static Element Jbe(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x76, 0x86, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if above or equal (CF=0)
        /// </summary>
        public static Element Jbe(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x76, 0x86, offsetElement, 0));
        }

        /// <summary>
        /// Jump if less (SF<>OF)
        /// </summary>
        public static Element Jl(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x7c, 0x8c, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if less (SF<>OF)
        /// </summary>
        public static Element Jl(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x7c, 0x8c, offsetElement, 0));
        }

        /// <summary>
        /// Jump if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Jle(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x7e, 0x8e, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if less or equal (ZF=1 or SF<>OF)
        /// </summary>
        public static Element Jle(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x7e, 0x8e, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not below (CF=0)
        /// </summary>
        public static Element Jnb(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x73, 0x83, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not below (CF=0)
        /// </summary>
        public static Element Jnb(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x73, 0x83, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Jnbe(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x77, 0x87, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not below or equal (CF=0 and ZF=0)
        /// </summary>
        public static Element Jnbe(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x77, 0x87, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not less (SF=OF)
        /// </summary>
        public static Element Jnl(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x7d, 0x8d, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not less (SF=OF)
        /// </summary>
        public static Element Jnl(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x7d, 0x8d, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Jnle(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x7f, 0x8f, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not less or equal (ZF=0 and SF=OF)
        /// </summary>
        public static Element Jnle(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x7f, 0x8f, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not overflow (OF=0)
        /// </summary>
        public static Element Jno(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x71, 0x81, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not overflow (OF=0)
        /// </summary>
        public static Element Jno(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x71, 0x81, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not parity (PF=0)
        /// </summary>
        public static Element Jnp(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x7b, 0x8b, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not parity (PF=0)
        /// </summary>
        public static Element Jnp(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x7b, 0x8b, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not sign (SF=0)
        /// </summary>
        public static Element Jns(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x79, 0x89, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not sign (SF=0)
        /// </summary>
        public static Element Jns(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x79, 0x89, offsetElement, 0));
        }

        /// <summary>
        /// Jump if not zero (ZF=0)
        /// </summary>
        public static Element Jnz(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x75, 0x85, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if not zero (ZF=0)
        /// </summary>
        public static Element Jnz(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x75, 0x85, offsetElement, 0));
        }

        /// <summary>
        /// Jump if overflow (OF=1)
        /// </summary>
        public static Element Jo(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x70, 0x80, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if overflow (OF=1)
        /// </summary>
        public static Element Jo(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x70, 0x80, offsetElement, 0));
        }

        /// <summary>
        /// Jump if parity (PF=1)
        /// </summary>
        public static Element Jp(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x7a, 0x8a, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if parity (PF=1)
        /// </summary>
        public static Element Jp(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x7a, 0x8a, offsetElement, 0));
        }

        /// <summary>
        /// Jump if sign (SF=1)
        /// </summary>
        public static Element Js(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x78, 0x88, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if sign (SF=1)
        /// </summary>
        public static Element Js(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x78, 0x88, offsetElement, 0));
        }

        /// <summary>
        /// Jump if zero (ZF = 1)
        /// </summary>
        public static Element Jz(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JccInstruction(0x74, 0x84, offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if zero (ZF = 1)
        /// </summary>
        public static Element Jz(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JccInstruction(0x74, 0x84, offsetElement, 0));
        }

        /// <summary>
        /// Jump if CX register is 0
        /// </summary>
        public static Element Jcxz(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JcxzInstruction(offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if CX register is 0
        /// </summary>
        public static Element Jcxz(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JcxzInstruction(offsetElement, 0));
        }

        /// <summary>
        /// Jump if ECX register is 0
        /// </summary>
        public static Element Jecxz(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new JecxzInstruction(offsetElement, offsetValue));
        }

        /// <summary>
        /// Jump if ECX register is 0
        /// </summary>
        public static Element Jecxz(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new JecxzInstruction(offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0
        /// </summary>
        public static Element Loop_CX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopCXInstruction(0xe2, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0
        /// </summary>
        public static Element Loop_CX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopCXInstruction(0xe2, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0
        /// </summary>
        public static Element Loop_ECX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopECXInstruction(0xe2, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0
        /// </summary>
        public static Element Loop_ECX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopECXInstruction(0xe2, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loope_CX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopCXInstruction(0xe1, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loope_CX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopCXInstruction(0xe1, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loope_ECX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopECXInstruction(0xe1, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loope_ECX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopECXInstruction(0xe1, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loopz_CX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopCXInstruction(0xe1, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loopz_CX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopCXInstruction(0xe1, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loopz_ECX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopECXInstruction(0xe1, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=1
        /// </summary>
        public static Element Loopz_ECX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopECXInstruction(0xe1, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopne_CX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopCXInstruction(0xe0, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopne_CX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopCXInstruction(0xe0, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopne_ECX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopECXInstruction(0xe0, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopne_ECX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopECXInstruction(0xe0, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopnz_CX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopCXInstruction(0xe0, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopnz_CX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopCXInstruction(0xe0, offsetElement, 0));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopnz_ECX(this ElementCollection collection, Element offsetElement, Int32 offsetValue)
        {
            return Add(collection, new LoopECXInstruction(0xe0, offsetElement, offsetValue));
        }

        /// <summary>
        /// Decrement count, jump if count != 0 and ZF=0
        /// </summary>
        public static Element Loopnz_ECX(this ElementCollection collection, Element offsetElement)
        {
            return Add(collection, new LoopECXInstruction(0xe0, offsetElement, 0));
        }

    }
}