//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20112
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
        public struct R12D : IGpReg32<R12>
        {

            [FieldOffset(0)]
            public uint r12d;

            [FieldOffset(0)]
            public R12W r12w;

            [FieldOffset(0)]
            public R12B r12b;
 
            public const GpRegId Id = GpRegId.r12;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R12D src)
                => src.r12d;

            [MethodImpl(Inline)]
            public static implicit operator R12D(uint src)
                => new R12D(src);

            [MethodImpl(Inline)]
            public R12D(uint src)
                : this()
            {
                r12d = src;
            }

            byte IGpReg32<R12>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r12b; 
 
                [MethodImpl(Inline)]
                set => r12b = value;
            }
            
            ushort IGpReg32<R12>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r12w; 
 
                [MethodImpl(Inline)]
                set => r12w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}