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
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc; 
    using static As;

    partial class x86
    {
        [MethodImpl(Inline)]
        public static __m128i _mm256_castsi256_si128(in __m256i a)
            => Vec128.define(a.x0, a.x1);

        [MethodImpl(Inline)]
        public static __m128d _mm256_castpd256_pd128(in __m256d a)
            => Vec128.define(a.x0d, a.x1d);

        [MethodImpl(Inline)]
        public static __m256d _mm256_castpd128_pd256(in __m128d a)
            => Vec256.define(a.x0d, a.x1d, 0, 0);

        [MethodImpl(Inline)]
        public static __m256i _mm256_setzero_si256()
            => Vec256.Zero<long>();

        [MethodImpl(Inline)]
        public static __m128d _mm_setzero_pd()
            => Vec128.Zero<double>();

        [MethodImpl(Inline)]
        public static __m256d _mm256_setzero_pd()
            => Vec256.Zero<double>();

        [MethodImpl(Inline)]
        public static __m256 _mm256_set1_ps(float a)
            => __m256.Broadcast(a);

        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_set_epi32(
            int x7, int x6, int x5, int x4, int x3, int x2, int x1, int x0 )
                => Vec256.define(x7, x6, x5, x4, x3, x2, x1, x0);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi8(sbyte x)
            => Vec256.Fill(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi8(byte x)
            => Vec256.Fill(x);


        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi16(short x)
            => Vector256.Create(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi16(ushort x)
            => Vector256.Create(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi32(int x)
            => Vector256.Create(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi32(uint x)
            => Vector256.Create(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi64x(long x)
            => Vector256.Create(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_set1_epi64x(ulong x)
            => Vec256.Fill(x);

        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_setr_epi8(
            sbyte x31, sbyte x30, sbyte x29, sbyte x28,  
            sbyte x27, sbyte x26, sbyte x25, sbyte x24, 
            sbyte x23, sbyte x22, sbyte x21, sbyte x20,
            sbyte x19, sbyte x18, sbyte x17, sbyte x16,
            sbyte x15, sbyte x14, sbyte x13, sbyte x12,  
            sbyte x11, sbyte x10, sbyte x9, sbyte x8, 
            sbyte x7, sbyte x6, sbyte x5, sbyte x4,
            sbyte x3, sbyte x2, sbyte x1, sbyte x0) 
                => Vec256.define(
                    x31, x30, x29, x28, 
                    x27, x26, x25, x24,
                    x23, x22, x21, x20,
                    x19, x18, x17, x16,
                    x15, x14, x13, x12, 
                    x11, x10,  x9,  x8, 
                     x7,  x6,  x5,  x4,
                     x3,  x2,  x1,  x0);
 
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_setr_epi16(
            short x15, short x14, short x13, short x12,  
            short x11, short x10, short x9, short x8, 
            short x7, short x6, short x5, short x4,
            short x3, short x2, short x1, short x0)
                => Vec256.define(
                    x15, x14, x13, x12, 
                    x11, x10,  x9,  x8, 
                     x7,  x6,  x5,  x4,
                     x3,  x2,  x1,  x0);                    

        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_setr_epi32(
            int x7, int x6, int x5, int x4, int x3, int x2, int x1, int x0 )
                => Vec256.define(x7, x6, x5, x4, x3, x2, x1, x0);

        [MethodImpl(Inline)]
        public static __m256i _mm256_setr_epi64x(long x3, long x2, long x1, long x0)
            => Vec256.define(x3, x2, x1, x0);

        ///<intrinsic> __m256d _mm256_add_pd (__m256d a, __m256d b) VADDPD ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_add_pd (in __m256d a, in __m256d b)
            => Add(a, b);

        ///<intrinsic> __m256 _mm256_add_ps (__m256 a, __m256 b) VADDPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_add_ps (in __m256 a, in __m256 b)
            => Add(a,b);
        
        ///<intrinsic> __m256d _mm256_and_pd (__m256d a, __m256d b) VANDPD ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_and_pd(in __m256d a, in __m256d b)
            => And(a,b);

        ///<intrinsic> __m256 _mm256_and_ps (__m256 a, __m256 b) VANDPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_and_ps(in __m256 a, in __m256 b)
            => And(a,b);

        ///<intrinsic> __m256d _mm256_andnot_pd (__m256d a, __m256d b) VANDNPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_andnot_pd(in __m256d a, in __m256d b)
            => AndNot(a,b);
        
        ///<intrinsic> __m256 _mm256_andnot_ps (__m256 a, __m256 b) VANDNPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_andnot_ps(in __m256 a, in __m256 b)
            => AndNot(a,b);
        
        ///<intrinsic> __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_blend_pd(in __m256d a, in __m256d b, byte imm8)
            => Blend(a, b, imm8);
        
        ///<intrinsic> __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8) VBLENDPS ymm, ymm, ymm/m256, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_blend_ps(in __m256 a, in __m256 b, byte imm8)
            => Blend(a, b, imm8);
        
        ///<intrinsic> __m256d _mm256_blendv_pd (__m256d a, __m256d b, __m256d mask) VBLENDVPD ymm, ymm, ymm/m256, ymm </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_blendv_pd(in __m256d a, in __m256d b, in __m256d mask)
            => BlendVariable(a, b, mask);
        
        ///<intrinsic> __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_blendv_ps(in __m256 a, in __m256 b, in __m256 mask)
            => BlendVariable(a, b, mask);
        
        ///<intrinsic> __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, in m32 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128 _mm_broadcast_ss(ref float mem_addr)
            => BroadcastScalarToVector128(As.pfloat32(ref mem_addr));
        
        ///<intrinsic> __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, in m64 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256d _mm256_broadcast_sd(ref double mem_addr)
            => BroadcastScalarToVector256(As.pfloat64(ref mem_addr));
        
        ///<intrinsic> __m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, in m32 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256 _mm256_broadcast_ss(ref float mem_addr)
            => BroadcastScalarToVector256(As.pfloat32(ref mem_addr));
        
        ///<intrinsic> __m256d _mm256_broadcast_pd (__m128d const * mem_addr) VBROADCASTF128, ymm, in __m128 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256d _mm256_broadcast_pd(ref double mem_addr)
            => BroadcastVector128ToVector256(As.pfloat64(ref mem_addr));
        
        ///<intrinsic> __m256 _mm256_broadcast_ps (__m128 const * mem_addr) VBROADCASTF128, ymm, in __m128 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256 _mm256_broadcast_ps(ref float mem_addr)
            => BroadcastVector128ToVector256(As.pfloat32(ref mem_addr));
        
        ///<intrinsic> __m256 _mm256_ceil_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(10) </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_ceil_ps(in __m256 a)
            => Ceiling(a);
        
        ///<intrinsic> __m256d _mm256_ceil_pd (__m256d a) VROUNDPD ymm, ymm/m256, imm8(10) </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_ceil_pd(in __m256d a)
            => Ceiling(a);

        ///<intrinsic> __m256d _mm256_max_pd (__m256d a, __m256d b) VMAXPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_max_pd(in __m256d a, in __m256d b)
            => Max(a,b);
        
        ///<intrinsic> __m256 _mm256_max_ps (__m256 a, __m256 b) VMAXPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_max_ps(in __m256 a, in __m256 b)
            => Max(a,b);
        
        ///<intrinsic> __m256d _mm256_min_pd (__m256d a, __m256d b) VMINPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_min_pd(in __m256d a, in __m256d b)
            => Min(a,b);
        
        ///<intrinsic> __m256 _mm256_min_ps (__m256 a, __m256 b) VMINPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_min_ps(in __m256 a, in __m256 b)
            => Min(a,b);

        //<intrinsic> __m256d _mm256_sqrt_pd (__m256d a) VSQRTPD ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_sqrt_pd(in __m256d a)
            => Sqrt(a);
        
        //<intrinsic> __m256 _mm256_sqrt_ps (__m256 a) VSQRTPS ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_sqrt_ps(in __m256 a)
            => Sqrt(a);

        ///<intrinsic> __m128d _mm_cmp_pd (__m128d a, __m128d b, const int imm8) VCMPPD xmm, xmm, xmm/m128, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_cmp_pd(in __m128d a, in __m128d b, FloatComparisonMode imm8)
            => Compare(a,b,imm8);
        
        ///<intrinsic> __m128 _mm_cmp_ps (__m128 a, __m128 b, const int imm8) VCMPPS xmm, xmm, xmm/m128, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmp_ps(in __m128 a, in __m128 b, FloatComparisonMode imm8)
            => Compare(a,b,imm8);
    
        ///<intrinsic> __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm, ymm/m256, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_cmp_pd(in __m256d a, in __m256d b, FloatComparisonMode imm8)
            => Compare(a,b,imm8);
        
        ///<intrinsic> __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_cmp_ps(in __m256 a, in __m256 b, FloatComparisonMode imm8)
            => Compare(a,b,imm8);
        
        ///<intrinsic> __m128d _mm_cmp_sd (__m128d a, __m128d b, const int imm8) VCMPSS xmm, xmm, xmm/m32, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_cmp_sd(in __m128d a, in __m128d b, FloatComparisonMode imm8)
            => CompareScalar(a,b,imm8);
        
        ///<intrinsic> __m128 _mm_cmp_ss (__m128 a, __m128 b, const int imm8) VCMPSD xmm, xmm, xmm/m64, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_cmp_ss(in __m128 a, in __m128 b, FloatComparisonMode imm8)
            => CompareScalar(a,b,imm8);
        
        ///<intrinsic> __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm256_cvtpd_epi32(in __m256d a)
            => ConvertToVector128Int32(a);

        ///<intrinsic> __m128i _mm256_cvttpd_epi32 (__m256d a) VCVTTPD2DQ xmm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm256_cvttpd_epi32(in __m256d a)
            => ConvertToVector128Int32WithTruncation(a);
        
        ///<intrinsic> __m128 _mm256_cvtpd_ps (__m256d a) VCVTPD2PS xmm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm256_cvtpd_ps(in __m256d a)
            => ConvertToVector128Single(a);
        
        ///<intrinsic> __m256d _mm256_cvtepi32_pd (__m128i a) VCVTDQ2PD ymm, xmm/m128 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_cvtepi32_pd(in __m128i a)
            => ConvertToVector256Double(a);
        
        ///<intrinsic> __m256d _mm256_cvtps_pd (__m128 a) VCVTPS2PD ymm, xmm/m128 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_cvtps_pd(in __m128 a)
            => ConvertToVector256Double(a);

        ///<intrinsic> __m256d _mm256_addsub_pd (__m256d a, __m256d b) VADDSUBPD ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_addsub_pd(in __m256d a, in __m256d b)
            => AddSubtract(a,b);            
        
        ///<intrinsic> __m256 _mm256_addsub_ps (__m256 a, __m256 b) VADDSUBPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_addsub_ps(in __m256 a, in __m256 b)
            => AddSubtract(a,b);

        ///<intrinsic> __m256i _mm256_cvtps_epi32 (__m256 a) VCVTPS2DQ ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_cvtps_epi32(in __m256 a)
            => ConvertToVector256Int32(a);

        ///<intrinsic> __m256i _mm256_cvttps_epi32 (__m256 a) VCVTTPS2DQ ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_cvttps_epi32(in __m256 a)
            => ConvertToVector256Int32WithTruncation(a);

        ///<intrinsic> __m256 _mm256_cvtepi32_ps (__m256i a) VCVTDQ2PS ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_cvtepi32_ps(in __m256i a)
            => ConvertToVector256Single(a);
        
        ///<intrinsic> __m256d _mm256_div_pd (__m256d a, __m256d b) VDIVPD ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_div_pd(in __m256d a, in __m256d b)
            => Divide(a,b);

        ///<intrinsic> __m256 _mm256_div_ps (__m256 a, __m256 b) VDIVPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_div_ps(in __m256 a, in __m256 b)
            => Divide(a,b);

        [MethodImpl(Inline)]
        public static bool _mm_testz_ps(in __m128 lhs, in __m128 rhs)
            => TestZ(lhs, rhs);        

        [MethodImpl(Inline)]
        public static bool _mm_testz_pd(in __m128d lhs, in __m128d rhs)
            => TestZ(lhs, rhs);        

        /// <intrinsic>int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static bool _mm256_testz_si256(in __m256i a, in __m256i b)
            => TestZ(v64i(a), v64i(b));        

        /// <intrinsic>int _mm256_testz_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static bool _mm256_testz_ps(in __m256 lhs, in __m256 rhs)
            => TestZ(lhs, rhs);        

        /// <intrinsic>int _mm256_testz_pd (__m256d a, __m256d b) VTESTPD ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static bool _mm256_testz_pd(in __m256d lhs, in __m256d rhs)
            => TestZ(lhs, rhs);        

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref sbyte dst, in __m256i src)
            => Store(refptr(ref dst), v8i(src));

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref byte dst, in __m256i src)
            => Store(refptr(ref dst), v8u(src));

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref short dst, in __m256i src)
            => Store(refptr(ref dst), v16i(src));

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref ushort dst, in __m256i src)
            => Store(refptr(ref dst), v16u(src));

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref int dst, in __m256i src)
            => Store(refptr(ref dst), v32i(src));
            
        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref uint dst, in __m256i src)
            => Store(refptr(ref dst), v32u(src));

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref long dst, in __m256i src)
            => Store(refptr(ref dst), v64i(src));

        /// <intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref ulong dst, in __m256i src)
            => Store(refptr(ref dst), v64u(src));

        /// <intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_ps(ref float dst, in __m256 src)
            => Store(refptr(ref dst), src);

        /// <intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_pd(ref double mem_addr, in __m256d src)
            => Store(refptr(ref mem_addr), src);

        ///<intrinsic> __m256 _mm256_dp_ps (__m256 a, __m256 b, const int imm8) VDPPS ymm, ymm, ymm/m256, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_dp_ps(in __m256 a, in __m256 b, byte imm8)
            => DotProduct(a,b, imm8);

        ///<intrinsic> __m256d _mm256_movedup_pd (__m256d a) VMOVDDUP ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_movedup_pd(in __m256d a)
            => DuplicateEvenIndexed(a);

        ///<intrinsic> __m256 _mm256_moveldup_ps (__m256 a) VMOVSLDUP ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_moveldup_ps(in __m256 a)
            => DuplicateEvenIndexed(a);

        ///<intrinsic> __m256 _mm256_rcp_ps (__m256 a) VRCPPS ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_rcp_ps(in __m256 value)
            => Reciprocal(value);
        
        ///<intrinsic> __m256 _mm256_rsqrt_ps (__m256 a) VRSQRTPS ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_rsqrt_ps(in __m256 value)
            => ReciprocalSqrt(value);

        ///<intrinsic> __m256 _mm256_movehdup_ps (__m256 a) VMOVSHDUP ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_movehdup_ps(in __m256 a)
            => DuplicateOddIndexed(a);

        ///<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm256_extractf128_si256(in __m256i a, byte imm8)
            => ExtractVector128(v64i(a), imm8);

        ///<intrinsic> __m128 _mm256_extractf128_ps (__m256 a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm256_extractf128_ps(in __m256 a, byte imm8)
            => ExtractVector128(a, imm8);

        ///<intrinsic> __m128d _mm256_extractf128_pd (__m256d a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm256_extractf128_pd(in __m256d a, byte imm8)
            => ExtractVector128(a, imm8);

        ///<intrinsic> __m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_mul_pd(in __m256d a, in __m256d b)
            => Multiply(a,b);
        
        ///<intrinsic> __m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_mul_ps(in __m256 a, in __m256 b)
            => Multiply(a,b);

        ///<intrinsic> __m256d _mm256_floor_pd (__m256d a) VROUNDPS ymm, ymm/m256, imm8(9) </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_floor_pd(in __m256d a)
            => Floor(a);
        
        ///<intrinsic> __m256 _mm256_floor_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(9) </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_floor_ps(in __m256 a)
            => Floor(a);

        ///<intrinsic> __m256d _mm256_hadd_pd (__m256d a, __m256d b) VHADDPD ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_hadd_pd(in __m256d a, in __m256d b)
            => HorizontalAdd(a,b);
        
        ///<intrinsic> __m256 _mm256_hadd_ps (__m256 a, __m256 b) VHADDPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_hadd_ps(in __m256 a, in __m256 b)
            => HorizontalAdd(a,b);

        ///<intrinsic> __m256d _mm256_hsub_pd (__m256d a, __m256d b) VHSUBPD ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_hsub_pd(in __m256d a, in __m256d b)
            => HorizontalSubtract(a,b);
        
        ///<intrinsic> __m256 _mm256_hsub_ps (__m256 a, __m256 b) VHSUBPS ymm, ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_hsub_ps(in __m256 a, in __m256 b)
            => HorizontalSubtract(a,b);

        ///<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        [MethodImpl(Inline)]
        public static __m256i InsertVector128(in __m256i a, in __m128i b, byte imm8)
            => InsertVector128(a,b, imm8);

        ///<intrinsic> __m256 _mm256_insertf128_ps (__m256 a, __m128 b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static __m256 InsertVector128(in __m256 a, in __m128 b, byte imm8)
            => InsertVector128(a,b,imm8);
        
        ///<intrinsic> __m256d _mm256_insertf128_pd (__m256d a, __m128d b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static __m256d InsertVector128(in __m256d a, in __m128d b, byte imm8)
            => InsertVector128(a,b,imm8);

        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref ulong mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref ushort mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256 _mm256_load_ps (float const * mem_addr) VMOVAPS ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256 _mm256_load_ps(ref float mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref sbyte mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref uint mem_addr)        
            => LoadAlignedVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref int mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref short mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256d _mm256_load_pd (double const * mem_addr) VMOVAPD ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256d _mm256_load_pd(ref double mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref byte mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_load_si256(ref long mem_addr)
            => LoadAlignedVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref ulong mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref byte mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref int mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref long mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref sbyte mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref ushort mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref uint mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_lddqu_si256(ref short mem_addr)
            => LoadDquVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref int mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref ulong mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref ushort mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref uint mem_addr)
            => LoadVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256 _mm256_loadu_ps (float const * mem_addr) VMOVUPS ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256 _mm256_loadu_ps(ref float mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref short mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref long mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256d _mm256_loadu_pd (double const * mem_addr) VMOVUPD ymm, ymm/m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256d _mm256_loadu_pd(ref double mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref byte mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_loadu_si256(ref sbyte mem_addr)
            => LoadVector256(refptr(ref mem_addr));
        
        ///<intrinsic> __m128d _mm_maskload_pd (double const * mem_addr, __m128i mask) VMASKMOVPD xmm, xmm, in __m128 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128d _mm_maskload_pd(ref double mem_addr, in __m128d mask)
            => MaskLoad(refptr(ref mem_addr), mask);
        
        ///<intrinsic> __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, in __m256 </intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256d _mm256_maskload_pd(ref double mem_addr, in __m256d mask)
            => MaskLoad(refptr(ref mem_addr), mask);
        
        ///<intrinsic> __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm, xmm, in __m128 </intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe __m128 _mm_maskload_ps(ref float mem_addr, in __m128 mask)
            => MaskLoad(refptr(ref mem_addr), mask);
        
        ///<intrinsic> __m256 _mm256_maskload_ps (float const * mem_addr, __m256i mask) VMASKMOVPS ymm, ymm, in __m256 </intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe __m256 _mm256_maskload_ps(ref float mem_addr, in __m256 mask)
            => MaskLoad(refptr(ref mem_addr), mask);
        
        ///<intrinsic> void _mm256_maskstore_ps (float * mem_addr, __m256i mask, __m256 a) VMASKMOVPS __m256, ymm, ymm </intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe void _mm256_maskstore_ps(ref float mem_addr, in __m256 mask, in __m256 a)
            => MaskStore(refptr(ref mem_addr), mask, a);
        
        ///<intrinsic> void _mm_maskstore_ps (float * mem_addr, __m128i mask, __m128 a) VMASKMOVPS __m128, xmm, xmm </intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe void _mm_maskstore_ps(ref float mem_addr, in __m128 mask, in __m128 a)
            => MaskStore(refptr(ref mem_addr), mask, a);
        
        ///<intrinsic> void _mm_maskstore_pd (double * mem_addr, __m128i mask, __m128d a) VMASKMOVPD __m128, xmm, xmm </intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe void _mm_maskstore_pd(ref double mem_addr, in __m128d mask, in __m128d a)
            => MaskStore(refptr(ref mem_addr), mask, a);
        
        ///<intrinsic> void _mm256_maskstore_pd (double * mem_addr, __m256i mask, __m256d a) VMASKMOVPD __m256, ymm, ymm </intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe void _mm256_maskstore_pd(ref double mem_addr, in __m256d mask, in __m256d a)
            => MaskStore(refptr(ref mem_addr), mask, a);

        ///<intrinsic> int _mm256_movemask_pd (__m256d a) VMOVMSKPD reg, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static int _mm256_movemask_pd(in __m256d a)
            => MoveMask(a);
        
        ///<intrinsic> int _mm256_movemask_ps (__m256 a) VMOVMSKPS reg, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static int _mm256_movemask_ps(in __m256 a)
            => MoveMask(a);
                
        ///<intrinsic> __m256 _mm256_or_ps (__m256 a, __m256 b) VORPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_or_ps(in __m256 a, in __m256 b)
            => Or(a,b);
        
        ///<intrinsic> __m256d _mm256_or_pd (__m256d a, __m256d b) VORPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_or_pd(in __m256d a, in __m256d b)
            => Or(a,b);
        
        ///<intrinsic> __m256 _mm256_permute_ps (__m256 a, int imm8) VPERMILPS ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_permute_ps(in __m256 a, byte imm8)
            => Permute(a,imm8);
        
        ///<intrinsic> __m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_permute_pd(in __m128d a, byte imm8)
            => Permute(a,imm8);
        
        ///<intrinsic> __m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_permute_ps(in __m128 a, byte imm8)
            => Permute(a,imm8);
        
        ///<intrinsic> __m256d _mm256_permute_pd (__m256d a, int imm8) VPERMILPD ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_permute_pd(in __m256d a, byte imm8)
            => Permute(a,imm8);
        
        ///<intrinsic> __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_permute2f128_pd(in __m256d a, in __m256d b, byte imm8)
            => Permute2x128(a,b,imm8);
                            
        ///<intrinsic> __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_permute2f128_ps(in __m256 a, in __m256 b, byte imm8)
            => Permute2x128(a,b,imm8);
        
        ///<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_permute2f128_si256(in __m256i a, in __m256i b, byte imm8)
            => Permute2x128(v64i(a),v64i(b),imm8);
                        
        ///<intrinsic> __m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_permutevar_ps(in __m256 a, in __m256i b)
            => PermuteVar(a,v32i(b));
        
        ///<intrinsic> __m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_permutevar_pd(in __m128d a, in __m128i b)
            => PermuteVar(a,b);
        
        ///<intrinsic> __m128 _mm_permutevar_ps (__m128 a, __m128i b) VPERMILPS xmm, xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128 _mm_permutevar_ps(in __m128 a, in __m128i b)
            => PermuteVar(a,b);
        
        ///<intrinsic> __m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_permutevar_pd(in __m256d a, in __m256i b)
            => PermuteVar(a,b);
                
        ///<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_CUR_DIRECTION) VROUNDPD ymm, ymm/m256, imm8(4)</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_round_pd(in __m256d a)
            => RoundCurrentDirection(a);
        
        ///<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_CUR_DIRECTION) VROUNDPS ymm, ymm/m256, imm8(4)</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_round_ps(in __m256 a)
            => RoundCurrentDirection(a);        

        ///<intrinsic> __m256d _mm256_shuffle_pd (__m256d a, __m256d b, const int imm8) VSHUFPD ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_shuffle_pd(in __m256d a, in __m256d b, byte imm8)
            => Shuffle(a,b,imm8);
        
        ///<intrinsic> __m256 _mm256_shuffle_ps (__m256 a, __m256 b, const int imm8) VSHUFPS ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_shuffle_ps(in __m256 a, in __m256 b, byte imm8)
            => Shuffle(a,b,imm8);

        ///<intrinsic> __m256d _mm256_unpackhi_pd (__m256d a, __m256d b) VUNPCKHPD ymm, ymm, ymm/m256 </intrinsic>
        public static __m256d _mm256_unpackhi_pd(in __m256d a, in __m256d b)
            => UnpackHigh(a, b);
        
        ///<intrinsic> __m256 _mm256_unpackhi_ps (__m256 a, __m256 b) VUNPCKHPS ymm, ymm, ymm/m256 </intrinsic>
        public static __m256 _mm256_unpackhi_ps(in __m256 a, in __m256 b)
            => UnpackHigh(a, b);
        
        ///<intrinsic> __m256d _mm256_unpacklo_pd (__m256d a, __m256d b) VUNPCKLPD ymm, ymm, ymm/m256 </intrinsic>
        public static __m256d _mm256_unpacklo_pd(in __m256d a, in __m256d b)
            => UnpackLow(a, b);
        
        ///<intrinsic> __m256 _mm256_unpacklo_ps (__m256 a, __m256 b) VUNPCKLPS ymm, ymm, ymm/m256 </intrinsic>
        public static __m256 _mm256_unpacklo_ps(in __m256 a, in __m256 b)
            => UnpackLow(a, b);
            
        ///<intrinsic> __m256d _mm256_xor_pd (__m256d a, __m256d b) VXORPS ymm, ymm, ymm/m256 </intrinsic>
        public static __m256d _mm256_xor_pd(in __m256d a, in __m256d b)
            => Xor(a,b);
        
        ///<intrinsic> __m256 _mm256_xor_ps (__m256 a, __m256 b) VXORPS ymm, ymm, ymm/m256 </intrinsic>
        public static __m256 _mm256_xor_ps(in __m256 a, in __m256 b)
            => Xor(a,b);

        ///<intrinsic> int _mm_testc_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128 </intrinsic>
        public static bool _mm_testc_ps(in __m128 a, in __m128 b)
            => TestC(a,b);
        
        ///<intrinsic> int _mm_testc_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128 </intrinsic>
        public static bool _mm_testc_pd(in __m128d a, in __m128d b)
            => TestC(a,b);
        
        ///<intrinsic> int _mm256_testnzc_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool _mm256_testnzc_ps(in __m256 a, in __m256 b)
            => TestNotZAndNotC(a, b);

        ///<intrinsic> int _mm256_testnzc_pd (__m256d a, __m256d b) VTESTPD ymm, ymm/m256 </intrinsic>
        public static bool _mm256_testnzc_pd(in __m256d a, in __m256d b)        
            => TestNotZAndNotC(a, b);
        
        ///<intrinsic> int _mm_testnzc_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128 </intrinsic>
        public static bool _mm_testnzc_ps(in __m128 a, in __m128 b)
            => TestNotZAndNotC(a, b);
        
        ///<intrinsic> int _mm_testnzc_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128 </intrinsic>
        public static bool _mm_testnzc_pd(in __m128d a, in __m128d b)
            => TestNotZAndNotC(a,b);

        #if false
                                                                            
        ///<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(8)
        public static __m256d _mm256_round_pd(in __m256d a)
              => RoundToNearestInteger(a);
        
        ///<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC) VROUNDPS ymm, ymm/m256, imm8(8)
        public static __m256 _mm256_round_ps(in __m256 a)
             => RoundToNearestInteger(a);
        
        ///<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(9)
        public static __m256d _mm256_round_pd(in __m256d a)
             => RoundToNegativeInfinity(a);
        
        ///<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC) VROUNDPS ymm, ymm/m256, imm8(9)
        public static __m256 _mm256_round_ps(in __m256 a)
            => RoundToNegativeInfinity(a);

        //<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(10)
        public static __m256d RoundToPositiveInfinity(in __m256d a)
            => throw new NotImplementedException();
        
        ///<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) VROUNDPS ymm, ymm/m256, imm8(10)
        public static __m256 RoundToPositiveInfinity(in __m256 value)
            => RoundToPositiveInfinity(value);

        ///<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) VROUNDPS ymm, ymm/m256, imm8(11)
        public static __m256 RoundToZero(in __m256 value)
            => throw new NotImplementedException();
        
        ///<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(11)
        public static __m256d RoundToZero(in __m256d a)
            => throw new NotImplementedException();        
                    
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref ushort mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref ulong mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref uint mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_ps (float * mem_addr, __m256 a) VMOVAPS __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref float mem_addr, in __m256 a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_pd (double * mem_addr, __m256d a) VMOVAPD __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref double mem_addr, in __m256d a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref long mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref int mem_addr, in __m128i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref short mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref byte mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA __m256, ymm <intrinsic>
        public static unsafe void StoreAligned(ref sbyte mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref ulong mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref ushort mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref uint mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_ps (float * mem_addr, __m256 a) MOVNTPS __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref float mem_addr, in __m256 a)        
            => throw new NotImplementedException();

        ///<intrinsic> void _mm256_stream_pd (double * mem_addr, __m256d a) MOVNTPD __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref double mem_addr, in __m256d a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref long mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref sbyte mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref byte mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref int mem_addr, in __m128i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ __m256, ymm <intrinsic>
        public static unsafe void StoreAlignedNonTemporal(ref short mem_addr, in __m256i a)
            => throw new NotImplementedException();
        
        ///<intrinsic> __m256d _mm256_sub_pd (__m256d a, __m256d b) VSUBPD ymm, ymm, ymm/m256 <intrinsic>
        public static __m256d Subtract(in __m256d a, in __m256d b)
            => throw new NotImplementedException();
        
        ///<intrinsic> __m256 _mm256_sub_ps (__m256 a, __m256 b) VSUBPS ymm, ymm, ymm/m256 </intrinsic>
        public static __m256 Subtract(in __m256 a, in __m256 b)
            => throw new NotImplementedException();
        
        ///<intrinsic> int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestC(in __m256i a, in __m256i b)        
            => throw new NotImplementedException();
        
        ///<intrinsic> int _mm256_testc_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool TestC(in __m256 a, in __m256 b)
            => throw new NotImplementedException();
               
        ///<intrinsic> int _mm256_testc_pd (__m256d a, __m256d b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool TestC(in __m256d a, in __m256d b)
            => throw new NotImplementedException();
                
        ///<intrinsic> int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestC(in __m128i a, in __m128i b)
            => throw new NotImplementedException();
        
        ///<intrinsic> int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in __m256i a, in __m256i b)
            => throw new NotImplementedException();
        
                
        ///<intrinsic> int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in __m256i a, in __m256i b)
            => throw new NotImplementedException();
                
        
        ///<intrinsic> int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in __m128i a, in __m128i b)
            => throw new NotImplementedException();                    
                         
        #endif

    }


}
