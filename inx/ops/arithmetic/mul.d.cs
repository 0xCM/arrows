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
        

        /// <summary>
        /// Multiplies two two 256-bit/u64 vectors to yield a 256-bit/u64 vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vumul256(in Vec256<ulong> x, in Vec256<ulong> y)    
        {
            ref var m = ref Vec1024.Merge(in x, in y, out Vec1024<uint>  _);
            ref var xh = ref m.At(3);
            ref var xl = ref m.At(2);
            ref var yh = ref m.At(1);
            ref var yl = ref m.At(0);

            var xh_yl = dinx.mul(xh, yl);
            var hl = Bits.shiftl(xh_yl, 32);

            var xh_mh = dinx.mul(xh, yh);
            var lh = Bits.shiftl(xh_mh, 32);

            var xl_yl = dinx.mul(xl, yl);

            var hl_lh = dinx.add(hl, lh);
            var z = dinx.add(xl_yl, hl_lh);
            return z;
        }

        /// <intrinsic>__m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> clmul(in Vec128<long> lhs, in Vec128<long> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        /// <intrinsic>__m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        /// <intrinsic>__m128i _mm_mul_epi32 (__m128i a, __m128i b) PMULDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Multiply(lhs, rhs);
            
        /// <intrinsic>__m128i _mm_mul_epu32 (__m128i a, __m128i b) PMULUDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic>__m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Multiply(lhs, rhs);

        /// <intrinsic>__m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Multiply(lhs, rhs);
        
        /// <intrinsic>__m128i _mm_mul_epi32 (__m128i a, __m128i b) PMULDQ xmm, xmm/m128</intrinsic>
        /// <intrinsic step='2'></instrinsc>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<int> lhs, in Vec128<int> rhs, ref long dst)
            => store(Multiply(lhs, rhs), ref dst);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<uint> lhs, in Vec128<uint> rhs, ref ulong dst)
            => store(Multiply(lhs, rhs), ref dst);

        /// <intrinsic>__m128 _mm_mul_ps (__m128 a, __m128 b) MULPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(Multiply(lhs, rhs), ref dst);

        /// <intrinsic>__m128d _mm_mul_pd (__m128d a, __m128d b) MULPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(Multiply(lhs, rhs), ref dst);

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<int> lhs, in Vec256<int> rhs, ref long dst)
            => store(Multiply(lhs, rhs), ref dst);

        /// <intrinsic>__m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<uint> lhs, in Vec256<uint> rhs, ref ulong dst)
            => store(Multiply(lhs, rhs), ref dst);

        /// <intrinsic>__m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static void mul(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Multiply(lhs, rhs), ref dst);

         /// <intrinsic>__m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256</intrinsic>
       [MethodImpl(Inline)]
        public static void mul(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Multiply(lhs, rhs), ref dst);


    }
}