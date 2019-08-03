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
        public struct AH : IGpReg8<AH>
        {
            [FieldOffset(0)]
            public byte ah;

            public const GpRegId Id = GpRegId.ah;            

            [MethodImpl(Inline)]
            public static implicit operator byte(AH src)
                => src.ah;

            [MethodImpl(Inline)]
            public static implicit operator AH(byte src)
                => new AH(src);

            [MethodImpl(Inline)]
            public AH(byte src)
                =>ah = src;
                
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}