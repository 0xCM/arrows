//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    
    
    using static zfunc;    

    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct EBP : IGpReg32<EBP>
        {
            [FieldOffset(0)]
            public uint ebp;

            [FieldOffset(0)]
            public BP bp;

            [FieldOffset(0)]
            public BPL bpl;

            public const GpRegId Id = GpRegId.ebp;

            [MethodImpl(Inline)]
            public static implicit operator uint(EBP src)
                => src.ebp;

            [MethodImpl(Inline)]
            public static implicit operator EBP(uint src)
                => new EBP(src);


            [MethodImpl(Inline)]
            public EBP(uint src)
                : this()
            {
                ebp = src;
            }

            byte IGpReg32<EBP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => bpl; 
 
                [MethodImpl(Inline)]
                set => bpl = value;
            }
            
            ushort IGpReg32<EBP>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => bp; 
 
                [MethodImpl(Inline)]
                set => bp = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
        }
    }

}