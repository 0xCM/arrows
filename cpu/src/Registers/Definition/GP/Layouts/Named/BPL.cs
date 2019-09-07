//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using Z0.Asm;

    using static zfunc;

    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct BPL : IGpReg8<BPL>
        {
            [FieldOffset(0)]
            public byte bpl;

            public const GpRegId Id = GpRegId.bpl;

            [MethodImpl(Inline)]
            public static implicit operator byte(BPL src)
                => src.bpl;

            [MethodImpl(Inline)]
            public static implicit operator BPL(byte src)
                => new BPL(src);


            [MethodImpl(Inline)]
            public BPL(byte src)
                : this()
            {
                bpl = src;
            }
            
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}