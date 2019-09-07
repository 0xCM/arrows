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
        public struct RBP : IGpReg64<RBP>
        {
            [FieldOffset(0)]
            public ulong rbp;

            [FieldOffset(0)]
            public EBP ebp;

            [FieldOffset(0)]
            public BP bp;

            [FieldOffset(0)]
            public BPL bpl;

            public const GpRegId Id = GpRegId.rbp;

            [MethodImpl(Inline)]
            public static implicit operator ulong(RBP src)
                => src.rbp;

            [MethodImpl(Inline)]
            public static implicit operator RBP(ulong src)
                => new RBP(src);


            [MethodImpl(Inline)]
            public RBP(ulong src)
                : this()
            {
                rbp = src;
            }

            byte IGpReg64<RBP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => bpl; 
 
                [MethodImpl(Inline)]
                set => bpl = value;
            }
            
            ushort IGpReg64<RBP>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => bp; 
 
                [MethodImpl(Inline)]
                set => bp = value;
            }

            uint IGpReg64<RBP>.Lo32
            { 
                [MethodImpl(Inline)]
                get => ebp; 
 
                [MethodImpl(Inline)]
                set => ebp = value;
            }

 
            GpRegId IGpReg.Id 
                => Id;
        }
    }

}