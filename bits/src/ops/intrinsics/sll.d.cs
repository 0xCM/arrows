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

    using static zfunc;
    
    partial class Bits
    {   
        /// <summary>
        /// _mm_sll_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> sll(in Vec128<short> src, Vec128<short> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_sll_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> sll(in Vec128<ushort> src, Vec128<ushort> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_sll_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> sll(in Vec128<int> src, Vec128<int> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_sll_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> sll(in Vec128<uint> src, Vec128<uint> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_sll_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> sll(in Vec128<long> src, Vec128<long> offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_sll_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> sll(in Vec128<ulong> src, Vec128<ulong> offset)
            => ShiftLeftLogical(src, offset);

    }

}