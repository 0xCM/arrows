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
        ///  __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> srlv(in Vec128<int> src, in Vec128<uint> control)
            => ShiftRightLogicalVariable(src, control);

        /// <summary>
        /// __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> srlv(in Vec128<uint> src, in Vec128<uint> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> srlv(in Vec128<long> src, in Vec128<ulong> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> srlv(in Vec128<ulong> src, in Vec128<ulong> offset)
            => ShiftRightLogicalVariable(src, offset);       
 
        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> srlv(in Vec256<int> src, in Vec256<uint> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> srlv(in Vec256<uint> src, in Vec256<uint> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> srlv(in Vec256<long> src, in Vec256<ulong> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        ///  __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> srlv(in Vec256<ulong> src, in Vec256<ulong> offset)
            => ShiftRightLogicalVariable(src, offset); 
    
        public static Span128<int> srlv(ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> srlv(ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, in  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> srlv(ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> srlv(ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> srlv(ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> srlv(ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> srlv(ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> srlv(ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                vstore(Bits.srlv(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
       }    
    }
}