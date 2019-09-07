//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20151
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
        public struct R15W : IGpReg16<R15W>
        {

            [FieldOffset(0)]
            public ushort r15w;

            [FieldOffset(0)]
            public R15B r15b;

            public const GpRegId Id = GpRegId.r15w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R15W src)
                => src.r15w;

            [MethodImpl(Inline)]
            public static implicit operator R15W(ushort src)
                => new R15W(src);

            [MethodImpl(Inline)]
            public R15W(ushort src)
                : this()
            {
                r15w = src;
            }
            byte IGpReg16<R15W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r15b; 
 
                [MethodImpl(Inline)]
                set => r15b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}