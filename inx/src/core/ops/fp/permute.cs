//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {

        ///<summary>__m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> permute(in Vec128<float> value, byte control)
            => Permute(value, control);

        ///<summary>__m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> permute(in Vec128<double> value, byte control)
            => Permute(value, control);

        ///<summary>__m256 _mm256_permute_ps (__m256 a, int imm8) VPERMILPS ymm, ymm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<float> permute(in Vec256<float> value, byte control)
            => Permute(value, control);

        ///<summary>__m256d _mm256_permute_pd (__m256d a, int imm8) VPERMILPD ymm, ymm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<double> permute(in Vec256<double> value, byte control)
            => Permute(value, control);

        ///<summary>__m128 _mm_permutevar_ps (__m128 a, __m128i b) VPERMILPS xmm, xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> permvar(in Vec128<float> lhs, in Vec128<int> control)
            => PermuteVar(lhs, control);

        ///<summary>__m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> permvar(in Vec128<double> lhs, in Vec128<long> control)
            => PermuteVar(lhs, control);

        ///<summary>__m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<float> permvar(Vec256<float> lhs, in Vec256<int> control)
            => PermuteVar(lhs, control);

        ///<summary>__m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<double> permvar(Vec256<double> lhs, in Vec256<long> control)
            => PermuteVar(lhs, control);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        ///<summary>__m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<double> perm4x64(in Vec256<double> value, byte control)
            => Permute4x64(value,control); 
    }
}