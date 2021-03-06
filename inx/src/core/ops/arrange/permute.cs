//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
        const byte M70 = 0b01110000;

        const byte MF0 = 0b11110000;

        static readonly Vec256<byte> K0 = Vec256.FromBytes(
            M70, M70, M70, M70, M70, M70, M70, M70, 
            M70, M70, M70, M70, M70, M70, M70, M70,            
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0);

        static readonly Vec256<byte> K1 = Vec256.FromBytes(
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0, 
            MF0, MF0, MF0, MF0, MF0, MF0, MF0, MF0,            
            M70, M70, M70, M70, M70, M70, M70, M70, 
            M70, M70, M70, M70, M70, M70, M70, M70);            

        /// <summary>
        /// Rearranges the source vector according to the indices specified in the control vector
        /// dst[i] = src[spec[i]]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector that defines the permutation</param>
        /// <remarks>Approach follows https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector/30669632#30669632</remarks>
        public static Vec256<byte> permute(in Vec256<byte> src, in Vec256<byte> spec)
        {
            var a = src;
            var b = swaphl(in src);
            var s1 = shuffle(in a, add(in spec, in K0));
            var s2 = shuffle(in b, add(in spec, in K1));
            return or(s1,s2);
        }


        /// <summary>
        /// Rearranges the components of the source vector according to an identified permutation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation identifier</param>
        [MethodImpl(Inline)]
        public static Vec128<int> permute(in Vec128<int> src, Perm4 spec)
            => Shuffle(src, (byte)spec);

        [MethodImpl(Inline)]
        public static Vec128<uint> permute(in Vec128<uint> src, Perm4 spec)
            => Shuffle(src, (byte)spec);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> perm2x128(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<byte> perm2x128(in Vec256<byte> lhs, in Vec256<byte> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<short> perm2x128(in Vec256<short> lhs, in Vec256<short> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<ushort> perm2x128(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<int> perm2x128(in Vec256<int> lhs, in Vec256<int> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<uint> perm2x128(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<long> perm2x128(in Vec256<long> lhs, in Vec256<long> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<ulong> perm2x128(in Vec256<ulong> lhs, in Vec256<ulong> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        ///<summary>__m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<float> perm2x128(in Vec256<float> lhs, in Vec256<float> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        /// <summary>
        /// __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<double> perm2x128(in Vec256<double> lhs, in Vec256<double> rhs, byte control)
            => Permute2x128(lhs,rhs,control); 

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        /// <summary>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</summary>
        [MethodImpl(Inline)]
        public static Vec256<int> perm8x32(in Vec256<int> src, in Vec256<int> control)
            => PermuteVar8x32(src,control);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        /// <summary>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</summary>
        [MethodImpl(Inline)]
        public static Vec256<uint> perm8x32(in Vec256<uint> src, in Vec256<uint> control)
            => PermuteVar8x32(src,control);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        /// <summary>__m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx) VPERMPS ymm, ymm/m256,ymm</summary>
        [MethodImpl(Inline)]
        public static Vec256<float> perm8x32(in Vec256<float> src, in Vec256<int> control)
            => PermuteVar8x32(src,control);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        ///<summary>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<long> perm4x64(in Vec256<long> value, byte control)
            => Permute4x64(value,control);

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        ///<summary>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,</summary>
        [MethodImpl(Inline)]
        public static Vec256<ulong> perm4x64(in Vec256<ulong> value, byte control)
            => Permute4x64(value,control);


 

    }
}