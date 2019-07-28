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
        public struct RAX : IGpReg64<RAX>
        {
            [FieldOffset(0)]
            public ulong rax;

            [FieldOffset(0)]
            public EAX eax;

            [FieldOffset(0)]
            public AX ax;

            [FieldOffset(0)]
            public AL al;

            [FieldOffset(1)]
            public AH ah;

            public const GpRegId Id = GpRegId.rcx;

            [MethodImpl(Inline)]
            public static implicit operator ulong(RAX src)
                => src.rax;

            [MethodImpl(Inline)]
            public static implicit operator RAX(ulong src)
                => new RAX(src);

            [MethodImpl(Inline)]
            public RAX(ulong src)
                : this()
            {
                rax = src;
            }

            byte IGpReg64<RAX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => al; 
 
                [MethodImpl(Inline)]
                set => al = value;
            }

            ushort IGpReg64<RAX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => ax; 
 
                [MethodImpl(Inline)]
                set => ax = value;
            }

            uint IGpReg64<RAX>.Lo32
            { 
                [MethodImpl(Inline)]
                get => eax; 
 
                [MethodImpl(Inline)]
                set => eax = value;
            }


            GpRegId IGpReg.Id 
                => Id;
        }
    }
}