//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20115
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
        public struct R15 : IGpReg64<R15>
        { 
            [FieldOffset(0)]
            public ulong r15;

            [FieldOffset(0)]
            public R15D r15d;

            [FieldOffset(0)]
            public R15W r15w;

            [FieldOffset(0)]
            public R15B r15b;

            public const GpRegId Id = GpRegId.r15;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R15 src)
                => src.r15;

            [MethodImpl(Inline)]
            public static implicit operator R15(ulong src)
                => new R15(src);

            [MethodImpl(Inline)]
            public R15(ulong src)
                : this()
            {
                r15 = src;
            }

            byte IGpReg64<R15>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r15b; 
 
                [MethodImpl(Inline)]
                set => r15b = value;
            }
            
            ushort IGpReg64<R15>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r15w; 
 
                [MethodImpl(Inline)]
                set => r15w = value;
            }

            uint IGpReg64<R15>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r15d; 
 
                [MethodImpl(Inline)]
                set => r15d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}