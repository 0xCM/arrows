//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20151
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
        public struct R15B : IGpReg8<R15B>
        {
            [FieldOffset(0)]
            public byte r15b;

            public const GpRegId Id = GpRegId.r15b;          

            [MethodImpl(Inline)]
            public static implicit operator byte(R15B src)
                => src.r15b;

            [MethodImpl(Inline)]
            public static implicit operator R15B(byte src)
                => new R15B(src);            

            [MethodImpl(Inline)]
            public R15B(byte src)
                => this.r15b = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}