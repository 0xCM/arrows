//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public struct AX : IGpReg16<AX>
        {
            [FieldOffset(0)]
            public ushort ax;

            [FieldOffset(0)]
            public AL al;

            [FieldOffset(1)]
            public AH ah;

            public const GpRegId Id = GpRegId.ax;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(AX src)
                => src.ax;

            [MethodImpl(Inline)]
            public static implicit operator AX(ushort src)
                => new AX(src);

            [MethodImpl(Inline)]
            public AX(ushort src)
                : this()
            {
                this.ax = src;
            }


            byte IGpReg16<AX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => al; 
 
                [MethodImpl(Inline)]
                set => al = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}