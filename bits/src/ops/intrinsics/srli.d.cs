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

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class Bits
    {         
        /// <summary>
        /// _mm_srli_epi16, sse2, shift right logical:
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> srli(in Vec128<short> src, byte offset)
            => Sse2.ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srli_epi16, sse2, shift right logical:
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> srli(in Vec128<ushort> src, byte offset)
            => Sse2.ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srli_epi32, sse2, shift right logical:
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> srli(in Vec128<int> src, byte offset)
            => Sse2.ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srli_epi32, sse2, shift right logical:
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> srli(in Vec128<uint> src, byte offset)
            => Sse2.ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srli_epi64, sse2: 
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> srli(in Vec128<long> src, byte offset)
            => Sse2.ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srli_epi64, sse2: 
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> srli(in Vec128<ulong> src, byte offset)
            => Sse2.ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srli_epi32, sse2: 
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> srli32(in Vec128<ulong> src, byte offset)
            => srli(src.As<uint>(),offset).As<ulong>();

        /// <summary>
        /// _mm256_srli_epi16, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> srli(in Vec256<short> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm256_srli_epi16, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> srli(in Vec256<ushort> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm256_srli_epi32, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> srli(in Vec256<int> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm256_srli_epi32, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> srli(in Vec256<uint> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm256_srli_epi64, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> srli(in Vec256<long> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm256_srli_epi64, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> srli(in Vec256<ulong> src, byte offset)
            => ShiftRightLogical(src, offset);
 
    }

}