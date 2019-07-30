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
        public struct RBX : IGpReg64<RBX>
        {
            [FieldOffset(0)]
            public ulong rbx;

            [FieldOffset(0)]
            public EBX ebx;

            [FieldOffset(0)]
            public BX bx;

            [FieldOffset(0)]
            public BL bl;

            [FieldOffset(1)]
            public BH bh;

            public const GpRegId Id = GpRegId.rbx;

            [MethodImpl(Inline)]
            public static implicit operator ulong(RBX src)
                => src.rbx;

            [MethodImpl(Inline)]
            public static implicit operator RBX(ulong src)
                => new RBX(src);

            [MethodImpl(Inline)]
            public RBX(ulong src)
                : this()
            {
                rbx = src;
            }
 
            byte IGpReg64<RBX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => bl; 
 
                [MethodImpl(Inline)]
                set => bl = value;
            }
            
            ushort IGpReg64<RBX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => bx; 
 
                [MethodImpl(Inline)]
                set => bx = value;
            }

            uint IGpReg64<RBX>.Lo32
            { 
                [MethodImpl(Inline)]
                get => ebx; 
 
                [MethodImpl(Inline)]
                set => ebx = value;
            }
   
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}