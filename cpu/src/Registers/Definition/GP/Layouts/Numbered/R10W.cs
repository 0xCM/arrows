//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20110
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
        public struct R10W : IGpReg16<R10W>
        {

            [FieldOffset(0)]
            public ushort r10w;

            [FieldOffset(0)]
            public R10B r10b;

            public const GpRegId Id = GpRegId.r10w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R10W src)
                => src.r10w;

            [MethodImpl(Inline)]
            public static implicit operator R10W(ushort src)
                => new R10W(src);

            [MethodImpl(Inline)]
            public R10W(ushort src)
                : this()
            {
                r10w = src;
            }
            byte IGpReg16<R10W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r10b; 
 
                [MethodImpl(Inline)]
                set => r10b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}