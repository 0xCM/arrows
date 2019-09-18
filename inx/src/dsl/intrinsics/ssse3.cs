//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;    
    using static System.Runtime.Intrinsics.X86.Ssse3;
    
    using static zfunc;    
    using static As;

    partial class x86
    {

        ///<summary> _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_shuffle_epi8(__m128i a, __m128i mask)
            => Shuffle(v8u(a),v8u(mask));

        ///<summary> _mm_abs_epi8 (__m128i a) PABSB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_abs_epi8(__m128i a)
            => Abs(v8i(a));

        ///<summary> _mm_abs_epi16 (__m128i a) PABSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_abs_epi16(__m128i a)
            => Abs(v16i(a));

        ///<summary> _mm_abs_epi32 (__m128i a) PABSD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vector128<uint> _mm_abs_epi32(__m128i a)
            => Abs(v32i(a));

        ///<summary> _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_alignr_epi8(in __m128i a, in __m128i b, byte count)
            => AlignRight(v8u(a), v8u(b), count);

        ///<summary> _mm_hadd_epi32 (__m128i a, __m128i b) PHADDD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_hadd_epi32(in __m128i a, in __m128i b)
            => HorizontalAdd(v32i(a),v32i(b));

        ///<summary> _mm_hadd_epi16 (__m128i a, __m128i b) PHADDW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_hadd_epi16(in __m128i a, in __m128i b)
            => HorizontalAdd(v16i(a),v16i(b));

        ///<summary> _mm_hadds_epi16 (__m128i a, __m128i b) PHADDSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_hadds_epi16(in __m128i a, in __m128i b)
            => HorizontalAddSaturate(v16i(a),v16i(b));

        ///<summary> _mm_hsub_epi16 (__m128i a, __m128i b) PHSUBW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_hsub_epi16(in __m128i a, in __m128i b)
            => HorizontalSubtract(v16i(a),v16i(b));

        ///<summary> _mm_hsub_epi32 (__m128i a, __m128i b) PHSUBD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_hsub_epi32(in __m128i a, in __m128i b)
            => HorizontalSubtract(v32i(a),v32i(b));

        ///<summary> _mm_hsubs_epi16 (__m128i a, __m128i b) PHSUBSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_hsubs_epi16(in __m128i a, in __m128i b)
            => HorizontalSubtractSaturate(v16i(a),v16i(b));

        ///<summary> _mm_maddubs_epi16 (__m128i a, __m128i b) PMADDUBSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_maddubs_epi16(in __m128i a, in __m128i b)
            => MultiplyAddAdjacent(v8u(a), v8i(b));

        ///<summary> _mm_mulhrs_epi16 (__m128i a, __m128i b) PMULHRSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_mulhrs_epi16(in __m128i a, in __m128i b)
            => MultiplyHighRoundScale(v16i(a), v16i(b));

        ///<summary> _mm_sign_epi16 (__m128i a, __m128i b) PSIGNW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sign_epi16(in __m128i a, in __m128i b)
            => Sign(v16i(a),v16i(b));

        ///<summary> _mm_sign_epi32 (__m128i a, __m128i b) PSIGND xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sign_epi32(in __m128i a, in __m128i b)
            => Sign(v32i(a),v32i(b));

        ///<summary> _mm_sign_epi8 (__m128i a, __m128i b) PSIGNB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sign_epi8(in __m128i a, in __m128i b)
            => Sign(v8i(a),v8i(b));

    }

}