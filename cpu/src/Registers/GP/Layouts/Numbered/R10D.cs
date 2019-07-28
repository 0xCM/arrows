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
        public struct R10D : IGpReg32<R10>
        {

            [FieldOffset(0)]
            public uint r10d;

            [FieldOffset(0)]
            public R10W r10w;

            [FieldOffset(0)]
            public R10B r10b;
 
            public const GpRegId Id = GpRegId.r10;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R10D src)
                => src.r10d;

            [MethodImpl(Inline)]
            public static implicit operator R10D(uint src)
                => new R10D(src);

            [MethodImpl(Inline)]
            public R10D(uint src)
                : this()
            {
                r10d = src;
            }

            byte IGpReg32<R10>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r10b; 
 
                [MethodImpl(Inline)]
                set => r10b = value;
            }
            
            ushort IGpReg32<R10>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r10w; 
 
                [MethodImpl(Inline)]
                set => r10w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}