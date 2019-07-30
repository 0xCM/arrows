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
    

    partial class Registers
    {

        [StructLayout(LayoutKind.Explicit)]
        public struct EBX : IGpReg32<EBX>
        {

            [FieldOffset(0)]
            public uint ebx;

            [FieldOffset(0)]
            public BX bx;

            [FieldOffset(0)]
            public BL bl;

            [FieldOffset(1)]
            public BH bh;

            public const GpRegId Id = GpRegId.ebx;

            [MethodImpl(Inline)]
            public static implicit operator uint(EBX src)
                => src.ebx;

            [MethodImpl(Inline)]
            public static implicit operator EBX(uint src)
                => new EBX(src);

            [MethodImpl(Inline)]
            public EBX(uint src)
                : this()
            {
                ebx = src;
            }
 
            byte IGpReg32<EBX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => bl; 
 
                [MethodImpl(Inline)]
                set => bl = value;
            }
            
            ushort IGpReg32<EBX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => bx; 
 
                [MethodImpl(Inline)]
                set => bx = value;
            }

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}