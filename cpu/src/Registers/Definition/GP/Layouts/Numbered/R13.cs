//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20113
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
        public struct R13 : IGpReg64<R13>
        { 
            [FieldOffset(0)]
            public ulong r13;

            [FieldOffset(0)]
            public R13D r13d;

            [FieldOffset(0)]
            public R13W r13w;

            [FieldOffset(0)]
            public R13B r13b;

            public const GpRegId Id = GpRegId.r13;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R13 src)
                => src.r13;

            [MethodImpl(Inline)]
            public static implicit operator R13(ulong src)
                => new R13(src);

            [MethodImpl(Inline)]
            public R13(ulong src)
                : this()
            {
                r13 = src;
            }

            byte IGpReg64<R13>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r13b; 
 
                [MethodImpl(Inline)]
                set => r13b = value;
            }
            
            ushort IGpReg64<R13>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r13w; 
 
                [MethodImpl(Inline)]
                set => r13w = value;
            }

            uint IGpReg64<R13>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r13d; 
 
                [MethodImpl(Inline)]
                set => r13d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}