//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20110
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static BitWidth;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct R10B : IGpReg8<R10B>
        {
            [FieldOffset(0)]
            public byte r10b;

            public const GpRegId Id = GpRegId.r10b;          

            [MethodImpl(Inline)]
            public static implicit operator byte(R10B src)
                => src.r10b;

            [MethodImpl(Inline)]
            public static implicit operator R10B(byte src)
                => new R10B(src);            

            [MethodImpl(Inline)]
            public R10B(byte src)
                => this.r10b = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}