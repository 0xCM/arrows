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
        public struct RDX : IGpReg64<RDX>
        {
            [FieldOffset(0)]
            public ulong rdx;

            [FieldOffset(0)]
            public EDX edx;

            [FieldOffset(0)]
            public DX dx;

            [FieldOffset(0)]
            public DL dl;

            [FieldOffset(1)]
            public DH dh;

            public const GpRegId Id = GpRegId.rdx;


            [MethodImpl(Inline)]
            public static implicit operator ulong(RDX src)
                => src.rdx;

            [MethodImpl(Inline)]
            public static implicit operator RDX(ulong src)
                => new RDX(src);

            [MethodImpl(Inline)]
            public RDX(ulong src)
                : this()
            {
                rdx = src;
            }

            byte IGpReg64<RDX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => dl; 
 
                [MethodImpl(Inline)]
                set => dl = value;
            }
            
            ushort IGpReg64<RDX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => dx; 
 
                [MethodImpl(Inline)]
                set => dx = value;
            }

            uint IGpReg64<RDX>.Lo32
            { 
                [MethodImpl(Inline)]
                get => edx; 
 
                [MethodImpl(Inline)]
                set => edx = value;
            }
   
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}