//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20112
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
        public struct R12 : IGpReg64<R12>
        { 
            [FieldOffset(0)]
            public ulong r12;

            [FieldOffset(0)]
            public R12D r12d;

            [FieldOffset(0)]
            public R12W r12w;

            [FieldOffset(0)]
            public R12B r12b;

            public const GpRegId Id = GpRegId.r12;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R12 src)
                => src.r12;

            [MethodImpl(Inline)]
            public static implicit operator R12(ulong src)
                => new R12(src);

            [MethodImpl(Inline)]
            public R12(ulong src)
                : this()
            {
                r12 = src;
            }

            byte IGpReg64<R12>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r12b; 
 
                [MethodImpl(Inline)]
                set => r12b = value;
            }
            
            ushort IGpReg64<R12>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r12w; 
 
                [MethodImpl(Inline)]
                set => r12w = value;
            }

            uint IGpReg64<R12>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r12d; 
 
                [MethodImpl(Inline)]
                set => r12d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}