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
    
    partial class Bits
    {   
        /// <summary>
        /// _mm_slli_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> slli(in Vec128<short> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi16, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> slli(in Vec128<ushort> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> slli(in Vec128<int> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> slli(in Vec128<uint> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> slli(in Vec128<long> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi64, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> slli(in Vec128<ulong> src, byte offset)
            => Sse2.ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm_slli_epi32, sse2, shift left logical:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> slli32(in Vec128<ulong> src, byte offset)
            => slli(src.As<uint>(), offset).As<ulong>();

        public static Vec256<byte> slli(in Vec256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            ref var srcX = ref convert(dinx.lo(src), out Vec256<ushort> _);
            ref var srcY = ref convert(dinx.hi(src), out Vec256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = slli(srcX, offset).As<byte>();
            var dstB = slli(srcY, offset).As<byte>();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
            ref readonly var trm = ref Vec256Pattern.ClearAlt<byte>();
            var trA = dinx.shuffle(in dstA, trm);
            var trB = dinx.shuffle(in dstB, trm);
                        
            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            ref readonly var permSpec = ref Vec256Pattern.LaneMerge<byte>();
            var permA = dinx.permute(trA, permSpec);
            var permB = dinx.permute(trB, permSpec);
            var result = default(Vec256<byte>);
            dinx.insert(dinx.extract128(in permA,0), dinx.extract128(in permB,0), ref result);            
            
            return result;            
        }

        /// <summary>
        /// _mm256_slli_epi16, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> slli(in Vec256<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi16, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> slli(in Vec256<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi32, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> slli(in Vec256<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// _mm256_slli_epi32, avx2:
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> slli(in Vec256<uint> src, byte offset)
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
        public static Vec256<ulong> slli(in Vec256<ulong> src, byte offset)
            => ShiftLeftLogical(src, offset); 
    }

}