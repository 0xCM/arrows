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
        /// Zero extends packed unsigned 8-bit integers in the source vector to packed 16-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepu8_epi16 (__m128i a) </summary>
        [MethodImpl(Inline)]
        public static ref Vec256<ushort> convert(in Vec128<byte> src, out Vec256<ushort> dst)
        {
            dst = ConvertToVector256Int16(src).AsUInt16();
            return ref dst;
        }

        /// <summary>
        /// _mm256_srli_epi16, avx2:
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> srli(in Vec256<short> src, byte offset)
            => ShiftRightLogical(src, offset);

        public static Vec256<byte> srli(in Vec256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            ref var srcX = ref convert(dinx.lo(src), out Vec256<ushort> _);
            ref var srcY = ref convert(dinx.hi(src), out Vec256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = Bits.srli(srcX, offset).As<byte>();
            var dstB = Bits.srli(srcY, offset).As<byte>();

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