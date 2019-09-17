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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;


    using static zfunc;
    
    partial class Bits
    {   
        /// <summary>
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vec128<byte> srl(in Vec128<byte> src, byte offset)
        {
            convert(in src, out Vec256<ushort> dst);
            Span<ushort> data = stackalloc ushort[Vec256<ushort>.Length];
            vstore(srl(dst, offset), ref data[0]);
            var i = 0;
            return Vec128.FromBytes(
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++], 
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++],
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++],
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++]
            );
        }

        /// <summary>
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vec128<sbyte> srl(in Vec128<sbyte> src, byte offset)
        {
            dinx.convert(in src, out Vec256<short> dst);
            Span<short> data = stackalloc short[Vec256<short>.Length];
            vstore(srl(dst, offset), ref data[0]);
            var i = 0;
            return Vec128.FromParts(
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], 
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++]
            );
        }

        /// <summary>
        ///  __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> srl(in Vec128<short> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        ///  __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> srl(in Vec128<ushort> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> srl(in Vec128<int> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> srl(in Vec128<uint> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        ///  __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> srl(in Vec128<long> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        ///  __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> srl(in Vec128<ulong> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> srl(in Vec256<short> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> srl(in Vec256<ushort> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> srl(in Vec256<int> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> srl(in Vec256<uint> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> srl(in Vec256<long> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> srl(in Vec256<ulong> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// Zero extends packed unsigned 8-bit integers in the source vector to packed 16-bit integers in the target vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <summary>__m256i _mm256_cvtepu8_epi16 (__m128i a) </summary>
        [MethodImpl(Inline)]
        static ref Vec256<ushort> convert(in Vec128<byte> src, out Vec256<ushort> dst)
        {
            dst = ConvertToVector256Int16(src).AsUInt16();
            return ref dst;
        }

        public static Vec256<byte> srl(in Vec256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            ref var srcX = ref convert(dinx.extract128(src,0), out Vec256<ushort> _);
            ref var srcY = ref convert(dinx.extract128(src,1), out Vec256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = srl(srcX, offset).As<byte>();
            var dstB = srl(srcY, offset).As<byte>();

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
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span128<short> srl(ReadOnlySpan128<short> src, byte offset, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec128(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span128<ushort> srl(ReadOnlySpan128<ushort> src, byte offset, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec128(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span128<int> srl(ReadOnlySpan128<int> src, byte offset, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec128(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span128<uint> srl(ReadOnlySpan128<uint> src, byte offset, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec128(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span128<long> srl(ReadOnlySpan128<long> src, byte offset, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec128(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span128<ulong> srl(ReadOnlySpan128<ulong> src, byte offset, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec128(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span256<short> srl(ReadOnlySpan256<short> src, byte offset, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec256(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span256<ushort> srl(ReadOnlySpan256<ushort> src, byte offset, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec256(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span256<int> srl(ReadOnlySpan256<int> src, byte offset, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec256(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span256<uint> srl(ReadOnlySpan256<uint> src, byte offset, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec256(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span256<long> srl(ReadOnlySpan256<long> src, byte offset, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec256(i), offset), ref dst[i]);
            return dst;            
        }

        /// <summary>
        /// Applies a logical shift to each source value in the source and writes the result to the target
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <param name="dst">The target span</param>
        public static Span256<ulong> srl(ReadOnlySpan256<ulong> src, byte offset, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < src.Length; i += width)
                vstore(srl(src.LoadVec256(i), offset), ref dst[i]);
            return dst;            
       }

    }

}