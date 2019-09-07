//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20113
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    

    using static zfunc;
    
    partial class Registers 
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct R13D : IGpReg32<R13>
        {

            [FieldOffset(0)]
            public uint r13d;

            [FieldOffset(0)]
            public R13W r13w;

            [FieldOffset(0)]
            public R13B r13b;
 
            public const GpRegId Id = GpRegId.r13;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R13D src)
                => src.r13d;

            [MethodImpl(Inline)]
            public static implicit operator R13D(uint src)
                => new R13D(src);

            [MethodImpl(Inline)]
            public R13D(uint src)
                : this()
            {
                r13d = src;
            }

            byte IGpReg32<R13>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r13b; 
 
                [MethodImpl(Inline)]
                set => r13b = value;
            }
            
            ushort IGpReg32<R13>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r13w; 
 
                [MethodImpl(Inline)]
                set => r13w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}