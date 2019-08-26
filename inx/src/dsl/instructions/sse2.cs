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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    
    using static zfunc;    
    using static As;

    partial class x86
    {
        /// <summary>
        /// Constructs a 128-bit vector from 16 bytes
        /// </summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_set_epi8(
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15)
                => Vec128.FromBytes(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10, x11,x12,x13,x14,x15);

        /// <summary>
        /// Constructs a 128-bit vector from 16 signed bytes
        /// </summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_set_epi8(
            sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, 
            sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                => Vec128.FromParts(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10, x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static __m128i _mm_set_epi32(uint x0, uint x1, uint x2, uint x3)
            => Vec128.FromParts(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static __m128i _mm_set_epi32(int x0, int x1, int x2, int x3)
            => Vec128.FromParts(x0,x1,x2,x3);

        ///<summary> m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8<summary>
        [MethodImpl(Inline)]
        public static Vector128<uint> _mm_shuffle_epi32(Vector128<uint> value, byte control)
            => Shuffle(value, control);

        /// <summary>__m128i _mm_add_epi8 (in __m128i a, in __m128i b) PADDB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi8(in __m128i a, in __m128i b)
            => Add(v8i(a), v8i(b));

        /// <summary>__m128i _mm_add_epi16 (in __m128i a, in __m128i b) PADDW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi16(in __m128i a, in __m128i b)
            => Add(v16i(a), v16i(b));

        /// <summary>_mm_add_epi32 (in __m128i a, in __m128i b) PADDD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi32(in __m128i a, in __m128i b)
            => Add(v32i(a), v32i(b));

        /// <summary>__m128i _mm_add_epi64 (in __m128i a, in __m128i b) PADDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi64(in __m128i a, in __m128i b)
            => Add(v64i(a), v64i(b));

        /// <summary>void _mm_storeu_pd (double* mem_addr, __m128d a) MOVUPD m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_pd(ref double dst, in __m128d src)
            => Store(refptr(ref dst), src);

        /// <summary>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref ulong dst, in __m128i src)
            => Store(refptr(ref dst), v64u(src));

        /// <summary>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref long dst, in __m128i src)
            => Store(refptr(ref dst), v64i(src));
 
        /// <summary>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref uint dst, in __m128i src)
            => Store(refptr(ref dst), v32u(src));

        /// <summary>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref short dst, in __m128i src)
            => Store(refptr(ref dst), v16i(src));

        /// <summary>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref sbyte dst, in __m128i src)
            => Store(refptr(ref dst), v8i(src));

        /// <summary>_mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref byte dst, in __m128i src)
            => Store(refptr(ref dst), v8u(src));

        /// <summary>_mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref ushort dst, in __m128i src)
            => Store(refptr(ref dst), v16u(src));

        ///<summary>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</summary>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref int dst, in __m128i src)
            => Store(refptr(ref dst), v32i(src));

        ///<summary>__m128d _mm_unpacklo_pd (in __m128d a, in __m128d b) UNPCKLPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_unpacklo_pd(in __m128d a, in __m128d b)
            => UnpackLow(a, b);

        ///<summary>m128i _mm_unpackhi_epi8 (in __m128i a, in __m128i b) PUNPCKHBW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpackhi_epi8(in __m128i a, in __m128i b)
            => UnpackHigh(v8i(a),v8i(b));

        ///<summary>m128i _mm_unpackhi_epi16 (in __m128i a, in __m128i b) PUNPCKHWD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpackhi_epi16(in __m128i a, in __m128i b)
            => UnpackHigh(v16i(a),v16i(b));
                
        ///<summary>m128i _mm_unpackhi_epi32 (in __m128i a, in __m128i b) PUNPCKHDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpackhi_epi32(in __m128i a, in __m128i b)
            => UnpackHigh(v32i(a),v32i(b));

        ///<summary>m128i _mm_unpackhi_epi64 (in __m128i a, in __m128i b) PUNPCKHQDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpackhi_epi64(in __m128i a, in __m128i b)
            => UnpackHigh(v64i(a),v64i(b));

        ///<summary>m128d _mm_unpackhi_pd (in __m128d a, in __m128d b) UNPCKHPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_unpackhi_pd(in __m128d a, in __m128d b)
            => UnpackHigh(a,b);

        ///<summary>m128d _mm_xor_pd (in __m128d a, in __m128d b) XORPD xmm, xmm/m128        
        [MethodImpl(Inline)]
        public static __m128d _mm_xor_pd(in __m128d a, in __m128d b)
            => Xor(a, b);

        ///<summary>m128d _mm_add_pd (in __m128d a, in __m128d b) ADDPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_add_pd(in __m128d a, in __m128d b)
            => Add(a,b);


        ///<summary>m128d _mm_add_sd (in __m128d a, in __m128d b) ADDSD xmm, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_add_sd(in __m128d a, in __m128d b)
            => AddScalar(a,b);

        ///<summary>m128d _mm_mul_sd (in __m128d a, in __m128d b) MULSD xmm, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_mul_sd(in __m128d a, in __m128d b)
            => MultiplyScalar(a, b);

        ///<summary>m128d _mm_mul_pd (in __m128d a, in __m128d b) MULPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_mul_pd(in __m128d a, in __m128d b)
            => Multiply(a,b);

        ///<summary>m128d _mm_max_pd (in __m128d a, in __m128d b) MAXPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_max_pd(in __m128d a, in __m128d b)
            => Max(a,b);
        
        ///<summary>m128d _mm_max_sd (in __m128d a, in __m128d b) MAXSD xmm, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_max_sd(in __m128d a, in __m128d b)
            => MaxScalar(a,b);

        ///<summary>m128d _mm_load_pd (double const* mem_address) MOVAPD xmm, m128</summary>
        [MethodImpl(Inline)]
        public static unsafe __m128d _mm_load_pd(ref double mem_address)
            => LoadAlignedVector128(refptr(ref mem_address));

        ///<summary>m128d _mm_loadu_pd (double const* mem_address) MOVUPD xmm, m128</summary>
        [MethodImpl(Inline)]
        public static unsafe __m128d _mm_loadu_pd(ref double mem_address)
            => LoadVector128(refptr(ref mem_address));

        ///<summary>m128d _mm_min_pd (in __m128d a, in __m128d b) MINPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_min_pd(in __m128d a, in __m128d b)
            => Min(a,b);

        ///<summary>m128i _mm_adds_epu8 (in __m128i a, in __m128i b) PADDUSB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_adds_epu8(in __m128i a, in __m128i b)
            => AddSaturate(v8u(a), v8u(b));

        ///<summary>m128i _mm_unpacklo_epi8 (in __m128i a, in __m128i b) PUNPCKLBW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpacklo_epi8(in __m128i a, in __m128i b)
            => UnpackLow(v8u(a),v8u(b));

        ///<summary>m128i _mm_unpacklo_epi16 (in __m128i a, in __m128i b) PUNPCKLWD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpacklo_epi16(in __m128i a, in __m128i b)
            => UnpackLow(v16u(a),v16u(b));
        
        ///<summary>m128i _mm_unpacklo_epi32 (in __m128i a, in __m128i b) PUNPCKLDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_unpacklo_epi32(in __m128i a, in __m128i b)
            => UnpackLow(v32u(a),v32u(b));

        ///<summary>m128i _mm_unpacklo_epi64 (in __m128i a, in __m128i b) PUNPCKLQDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vector128<ulong> _mm_unpacklo_epi64(in __m128i a, in __m128i b)
            => UnpackLow(v64u(a),v64u(b));

        /// <summary>
        /// _mm_slli_epi16: Shifts components in the source leftwards by a specified number of bits
        /// </summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_slli_epi16(__m128i a, byte imm8)
            => ShiftLeftLogical(v16u(a), imm8);

        ///<summary>m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_slli_epi32(__m128i a, byte imm8)
            => ShiftLeftLogical(v32u(a), imm8);

        ///<summary>m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_slli_epi64(__m128i a, byte imm8)
            => ShiftLeftLogical(v64u(a), imm8);

        ///<summary>
        /// _mm_srli_epi16, PSRLW
        /// Shifts components in the source rightwards by a specified number of bits
        /// </summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srli_epi16(__m128i a, byte imm8)
            => ShiftRightLogical(v16u(a), imm8);

        ///<summary>
        /// _mm_srli_epi32: Shifts components in the source rightwards by a specified number of bits
        ///</summary>        
        [MethodImpl(Inline)]
        public static __m128i _mm_srli_epi32(in __m128i a, byte imm8)
            => ShiftRightLogical(v32u(a), imm8);

        /// <summary>
        /// _mm_srli_epi64: Shifts components in the source rightwards by a specified number of bits
        /// </summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srli_epi64(in __m128i a, byte imm8)
            => ShiftRightLogical(v64u(a), imm8);

        ///<summary>m128i _mm_srai_epi16 (in __m128i a, int immediate) PSRAW xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srai_epi16(in __m128i a, byte imm8)
            => ShiftRightArithmetic(v16i(a), imm8);
        
        ///<summary>m128i _mm_srai_epi32 (in __m128i a, int immediate) PSRAD xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srai_epi32(in __m128i a, byte imm8)
            => ShiftRightArithmetic(v32i(a), imm8);        

        ///<summary>m128i _mm_bslli_si128 (in __m128i a, int imm8) PSLLDQ xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_bslli_si128(in __m128i a, byte imm8)
            => ShiftLeftLogical128BitLane(v64u(a), imm8);

        ///<summary>m128i _mm_bsrli_si128 (in __m128i a, int imm8) PSRLDQ xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_bsrli_si128(in __m128i a, byte imm8)
            => ShiftRightLogical128BitLane(v64u(a), imm8);

        ///<summary>_mm_sll_epi64 (in __m128i a, __m128i count) PSLLQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sll_epi64(in __m128i a, in __m128i count)
            => ShiftLeftLogical(v64u(a), v64u(count));

        ///<summary>m128i _mm_sll_epi32 (in __m128i a, __m128i count) PSLLD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sll_epi32(in __m128i a, in __m128i count)
            => ShiftLeftLogical(v32u(a), v32u(count));
        
        ///<summary>m128i _mm_sll_epi16 (in __m128i a, __m128i count) PSLLW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sll_epi16(in __m128i a, in __m128i count)
            => ShiftLeftLogical(v16u(a), v16u(count));

        ///<summary>m128i _mm_srl_epi16 (in __m128i a, __m128i count) PSRLW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srl_epi16(in __m128i a, in __m128i count)
            => ShiftRightLogical(v16i(a), v16i(count));

        
        ///<summary>m128i _mm_srl_epi32 (in __m128i a, __m128i count) PSRLD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srl_epi32(in __m128i a, in __m128i count)
            => ShiftRightLogical(v32u(a), v32u(count));

        ///<summary>m128i _mm_srl_epi16 (in __m128i a, __m128i count) PSRLW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srli_epi16(in __m128i a, in __m128i count)
            => ShiftRightLogical(v16u(a), v16u(count));

        ///<summary>m128i _mm_srl_epi64 (in __m128i a, __m128i count) PSRLQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_srl_epi64(in __m128i a, in __m128i count)
            => ShiftRightLogical(v64u(a), v64u(count));

        ///<summary>m128i _mm_sra_epi32 (__m128i a, __m128i count) PSRAD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sra_epi32(in __m128i a, in __m128i count)
            => ShiftRightArithmetic(v32i(a), v32i(count));
        
        ///<summary>m128i _mm_sra_epi16 (__m128i a, __m128i count) PSRAW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_sra_epi16(in __m128i a, in __m128i count)
            => ShiftRightArithmetic(v16i(a), v16i(count));


        ///<summary>m128i _mm_and_si128 (in __m128i a, in __m128i b) PAND xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_and_si128(in __m128i a, in __m128i b)
            => And(v64u(a), v64u(b));

        ///<summary>m128d _mm_and_pd (in __m128d a, in __m128d b) ANDPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_and_pd(in __m128d a, in __m128d b)
            => And(a,b);

        ///<summary>m128i _mm_andnot_si128 (in __m128i a, in __m128i b) PANDN xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_andnot_si128(in __m128i a, in __m128i b)
            => AndNot(v64u(a), v64u(b));
                    
        ///<summary>m128d _mm_andnot_pd (in __m128d a, in __m128d b) ADDNPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_andnot_pd(in __m128d a, in __m128d b)
            => AndNot(a,b);

        ///<summary>m128i _mm_or_si128 (in __m128i a, in __m128i b) POR xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_or_si128(in __m128i a, in __m128i b)
            => Or(v64u(a),v64u(b));

        ///<summary>m128i _mm_xor_si128 (in __m128i a, in __m128i b) PXOR xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_xor_si128(in __m128i a, in __m128i b)
            => Xor(v8u(a), v8u(b));

        ///<summary>m128d _mm_cmpgt_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(6) </summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_cmpgt_pd(in __m128d a, in __m128d b)
            => CompareGreaterThan(a,b);

        ///<summary>m128i _mm_cmpeq_epi8 (in __m128i a, in __m128i b) PCMPEQB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_cmpeq_epi8(in __m128i a, in __m128i b)
            => CompareEqual(v8u(a),v8u(b));

        ///<summary>m128i _mm_cmpeq_epi16 (in __m128i a, in __m128i b) PCMPEQW xmm, xmm/m128</summary>
        public static __m128i _mm_cmpeq_epi16(in __m128i a, in __m128i b)
            => CompareEqual(v16u(a),v16u(b));

        ///<summary>m128i _mm_cmpeq_epi32 (in __m128i a, in __m128i b) PCMPEQD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_cmpeq_epi32(in __m128i a, in __m128i b)
            => CompareEqual(v32u(a),v32u(b));

        ///<summary>m128d _mm_cmpeq_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(0)</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_cmpeq_pd(in __m128d a, in __m128d b)
            => CompareEqual(a,b);

        ///<summary>m128d _mm_cvtsi64_sd (__m128d a, __int64 b) CVTSI2SD xmm, reg/m64</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_cvtsi64_sd(__m128d a, long b)
            => ConvertScalarToVector128Double(a,b);

        ///<summary>m128i _mm_cvtsi64_si128 (__int64 a) MOVQ xmm, reg/m64</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtsi64_si128(long a)
            => ConvertScalarToVector128Int64(a);

        ///<summary>__m128i _mm_cvtsi64_si128 (__int64 a) MOVQ xmm, reg/m64</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtsi64_si128(ulong a)
            => ConvertScalarToVector128UInt64(a);

        ///<summary>int64 _mm_cvtsd_si64 (__m128d a) CVTSD2SI r64, xmm/m64</summary>
        [MethodImpl(Inline)]
        public static long _mm_cvtsd_si64(__m128d a)
            => ConvertToInt64(a);

        /// <summary>void _mm_mfence(void) MFENCE</summary>
        [MethodImpl(Inline)]
        public static void _mm_mfence()
            => MemoryFence();
        }

/*                
                    
        ///<summary>m128i _mm_adds_epi16 (in __m128i a, in __m128i b) PADDSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vector128<short> AddSaturate(Vector128<short> a, Vector128<short> b)
        
        ///<summary>m128i _mm_adds_epi8 (in __m128i a, in __m128i b) PADDSB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> AddSaturate(Vector128<sbyte> a, Vector128<sbyte> b)
        
        ///<summary>m128i _mm_adds_epu16 (in __m128i a, in __m128i b) PADDUSW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vector128<ushort> AddSaturate(Vector128<ushort> a, Vector128<ushort> b)
                
        ///<summary>m128i _mm_avg_epu8 (in __m128i a, in __m128i b) PAVGB xmm, xmm/m128</summary>
        public static Vector128<byte> Average(Vector128<byte> a, Vector128<byte> b)
            
        ///<summary>m128i _mm_avg_epu16 (in __m128i a, in __m128i b) PAVGW xmm, xmm/m128</summary>
        public static Vector128<ushort> Average(Vector128<ushort> a, Vector128<ushort> b)            

        ///<summary>m128i _mm_cmpgt_epi8 (in __m128i a, in __m128i b) PCMPGTB xmm, xmm/m128</summary>
        public static Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> a, Vector128<sbyte> b)
        //
        
        ///<summary>m128i _mm_cmpgt_epi16 (in __m128i a, in __m128i b) PCMPGTW xmm, xmm/m128</summary>
        public static Vector128<short> CompareGreaterThan(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128i _mm_cmpgt_epi32 (in __m128i a, in __m128i b) PCMPGTD xmm, xmm/m128</summary>
        public static Vector128<int> CompareGreaterThan(Vector128<int> a, Vector128<int> b)
        //
        
        ///<summary>m128d _mm_cmpge_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        public static __m128d CompareGreaterThanOrEqual(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_cmplt_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        public static __m128d CompareLessThan(in __m128d a, in __m128d b)
        
        ///<summary>m128i _mm_cmplt_epi16 (in __m128i a, in __m128i b) PCMPGTW xmm, xmm/m128
        public static Vector128<short> CompareLessThan(Vector128<short> a, Vector128<short> b)
        
        ///<summary>m128i _mm_cmplt_epi32 (in __m128i a, in __m128i b) PCMPGTD xmm, xmm/m128
        public static Vector128<int> CompareLessThan(Vector128<int> a, Vector128<int> b)
        
        ///<summary>m128i _mm_cmplt_epi8 (in __m128i a, in __m128i b) PCMPGTB xmm, xmm/m128
        public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> a, Vector128<sbyte> b)
        
        ///<summary>m128d _mm_cmple_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(2)
        public static __m128d CompareLessThanOrEqual(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_cmpneq_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(4)
        public static __m128d CompareNotEqual(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_cmpngt_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(2)
        public static __m128d CompareNotGreaterThan(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_cmpnge_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        public static __m128d CompareNotGreaterThanOrEqual(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_cmpnlt_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        public static __m128d CompareNotLessThan(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_cmpnle_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(6)
        public static __m128d CompareNotLessThanOrEqual(in __m128d a, in __m128d b)
        //
        
        ///<summary>m128d _mm_cmpord_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(7)
        public static __m128d CompareOrdered(in __m128d a, in __m128d b)
        public static __m128d CompareScalarEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarGreaterThan(in __m128d a, in __m128d b)
        public static __m128d CompareScalarGreaterThanOrEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarLessThan(in __m128d a, in __m128d b)
        public static __m128d CompareScalarLessThanOrEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarNotEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarNotGreaterThan(in __m128d a, in __m128d b)
        public static __m128d CompareScalarNotGreaterThanOrEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarNotLessThan(in __m128d a, in __m128d b)
        public static __m128d CompareScalarNotLessThanOrEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarOrdered(in __m128d a, in __m128d b)
        public static bool CompareScalarOrderedEqual(in __m128d a, in __m128d b)
        public static bool CompareScalarOrderedGreaterThan(in __m128d a, in __m128d b)
        public static bool CompareScalarOrderedGreaterThanOrEqual(in __m128d a, in __m128d b)
        public static bool CompareScalarOrderedLessThan(in __m128d a, in __m128d b)
        public static bool CompareScalarOrderedLessThanOrEqual(in __m128d a, in __m128d b)
        public static bool CompareScalarOrderedNotEqual(in __m128d a, in __m128d b)
        public static __m128d CompareScalarUnordered(in __m128d a, in __m128d b)
        public static bool CompareScalarUnorderedEqual(in __m128d a, in __m128d b)
        public static bool CompareScalarUnorderedGreaterThan(in __m128d a, in __m128d b)
        public static bool CompareScalarUnorderedGreaterThanOrEqual(in __m128d a, in __m128d b)
        public static bool CompareScalarUnorderedLessThan(in __m128d a, in __m128d b)
        public static bool CompareScalarUnorderedLessThanOrEqual(in __m128d a, in __m128d b)
        public static bool CompareScalarUnorderedNotEqual(in __m128d a, in __m128d b)
        //
        
        ///<summary>m128d _mm_cmpunord_pd (in __m128d a, in __m128d b) CMPPD xmm, xmm/m128, imm8(3)
        public static __m128d CompareUnordered(in __m128d a, in __m128d b)
        //
        
        ///<summary>m128d _mm_cvtsi32_sd (__m128d a, int b) CVTSI2SD xmm, reg/m32
        public static __m128d ConvertScalarToVector128Double(__m128d upper, int value)
        //
        
        ///<summary>m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        public static __m128d ConvertScalarToVector128Double(__m128d upper, __mm128 value)
        //
        
        ///<summary>m128i _mm_cvtsi32_si128 (int a) MOVD xmm, reg/m32
        public static Vector128<int> ConvertScalarToVector128Int32(int value)
        //
        
        ///<summary>m128 _mm_cvtsd_ss (__m128 a, __m128d b) CVTSD2SS xmm, xmm/m64
        public static __mm128 ConvertScalarToVector128Single(__mm128 upper, __m128d value)
        //
        
        ///<summary>m128i _mm_cvtsi32_si128 (int a) MOVD xmm, reg/m32
        public static Vector128<uint> ConvertScalarToVector128UInt32(uint value)
        //
        
        ///<summary>int _mm_cvtsd_si32 (__m128d a) CVTSD2SI r32, xmm/m64
        public static int ConvertToInt32(__m128d value)
        
        ///<summary>int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        public static int _mm_cvtsi128_si32(Vector128<int> a)
            => ConvertToInt32(a);
        
        ///<summary>int _mm_cvttsd_si32 (__m128d a) CVTTSD2SI reg, xmm/m64
        public static int ConvertToInt32WithTruncation(__m128d value)
        
        ///<summary>int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        public static uint ConvertToUInt32(Vector128<uint> value)
        
        ///<summary>m128d _mm_cvtepi32_pd (__m128i a) CVTDQ2PD xmm, xmm/m128
        public static __m128d ConvertToVector128Double(Vector128<int> value)
        
        ///<summary>m128d _mm_cvtps_pd (__m128 a) CVTPS2PD xmm, xmm/m128
        public static __m128d ConvertToVector128Double(__mm128 value)
        
        ///<summary>m128i _mm_cvtpd_epi32 (__m128d a) CVTPD2DQ xmm, xmm/m128
        public static Vector128<int> ConvertToVector128Int32(__m128d value)
        
        ///<summary>m128i _mm_cvtps_epi32 (__m128 a) CVTPS2DQ xmm, xmm/m128
        public static Vector128<int> ConvertToVector128Int32(__mm128 value)
        
        ///<summary>m128i _mm_cvttpd_epi32 (__m128d a) CVTTPD2DQ xmm, xmm/m128
        public static Vector128<int> ConvertToVector128Int32WithTruncation(__m128d value)
        
        ///<summary>m128i _mm_cvttps_epi32 (__m128 a) CVTTPS2DQ xmm, xmm/m128
        public static Vector128<int> ConvertToVector128Int32WithTruncation(__mm128 value)
        
        ///<summary>m128 _mm_cvtpd_ps (__m128d a) CVTPD2PS xmm, xmm/m128
        public static __mm128 ConvertToVector128Single(__m128d value)
        
        ///<summary>m128 _mm_cvtepi32_ps (__m128i a) CVTDQ2PS xmm, xmm/m128
        public static __mm128 ConvertToVector128Single(Vector128<int> value)
        
        ///<summary>m128d _mm_div_pd (in __m128d a, in __m128d b) DIVPD xmm, xmm/m128
        public static __m128d Divide(in __m128d a, in __m128d b)
        
        ///<summary>m128d _mm_div_sd (in __m128d a, in __m128d b) DIVSD xmm, xmm/m64
        public static __m128d DivideScalar(in __m128d a, in __m128d b)
        
        ///<summary>int _mm_extract_epi16 (__m128i a, int immediate) PEXTRW reg, xmm, imm8
        public static ushort Extract(Vector128<ushort> value, byte index)
        
        ///<summary>m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        public static Vector128<short> Insert(Vector128<short> value, short data, byte index)
        
        ///<summary>m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        public static Vector128<ushort> Insert(Vector128<ushort> value, ushort data, byte index)
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<ushort> LoadAlignedVector128(ushort* address)
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<uint> LoadAlignedVector128(uint* address)
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<sbyte> LoadAlignedVector128(sbyte* address)
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<ulong> LoadAlignedVector128(ulong* address)
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<int> LoadAlignedVector128(int* address)
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<short> LoadAlignedVector128(short* address)
        
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<long> LoadAlignedVector128(long* address)
        //
        
        ///<summary>m128i _mm_load_si128 (__m128i const* mem_address) MOVDQA xmm, m128
        public static Vector128<byte> LoadAlignedVector128(byte* address)
        
        //     void _mm_lfence(void) LFENCE
        public static void LoadFence()
        
        ///<summary>m128d _mm_loadh_pd (__m128d a, double const* mem_addr) MOVHPD xmm, m64
        public static __m128d LoadHigh(__m128d lower, double* address)
        
        ///<summary>m128d _mm_loadl_pd (__m128d a, double const* mem_addr) MOVLPD xmm, m64
        public static __m128d LoadLow(__m128d upper, double* address)
        
        ///<summary>m128d _mm_load_sd (double const* mem_address) MOVSD xmm, m64
        public static __m128d LoadScalarVector128(double* address)
        
        // This native signature does not exist. We provide this additional overload for completeness.
        ///<summary>m128i _mm_loadl_epi32 (__m128i const* mem_addr) MOVD xmm, reg/m32
        public static Vector128<int> LoadScalarVector128(int* address)
        
        ///<summary>m128i _mm_loadl_epi64 (__m128i const* mem_addr) MOVQ xmm, reg/m64
        public static Vector128<long> LoadScalarVector128(long* address)
        
        // This native signature does not exist. We provide this additional overload for completeness.
        ///<summary>m128i _mm_loadl_epi32 (__m128i const* mem_addr) MOVD xmm, reg/m32 
        public static Vector128<uint> LoadScalarVector128(uint* address)
        
        ///<summary>m128i _mm_loadl_epi64 (__m128i const* mem_addr) MOVQ xmm, reg/m64
        public static Vector128<ulong> LoadScalarVector128(ulong* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<uint> LoadVector128(uint* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<ushort> LoadVector128(ushort* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<sbyte> LoadVector128(sbyte* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<ulong> LoadVector128(ulong* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<int> LoadVector128(int* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<short> LoadVector128(short* address)
        //
        
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<long> LoadVector128(long* address)
        //
        
        ///<summary>m128i _mm_loadu_si128 (__m128i const* mem_address) MOVDQU xmm, m128
        public static Vector128<byte> LoadVector128(byte* address)
        //
        
        //     void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        public static void MaskMove(Vector128<byte> source, Vector128<byte> mask, byte* address)
        //
        
        //     void _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        public static void MaskMove(Vector128<sbyte> source, Vector128<sbyte> mask, sbyte* address)
        
        ///<summary>m128i _mm_max_epi16 (in __m128i a, in __m128i b) PMAXSW xmm, xmm/m128
        public static Vector128<short> Max(Vector128<short> a, Vector128<short> b)
        
        ///<summary>m128i _mm_max_epu8 (in __m128i a, in __m128i b) PMAXUB xmm, xmm/m128
        public static Vector128<byte> Max(Vector128<byte> a, Vector128<byte> b)
        
        
        
        
        
        ///<summary>m128i _mm_min_epi16 (in __m128i a, in __m128i b) PMINSW xmm, xmm/m128
        public static Vector128<short> Min(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128i _mm_min_epu8 (in __m128i a, in __m128i b) PMINUB xmm, xmm/m128
        public static Vector128<byte> Min(Vector128<byte> a, Vector128<byte> b)
        //
        
        ///<summary>m128d _mm_min_sd (in __m128d a, in __m128d b) MINSD xmm, xmm/m64
        public static __m128d MinScalar(in __m128d a, in __m128d b)
        //
        
        //     int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        public static int MoveMask(Vector128<byte> value)
        //
        
        //     int _mm_movemask_pd (__m128d a) MOVMSKPD reg, xmm
        public static int MoveMask(__m128d value)
        //
        
        //     int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        public static int MoveMask(Vector128<sbyte> value)
        //
        
        ///<summary>m128d _mm_move_sd (in __m128d a, in __m128d b) MOVSD xmm, xmm
        public static __m128d MoveScalar(__m128d upper, __m128d value)
        //
        
        ///<summary>m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        public static Vector128<long> MoveScalar(Vector128<long> value)
        //
        
        ///<summary>m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        public static Vector128<ulong> MoveScalar(Vector128<ulong> value)
        //
        
        ///<summary>m128i _mm_mul_epu32 (in __m128i a, in __m128i b) PMULUDQ xmm, xmm/m128
        public static Vector128<ulong> Multiply(Vector128<uint> a, Vector128<uint> b)
        //
        
        //
        
        ///<summary>m128i _mm_madd_epi16 (in __m128i a, in __m128i b) PMADDWD xmm, xmm/m128
        public static Vector128<int> MultiplyAddAdjacent(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128i _mm_mulhi_epu16 (in __m128i a, in __m128i b) PMULHUW xmm, xmm/m128
        public static Vector128<ushort> MultiplyHigh(Vector128<ushort> a, Vector128<ushort> b)
        //
        
        ///<summary>m128i _mm_mulhi_epi16 (in __m128i a, in __m128i b) PMULHW xmm, xmm/m128
        public static Vector128<short> MultiplyHigh(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128i _mm_mullo_epi16 (in __m128i a, in __m128i b) PMULLW xmm, xmm/m128
        public static Vector128<ushort> MultiplyLow(Vector128<ushort> a, Vector128<ushort> b)
        //
        
        ///<summary>m128i _mm_mullo_epi16 (in __m128i a, in __m128i b) PMULLW xmm, xmm/m128
        public static Vector128<short> MultiplyLow(Vector128<short> a, Vector128<short> b)
        //
        
            
        ///<summary>m128d _mm_or_pd (in __m128d a, in __m128d b) ORPD xmm, xmm/m128
        public static __m128d Or(in __m128d a, in __m128d b)
        //
        
        ///<summary>m128i _mm_or_si128 (in __m128i a, in __m128i b) POR xmm, xmm/m128
        public static Vector128<byte> Or(Vector128<byte> a, Vector128<byte> b)
        //
        
        ///<summary>m128i _mm_or_si128 (in __m128i a, in __m128i b) POR xmm, xmm/m128
        public static Vector128<long> Or(Vector128<long> a, Vector128<long> b)
        //
        
        ///<summary>m128i _mm_packs_epi16 (in __m128i a, in __m128i b) PACKSSWB xmm, xmm/m128
        public static Vector128<sbyte> PackSignedSaturate(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128i _mm_packs_epi32 (in __m128i a, in __m128i b) PACKSSDW xmm, xmm/m128
        public static Vector128<short> PackSignedSaturate(Vector128<int> a, Vector128<int> b)
        //
        
        ///<summary>m128i _mm_packus_epi16 (in __m128i a, in __m128i b) PACKUSWB xmm, xmm/m128
        public static Vector128<byte> PackUnsignedSaturate(Vector128<short> a, Vector128<short> b)
        //
        
        
        ///<summary>m128d _mm_shuffle_pd (in __m128d a, in __m128d b, int immediate) SHUFPD xmm, xmm/m128, imm8
        public static __m128d Shuffle(in __m128d a, in __m128d b, byte control)
        
        
        
        ///<summary>m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        public static Vector128<short> ShuffleHigh(Vector128<short> value, byte control)
        
        ///<summary>m128i _mm_shufflehi_epi16 (__m128i a, int control) PSHUFHW xmm, xmm/m128, imm8
        public static Vector128<ushort> ShuffleHigh(Vector128<ushort> value, byte control)
        
        ///<summary>m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        public static Vector128<short> ShuffleLow(Vector128<short> value, byte control)
        
        ///<summary>m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        public static Vector128<ushort> ShuffleLow(Vector128<ushort> value, byte control)
        
        ///<summary>m128d _mm_sqrt_pd (__m128d a) SQRTPD xmm, xmm/m128
        public static __m128d Sqrt(__m128d value)
        
        ///This native signature does not exist. 
        ///<summary>m128d _mm_sqrt_sd (__m128d a) SQRTSD xmm, xmm/64 
        public static __m128d SqrtScalar(__m128d value)
        
        ///<summary>m128d _mm_sqrt_sd (in __m128d a, in __m128d b) SQRTSD xmm, xmm/64
        public static __m128d SqrtScalar(__m128d upper, __m128d value)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(ulong* address, Vector128<ulong> source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(uint* address, Vector128<uint> source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(ushort* address, Vector128<ushort> source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(sbyte* address, Vector128<sbyte> source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(int* address, Vector128<int> source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(short* address, Vector128<short> source)
        //
        
        //     void _mm_store_pd (double* mem_addr, __m128d a) MOVAPD m128, xmm
        public static void StoreAligned(double* address, __m128d source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(byte* address, Vector128<byte> source)
        //
        
        //     void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        public static void StoreAligned(long* address, Vector128<long> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(ushort* address, Vector128<ushort> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(ulong* address, Vector128<ulong> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(uint* address, Vector128<uint> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(sbyte* address, Vector128<sbyte> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(int* address, Vector128<int> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(short* address, Vector128<short> source)
        //
        
        //     void _mm_stream_pd (double* mem_addr, __m128d a) MOVNTPD m128, xmm
        public static void StoreAlignedNonTemporal(double* address, __m128d source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(byte* address, Vector128<byte> source)
        //
        
        //     void _mm_stream_si128 (__m128i* mem_addr, __m128i a) MOVNTDQ m128, xmm
        public static void StoreAlignedNonTemporal(long* address, Vector128<long> source)
        //
        
        //     void _mm_storeh_pd (double* mem_addr, __m128d a) MOVHPD m64, xmm
        public static void StoreHigh(double* address, __m128d source)
        //
        
        //     void _mm_storel_pd (double* mem_addr, __m128d a) MOVLPD m64, xmm
        public static void StoreLow(double* address, __m128d source)
        //
        
        //     void _mm_stream_si32(int *p, int a) MOVNTI m32, r32
        public static void StoreNonTemporal(int* address, int value)
        //
        
        //     void _mm_stream_si32(int *p, int a) MOVNTI m32, r32
        public static void StoreNonTemporal(uint* address, uint value)
        //
        
        //     void _mm_store_sd (double* mem_addr, __m128d a) MOVSD m64, xmm
        public static void StoreScalar(double* address, __m128d source)
        public static void StoreScalar(long* address, Vector128<long> source)
        public static void StoreScalar(ulong* address, Vector128<ulong> source)
        //
        
        ///<summary>m128i _mm_sub_epi16 (in __m128i a, in __m128i b) PSUBW xmm, xmm/m128
        public static Vector128<ushort> Subtract(Vector128<ushort> a, Vector128<ushort> b)
        //
        
        ///<summary>m128i _mm_sub_epi64 (in __m128i a, in __m128i b) PSUBQ xmm, xmm/m128
        public static Vector128<ulong> Subtract(Vector128<ulong> a, Vector128<ulong> b)
        //
        
        ///<summary>m128i _mm_sub_epi8 (in __m128i a, in __m128i b) PSUBB xmm, xmm/m128
        public static Vector128<sbyte> Subtract(Vector128<sbyte> a, Vector128<sbyte> b)
        //
        
        ///<summary>m128i _mm_sub_epi32 (in __m128i a, in __m128i b) PSUBD xmm, xmm/m128
        public static Vector128<uint> Subtract(Vector128<uint> a, Vector128<uint> b)
        //
        
        ///<summary>m128i _mm_sub_epi32 (in __m128i a, in __m128i b) PSUBD xmm, xmm/m128
        public static Vector128<int> Subtract(Vector128<int> a, Vector128<int> b)
        //
        
        ///<summary>m128i _mm_sub_epi16 (in __m128i a, in __m128i b) PSUBW xmm, xmm/m128
        public static Vector128<short> Subtract(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128d _mm_sub_pd (in __m128d a, in __m128d b) SUBPD xmm, xmm/m128
        public static __m128d Subtract(in __m128d a, in __m128d b)
        //
        
        ///<summary>m128i _mm_sub_epi8 (in __m128i a, in __m128i b) PSUBB xmm, xmm/m128
        public static Vector128<byte> Subtract(Vector128<byte> a, Vector128<byte> b)
        //
        
        ///<summary>m128i _mm_sub_epi64 (in __m128i a, in __m128i b) PSUBQ xmm, xmm/m128
        public static Vector128<long> Subtract(Vector128<long> a, Vector128<long> b)
        //
        
        ///<summary>m128i _mm_subs_epu8 (in __m128i a, in __m128i b) PSUBUSB xmm, xmm/m128
        public static Vector128<byte> SubtractSaturate(Vector128<byte> a, Vector128<byte> b)
        //
        
        ///<summary>m128i _mm_subs_epi16 (in __m128i a, in __m128i b) PSUBSW xmm, xmm/m128
        public static Vector128<short> SubtractSaturate(Vector128<short> a, Vector128<short> b)
        //
        
        ///<summary>m128i _mm_subs_epi8 (in __m128i a, in __m128i b) PSUBSB xmm, xmm/m128
        public static Vector128<sbyte> SubtractSaturate(Vector128<sbyte> a, Vector128<sbyte> b)
        //
        
        ///<summary>m128i _mm_subs_epu16 (in __m128i a, in __m128i b) PSUBUSW xmm, xmm/m128
        public static Vector128<ushort> SubtractSaturate(Vector128<ushort> a, Vector128<ushort> b)
        //
        
        ///<summary>m128d _mm_sub_sd (in __m128d a, in __m128d b) SUBSD xmm, xmm/m64
        public static __m128d SubtractScalar(in __m128d a, in __m128d b)
        //
        
        ///<summary>m128i _mm_sad_epu8 (in __m128i a, in __m128i b) PSADBW xmm, xmm/m128
        public static Vector128<ushort> SumAbsoluteDifferences(Vector128<byte> a, Vector128<byte> b)            
        

                        
        
        

        //64-bit


        ///<summary>int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        [MethodImpl(Inline)]
        public static long ConvertToInt64(Vector128<long> a)

        ///<summary>int64 _mm_cvttsd_si64 (__m128d a) CVTTSD2SI reg, xmm/m64
        [MethodImpl(Inline)]
        public static long ConvertToInt64WithTruncation(__m128d a)

        ///<summary>int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        [MethodImpl(Inline)]
        public static ulong ConvertToUInt64(Vector128<ulong> a)

        ///<summary>void _mm_stream_si64(__int64 *p, __int64 a) MOVNTI m64, r64
        [MethodImpl(Inline)]
        public static void StoreNonTemporal(long* address, long value)

        ///<summary>void _mm_stream_si64(__int64 *p, __int64 a) MOVNTI m64, r64
        [MethodImpl(Inline)]
        public static void StoreNonTemporal(ulong* address, ulong value)

 */     
}