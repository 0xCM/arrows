//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;

    class IntrinsicScenarios : Deconstructable<IntrinsicScenarios>
    {
        public IntrinsicScenarios()
            : base(callerfile())
        {

        }

        [MethodImpl(Inline | Optimize)]
        public static Vector128<sbyte> addv8u128(in Vector128<sbyte> lhs, in Vector128<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vector128<sbyte> add2(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Add(lhs, rhs);
        
        [MethodImpl(Inline | Optimize)]
        public static Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vector256<sbyte> add5(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Add(lhs, rhs);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<long> shiftlw(in Vector256<long> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<ulong> shiftlw(Vector256<ulong> src, byte count)
            => ShiftLeftLogical128BitLane(src, count); 

         ///<intrinsic>__m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector128<float> permute(in Vector128<float> value, byte control)
            => Permute(value, control);

        ///<intrinsic>__m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector128<double> permute(in Vector128<double> value, byte control)
            => Permute(value, control);

        ///<intrinsic>__m128 _mm_permutevar_ps (__m128 a, __m128i b) VPERMILPS xmm, xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector128<float> permute(in Vector128<float> lhs, in Vector128<int> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector128<double> permute(in Vector128<double> lhs, in Vector128<long> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<float> permute(Vector256<float> lhs, in Vector256<int> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<double> permute(Vector256<double> lhs, in Vector256<long> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<sbyte> permute2x128(in Vector256<sbyte> lhs, in Vector256<sbyte> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<byte> permute2x128(in Vector256<byte> lhs, in Vector256<byte> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<short> permute2x128(in Vector256<short> lhs, in Vector256<short> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<ushort> permute2x128(in Vector256<ushort> lhs, in Vector256<ushort> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<int> permute2x128(in Vector256<int> lhs, in Vector256<int> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<uint> permute2x128(in Vector256<uint> lhs, in Vector256<uint> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<long> permute2x128(in Vector256<long> lhs, in Vector256<long> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<ulong> permute2x128(in Vector256<ulong> lhs, in Vector256<ulong> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<float> permute2x128(in Vector256<float> lhs, in Vector256<float> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<double> permute2x128(in Vector256<double> lhs, in Vector256<double> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec); 

        /// <intrinsic>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<int> permute8x32(in Vector256<int> src, in Vector256<int> control)
            => PermuteVar8x32(src,control);

        /// <intrinsic>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<uint> permute8x32(in Vector256<uint> src, in Vector256<uint> control)
            => PermuteVar8x32(src,control);

        /// <intrinsic>__m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx) VPERMPS ymm, ymm/m256,ymm</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<float> permute8x32(in Vector256<float> src, in Vector256<int> control)
            => PermuteVar8x32(src,control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<long> permute4x64(in Vector256<long> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<ulong> permute4x64(in Vector256<ulong> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<double> permute4x64(in Vector256<double> value, byte control)
            => Permute4x64(value,control);

        #region testz

        [MethodImpl(Inline)]
        public static bool testz(in Vector128<byte> lhs, in Vector128<byte> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector128<long> lhs, in Vector128<long> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector128<ulong> lhs, in Vector128<ulong> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector128<float> lhs, in Vector128<float> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector128<double> lhs, in Vector128<double> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector256<long> lhs, in Vector256<long> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector256<ulong> lhs, in Vector256<ulong> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector256<float> lhs, in Vector256<float> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vector256<double> lhs, in Vector256<double> rhs)
            => TestZ(lhs,rhs);        
        #endregion
    }


}