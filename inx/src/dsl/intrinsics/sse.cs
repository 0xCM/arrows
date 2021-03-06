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
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static zfunc;
    using static As;

    partial class x86
    {

        /// <intrinsic>void _mm_storeu_ps (float* mem_addr, __m128 a) MOVUPS m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_ps(ref float mem_addr, in __m128 a)
            => Store(refptr(ref mem_addr), a);

        ///<intrinsic> __m128 _mm_mul_ps (__m128 a, __m128 b) MULPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_mul_ps(in __m128 a, in __m128 b)
            => Multiply(a,b);
        
        ///<intrinsic> __m128 _mm_mul_ss (__m128 a, __m128 b) MULPS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_mul_ss (in __m128 a, in __m128 b)
            => MultiplyScalar(a,b);

        ///<intrinsic> __m128 _mm_unpackhi_ps (__m128 a, __m128 b) UNPCKHPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_unpackhi_ps(in __m128 a, in __m128 b)
            => UnpackHigh(a,b);

        ///<intrinsic> __m128 _mm_unpacklo_ps (__m128 a, __m128 b) UNPCKLPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_unpacklo_ps(in __m128 a, in __m128 b)
            => UnpackLow(a,b);

        ///<intrinsic> __m128 _mm_andnot_ps (__m128 a, __m128 b) ANDNPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_andnot_ps(in __m128 a, in __m128 b)
            => AndNot(a,b);

        ///<intrinsic> __m128 _mm_div_ps (__m128 a, __m128 b) DIVPS xmm, xmm/m128</intrinsic>    
        [MethodImpl(Inline)]
        public static __m128 _mm_div_ps(in __m128 a, in __m128 b)
            => Divide(a,b);

        ///<intrinsic> __m128 _mm_div_ss (__m128 a, __m128 b) DIVSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_div_ss (in __m128 a, in __m128 b)
            => DivideScalar(a,b);

        ///<intrinsic> __m128 _mm_add_ps (__m128 a, __m128 b) ADDPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_add_ps(in __m128 a, in __m128 b)
            => Add(a,b);

        ///<intrinsic> __m128 _mm_add_ss (__m128 a, __m128 b) ADDSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_add_ss(in __m128 a, in __m128 b)
            => AddScalar(a,b);

        ///<intrinsic> __m128 _mm_and_ps (__m128 a, __m128 b) ANDPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_and_ps(in __m128 a, in __m128 b)
            => And(a,b);

        ///<intrinsic> __m128 _mm_cmpeq_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(0)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmpeq_ps(in __m128 a, in __m128 b)
            => CompareEqual(a,b);

        ///<intrinsic> __m128 _mm_sub_ss (__m128 a, __m128 b) SUBSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_sub_ss(in __m128 a, in __m128 b)
            => SubtractScalar(a,b);

        ///<intrinsic> __m128 _mm_xor_ps (__m128 a, __m128 b) XORPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_xor_ps(in __m128 a, in __m128 b)
            => Xor(a,b);

        ///<intrinsic> __m128 _mm_cmpgt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(6)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmpgt_ps(in __m128 a, in __m128 b)
            => CompareGreaterThan(a,b);

        ///<intrinsic> __m128 _mm_cmpord_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(7)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmpord_ps(in __m128 a, in __m128 b)
            => CompareOrdered(a,b);

        ///<intrinsic> __m128 _mm_cmpnle_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(6)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmpnle_ps(in __m128 a, in __m128 b)
            => CompareNotLessThanOrEqual(a,b);

        ///<intrinsic> __m128 _mm_max_ps (__m128 a, __m128 b) MAXPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_max_ps(in __m128 a, in __m128 b)
            => Max(a,b);

        ///<intrinsic> __m128 _mm_shuffle_ps (__m128 a, __m128 b, unsigned int control) SHUFPS xmm,xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_shuffle_ps(in __m128 a, in __m128 b, byte control)
            => Shuffle(a,b,control);

        ///<intrinsic> __m128 _mm_cmpngt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(2)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmpngt_ps(__m128 a, __m128 b)
            => CompareNotGreaterThan(a,b);

        ///<intrinsic> __m128 _mm_cvtsi32_ss (__m128 a, int b) CVTSI2SS xmm, reg/m32
        [MethodImpl(Inline)]
        public static __m128 _mm_cvtsi32_ss(__m128 a, int b)
            => ConvertScalarToVector128Single(a, b);

        ///<intrinsic> __m128 _mm_max_ss (__m128 a, __m128 b) MAXSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_max_ss(__m128 a, __m128 b)
            => MaxScalar(a,b);

    }

