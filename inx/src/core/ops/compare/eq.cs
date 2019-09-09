//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {   
        /// <summary>
        /// __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b) PCMPEQB xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 15
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR        
        /// </algirithm>
        [MethodImpl(Inline)]
        public static Vec128Cmp<sbyte> eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Vec128Cmp.Define<sbyte>(CompareEqual(lhs,rhs));
            
        /// <summary>
        /// __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b) PCMPEQB xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 15
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR        
        /// </algirithm>
        [MethodImpl(Inline)]
        public static Vec128Cmp<byte> eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Vec128Cmp.Define<byte>(CompareEqual(lhs,rhs));

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<short> eq(in Vec128<short> lhs, in Vec128<short> rhs)
            => Vec128Cmp.Define<short>(CompareEqual(lhs,rhs));

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<ushort> eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Vec128Cmp.Define<ushort>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<int> eq(in Vec128<int> lhs, in Vec128<int> rhs)
            => Vec128Cmp.Define<int>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<uint> eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Vec128Cmp.Define<uint>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<long> eq(in Vec128<long> lhs, in Vec128<long> rhs)
            => Vec128Cmp.Define<long>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<ulong> eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Vec128Cmp.Define<ulong>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 31
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Vec256Cmp.Define<sbyte>(CompareEqual(lhs,rhs));
            
        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 31
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Vec256Cmp.Define<byte>(CompareEqual(lhs,rhs));

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 15
        /// 	i := j*16
        /// 	dst[i+15:i] := ( a[i+15:i] == b[i+15:i] ) ? 0xFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
            => Vec256Cmp.Define<short>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256 
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 15
        /// 	i := j*16
        /// 	dst[i+15:i] := ( a[i+15:i] == b[i+15:i] ) ? 0xFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Vec256Cmp.Define<ushort>(CompareEqual(lhs,rhs));

        /// <summary>
        /// _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 7
        /// 	i := j*32
        /// 	dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
            => Vec256Cmp.Define<int>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 7
        /// 	i := j*32
        /// 	dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0  
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Vec256Cmp.Define<uint>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 3
        /// 	i := j*64
        /// 	dst[i+63:i] := ( a[i+63:i] == b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<long> eq(in Vec256<long> lhs, in Vec256<long> rhs)
            => Vec256Cmp.Define<long>(CompareEqual(lhs,rhs));

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares the operands for equality and returns a comparison vector describing the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 3
        /// 	i := j*64
        /// 	dst[i+63:i] := ( a[i+63:i] == b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
        /// ENDFOR
        /// dst[MAX:256] := 0
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256Cmp<ulong> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Vec256Cmp.Define<ulong>(CompareEqual(lhs,rhs));
    }
}