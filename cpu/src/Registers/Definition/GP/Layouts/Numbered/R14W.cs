//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20141
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
        public struct R14W : IGpReg16<R14W>
        {

            [FieldOffset(0)]
            public ushort r14w;

            [FieldOffset(0)]
            public R14B r14b;

            public const GpRegId Id = GpRegId.r14w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R14W src)
                => src.r14w;

            [MethodImpl(Inline)]
            public static implicit operator R14W(ushort src)
                => new R14W(src);

            [MethodImpl(Inline)]
            public R14W(ushort src)
                : this()
            {
                r14w = src;
            }
            byte IGpReg16<R14W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r14b; 
 
                [MethodImpl(Inline)]
                set => r14b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}