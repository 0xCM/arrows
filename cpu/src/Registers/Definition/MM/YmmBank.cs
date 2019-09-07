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
    using static Registers;

    [StructLayout(LayoutKind.Explicit, Size = SegLen*SegCount)]
    public unsafe struct YmmBank
    {
        public const int SegLen = 32;

        public const int SegCount = 16;

        const int HiPart = 16;

        [FieldOffset(0)]        
        fixed byte Bytes[SegLen*SegCount];

        /// <summary>
        /// Returns a reference to the first register
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref YMM First<T>()
            where T : unmanaged
                => ref Unsafe.As<byte,YMM>(ref Bytes[0]);

        /// <summary>
        /// Returns a reference to an index-identified slot
        /// </summary>
        /// <param name="index">The zero-based register index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref YMM Slot<T>(int index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), index);


        //~ 00
        //~ ----------------------
        [FieldOffset(0)]
        public YMM ymm0;

        [FieldOffset(0)]
        public XMM xmm0L;

        [FieldOffset(HiPart)]
        public XMM xmm0H;

        //~ 01
        //~ ----------------------
        [FieldOffset(SegLen)]
        public YMM ymm1;

        [FieldOffset(SegLen)]
        public XMM xmm1L;

        [FieldOffset(SegLen + HiPart)]
        public XMM xmm1H;

        //~ 02
        //~ ----------------------
        [FieldOffset(SegLen*2)]
        public YMM ymm2;

        [FieldOffset(SegLen*2)]
        public XMM xmm2L;

        [FieldOffset(SegLen*2 + HiPart)]
        public XMM xmm2H;

        //~ 03
        //~ ----------------------
        [FieldOffset(SegLen*3)]
        public YMM ymm3;

        [FieldOffset(SegLen*3)]
        public XMM xmm3L;

        [FieldOffset(SegLen*3 + HiPart)]
        public XMM xmm3H;

        //~ 04
        //~ ----------------------
        [FieldOffset(SegLen*4)]
        public YMM ymm4;

        [FieldOffset(SegLen*4)]
        public XMM xmm4L;

        [FieldOffset(SegLen*4 + HiPart)]
        public XMM xmm4H;

        //~ 05
        //~ ----------------------
        [FieldOffset(SegLen*5)]
        public YMM ymm5;

        [FieldOffset(SegLen*5)]
        public XMM xmm5L;

        [FieldOffset(SegLen*5 + HiPart)]
        public XMM xmm5H;


        //~ 06
        //~ ----------------------
        [FieldOffset(SegLen*6)]
        public YMM ymm6;

        [FieldOffset(SegLen*6)]
        public XMM xmm6L;

        [FieldOffset(SegLen*6 + HiPart)]
        public XMM xmm6H;

        //~ 07
        //~ ----------------------
        [FieldOffset(SegLen*7)]
        public YMM ymm7;

        [FieldOffset(SegLen*7)]
        public XMM xmm7L;

        [FieldOffset(SegLen*7 + HiPart)]
        public XMM xmm7H;

        //~ 08
        //~ ----------------------
        [FieldOffset(SegLen*8)]
        public YMM ymm8;

        [FieldOffset(SegLen*8)]
        public XMM xmm8L;

        [FieldOffset(SegLen*8 + HiPart)]
        public XMM xmm8H;

        //~ 09
        //~ ----------------------
        [FieldOffset(SegLen*9)]
        public YMM ymm9;

        [FieldOffset(SegLen*9)]
        public XMM xmm9L;

        [FieldOffset(SegLen*9 + HiPart)]
        public XMM xmm9H;

        //~ 10
        //~ ----------------------
        [FieldOffset(SegLen*10)]
        public YMM ymm10;

        [FieldOffset(SegLen*10)]
        public XMM xmm10L;

        [FieldOffset(SegLen*10 + HiPart)]
        public XMM xmm10H;

        //~ 11
        //~ ----------------------
        [FieldOffset(SegLen*11)]
        public YMM ymm11;

        [FieldOffset(SegLen*11)]
        public XMM xmm11L;

        [FieldOffset(SegLen*11 + HiPart)]
        public XMM xmm11H;

        //~ 12
        //~ ----------------------
        [FieldOffset(SegLen*12)]
        public YMM ymm12;

        [FieldOffset(SegLen*12)]
        public XMM xmm12L;

        [FieldOffset(SegLen*12 + HiPart)]
        public XMM xmm12H;

        //~ 13
        //~ ----------------------
        [FieldOffset(SegLen*13)]
        public YMM ymm13;

        [FieldOffset(SegLen*13)]
        public XMM xmm13L;

        [FieldOffset(SegLen*13 + HiPart)]
        public XMM xmm13H;

        //~ 14
        //~ ----------------------
        [FieldOffset(SegLen*14)]
        public YMM ymm14;

        [FieldOffset(SegLen*14)]
        public XMM xmm14L;

        [FieldOffset(SegLen*14 + HiPart)]
        public XMM xmm14H;

        //~ 15
        //~ ----------------------
        [FieldOffset(SegLen*15)]
        public YMM ymm15;

        [FieldOffset(SegLen*15)]
        public XMM xmm15L;

        [FieldOffset(SegLen*15 + HiPart)]
        public XMM xmm15H;



    }
}