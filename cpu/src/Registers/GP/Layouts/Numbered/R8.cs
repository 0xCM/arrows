//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public struct R8 : IGpReg64<R8>
        {
            [FieldOffset(0)]
            public ulong r8;

            [FieldOffset(0)]
            public R8D r8d;

            [FieldOffset(0)]
            public R8W r8w;

            [FieldOffset(0)]
            public R8B r8b;

            public const GpRegId Id = GpRegId.r8;

            [MethodImpl(Inline)]
            public static implicit operator ulong(R8 src)
                => src.r8;

            [MethodImpl(Inline)]
            public static implicit operator R8(ulong src)
                => new R8(src);

            [MethodImpl(Inline)]
            public R8(ulong src)
                : this()
            {
                r8 = src;
            }

            byte IGpReg64<R8>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r8b; 
 
                [MethodImpl(Inline)]
                set => r8b = value;
            }
            
            ushort IGpReg64<R8>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r8w; 
 
                [MethodImpl(Inline)]
                set => r8w = value;
            }

            uint IGpReg64<R8>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r8d; 
 
                [MethodImpl(Inline)]
                set => r8d = value;
            }

            GpRegId IGpReg.Id 
                => Id;

       }
    }
}