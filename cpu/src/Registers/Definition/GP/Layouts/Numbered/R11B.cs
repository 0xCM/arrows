//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20111
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
        public struct R11B : IGpReg8<R11B>
        {
            [FieldOffset(0)]
            public byte r11b;

            public const GpRegId Id = GpRegId.r11b;          

            [MethodImpl(Inline)]
            public static implicit operator byte(R11B src)
                => src.r11b;

            [MethodImpl(Inline)]
            public static implicit operator R11B(byte src)
                => new R11B(src);            

            [MethodImpl(Inline)]
            public R11B(byte src)
                => this.r11b = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}