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
        public struct BX : IGpReg16<BX>
        {
            [FieldOffset(0)]
            public ushort bx;

            [FieldOffset(0)]
            public BL bl;

            [FieldOffset(1)]
            public BH bh;

            public const GpRegId Id = GpRegId.bx;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(BX src)
                => src.bx;

            [MethodImpl(Inline)]
            public static implicit operator BX(ushort src)
                => new BX(src);

            [MethodImpl(Inline)]
            public BX(ushort src)
                : this()
            {
                this.bx = src;
            }
 
            byte IGpReg16<BX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => bl; 
 
                [MethodImpl(Inline)]
                set => bl = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}