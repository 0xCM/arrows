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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx
    {
        
        [MethodImpl(Inline)]
        public static Vec128<sbyte> alignr(Vec128<sbyte> left, Vec128<sbyte> right, byte offset)
            => AlignRight(left, right, offset);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Concatenate 16-byte blocks in a and b into a 32-byte temporary result, shift the result right 
        /// by count bytes, and store the low 16 bytes in dst.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline)]
        public static Vec128<byte> alignr(Vec128<byte> left, Vec128<byte> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec128<short> alignr(Vec128<short> left, Vec128<short> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec128<ushort> alignr(Vec128<ushort> left, Vec128<ushort> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec128<int> alignr(Vec128<int> left, Vec128<int> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec128<uint> alignr(Vec128<uint> left, Vec128<uint> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec128<long> alignr(Vec128<long> left, Vec128<long> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec128<ulong> alignr(Vec128<ulong> left, Vec128<ulong> right, byte offset)
            => AlignRight(left, right, offset);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count) VPALIGNR ymm,ymm, ymm/m256, imm8 
        /// </summary>
        /// <param name="left">The left source vector</param>
        /// <param name="right">The right source vector</param>
        /// <param name="offset">The number of *bytes* to shift rightwards</param>
        /// <remarks>
        /// Intel's description:
        /// Performs an alignment operation by concatenating two blocks of 16-byte data 
        /// from the first and second source vectors into an intermediate 32-byte composite, 
        /// shifting the composite at byte granularity to the right by a constant immediate 
        /// specified by mask, and extracting the right-aligned 16-byte result into the 
        /// destination vector. The immediate value is considered unsigned.
        /// </remarks>
        [MethodImpl(Inline)]
        public static Vec256<byte> alignr(Vec256<byte> left, Vec256<byte> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> alignr(Vec256<sbyte> left, Vec256<sbyte> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<short> alignr(Vec256<short> left, Vec256<short> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<ushort> alignr(Vec256<ushort> left, Vec256<ushort> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<int> alignr(Vec256<int> left, Vec256<int> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<uint> alignr(Vec256<uint> left, Vec256<uint> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<long> alignr(Vec256<long> left, Vec256<long> right, byte offset)
            => AlignRight(left, right, offset);

        [MethodImpl(Inline)]
        public static Vec256<ulong> alignr(Vec256<ulong> left, Vec256<ulong> right, byte offset)
            => AlignRight(left, right, offset);



    }

}