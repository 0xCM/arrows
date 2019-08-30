//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static As;
    using static zfunc;    


    partial class dfp
    {

        /// <summary>
        ///  __m128 _mm_mul_ss (__m128 a, __m128 b) MULPS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Num128<float> mul(in Num128<float> lhs, in Num128<float> rhs)
            =>  MultiplyScalar(lhs, rhs);

        /// <summary>
        ///  __m128d _mm_mul_sd (__m128d a, __m128d b) MULSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Num128<double> mul(in Num128<double> lhs, in Num128<double> rhs)
            =>  MultiplyScalar(lhs, rhs);

        /// <summary>
        /// __m128 _mm_mul_ps (__m128 a, __m128 b) MULPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Multiply(lhs, rhs);        

        /// <summary>
        /// __m128d _mm_mul_pd (__m128d a, __m128d b) MULPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Multiply(lhs, rhs);
        
        /// <summary>
        /// __m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Multiply(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Multiply(lhs, rhs);

        public static Span128<float> mul(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span128<double> mul(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }
        
        public static Span256<float> mul(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<double> mul(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

    }

}