//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20131
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct R13B : IGpReg8<R13B>
        {
            [FieldOffset(0)]
            public byte r13b;

            public const GpRegId Id = GpRegId.r13b;          

            [MethodImpl(Inline)]
            public static implicit operator byte(R13B src)
                => src.r13b;

            [MethodImpl(Inline)]
            public static implicit operator R13B(byte src)
                => new R13B(src);            

            [MethodImpl(Inline)]
            public R13B(byte src)
                => this.r13b = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}