//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2018
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
        public struct R8W : IGpReg16<R8W>
        {

            [FieldOffset(0)]
            public ushort r8w;

            [FieldOffset(0)]
            public R8B r8b;

            public const GpRegId Id = GpRegId.r8w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R8W src)
                => src.r8w;

            [MethodImpl(Inline)]
            public static implicit operator R8W(ushort src)
                => new R8W(src);

            [MethodImpl(Inline)]
            public R8W(ushort src)
                : this()
            {
                r8w = src;
            }
            byte IGpReg16<R8W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r8b; 
 
                [MethodImpl(Inline)]
                set => r8b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}