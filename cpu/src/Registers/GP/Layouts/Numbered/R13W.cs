//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20131
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
        public struct R13W : IGpReg16<R13W>
        {

            [FieldOffset(0)]
            public ushort r13w;

            [FieldOffset(0)]
            public R13B r13b;

            public const GpRegId Id = GpRegId.r13w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R13W src)
                => src.r13w;

            [MethodImpl(Inline)]
            public static implicit operator R13W(ushort src)
                => new R13W(src);

            [MethodImpl(Inline)]
            public R13W(ushort src)
                : this()
            {
                r13w = src;
            }
            byte IGpReg16<R13W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r13b; 
 
                [MethodImpl(Inline)]
                set => r13b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}