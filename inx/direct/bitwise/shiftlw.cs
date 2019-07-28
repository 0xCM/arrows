//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static UInt128 shiftlw(UInt128 src, byte count)        
            => ShiftLeftLogical128BitLane(src, count).ToUInt128();                            

        /// <intrinsic>__m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<short> shiftlw(in Vec128<short> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shiftlw(in Vec128<ushort> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftlw(in Vec128<int> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftlw(in Vec128<uint> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftlw(in Vec128<long> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftlw(in Vec128<ulong> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);
        
        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<short> shiftlw(in Vec256<short> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ushort> shiftlw(in Vec256<ushort> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<int> shiftlw(in Vec256<int> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<uint> shiftlw(in Vec256<uint> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> shiftlw(in Vec256<long> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftlw(in Vec256<ulong> src, byte count)
            => ShiftLeftLogical128BitLane(src, count); 
    }
}