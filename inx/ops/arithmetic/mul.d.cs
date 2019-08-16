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

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {
        /// <intrinsic>__m128i _mm_mul_epi32 (__m128i a, __m128i b) PMULDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Multiply(lhs, rhs);
            
        /// <intrinsic>__m128i _mm_mul_epu32 (__m128i a, __m128i b) PMULUDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic>__m256i _mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Multiply(lhs, rhs);


        /// <intrinsic>_m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<int> lhs, in Vec256<int> rhs, ref long dst)
            => vstore(mul(lhs, rhs), ref dst);

        /// <intrinsic>__m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<uint> lhs, in Vec256<uint> rhs, ref ulong dst)
            => vstore(mul(lhs, rhs), ref dst);

        /// <intrinsic>__m128i _mm_mul_epi32 (__m128i a, __m128i b) PMULDQ xmm, xmm/m128</intrinsic>
        /// <intrinsic step='2'></instrinsc>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<int> lhs, in Vec128<int> rhs, ref long dst)
            => vstore(mul(lhs, rhs), ref dst);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<uint> lhs, in Vec128<uint> rhs, ref ulong dst)
            => vstore(mul(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static long mul(long lhs, long rhs)
            => CarrylessMultiply(Vector128.Create(lhs, 0L), Vector128.Create(rhs, 0L), 0).GetElement(0);

        [MethodImpl(Inline)]
        public static ulong mul(ulong lhs, ulong rhs)
            => CarrylessMultiply(Vector128.Create(lhs, 0ul), Vector128.Create(rhs, 0ul), 0).GetElement(0);

        /// <intrinsic>__m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> clmul(in Vec128<long> lhs, in Vec128<long> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        /// <intrinsic>__m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);
        
        /// <summary>
        /// Calculates the 128-bit product of two 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The 128 bit result</param>
        [MethodImpl(Inline)]
        public static unsafe ref UInt128 umul128(ulong lhs, ulong rhs, out UInt128 dst)
        {
            dst = 0;
            UMul.mul(lhs,rhs, out dst.lo, out dst.hi);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<long> lhs, in Vec128<long> rhs)
        {
            var low = CarrylessMultiply(lhs, rhs, 0).GetElement(0);
            var hi = CarrylessMultiply(lhs,rhs,4).GetElement(0);
            return Vec128.FromParts(low,hi);
        }


        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
        {
            var low = CarrylessMultiply(lhs, rhs, 0).GetElement(0);
            var hi = CarrylessMultiply(lhs,rhs,4).GetElement(0);
            return Vec128.FromParts(low,hi);
        }


        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic>__m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic>__m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Multiply(lhs, rhs);
        

        /// <intrinsic>__m128 _mm_mul_ps (__m128 a, __m128 b) MULPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => vstore(mul(lhs, rhs), ref dst);

        /// <intrinsic>__m128d _mm_mul_pd (__m128d a, __m128d b) MULPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => vstore(mul(lhs, rhs), ref dst);


        /// <intrinsic>__m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => vstore(mul(lhs, rhs), ref dst);

         /// <intrinsic>__m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => vstore(mul(lhs, rhs), ref dst);


        [MethodImpl(Inline)]
        public static Span128<long> mul(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<long> dst)
            => lhs.Mul(rhs,dst);

        [MethodImpl(Inline)]
        public static Span128<ulong> mul(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<ulong> dst)
            => lhs.Mul(rhs,dst);

        [MethodImpl(Inline)]
        public static Span128<float> mul(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
            => lhs.Mul(rhs, dst);

        [MethodImpl(Inline)]
        public static Span128<double> mul(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
            => lhs.Mul(rhs, dst);
        
        [MethodImpl(Inline)]
        public static Span256<long> mul(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<long> dst)
            => lhs.Mul(rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<ulong> mul(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<ulong> dst)
            => lhs.Mul(rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<float> mul(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
            => lhs.Mul(rhs, dst);

        [MethodImpl(Inline)]
        public static Span256<double> mul(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
            => lhs.Mul(rhs, dst);

    }
}