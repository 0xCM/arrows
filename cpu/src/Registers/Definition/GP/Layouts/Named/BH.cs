//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using Z0.Asm;

    using static zfunc;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct BH : IGpReg8<BH>
        {
            [FieldOffset(0)]
            public byte bh;

            public const GpRegId Id = GpRegId.bh;            

            [MethodImpl(Inline)]
            public static implicit operator byte(BH src)
                => src.bh;

            [MethodImpl(Inline)]
            public static implicit operator BH(byte src)
                => new BH(src);

            [MethodImpl(Inline)]
            public BH(byte src)
                => bh = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}