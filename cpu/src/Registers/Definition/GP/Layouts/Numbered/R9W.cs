//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public struct R9W : IGpReg16<R9W>
        {

            [FieldOffset(0)]
            public ushort r9w;

            [FieldOffset(0)]
            public R9B r9b;

            public const GpRegId Id = GpRegId.r9w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R9W src)
                => src.r9w;

            [MethodImpl(Inline)]
            public static implicit operator R9W(ushort src)
                => new R9W(src);

            [MethodImpl(Inline)]
            public R9W(ushort src)
                : this()
            {
                r9w = src;
            }
            byte IGpReg16<R9W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r9b; 
 
                [MethodImpl(Inline)]
                set => r9b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}