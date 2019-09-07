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
    public unsafe struct XmmBank
    {
        /// <summary>
        /// The length of each segment
        /// </summary>
        public const int SegLen = 16;

        /// <summary>
        /// The number of segments in the bank
        /// </summary>
        public const int SegCount = 16;
        
        [FieldOffset(0)]        
        fixed byte Bytes[SegLen*SegCount];

        /// <summary>
        /// Returns a reference to the first element
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref XMM First<T>()
            where T : unmanaged
                => ref Unsafe.As<byte,XMM>(ref Bytes[0]);

        /// <summary>
        /// Returns a reference to an index-identified slot
        /// </summary>
        /// <param name="index">The zero-based register index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref XMM Slot<T>(int index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), index);


        [FieldOffset(0)]
        public XMM xmm0;

        [FieldOffset(SegLen)]
        public XMM xmm1;

        [FieldOffset(SegLen*2)]
        public XMM xmm2;

        [FieldOffset(SegLen*3)]
        public XMM xmm3;

        [FieldOffset(SegLen*4)]
        public XMM xmm4;

        [FieldOffset(SegLen*5)]
        public XMM xmm5;

        [FieldOffset(SegLen*6)]
        public XMM xmm6;

        [FieldOffset(SegLen*7)]
        public XMM xmm7;

        [FieldOffset(SegLen*8)]
        public XMM xmm8;

        [FieldOffset(SegLen*9)]
        public XMM xmm9;

        [FieldOffset(SegLen*10)]
        public XMM xmm10;

        [FieldOffset(SegLen*11)]
        public XMM xmm11;

        [FieldOffset(SegLen*12)]
        public XMM xmm12;

        [FieldOffset(SegLen*13)]
        public XMM xmm13;

        [FieldOffset(SegLen*14)]
        public XMM xmm14;

        [FieldOffset(SegLen*15)]
        public XMM xmm15;

    }
}