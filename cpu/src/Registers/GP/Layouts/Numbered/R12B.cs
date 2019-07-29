//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20121
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
        public struct R12B : IGpReg8<R12B>
        {
            [FieldOffset(0)]
            public byte r12b;

            public const GpRegId Id = GpRegId.r12b;          

            [MethodImpl(Inline)]
            public static implicit operator byte(R12B src)
                => src.r12b;

            [MethodImpl(Inline)]
            public static implicit operator R12B(byte src)
                => new R12B(src);            

            [MethodImpl(Inline)]
            public R12B(byte src)
                => this.r12b = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}