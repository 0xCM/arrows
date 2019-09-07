//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public struct R9 : IGpReg64<R9>
        {
            [FieldOffset(0)]
            public ulong r9;

            [FieldOffset(0)]
            public R9D r9d;

            [FieldOffset(0)]
            public R9W r9w;

            [FieldOffset(0)]
            public R9B r9b;
 
            public const GpRegId Id = GpRegId.r9;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R9 src)
                => src.r9;

            [MethodImpl(Inline)]
            public static implicit operator R9(ulong src)
                => new R9(src);

            [MethodImpl(Inline)]
            public R9(ulong src)
                : this()
            {
                r9 = src;
            }

            byte IGpReg64<R9>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r9b; 
 
                [MethodImpl(Inline)]
                set => r9b = value;
            }
            
            ushort IGpReg64<R9>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r9w; 
 
                [MethodImpl(Inline)]
                set => r9w = value;
            }

            uint IGpReg64<R9>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r9d; 
 
                [MethodImpl(Inline)]
                set => r9d = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}