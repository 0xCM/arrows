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
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;
    
    partial class dinx
    {   
        /// <summary>
        /// _mm_slli_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> sll(in Vec128<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> sll(in Vec128<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> sll(in Vec128<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> sll(in Vec128<uint> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> sll(in Vec128<long> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> sll(in Vec128<ulong> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi16, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> sll(in Vec256<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi16, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> sll(in Vec256<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi32, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> sll(in Vec256<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi32, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> sll(in Vec256<uint> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi64, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> slli(in Vec256<long> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi64, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> sll(in Vec256<ulong> src, byte offset)
            => ShiftLeftLogical(src, offset);
    }

}