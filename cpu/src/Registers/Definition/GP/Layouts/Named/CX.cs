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
        public struct CX : IGpReg16<CX>
        {
            [FieldOffset(0)]
            public ushort cx;

            [FieldOffset(0)]
            public CL cl;

            [FieldOffset(1)]
            public CH ch;

            public const GpRegId Id = GpRegId.cx;          

            [MethodImpl(Inline)]
            public static implicit operator ushort(CX src)
                => src.cx;

            [MethodImpl(Inline)]
            public static implicit operator CX(ushort src)
                => new CX(src);

            [MethodImpl(Inline)]
            public CX(ushort src)
                : this()
            {
                this.cx = src;
            }

            byte IGpReg16<CX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => cl; 
 
                [MethodImpl(Inline)]
                set => cl = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}