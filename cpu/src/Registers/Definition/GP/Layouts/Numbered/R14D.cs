//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20114
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
        public struct R14D : IGpReg32<R14>
        {

            [FieldOffset(0)]
            public uint r14d;

            [FieldOffset(0)]
            public R14W r14w;

            [FieldOffset(0)]
            public R14B r14b;
 
            public const GpRegId Id = GpRegId.r14;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R14D src)
                => src.r14d;

            [MethodImpl(Inline)]
            public static implicit operator R14D(uint src)
                => new R14D(src);

            [MethodImpl(Inline)]
            public R14D(uint src)
                : this()
            {
                r14d = src;
            }

            byte IGpReg32<R14>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r14b; 
 
                [MethodImpl(Inline)]
                set => r14b = value;
            }
            
            ushort IGpReg32<R14>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r14w; 
 
                [MethodImpl(Inline)]
                set => r14w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}