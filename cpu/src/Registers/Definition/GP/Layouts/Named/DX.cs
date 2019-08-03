//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using Z0.Asm;

    using static zfunc;
        
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct DX : IGpReg16<DX>
        {
            [FieldOffset(0)]
            public ushort dx;

            [FieldOffset(0)]
            public DL dl;

            [FieldOffset(1)]
            public DH dh;

            public const int BitWidth = 16;        

            public const int ByteCount = 2;

            public const string Name = nameof(DX);

            public const GpRegId Id = GpRegId.dx;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(DX src)
                => src.dx;

            [MethodImpl(Inline)]
            public static implicit operator DX(ushort src)
                => new DX(src);

            [MethodImpl(Inline)]
            public DX(ushort src)
                : this()
            {
                this.dx = src;
            }
 
            byte IGpReg16<DX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => dl; 
 
                [MethodImpl(Inline)]
                set => dl = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}