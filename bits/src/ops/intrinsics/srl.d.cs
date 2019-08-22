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
        /// _mm_srl_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> srl(in Vec128<short> src, Vec128<short> offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srl_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> srl(in Vec128<ushort> src, Vec128<ushort> offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srl_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> srl(in Vec128<int> src, Vec128<int> offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srl_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> srl(in Vec128<uint> src, Vec128<uint> offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srl_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> srl(in Vec128<long> src, Vec128<long> offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// _mm_srl_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> srl(in Vec128<ulong> src, Vec128<ulong> offset)
            => ShiftRightLogical(src, offset);

    }

}