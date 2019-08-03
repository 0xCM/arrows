//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2018
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
        public struct R8B : IGpReg8<R8B>
        {
            [FieldOffset(0)]
            public byte r8b;

            public const GpRegId Id = GpRegId.r8b;


            [MethodImpl(Inline)]
            public static implicit operator byte(R8B src)
                => src.r8b;

            [MethodImpl(Inline)]
            public static implicit operator R8B(byte src)
                => new R8B(src);            

            [MethodImpl(Inline)]
            public R8B(byte src)
                => this.r8b = src;

            GpRegId IGpReg.Id 
                => Id;

        }
    }
}