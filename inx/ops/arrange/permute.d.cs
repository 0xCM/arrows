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
    using System.Collections.Generic;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    
    using static zfunc;

    public abstract class Literal<T,L>
        where T : Literal<T,L>
    {
        [MethodImpl(Inline)]
        public static implicit operator L(Literal<T,L> src)
            => src.Value;

        public readonly L Value;

        protected Literal(L Value)
            => this.Value = Value;
    }

    public sealed class PermId : Literal<PermId,byte>
    {
        public static byte Define(PermId x0, PermId x1, PermId x2, PermId x3)
            => (byte)(x0 << 0 | x1 << 2 | x2 << 4 | x3 << 6); 

        public static byte Define(byte x0, byte x1, byte x2, byte x3)
            => (byte)(x0 << 0 | x1 << 2 | x2 << 4 | x3 << 6); 

        PermId(byte value)
            : base(value)
            {

            }

    }

    public enum Perm4 : byte
    {        
        /// <summary>
        /// [00 01 11 10]: ABCD -> ABDC
        /// </summary>
        ABDC = 0x1E, 

        /// <summary>
        /// [00 10 01 11]: ABCD -> ACBD
        /// </summary>
        ACBD = 0x27, 

        /// <summary>
        /// [00 10 11 01]: ABCD -> ACDB
        /// </summary>
        ACDB = 0x2D,  

        /// <summary>
        /// ABCD -> ADBC
        /// </summary>
        ADBC = 0x36, 

        /// <summary>
        /// ABCD -> ADCA
        /// </summary>
        ADCA = 0x38, 

        /// <summary>
        /// ABCD -> ADCB
        /// </summary>
        ADCB = 0x39, 

        /// <summary>
        /// ABCD -> BADC
        /// </summary>
        BADC = 0x4E,                 

        /// <summary>
        /// ABCD -> BCAD
        /// </summary>
        BCAD = 0x63, 

        /// <summary>
        /// ABCD -> BCDA
        /// </summary>
        BCDA = 0x6C, 

        /// <summary>
        /// ABCD -> BDAC
        /// </summary>
        BDAC = 0x72, 

        /// <summary>
        /// ABCD -> BDCA
        /// </summary>
        BDCA = 0x78, 

        /// <summary>
        /// ABCD -> CABD
        /// </summary>
        CABD = 0x87, 

        /// <summary>
        /// ABCD -> CADB
        /// </summary>
        CADB = 0x8D, 

        /// <summary>
        /// ABCD -> CBAD
        /// </summary>
        CBAD = 0x93, 

        /// <summary>
        /// ABCD -> CBDA
        /// </summary>
        CBDA = 0x9C, 

        /// <summary>
        /// ABCD -> CDAB
        /// </summary>
        CDAB = 0xB1, 

        /// <summary>
        /// ABCD -> CDBA
        /// </summary>
        CDBA = 0xB4,         

        /// <summary>
        /// ABCD -> DABC
        /// </summary>
        DABC = 0xC6,

        /// <summary>
        /// ABCD -> DACB
        /// </summary>
        DACB = 0xC9,  

        /// <summary>
        /// [11 01 00 10]: ABCD -> DBAC
        /// </summary>
        DBAC = 0xD2, 

        /// <summary>
        /// [11 01 10 00]: ABCD -> DBCA
        /// </summary>
        DBCA = 0xD8, 

        /// <summary>
        /// ABCD -> DCAB
        /// </summary>
        DCAB = 0xE1, 

        /// <summary>
        /// ABCD -> DCBA
        /// </summary>
        DCBA = 0xE4, 

    
    }


    partial class dinx
    {

        ///<intrinsic>__m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<float> permute(in Vec128<float> value, byte control)
            => Permute(value, control);

        ///<intrinsic>__m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<double> permute(in Vec128<double> value, byte control)
            => Permute(value, control);

        ///<intrinsic>__m128 _mm_permutevar_ps (__m128 a, __m128i b) VPERMILPS xmm, xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<float> permute(in Vec128<float> lhs, in Vec128<int> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<double> permute(in Vec128<double> lhs, in Vec128<long> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> permute(Vec256<float> lhs, in Vec256<int> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> permute(Vec256<double> lhs, in Vec256<long> control)
            => PermuteVar(lhs, control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> permute4x64(in Vec256<long> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> permute4x64(in Vec256<ulong> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> permute4x64(in Vec256<double> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> permute2x128(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<byte> permute2x128(in Vec256<byte> lhs, in Vec256<byte> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<short> permute2x128(in Vec256<short> lhs, in Vec256<short> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ushort> permute2x128(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<int> permute2x128(in Vec256<int> lhs, in Vec256<int> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<uint> permute2x128(in Vec256<uint> lhs, in Vec256<uint> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> permute2x128(in Vec256<long> lhs, in Vec256<long> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> permute2x128(in Vec256<ulong> lhs, in Vec256<ulong> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> permute2x128(in Vec256<float> lhs, in Vec256<float> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec);

        ///<intrinsic>__m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> permute2x128(in Vec256<double> lhs, in Vec256<double> rhs, byte spec)
            => Permute2x128(lhs,rhs,spec); 

        /// <intrinsic>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<int> permute8x32(in Vec256<int> src, in Vec256<int> control)
            => PermuteVar8x32(src,control);

        /// <intrinsic>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<uint> permute8x32(in Vec256<uint> src, in Vec256<uint> control)
            => PermuteVar8x32(src,control);

        /// <intrinsic>__m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx) VPERMPS ymm, ymm/m256,ymm</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> permute8x32(in Vec256<float> src, in Vec256<int> control)
            => PermuteVar8x32(src,control);


    }
}