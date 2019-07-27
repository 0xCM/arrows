//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20121
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
        public struct R12W : IGpReg16<R12W>
        {

            [FieldOffset(0)]
            public ushort r12w;

            [FieldOffset(0)]
            public R12B r12b;

            public const GpRegId Id = GpRegId.r12w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R12W src)
                => src.r12w;

            [MethodImpl(Inline)]
            public static implicit operator R12W(ushort src)
                => new R12W(src);

            [MethodImpl(Inline)]
            public R12W(ushort src)
                : this()
            {
                r12w = src;
            }
            byte IGpReg16<R12W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r12b; 
 
                [MethodImpl(Inline)]
                set => r12b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}