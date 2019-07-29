//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

	using Iced.Intel;

    using static zfunc;

    using Z0.Cpu;

    using AsmOpKind = Iced.Intel.OpKind;
    using static Iced.Intel.OpKind;

    public class AsmOpMemInfo
    {
        public byte OperandIndex {get;set;}
        
        public Char8? BaseRegister {get;set;}
        
        public uint? Displacement {get; set;}
        
        public int? IndexScale {get; set;}
        
        public int? DisplacementSize {get;set;}
        
        public Char8? SegmentRegister {get; set;}
        
        public Char8? SegmentPrefix {get; set;}
        
        public string Size {get; set;}
        
    }

    public class AsmOpRegisterInfo
    {
        public AsmOpRegisterInfo(string RegisterName)
        {
            this.RegisterName = RegisterName;
        }
        
        public string RegisterName {get;}
    }

    public static class AsmOperandKind
    {
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        public static bool IsNearBranch(this AsmOpKind src)        
            => src == AsmOpKind.NearBranch16
            || src == AsmOpKind.NearBranch32
            || src == AsmOpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        public static bool IsFarBranch(this AsmOpKind src)        
            => src == AsmOpKind.FarBranch16
            || src == AsmOpKind.FarBranch32;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSpecialImmediate8(this AsmOpKind src)
            => src == AsmOpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSignExtendedImmediate(this AsmOpKind src)
            => src == AsmOpKind.Immediate8to16  
            || src == AsmOpKind.Immediate8to32  
            || src == AsmOpKind.Immediate8to64  
            || src == AsmOpKind.Immediate32to64 
             ;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectImmediate(this AsmOpKind src)
            => src == AsmOpKind.Immediate8
            || src == AsmOpKind.Immediate16
            || src == AsmOpKind.Immediate32
            || src == AsmOpKind.Immediate64
            ;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsImmediate(this AsmOpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise,
        /// returns <see cref='BitSize.Zero'/>
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static BitSize GetImmediateSize(this AsmOpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return 8;
            else if(src == Immediate16 || src == Immediate8to16)
                return 16;
            else if(src == Immediate32 || src == Immediate8to32)
                return 32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return 64;
            else
                return BitSize.Zero;
        }

        public static Option<AsmOpRegisterInfo> RegisterInfo(this Instruction inx, int operand)
        {
            var kind = inx.GetOpKind(operand);
            if(kind.IsRegister())
            {
                var reg = inx.GetOpRegister(operand);

                return new AsmOpRegisterInfo(reg.ToString());
                
            }

            return default;
        }
        public static Option<AsmOpMemInfo> MemoryInfo(this Instruction inx, int operand)
        {
            var kind = inx.GetOpKind(operand);
            var info = new AsmOpMemInfo();
            if(kind.IsMemDirect())
            {
                info.BaseRegister = inx.MemoryBase.ToString();
                info.Displacement = inx.MemoryDisplacement;
                info.DisplacementSize = inx.MemoryDisplSize;
                info.IndexScale = inx.MemoryIndexScale;

                info.Size = inx.MemorySize.ToString();
                info.SegmentRegister = inx.MemorySegment.ToString();
                info.SegmentPrefix = inx.SegmentPrefix.ToString();
            }

            return default;
        }

        public static Option<ImmInfo> ImmediateInfo(this Instruction inx, int operand)
        {
            var result = none<ImmInfo>();
            var kind = inx.GetOpKind(operand);
            int size = kind.GetImmediateSize();
            if(size != 0)
            {
                var sinx = kind.IsSignExtendedImmediate();
                var immval = inx.GetImmediate(operand);
                switch(size)
                {
                    case Pow2.T03:
                        return Imm8.Define((byte)immval).Description;
                    case Pow2.T04:
                        if(sinx)
                            return Imm16i.Define((short)immval).Description;
                        else 
                            return Imm16.Define((ushort)immval).Description;
                    case Pow2.T05:
                        if(sinx)
                            return Imm32i.Define((int)immval).Description;
                        else 
                            return Imm32.Define((uint)immval).Description;                    
                    case Pow2.T06:
                        if(sinx)
                            return Imm64i.Define((long)immval).Description;
                        else 
                            return Imm64.Define(immval).Description;                    
                }

            }

            return result;
        }
        
        /// <summary>
        /// Determines whether the classified operand is a segment of the form seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemBaseSegment(this AsmOpKind src)
            => src == AsmOpKind.MemorySegDI
            || src == AsmOpKind.MemorySegEDI
            || src == AsmOpKind.MemorySegESI
            || src == AsmOpKind.MemorySegRDI
            || src == AsmOpKind.MemorySegRSI
            || src == AsmOpKind.MemorySegSI
            ;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemEsSegment(this AsmOpKind src)            
            => src == AsmOpKind.MemoryESDI
            || src == AsmOpKind.MemoryESEDI
            || src == AsmOpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemOffset64(this AsmOpKind src)
            =>  src == AsmOpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemDirect(this AsmOpKind src)
            => src == AsmOpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemory(this AsmOpKind src)            
            => src.IsMemDirect() || src.IsMemOffset64() || src.IsMemEsSegment() || src.IsMemBaseSegment();

        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsRegister(this AsmOpKind src)
            => src == AsmOpKind.Register;

    }

}