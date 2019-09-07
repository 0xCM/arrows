//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20111
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
        public struct R11 : IGpReg64<R11>
        { 
            [FieldOffset(0)]
            public ulong r11;

            [FieldOffset(0)]
            public R11D r11d;

            [FieldOffset(0)]
            public R11W r11w;

            [FieldOffset(0)]
            public R11B r11b;

            public const GpRegId Id = GpRegId.r11;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R11 src)
                => src.r11;

            [MethodImpl(Inline)]
            public static implicit operator R11(ulong src)
                => new R11(src);

            [MethodImpl(Inline)]
            public R11(ulong src)
                : this()
            {
                r11 = src;
            }

            byte IGpReg64<R11>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r11b; 
 
                [MethodImpl(Inline)]
                set => r11b = value;
            }
            
            ushort IGpReg64<R11>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r11w; 
 
                [MethodImpl(Inline)]
                set => r11w = value;
            }

            uint IGpReg64<R11>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r11d; 
 
                [MethodImpl(Inline)]
                set => r11d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}