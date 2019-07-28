//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public struct EDX : IGpReg32<EDX>
        {
            [FieldOffset(0)]
            public uint edx;

            [FieldOffset(0)]
            public DX dx;

            [FieldOffset(0)]
            public DL dl;

            [FieldOffset(1)]
            public DH dh;

            public const GpRegId Id = GpRegId.edx;          

            [MethodImpl(Inline)]
            public static implicit operator uint(EDX src)
                => src.edx;

            [MethodImpl(Inline)]
            public static implicit operator EDX(uint src)
                => new EDX(src);

            [MethodImpl(Inline)]
            public EDX(uint src)
                : this()
            {
                this.edx = src;
            }

            public uint Content 
            { 
                [MethodImpl(Inline)]
                get => edx; 

                [MethodImpl(Inline)]
                set => edx = value;
            }

            byte IGpReg32<EDX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => dl; 
 
                [MethodImpl(Inline)]
                set => dl = value;
            }
            
            ushort IGpReg32<EDX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => dx; 
 
                [MethodImpl(Inline)]
                set => dx = value;
            }
  
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}