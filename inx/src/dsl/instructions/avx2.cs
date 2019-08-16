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
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc; 
    using static As;

    #pragma warning disable 626
    
    partial class x86
    {
        ///<intrinsic>__m256i _mm256_mpsadbw_epu8 (__m256i a, __m256i b, const int imm8) VMPSADBW ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mpsadbw_epu8(in __m256i a, in __m256i b, byte imm8)
            => MultipleSumAbsoluteDifferences(a,b,imm8);

        ///<intrinsic> __m256i _mm256_abs_epi8 (__m256i a) VPABSB ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_abs_epi8(in __m256i a)
            => Abs(v8i(a));

        ///<intrinsic> __m256i _mm256_abs_epi16 (__m256i a) VPABSW ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_abs_epi16(in __m256i a)
            => Abs(v16i(a));

        ///<intrinsic> __m256i _mm256_abs_epi32 (__m256i a) VPABSD ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_abs_epi32(in __m256i a)
            => Abs(v32i(a));

        ///<intrinsic> __m256i _mm256_subs_epu16 (__m256i a, __m256i b) VPSUBUSW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_subs_epu16(in __m256i a, in __m256i b)
            => SubtractSaturate(v16i(a), v16i(b));

        ///<intrinsic> __m256i _mm256_sad_epu8 (__m256i a, __m256i b) VPSADBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sad_epu8(in __m256i a, in __m256i b)
            => SumAbsoluteDifferences(a, b);


        ///<intrinsic> __m256i _mm256_add_epi64 (__m256i a, __m256i b) VPADDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_add_epi64(in __m256i a, in __m256i b)
            => Add(v64i(a), v64i(b));

        ///<intrinsic> __m256i _mm256_add_epi32 (__m256i a, __m256i b) VPADDD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_add_epi32(in __m256i a, in __m256i b)
            => Add(v32i(a), v32i(b));

        ///<intrinsic> __m256i _mm256_add_epi16 (__m256i a, __m256i b) VPADDW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_add_epi16(in __m256i a, in __m256i b)
            => Add(v16i(a), v16i(b));

        ///<intrinsic> __m256i _mm256_add_epi8 (__m256i a, __m256i b) VPADDB ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_add_epi8(in __m256i a, in __m256i b)
            => Add(v8i(a), v8i(b));

        ///<intrinsic> __m256i _mm256_adds_epu8 (__m256i a, __m256i b) VPADDUSB ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_adds_epu8(in __m256i a, in __m256i b)
            => Add(v8u(a), v8u(b));

        ///<intrinsic>__m256i _mm256_add_epi16 (__m256i a, __m256i b) VPADDW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mm_add_epi8(in __m256i a, in __m256i b)
            => Add(v8i(a), v8i(b));

        ///<intrinsic>__m256i _mm256_add_epi16 (__m256i a, __m256i b) VPADDW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mm_add_epi16(in __m256i a, in __m256i b)
            => Add(v16i(a), v16i(b));

        /// <intrinsic>__m256i _mm256_add_epi32 (__m256i a, __m256i b) VPADDD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mm_add_epi32(in __m256i a, in __m256i b)
            => Add(v32i(a), v32i(b));

        /// <intrinsic>_mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_and_si256(in __m256i a, in __m256i b)
            => And(v64i(a),v64i(b));

        ///<intrinsic> __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpacklo_epi64(in __m256i a, in __m256i b)
            => UnpackLow(v64i(a),v64i(b));

        /// <summary>
        /// Multiplies corresponding lo input vector components 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <remarks>
        /// a[0]:uint * b[0]:uint -> c[0]:ulong
        /// a[1]:uint * b[1]:uint -> c[1]:ulong
        /// a[2]:uint * b[2]:uint -> c[2]:ulong
        /// a[3]:uint * b[3]:uint -> c[3]:ulong
        /// </remarks>
        /// <intrinsic>__m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mul_epu32(in __m256i a, in __m256i b)
            => Multiply(v32u(a),v32u(b));

        /// <summary>
        /// Multiplies corresponding input vector components components
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <remarks>
        /// a[0]:int * b[0]:int -> c[0]:long
        /// a[1]:int * b[1]:int -> c[1]:long
        /// a[2]:int * b[2]:int -> c[2]:long
        /// a[3]:int * b[3]:int -> c[3]:long
        /// </remarks>
        /// <intrinsic>_mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mul_epi32(in __m256i a, in __m256i b)
            => Multiply(v32i(a),v32i(b));
    
        ///<intrinsic>__m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_or_si256(in __m256i a, in __m256i b)
            => Or(v64i(a),v64i(b)); 

        ///<intrinsic> __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256i _mm256_cmpeq_epi16(in __m256i a, in __m256i b)
            => CompareEqual(v16i(a),v16i(b));

        ///<intrinsic> __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256i _mm256_cmpeq_epi64(in __m256i a, in __m256i b)
            => CompareEqual(v64i(a),v64i(b));
        
        /// <intrinsic>__m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_permutevar8x32_epi32(in __m256i a, in __m256i b)
            => PermuteVar8x32(v32i(a), v32i(b));

        /// <summary>
        ///  Right-shifts the components of a common value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="imm8"></param>
        /// <intrinsic>__m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srli_epi64(in __m256i a, byte imm8)
            => ShiftRightLogical(v64i(a), imm8);

        /// <summary>
        ///  Left-shifts the components of a common value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="imm8"></param>
        /// <intrinsic>__m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_slli_epi64(in __m256i a, byte imm8)
            => ShiftLeftLogical(v64i(a), imm8);

        /// <summary>
        ///  Right-shifts the components of the first vector by the values specified by the corresponding components in the second
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>__m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srlv_epi32(in __m256i a, in __m256i b)
            => ShiftRightLogicalVariable(v32u(a),v32u(b));
    
        /// <summary>
        ///  Left-shifts the components of the first vector by the values specified by the corresponding components in the second
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>_mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sllv_epi32(in __m256i a, in __m256i b)
            => ShiftLeftLogicalVariable(v32u(a),v32u(b));
 
         /// <intrinsic>_mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sub_epi64(in __m256i a, in __m256i b)
            => Subtract(v64i(a),v64i(b));

        /// <intrinsic>_mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sub_epi32(in __m256i a, in __m256i b)
            => Subtract(v32i(a),v32i(b));

        /// <intrinsic>_mm256_xor_si256 (__m256i a, __m256i b) VPXOR ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_xor_si256(in __m256i a, in __m256i b)
            => Xor(v64i(a),v64i(b));

        ///<intrinsic> __m256i _mm256_srai_epi16 (__m256i a, int imm8) VPSRAW ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srai_epi16(in __m256i a, byte imm8)
            => ShiftRightArithmetic(v16i(a), imm8);

        ///<intrinsic> __m256i _mm256_srai_epi32 (__m256i a, int imm8) VPSRAD ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srai_epi32(in __m256i a, byte imm8)
            => ShiftRightArithmetic(v32i(a), imm8);

        ///<intrinsic> _mm256_sra_epi32 (__m256i a, __m128i imm8) VPSRAD ymm, ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sra_epi32(in __m256i a, in __m128i imm8)
            => ShiftRightArithmetic(v32i(a), imm8);

        ///<intrinsic> _mm256_sra_epi16 (__m256i a, __m128i imm8) VPSRAW ymm, ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sra_epi16(in __m256i a, in __m128i imm8)
            => ShiftRightArithmetic(v16i(a), imm8);

        ///<intrinsic> __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXWQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_cvtepi16_epi64(in __m128i value)
            => ConvertToVector256Int32(v16i(value));
            
        ///<intrinsic> __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_cvtepi32_epi64(in __m128i a)
            => ConvertToVector256Int64(v32i(a));

        ///<intrinsic>__m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_cvtepi8_epi64(ref byte mem_addr)
            => ConvertToVector256Int64(refptr(ref mem_addr));        

        ///<intrinsic>__m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_cvtepi32_epi64(ref int mem_addr)
            => ConvertToVector256Int64(refptr(ref mem_addr));      

        ///<intrinsic>__m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_cvtepi16_epi64(ref short mem_addr)
            => ConvertToVector256Int64(refptr(ref mem_addr));        

        ///<intrinsic> __m256i _mm256_cvtepi8_epi64 (__m128i a) VPMOVSXBQ ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_cvtepi8_epi64(in __m128i a)
            => ConvertToVector256Int64(v8i(a));

        ///<intrinsic> __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srli_epi32(in __m256i a, byte imm8)
            => ShiftRightLogical(v32i(a), imm8);

        ///<intrinsic>__m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srl_epi64(in __m256i a, in __m128i count)
            => ShiftRightLogical(v64i(a), count);

        ///<intrinsic>__m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srl_epi32(in __m256i a, in __m128i count)
            => ShiftRightLogical(v32i(a), count);

        ///<intrinsic>__m256i _mm256_srl_epi16 (__m256i a, __m128i count) VPSRLW ymm, ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srl_epi16(in __m256i a, __m128i count)
            => ShiftRightLogical(v16i(a), count);

        ///<intrinsic>__m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srli_epi16(in __m256i a, byte imm8)
            => ShiftRightLogical(v16i(a), imm8);
       
        ///<intrinsic>__m256i _mm256_srl_epi16 (__m256i a, __m128i count) VPSRLW ymm, ymm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_srl_epi16(in __m256i a, in __m128i count)
            => ShiftRightLogical(v16i(a), count);

        ///<intrinsic> __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8</intrinsic>
        public static __m256i _mm256_slli_epi32(in __m256i a, byte imm8)
            => ShiftLeftLogical(v32i(a),imm8);

        ///<intrinsic> __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_andnot_si256(in __m256i a, in __m256i b)
            => AndNot(v64i(a),v64i(b));

        ///<intrinsic> __m256i _mm256_avg_epu8 (__m256i a, __m256i b) VPAVGB ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_avg_epu8(in __m256i a, in __m256i b)
            => Average(v8u(a), v8u(b));

        ///<intrinsic> __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpacklo_epi8(in __m256i a, in __m256i b)
            => UnpackLow(v8i(a), v8i(b));

        ///<intrinsic> __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpacklo_epi32(in __m256i a, in __m256i b)
            => UnpackLow(v32i(a), v32i(b));


        ///<intrinsic> __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpacklo_epi16(in __m256i a, in __m256i b)
            => UnpackLow(v16i(a), v16i(b));

        ///<intrinsic> __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_blend_epi32(in __m128i left, in __m128i right, byte imm8)
            => Blend(v32i(left), v32i(right), imm8);

        ///<intrinsic> __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_blend_epi16(in __m256i a, in __m256i b, byte imm8)
            => Blend(v16i(a),v16i(b), imm8);

        ///<intrinsic> __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_blend_epi32(in __m256i a, in __m256i b, byte imm8)
            => Blend(v32i(a),v32i(b), imm8);

        /// This intrinsic generates VPBLENDVB that needs a BYTE mask-vector,so users should correctly set each mask byte for the selected elements.
        ///<intrinsic> __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm, ymm, ymm/m256, ymm</intrinsic> 
        [MethodImpl(Inline)]
        public static __m256i _mm256_blendv_epi8(in __m256i a, in __m256i b, in __m256i mask)
            => BlendVariable(v8i(a), v8i(b), mask);

        ///<intrinsic> __m256i _mm256_maddubs_epi16 (__m256i a, __m256i b) VPMADDUBSW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_maddubs_epi16(in __m256i a, in __m256i b)
            => MultiplyAddAdjacent(v8u(a),v8i(b));

        ///<intrinsic> __m256i _mm256_madd_epi16 (__m256i a, __m256i b) VPMADDWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_madd_epi16(in __m256i a, in __m256i b)
            => MultiplyAddAdjacent(v16i(a),v16i(b));

        ///<intrinsic> __m256i _mm256_avg_epu16 (__m256i a, __m256i b) VPAVGW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_avg_epu16(in __m256i a, in __m256i b)
            => Average(v16u(a),v16u(b));

        ///<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128</intrinsic> 
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastsi128_si256(ref ulong mem_addr)
            => BroadcastVector128ToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastsi128_si256(ref short mem_addr)
            => BroadcastVector128ToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_mulhi_epi16 (__m256i a, __m256i b) VPMULHW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mulhi_epi16(in __m256i a, in __m256i b)
            => MultiplyHigh(v16i(a),v16i(b));

        ///<intrinsic> __m256i _mm256_mulhi_epu16 (__m256i a, __m256i b) VPMULHUW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mulhi_epu16(in __m256i a, in __m256i b)
            => MultiplyHigh(v16u(a),v16u(b));

        ///<intrinsic> __m256i _mm256_mullo_epi16 (__m256i a, __m256i b) VPMULLW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mullo_epi16(in __m256i a, in __m256i b)
            => MultiplyLow(v16i(a),v16i(b));

        ///<intrinsic> __m256i _mm256_mullo_epi32 (__m256i a, __m256i b) VPMULLD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_mullo_epi32(in __m256i a, in __m256i b)
            => MultiplyLow(v32i(a),v32i(b));

        ///<intrinsic> __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpackhi_epi16(in __m256i a, in __m256i b)
            => UnpackHigh(v16i(a),v16i(b));

        ///<intrinsic> __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpackhi_epi64(in __m256i a, in __m256i b)
            => UnpackHigh(v64i(a),v64i(b));

        ///<intrinsic> __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpackhi_epi32(in __m256i a, in __m256i b)
            => UnpackHigh(v32i(a),v32i(b));

        ///<intrinsic> __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_unpackhi_epi8(in __m256i a, in __m256i b)
            => UnpackHigh(v8i(a),v8i(b));

        ///<intrinsic> __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, in m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastd_epi32(ref uint mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, in m16</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastw_epi16(ref ushort mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, in m8</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastb_epi8(ref sbyte mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastd_epi32(in __m128i a)
            => BroadcastScalarToVector256(v32i(a));

        ///<intrinsic> __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastw_epi16(in __m128i a)
            => BroadcastScalarToVector256(v16i(a));

        ///<intrinsic> __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, in m16</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_broadcastw_epi16(ref ushort mem_addr)
            => BroadcastScalarToVector128(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastb_epi8(in __m128i a)
            => BroadcastScalarToVector256(v8i(a));

        ///<intrinsic> __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastq_epi64(in __m128i a)
            => BroadcastScalarToVector256(v64i(a));

        ///<intrinsic> __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, in m8</intrinsic>        
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastb_epi8(ref byte mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, in m16</intrinsic>        
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastw_epi16(ref short mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, in m32</intrinsic>        
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastd_epi32(ref int mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, in m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe __m256i _mm256_broadcastq_epi64(ref long mem_addr)
            => BroadcastScalarToVector256(refptr(ref mem_addr));

        ///<intrinsic> __m256 _mm256_broadcastss_ps (__m128 a) VBROADCASTSS ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256d _mm256_broadcastss_ps(in __m128d a)
            => BroadcastScalarToVector256(a);

        ///<intrinsic> __m256i _mm256_subs_epi8 (__m256i a, __m256i b) VPSUBSB ymm, ymm, ymm/m256<intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_subs_epi8(in __m256i a, in __m256i b)
            => Subtract(v8i(a), v8i(b));

        ///<intrinsic> __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8<intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_bslli_epi128(in __m256i a, byte imm8)
            => ShiftLeftLogical128BitLane(v64i(a),imm8);


        ///<intrinsic> __m256i _mm256_sllv_epi64 (__m256i a, __m256i imm8) VPSLLVQ ymm, ymm, ymm/m256<intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_sllv_epi64(in __m256i a, in __m256i imm8)
            => ShiftLeftLogicalVariable(v64i(a), imm8);
        

        ///<intrinsic> __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128<intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_sllv_epi32(in __m128i a, in __m128i count)
            => ShiftLeftLogicalVariable(v32i(a),count);

        ///<intrinsic> __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128<intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_sllv_epi64(in __m128i a, in __m128i count)
            => ShiftLeftLogicalVariable(v64i(a),count);

        ///<intrinsic> __m256i _mm256_adds_epi16 (__m256i a, __m256i b) VPADDSW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_adds_epi16(in __m256i a, in __m256i b)
            => AddSaturate(v16i(a),v16i(b));

        ///<intrinsic> __m256i _mm256_adds_epi8 (__m256i a, __m256i b) VPADDSB ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_adds_epi8(in __m256i a, in __m256i b)
            => AddSaturate(v8i(a),v8i(b));

        ///<intrinsic> __m256i _mm256_adds_epu16 (__m256i a, __m256i b) VPADDUSW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_adds_epu16(in __m256i a, in __m256i b)
            => AddSaturate(v16u(a),v16u(b));

        /// <intrinsic>void _mm_maskstore_epi64 (__int64* mem_addr, __m128i mask, __m128i a) VPMASKMOVQ __m128, xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_maskstore_epi64(ref long mem_addr, in __m128i mask, in __m128i a)
            => MaskStore(refptr(ref mem_addr), v64i(mask), v64i(a));

        ///<intrinsic>void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_maskstore_epi64(ref long mem_addr, in __m256i mask, in __m256i a)
            => MaskStore(refptr(ref mem_addr), v64i(mask), v64i(a));

        /// <intrinsic>void _mm256_maskstore_epi32 (ref int mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm256_maskstore_epi32(ref int mem_addr, in __m256i mask, in __m256i a)
            => MaskStore(refptr(ref mem_addr), v32i(mask), v32i(a));


        #if false


        // This intrinsic generates VPALIGNR that operates over bytes rather than elements of the vectors.
        ///<intrinsic> __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int imm8) VPALIGNR ymm,ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_alignr_epi8(in __m256i a, in __m256i b, byte count)

        ///<intrinsic> __m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, in m64</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastq_epi64(ref ulong a)

        ///<intrinsic> __m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, in m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastd_epi32(ref uint a)

        
        //<intrinsic> __m128i _mm_broadcastb_epi8 (__m128i a) VPBROADCASTB xmm, in m8</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastb_epi8(ref sbyte mem_addr)

        //<intrinsic> __m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastq_epi64(in __m128i value)
        //

        //<intrinsic> __m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastd_epi32(in __m128i value)

        ///<intrinsic> __m128 _mm_broadcastss_ps (__m128 a) VBROADCASTSS xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_broadcastss_ps(in __m128d value)

        ///<intrinsic> __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, in m16</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastw_epi16(ref short a)

        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastb_epi8(in __m128i value)

        ///<intrinsic> __m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, in m32</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastd_epi32(ref int a)

        ///<intrinsic> __m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, in m64</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastq_epi64(ref long a)

        ///<intrinsic> __m128i _mm_broadcastb_epi8 (__m128i a) VPBROADCASTB xmm, in m8</intrinsic>   
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastb_epi8(ref byte a)

        ///<intrinsic> __m128d _mm_broadcastsd_pd (__m128d a) VMOVDDUP xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128d _mm_broadcastsd_pd(in __m128d value)

        ///<intrinsic> __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_broadcastw_epi16(in __m128i value)

        ///<intrinsic> __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, in m64</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastq_epi64(ref ulong a);

        ///<intrinsic> __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastb_epi8(in __m128i a);

        ///<intrinsic> __m256d _mm256_broadcastsd_pd (__m128d a) VBROADCASTSD ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static m256d _mm256_broadcastsd_pd(in __m128d a);

        ///<intrinsic> __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i _mm256_broadcastw_epi16(in __m128i a);

        

        ///<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m256i BroadcastVector128ToVector256(ref byte mem_addr);
        //

        //<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128 The        
        [MethodImpl(Inline)]
        public static __m256i BroadcastVector128ToVector256(ref int mem_addr);
        //

        //<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128 The
        
        [MethodImpl(Inline)]
        public static __m256i BroadcastVector128ToVector256(ref long mem_addr);
        //

        //<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128 The
        
        [MethodImpl(Inline)]
        public static __m256i BroadcastVector128ToVector256(ref sbyte mem_addr);
        //

        //<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128 The
        
        [MethodImpl(Inline)]
        public static __m256i BroadcastVector128ToVector256(ref ushort mem_addr);
        //

        //<intrinsic> __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in __m128 The        
        [MethodImpl(Inline)]
        public static __m256i BroadcastVector128ToVector256(ref uint mem_addr);
        //

        //<intrinsic> __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256i _mm256_cmpeq_epi32(in __m256i a, in __m256i b);
        //

        //<intrinsic> __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        public static __m256i CompareEqual(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        public static __m256i CompareEqual(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        public static __m256i CompareEqual(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_cmpgt_epi16 (__m256i a, __m256i b) VPCMPGTW ymm, ymm, ymm/m256
        public static __m256i CompareGreaterThan(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        public static __m256i CompareGreaterThan(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        public static __m256i CompareGreaterThan(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        public static __m256i CompareGreaterThan(in __m256i a, in __m256i b);

        //     int _mm256_cvtsi256_si32 (__m256i a) MOVD reg/m32, xmm
        public static int _mm256_cvtsi256_si32(in __m256i a)
            => ConvertToInt32(a);
        //

        //     int _mm256_cvtsi256_si32 (__m256i a) MOVD reg/m32, xmm
        public static uint ConvertToUInt32(in __m256i a);
        public static __m256i ConvertToVector256Int16(in __m128i a);
        //

        //<intrinsic> __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        public static __m256i _mm256_cvtepi8_epi16(in __m128i a);
        public static __m256i _mm256_cvtepi8_epi16(ref sbyte mem_addr);
        public static __m256i _mm256_cvtepi16_epi32(ref ushort mem_addr);
        public static __m256i _mm256_cvtepi8_epi32(ref sbyte mem_addr);
        public static __m256i _mm256_cvtepi16_epi32(__m128i value);
        public static __m256i _mm256_cvtepi16_epi32(ref short mem_addr);
        //

        //<intrinsic> __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        public static __m256i _mm256_cvtepi16_epi32(in __m128i value);
        public static __m256i _mm256_cvtepi8_epi32(ref byte mem_addr);
        //

        //<intrinsic> __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        public static __m256i ConvertToVector256Int64(ref uint mem_addr);
        public static __m256i _mm256_cvtepi8_epi32(in __m128i value);
        public static __m256i _mm256_cvtepi16_epi64(ref ushort mem_addr);
        public static __m256i _mm256_cvtepi8_epi64(ref sbyte mem_addr);
        public static __m256i _mm256_cvtepi16_epi64(__m128i value);


        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //<intrinsic> __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static __m128i ExtractVector128(in __m256i a, byte index);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128i GatherMaskVector128(in __m128i src, ref ulong base_addr, in __m128i index, in __m128i mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i32gather_epi64 (__m128i src, __int64 const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDQ xmm, vm32x, xmm </intrinsic>
        public static __m128i GatherMaskVector128(in __m128i src, ref ulong base_addr, in __m128i index, in __m128i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm256_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m256i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm32y, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128i GatherMaskVector128(in __m128i src, ref uint base_addr, in __m256i index, in __m128i mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128i GatherMaskVector128(in __m128i src, ref uint base_addr, in __m128i index, in __m128i mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128i GatherMaskVector128(in __m128i src, ref uint base_addr, in __m128i index, in __m128i mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128 _mm256_mask_i64gather_ps (__m128 src, float const* base_addr, __m256i
        //     vindex, __m128 mask, const int scale) VGATHERQPS xmm, vm32y, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128d GatherMaskVector128(in __m128d src, ref float base_addr, in __m256i index, in __m128d mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128 _mm_mask_i64gather_ps (__m128 src, float const* base_addr, __m128i vindex, __m128 mask, const int scale) VGATHERQPS xmm, vm64x, xmm</intrinsic>
        public static __m128d GatherMaskVector128(in __m128d src, ref float base_addr, in __m128i index, in __m128d mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm
        public static __m128i GatherMaskVector128(in __m128i src, ref long base_addr, in __m128i index, in __m128i mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i32gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERDQ xmm, vm32x, xmm
        public static __m128i GatherMaskVector128(in __m128i src, ref long base_addr, in __m128i index, in __m128i mask, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm256_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m256i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm32y, xmm
        public static __m128i GatherMaskVector128(in __m128i src, ref int base_addr, in __m256i index, in __m128i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm64x, xmm
        public static __m128i GatherMaskVector128(in __m128i src, ref int base_addr, in __m128i index, in __m128i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm 
        public static __m128i GatherMaskVector128(in __m128i src, ref int base_addr, in __m128i index, in __m128i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128d _mm_mask_i64gather_pd (__m128d src, double const* base_addr, __m128i vindex, __m128d mask, const int scale) VGATHERQPD xmm, vm64x, xmm
        public static __m128d GatherMaskVector128(in __m128d src, ref double base_addr, in __m128i index, in __m128d mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128d _mm_mask_i32gather_pd (__m128d src, double const* base_addr, __m128i vindex, __m128d mask, const int scale) VGATHERDPD xmm, vm32x, xmm
        public static __m128d GatherMaskVector128(in __m128d src, ref double base_addr, in __m128i index, in __m128d mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128 _mm_mask_i32gather_ps (__m128 src, float const* base_addr, __m128i vindex, __m128 mask, const int scale) VGATHERDPS xmm, vm32x, xmm
        public static __m128d GatherMaskVector128(in __m128d src, ref float base_addr, in __m128i index, in __m128d mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm 
        public static __m256i GatherMaskVector256(in __m256i src, ref ulong base_addr, in __m256i index, in __m256i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i vindex, __m256i mask, const int scale)
        public static __m256i GatherMaskVector256(in __m256i src, ref ulong base_addr, in __m128i index, in __m256i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm
        public static __m256i GatherMaskVector256(in __m256i src, ref uint base_addr, in __m256i index, in __m256i mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256 _mm256_mask_i32gather_ps (__m256 src, float const* base_addr, __m256i vindex, __m256 mask, const int scale) VPGATHERDPS ymm, vm32y, ymm
        public static m256 GatherMaskVector256(in m256 src, ref float base_addr, in __m256i index, in m256 mask, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i vindex, __m256i mask, const int scale) VPGATHERDQ ymm, vm32y, ymm
        public static __m256i GatherMaskVector256(in __m256i src, ref long base_addr, in __m128i index, in __m256i mask, byte scale);

        //<intrinsic> __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i
        //     vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m256i GatherMaskVector256(in __m256i src, ref int base_addr, in __m256i index, in __m256i mask, byte scale);
        //

        //<intrinsic> __m256d _mm256_mask_i64gather_pd (__m256d src, double const* base_addr, __m256i
        //     vindex, __m256d mask, const int scale) VGATHERQPD ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256d GatherMaskVector256(in m256d src, ref double base_addr, in __m256i index, in m256d mask, byte scale);
        //

        //<intrinsic> __m256d _mm256_mask_i32gather_pd (__m256d src, double const* base_addr, __m128i
        //     vindex, __m256d mask, const int scale) VPGATHERDPD ymm, vm32y, ymm The scale
        //     parameter should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will
        //     be thrown.
        public static m256d GatherMaskVector256(in m256d source, ref double base_addr, in __m128i index, in m256d mask, byte scale);
        //

        //<intrinsic> __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i
        //     vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m256i GatherMaskVector256(in __m256i source, ref long base_addr, in __m256i index, in __m256i mask, byte scale);
        //

        //<intrinsic> __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERQQ xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128i GatherVector128(ref ulong base_addr, in __m128i index, byte scale);
        //

        //<intrinsic> __m128i _mm_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERDQ xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static __m128i GatherVector128(ref ulong base_addr, in __m128i index, byte scale);
        //

        //<intrinsic> __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERQD xmm, vm64y, xmm 
        public static __m128i GatherVector128(ref uint base_addr, in __m256i index, byte scale);

        //<intrinsic> __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERQD xmm, vm64x, xmm 
        public static __m128i GatherVector128(ref uint base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm</intrinsic>
        public static __m128i GatherVector128(ref uint base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128 _mm256_i64gather_ps (float const* base_addr, __m256i vindex, const int
        //     scale) VGATHERQPS xmm, vm64y, xmm 
        public static __m128d GatherVector128(ref float base_addr, in __m256i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128 _mm_i64gather_ps (float const* base_addr, __m128i vindex, const int scale)
        //     VGATHERQPS xmm, vm64x, xmm 
        public static __m128d GatherVector128(ref float base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm 
        public static __m128i GatherVector128(ref long base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERDQ xmm, vm32x, xmm 
        public static __m128i GatherVector128(ref long base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int
        //     scale) VPGATHERQD xmm, vm64y, xmm 
        public static __m128i GatherVector128(ref int base_addr, in __m256i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int
        //     scale) VPGATHERQD xmm, vm64x, xmm 
        public static __m128i GatherVector128(ref int base_addr, in __m128i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int
        //     scale) VPGATHERDD xmm, vm32x, xmm 
        public static __m128i GatherVector128(ref int base_addr, in __m128i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128d _mm_i64gather_pd (double const* base_addr, __m128i vindex, const int
        //     scale) VGATHERQPD xmm, vm64x, xmm 
        public static __m128d GatherVector128(ref double base_addr, in __m128i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128d _mm_i32gather_pd (double const* base_addr, __m128i vindex, const int
        //     scale) VGATHERDPD xmm, vm32x, xmm 
        public static __m128d GatherVector128(ref double base_addr, in __m128i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m128 _mm_i32gather_ps (float const* base_addr, __m128i vindex, const int scale)
        //     VGATHERDPS xmm, vm32x, xmm 
        public static __m128d GatherVector128(ref float base_addr, in __m128i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const
        //     int scale) VPGATHERQQ ymm, vm64y, ymm 
        public static __m256i GatherVector256(ref ulong base_addr, in __m256i index, byte scale);
        //

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm 
        public static __m256i GatherVector256(ref ulong base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm 
        public static __m256i GatherVector256(ref uint base_addr, in __m256i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256 _mm256_i32gather_ps (float const* base_addr, __m256i vindex, const int scale) VGATHERDPS ymm, vm32y, ymm 
        public static m256 GatherVector256(ref float base_addr, in __m256i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm 
        public static __m256i GatherVector256(ref long base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm 
        public static __m256i GatherVector256(ref int base_addr, in __m256i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256d _mm256_i64gather_pd (double const* base_addr, __m256i vindex, const int scale) VGATHERQPD ymm, vm64y, ymm 
        public static m256d GatherVector256(ref double base_addr, in __m256i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256d _mm256_i32gather_pd (double const* base_addr, __m128i vindex, const int scale) VGATHERDPD ymm, vm32y, ymm 
        public static m256d GatherVector256(ref double base_addr, in __m128i index, byte scale);

        //The scale parameter should be 1, 2, 4 or 8
        //<intrinsic> __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        public static __m256i GatherVector256(ref long base_addr, in __m256i index, byte scale);

        //<intrinsic> __m256i _mm256_hadd_epi16 (__m256i a, __m256i b) VPHADDW ymm, ymm, ymm/m256
        public static __m256i HorizontalAdd(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_hadd_epi32 (__m256i a, __m256i b) VPHADDD ymm, ymm, ymm/m256
        public static __m256i HorizontalAdd(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_hadds_epi16 (__m256i a, __m256i b) VPHADDSW ymm, ymm, ymm/m256
        public static __m256i HorizontalAddSaturate(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_hsub_epi16 (__m256i a, __m256i b) VPHSUBW ymm, ymm, ymm/m256
        public static __m256i HorizontalSubtract(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_hsub_epi32 (__m256i a, __m256i b) VPHSUBD ymm, ymm, ymm/m256
        public static __m256i HorizontalSubtract(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_hsubs_epi16 (__m256i a, __m256i b) VPHSUBSW ymm, ymm, ymm/m256
        public static __m256i HorizontalSubtractSaturate(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        public static __m256i InsertVector128(in __m256i a, in __m128i data, byte index);

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        public static __m256i InsertVector128(in __m256i a, in __m128i data, byte index);

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        public static __m256i InsertVector128(in __m256i a, in __m128i data, byte index);

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static __m256i InsertVector128(in __m256i a, in __m128i data, byte index);
        //

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static __m256i InsertVector128(in __m256i a, __m128i data, byte index);
        //

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static __m256i _mm256_inserti128_si256(in __m256i a, in __m128i data, byte index);

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        public static __m256i _mm256_inserti128_si256(in __m256i a, in __m128i data, byte index);

        //<intrinsic> __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        public static __m256i _mm256_inserti128_si256(in __m256i a, in __m128i data, byte index);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i _mm256_stream_load_si256(ref ulong mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i _mm256_stream_load_si256(ref ushort mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i _mm256_stream_load_si256(ref sbyte mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i LoadAlignedVector256NonTemporal(ref uint mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i LoadAlignedVector256NonTemporal(ref int mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i LoadAlignedVector256NonTemporal(ref short mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i LoadAlignedVector256NonTemporal(ref byte mem_addr);

        //<intrinsic> __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static __m256i LoadAlignedVector256NonTemporal(ref long mem_addr);

        //<intrinsic> __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, in __m128
        public static __m128i MaskLoad(ref int mem_addr, in __m128i mask);

        //<intrinsic> __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, in m256
        public static __m256i MaskLoad(ref int mem_addr, in __m256i mask);

        //<intrinsic> __m128i _mm_maskload_epi64 (__int64 const* mem_addr, __m128i mask) VPMASKMOVQ xmm, xmm, in __m128
        public static __m128i MaskLoad(ref long mem_addr, in __m128i mask);

        //<intrinsic> __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, in m256
        public static __m256i MaskLoad(ref long mem_addr, in __m256i mask);

        //<intrinsic> __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, in __m128
        public static __m128i MaskLoad(ref uint mem_addr, in __m128i mask);

        //<intrinsic> __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, in m256
        public static __m256i MaskLoad(ref uint mem_addr, in __m256i mask);

        //<intrinsic> __m128i _mm_maskload_epi64 (__int64 const* mem_addr, __m128i mask) VPMASKMOVQ xmm, xmm, in __m128
        public static __m128i MaskLoad(ref ulong mem_addr, in __m128i mask);

        //<intrinsic> __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, in m256
        public static __m256i MaskLoad(ref ulong mem_addr, in __m256i mask);

        //<intrinsic>void _mm_maskstore_epi32 (ref int mem_addr, __m128i mask, __m128i a) VPMASKMOVD __m128, xmm, xmm</intrinsic>
        public static void MaskStore(ref uint mem_addr, in __m128i mask, in __m128i a);

        //<intrinsic>void _mm_maskstore_epi32 (ref int mem_addr, __m128i mask, __m128i a) VPMASKMOVD __m128, xmm, xmm</intrinsic>
        public static void MaskStore(ref int mem_addr, in __m128i mask, in __m128i a);

        //<intrinsic>void _mm_maskstore_epi64 (__int64* mem_addr, __m128i mask, __m128i a) VPMASKMOVQ __m128, xmm, xmm</intrinsic>
        public static void MaskStore(ref long mem_addr, in __m128i mask, in __m128i a);

        //<intrinsic> __m256i _mm256_max_epu8 (__m256i a, __m256i b) VPMAXUB ymm, ymm, ymm/m256
        public static __m256i Max(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_max_epi16 (__m256i a, __m256i b) VPMAXSW ymm, ymm, ymm/m256
        public static __m256i Max(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_max_epi32 (__m256i a, __m256i b) VPMAXSD ymm, ymm, ymm/m256
        public static __m256i Max(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_max_epi8 (__m256i a, __m256i b) VPMAXSB ymm, ymm, ymm/m256
        public static __m256i Max(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_max_epu16 (__m256i a, __m256i b) VPMAXUW ymm, ymm, ymm/m256
        public static __m256i Max(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_max_epu32 (__m256i a, __m256i b) VPMAXUD ymm, ymm, ymm/m256
        public static __m256i Max(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_min_epu32 (__m256i a, __m256i b) VPMINUD ymm, ymm, ymm/m256
        public static __m256i Min(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_min_epu16 (__m256i a, __m256i b) VPMINUW ymm, ymm, ymm/m256
        public static __m256i Min(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_min_epi32 (__m256i a, __m256i b) VPMINSD ymm, ymm, ymm/m256
        public static __m256i Min(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_min_epu8 (__m256i a, __m256i b) VPMINUB ymm, ymm, ymm/m256
        public static __m256i Min(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_min_epi8 (__m256i a, __m256i b) VPMINSB ymm, ymm, ymm/m256
        public static __m256i Min(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_min_epi16 (__m256i a, __m256i b) VPMINSW ymm, ymm, ymm/m256
        public static __m256i Min(in __m256i a, in __m256i b);

        //<intrinsic> int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        public static int MoveMask(in __m256i a);

        //<intrinsic>int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        public static int MoveMask(in __m256i a);

        //<intrinsic> __m256i _mm256_mulhrs_epi16 (__m256i a, __m256i b) VPMULHRSW ymm, ymm, ymm/m256
        public static __m256i MultiplyHighRoundScale(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static __m256i Or(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_packs_epi16 (__m256i a, __m256i b) VPACKSSWB ymm, ymm, ymm/m256
        public static __m256i PackSignedSaturate(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_packs_epi32 (__m256i a, __m256i b) VPACKSSDW ymm, ymm, ymm/m256
        public static __m256i PackSignedSaturate(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_packus_epi16 (__m256i a, __m256i b) VPACKUSWB ymm, ymm, ymm/m256
        public static __m256i PackUnsignedSaturate(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_packus_epi32 (__m256i a, __m256i b) VPACKUSDW ymm, ymm, ymm/m256
        public static __m256i PackUnsignedSaturate(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);
        //

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);
        //

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);
        //

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);
        //

        //<intrinsic> __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static __m256i Permute2x128(in __m256i a, in __m256i b, byte imm8);
        //

        //<intrinsic> __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256,
        //     imm8
        public static m256d Permute4x64(in m256d value, byte imm8);
        //

        //<intrinsic> __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,
        //     imm8
        public static __m256i Permute4x64(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,
        //     imm8
        public static __m256i Permute4x64(in __m256i a, byte imm8);


        //<intrinsic> __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx) VPERMPS ymm, ymm/m256,
        //     ymm
        public static m256 PermuteVar8x32(in m256 left, in __m256i imm8);


        //<intrinsic> __m256i _mm256_sll_epi64 (__m256i a, __m128i count) VPSLLQ ymm, ymm, xmm/m128
        public static __m256i ShiftLeftLogical(in __m256i a, in __m128i count);
        //


        //<intrinsic> __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, in __m128i count);
        //

        //

        //<intrinsic> __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, __m128i count);
        //

        //<intrinsic> __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, in __m128i count);
        //

        //<intrinsic> __m256i _mm256_sll_epi64 (__m256i a, __m128i count) VPSLLQ ymm, ymm, xmm/m128<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, in __m128i count);
        //

        //<intrinsic> __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, byte count);
        //


        //<intrinsic> __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, in __m128i count);
        //

        //<intrinsic> __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, byte count);

        //<intrinsic> __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8<intrinsic>
        public static __m256i ShiftLeftLogical(in __m256i a, byte count);


        //<intrinsic> __m128i _mm_srav_epi32 (__m128i a, __m128i imm8) VPSRAVD xmm, xmm, xmm/m128
        public static __m128i ShiftRightArithmeticVariable(in __m128i value, in __m128i imm8);

        //<intrinsic> __m256i _mm256_srav_epi32 (__m256i a, __m256i imm8) VPSRAVD ymm, ymm, ymm/m256
        public static __m256i _mm256_srav_epi32(in __m256i a, in __m256i imm8)
            => ShiftRightArithmeticVariable(a,imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i _mm256_bsrli_epi128(in __m256i a, byte imm8)
            => ShiftRightLogical128BitLane(a,imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i _mm256_bsrli_epi128(in __m256i a, byte imm8)
            => ShiftRightLogical128BitLane(a, imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i _mm256_bsrli_epi128 (in __m256i a, byte imm8)
            => ShiftRightLogical128BitLane(a, imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i ShiftRightLogical128BitLane(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i ShiftRightLogical128BitLane(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i ShiftRightLogical128BitLane(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i ShiftRightLogical128BitLane(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static __m256i ShiftRightLogical128BitLane(in __m256i a, byte imm8);

        //<intrinsic> __m128i _mm_srlv_epi32 (__m128i a, __m128i imm8) VPSRLVD xmm, xmm, xmm/m128
        public static __m128i ShiftRightLogicalVariable(in __m128i value, in __m128i imm8);

        //<intrinsic> __m128i _mm_srlv_epi64 (__m128i a, __m128i imm8) VPSRLVQ xmm, xmm, xmm/m128
        public static __m128i ShiftRightLogicalVariable(in __m128i value, in __m128i imm8);

        //<intrinsic> __m128i _mm_srlv_epi32 (__m128i a, __m128i imm8) VPSRLVD xmm, xmm, xmm/m128
        public static __m128i ShiftRightLogicalVariable(in __m128i value, in __m128i imm8);

        //<intrinsic> __m128i _mm_srlv_epi64 (__m128i a, __m128i imm8) VPSRLVQ xmm, xmm, xmm/m128
        public static __m128i ShiftRightLogicalVariable(in __m128i value, in __m128i imm8);

        //<intrinsic> __m256i _mm256_srlv_epi64 (__m256i a, __m256i imm8) VPSRLVQ ymm, ymm, ymm/m256
        public static __m256i ShiftRightLogicalVariable(in __m256i a, in __m256i imm8);

        //<intrinsic> __m256i _mm256_srlv_epi64 (__m256i a, __m256i imm8) VPSRLVQ ymm, ymm, ymm/m256
        public static __m256i ShiftRightLogicalVariable(in __m256i a, in __m256i imm8);

        //<intrinsic> __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        public static __m256i Shuffle(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        public static __m256i Shuffle(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        public static __m256i Shuffle(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8) VPSHUFHW ymm, ymm/m256, imm8
        public static __m256i ShuffleHigh(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8) VPSHUFHW ymm, ymm/m256, imm8
        public static __m256i ShuffleHigh(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8) VPSHUFLW ymm, ymm/m256, imm8
        public static __m256i ShuffleLow(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8) VPSHUFLW ymm, ymm/m256, imm8
        public static __m256i ShuffleLow(in __m256i a, byte imm8);

        //<intrinsic> __m256i _mm256_sign_epi16 (__m256i a, __m256i b) VPSIGNW ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Sign(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sign_epi32 (__m256i a, __m256i b) VPSIGND ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Sign(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sign_epi8 (__m256i a, __m256i b) VPSIGNB ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Sign(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Subtract(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Subtract(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Subtract(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256<intrinsic>
        public static __m256i _mm256_sub_epi8(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256<intrinsic>
        public static __m256i _mm256_sub_epi64(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256<intrinsic>
        public static __m256i Subtract(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256<intrinsic>
        public static __m256i _mm256_sub_epi16(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256<intrinsic>
        public static __m256i _mm256_sub_epi8(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_subs_epu8 (__m256i a, __m256i b) VPSUBUSB ymm, ymm, ymm/m256<intrinsic>
        public static __m256i _mm256_subs_epu8(in __m256i a, in __m256i b);

        //<intrinsic> __m256i _mm256_subs_epi16 (__m256i a, __m256i b) VPSUBSW ymm, ymm, ymm/m256<intrinsic>
        public static __m256i _mm256_subs_epi16(in __m256i a, in __m256i b);


    #endif
    }
}
