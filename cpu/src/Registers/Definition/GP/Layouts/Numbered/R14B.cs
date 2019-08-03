//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20141
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
        public struct R14B : IGpReg8<R14B>
        {
            [FieldOffset(0)]
            public byte r14b;

            public const GpRegId Id = GpRegId.r14b;          

            [MethodImpl(Inline)]
            public static implicit operator byte(R14B src)
                => src.r14b;

            [MethodImpl(Inline)]
            public static implicit operator R14B(byte src)
                => new R14B(src);            

            [MethodImpl(Inline)]
            public R14B(byte src)
                => this.r14b = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}