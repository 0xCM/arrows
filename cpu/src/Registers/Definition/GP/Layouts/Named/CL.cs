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
        public struct CL : IGpReg8<CL>
        {
            [FieldOffset(0)]
            public byte cl;

            public const GpRegId Id = GpRegId.cl;            

            [MethodImpl(Inline)]
            public static implicit operator byte(CL src)
                => src.cl;

            [MethodImpl(Inline)]
            public static implicit operator CL(byte src)
                => new CL(src);

            [MethodImpl(Inline)]
            public CL(byte src)
                => cl = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}