/*


        ///<intrinsic> __m128 _mm_cmpge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 CompareGreaterThanOrEqual(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_cmplt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(1)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 CompareLessThan(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_cmple_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(2)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 CompareLessThanOrEqual(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_cmpneq_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(4)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 CompareNotEqual(__m128 a, __m128 b)


        ///<intrinsic> __m128 _mm_cmpnge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(1)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 CompareNotGreaterThanOrEqual(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_cmpnlt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 CompareNotLessThan(__m128 a, __m128 b)


        [MethodImpl(Inline)]
        public static __m128 CompareScalarEqual(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarGreaterThan(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarGreaterThanOrEqual(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarLessThan(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarLessThanOrEqual(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarNotEqual(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarNotGreaterThan(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarNotGreaterThanOrEqual(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarNotLessThan(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarNotLessThanOrEqual(__m128 a, __m128 b)

        [MethodImpl(Inline)]
        public static __m128 CompareScalarOrdered(__m128 a, __m128 b)
        public static bool CompareScalarOrderedEqual(__m128 a, __m128 b)
        public static bool CompareScalarOrderedGreaterThan(__m128 a, __m128 b)
        public static bool CompareScalarOrderedGreaterThanOrEqual(__m128 a, __m128 b)
        public static bool CompareScalarOrderedLessThan(__m128 a, __m128 b)
        public static bool CompareScalarOrderedLessThanOrEqual(__m128 a, __m128 b)
        public static bool CompareScalarOrderedNotEqual(__m128 a, __m128 b)
        public static __m128 CompareScalarUnordered(__m128 a, __m128 b)
        public static bool CompareScalarUnorderedEqual(__m128 a, __m128 b)
        public static bool CompareScalarUnorderedGreaterThan(__m128 a, __m128 b)
        public static bool CompareScalarUnorderedGreaterThanOrEqual(__m128 a, __m128 b)
        public static bool CompareScalarUnorderedLessThan(__m128 a, __m128 b)
        public static bool CompareScalarUnorderedLessThanOrEqual(__m128 a, __m128 b)
        public static bool CompareScalarUnorderedNotEqual(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_cmpunord_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(3)
        [MethodImpl(Inline)]
        public static __m128 CompareUnordered(__m128 a, __m128 b)


        ///<intrinsic> int _mm_cvtss_si32 (__m128 a) CVTSS2SI r32, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static int ConvertToInt32(__m128 value)

        ///<intrinsic> int _mm_cvttss_si32 (__m128 a) CVTTSS2SI r32, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static int ConvertToInt32WithTruncation(__m128 value)

        ///<intrinsic> __m128 _mm_load_ps (float const* mem_address) MOVAPS xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 LoadAlignedVector128(float* address)

        ///<intrinsic> __m128 _mm_loadh_pi (__m128 a, __m64 const* mem_addr) MOVHPS xmm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 LoadHigh(__m128 lower, float* address)

        ///<intrinsic> __m128 _mm_loadl_pi (__m128 a, __m64 const* mem_addr) MOVLPS xmm, m64</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 LoadLow(__m128 upper, float* address)

        ///<intrinsic> __m128 _mm_load_ss (float const* mem_address) MOVSS xmm, m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 LoadScalarVector128(float* address)

        ///<intrinsic> __m128 _mm_loadu_ps (float const* mem_address) MOVUPS xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 LoadVector128(float* address)

        
        ///<intrinsic> __m128 _mm_min_ps (__m128 a, __m128 b) MINPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 Min(__m128 a, __m128 b)
        
        ///<intrinsic> __m128 _mm_min_ss (__m128 a, __m128 b) MINSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 MinScalar(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_movehl_ps (__m128 a, __m128 b) MOVHLPS xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 MoveHighToLow(__m128 a, __m128 b)

        ///<intrinsic> __m128 _mm_movelh_ps (__m128 a, __m128 b) MOVLHPS xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 MoveLowToHigh(__m128 a, __m128 b)

        ///<intrinsic> int _mm_movemask_ps (__m128 a) MOVMSKPS reg, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static int MoveMask(__m128 value)

        ///<intrinsic> __m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 MoveScalar(__m128 upper, __m128 value)

        ///<intrinsic> __m128 _mm_or_ps (__m128 a, __m128 b) ORPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 Or(__m128 a, __m128 b)

        ///<intrinsic> void _mm_prefetch(char* p, int i) PREFETCHT0 m8</intrinsic>
        [MethodImpl(Inline)]
        public static void Prefetch0(void* address)

        ///<intrinsic> void _mm_prefetch(char* p, int i) PREFETCHT1 m8</intrinsic>
        [MethodImpl(Inline)]
        public static void Prefetch1(void* address)

        ///<intrinsic> void _mm_prefetch(char* p, int i) PREFETCHT2 m8</intrinsic>
        [MethodImpl(Inline)]
        public static void Prefetch2(void* address)

        ///<intrinsic> void _mm_prefetch(char* p, int i) PREFETCHNTA m8</intrinsic>
        [MethodImpl(Inline)]
        public static void PrefetchNonTemporal(void* address)

        ///<intrinsic> __m128 _mm_rcp_ps (__m128 a) RCPPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 Reciprocal(__m128 value)

        ///<intrinsic> __m128 _mm_rcp_ss (__m128 a, __m128 b) RCPSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 ReciprocalScalar(__m128 upper, __m128 value)

        ///<intrinsic> __m128 _mm_rcp_ss (__m128 a) RCPSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 ReciprocalScalar(__m128 value)

        ///<intrinsic> __m128 _mm_rsqrt_ps (__m128 a) RSQRTPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 ReciprocalSqrt(__m128 value)

        ///<intrinsic> __m128 _mm_rsqrt_ss (__m128 a) RSQRTSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 ReciprocalSqrtScalar(__m128 value)

        ///<intrinsic> __m128 _mm_rsqrt_ss (__m128 a, __m128 b) RSQRTSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 ReciprocalSqrtScalar(__m128 upper, __m128 value)

        ///<intrinsic> __m128 _mm_sqrt_ps (__m128 a) SQRTPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 Sqrt(__m128 a)
            => Sqrt(a);

        ///<intrinsic> __m128 _mm_sqrt_ss (__m128 a) SQRTSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 SqrtScalar(__m128 a)
            => SqrtScalar(a);
        
        ///<intrinsic> __m128 _mm_sqrt_ss (__m128 a, __m128 b) SQRTSS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_sqrt_ss(__m128 a, __m128 b)
            => SqrtScalar(a,b);

        ///<intrinsic> void _mm_store_ps (float* mem_addr, __m128 a) MOVAPS m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static void StoreAligned(float* address, __m128 source)

        ///<intrinsic> void _mm_stream_ps (float* mem_addr, __m128 a) MOVNTPS m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static void StoreAlignedNonTemporal(float* address, __m128 source)

        ///<intrinsic> void _mm_sfence(void) SFENCE</intrinsic>
        [MethodImpl(Inline)]
        public static void StoreFence()

        ///<intrinsic> void _mm_storeh_pi (__m64* mem_addr, __m128 a) MOVHPS m64, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static void StoreHigh(float* address, __m128 source)

        ///<intrinsic> void _mm_storel_pi (__m64* mem_addr, __m128 a) MOVLPS m64, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static void StoreLow(float* address, __m128 source)

        ///<intrinsic> void _mm_store_ss (float* mem_addr, __m128 a) MOVSS m32, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static void StoreScalar(float* address, __m128 source)

        ///<intrinsic> __m128d _mm_sub_ps (__m128d a, __m128d b) SUBPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 Subtract(__m128 a, __m128 b)
            => Subtract(a,b);


        public abstract class X64
        {

            ///<intrinsic> __m128 _mm_cvtsi64_ss (__m128 a, __int64 b) CVTSI2SS xmm, reg/m64</intrinsic>
            [MethodImpl(Inline)]
            public static __m128 ConvertScalarToVector128Single(__m128 a, long b)

            ///<intrinsic> __int64 _mm_cvtss_si64 (__m128 a) CVTSS2SI r64, xmm/m32</intrinsic>
            [MethodImpl(Inline)]
            public static long ConvertToInt64(__m128 a)

            ///<intrinsic> __int64 _mm_cvttss_si64 (__m128 a) CVTTSS2SI r64, xmm/m32</intrinsic>
            [MethodImpl(Inline)]
            public static long ConvertToInt64WithTruncation(__m128 a)
        }
    }
}

 */
}