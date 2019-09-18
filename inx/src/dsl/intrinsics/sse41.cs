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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static As;    
    using static AsIn;    

    using static zfunc;    

    partial class x86
    {
        ///<summary>int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static bool _mm_testz_si128(in __m128i a, in __m128i b)
            => TestZ(v64i(a),v64i(b));        

        /// <summary> int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static bool _mm_testc_si128(__m128i a, __m128i b)
            => TestC(v8u(a),v8u(b));
 
        /// <summary> int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static bool _mm_testnzc_si128(__m128i a, __m128i b)
            => TestNotZAndNotC(v8u(a),v8u(b));

        /// <summary> int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static bool _mm_testz_si128(__m128i a, __m128i b)
            => TestZ(v8u(a),v8u(b));

        /// <summary> __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_blend_pd(__m128d a, __m128d b, byte control)
            => Blend(a,b,control);

        /// <summary> __m128 _mm_blend_ps (__m128 a, __m128 b, const int imm8) BLENDPS xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_blend_ps(__m128 a, __m128 b, byte control)
            => Blend(a,b,control);

        /// <summary> __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128 imm8</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_blend_epi16(__m128i a, __m128i b, byte control)
            => Blend(v16u(a),v16u(b),control);

        /// <summary> __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_blendv_epi8(__m128i a, __m128i b, __m128i control)
            => BlendVariable(v8u(a),v8u(b),v8u(control));

        /// <summary> __m128 _mm_blendv_ps (__m128 a, __m128 b, __m128 mask) BLENDVPS xmm, xmm/m128, xmm0</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_blendv_ps(__m128 a, __m128 b, __m128 control)
            => BlendVariable(a,b,control);

        /// <summary> __m128d _mm_blendv_pd (__m128d a, __m128d b, __m128d mask) BLENDVPD xmm, xmm/m128, xmm0</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_blendv_pd(__m128d a, __m128d b, __m128d control)
            => BlendVariable(a,b,control);
        
        /// <summary> __m128d _mm_ceil_pd (__m128d a) ROUNDPD xmm, xmm/m128, imm8(10)</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_ceil_pd(__m128d a)
            => Ceiling(a);

        /// <summary> __m128 _mm_ceil_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(10)</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_ceil_ps(__m128 a)
            => Ceiling(a);

        /// <summary> __m128d _mm_ceil_sd (__m128d a) ROUNDSD xmm, xmm/m128, imm8(10)</summary> 
        [MethodImpl(Inline)]
        public static __m128d _mm_ceil_sd(__m128d a)
            => CeilingScalar(a);

        /// <summary> __m128d _mm_ceil_sd (__m128d a, __m128d b) ROUNDSD xmm, xmm/m128, imm8(10)</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_ceil_sd(__m128d a, __m128d b)
            => CeilingScalar(a,b);

        /// <summary> __m128 _mm_ceil_ss (__m128 a) ROUNDSD xmm, xmm/m128, imm8(10)</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_ceil_ss(__m128 a)
            => CeilingScalar(a);

        /// <summary> __m128 _mm_ceil_ss (__m128 a, __m128 b) ROUNDSS xmm, xmm/m128, imm8(10)</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_ceil_ss(__m128 a, __m128 b)
            => CeilingScalar(a,b);

        /// <summary> __m128d _mm_floor_pd (__m128d a) ROUNDPD xmm, xmm/m128, imm8(9)</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_floor_pd(__m128d a)
            => Floor(a);

        /// <summary> __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_floor_ps(__m128 a)
            => Floor(a);

        /// <summary> __m128d _mm_floor_sd (__m128d a) ROUNDSD xmm, xmm/m128, imm8(9)</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_floor_sd(__m128d a)
            => FloorScalar(a);

        /// <summary> __m128d _mm_floor_sd (__m128d a, __m128d b) ROUNDSD xmm, xmm/m128, imm8(9)</summary>
        [MethodImpl(Inline)]
        public static __m128d _mm_floor_sd(__m128d a, __m128d b)
            => FloorScalar(a,b);

        /// <summary> __m128 _mm_floor_ss (__m128 a) ROUNDSS xmm, xmm/m128, imm8(9)</summary> 
        [MethodImpl(Inline)]
        public static __m128 _mm_floor_ss(__m128 a)
            => FloorScalar(a);

        /// <summary> __m128 _mm_floor_ss (__m128 a, __m128 b) ROUNDSS xmm, xmm/m128, imm8(9)</summary>
        [MethodImpl(Inline)]
        public static __m128 _mm_floor_ss(__m128 a, __m128 b)
            => FloorScalar(a,b);

        /// <summary> __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static __m128i _mm_cmpeq_epi64(__m128i a, __m128i b)
            => CompareEqual(v64u(a),v64u(b));

        /// <summary> __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepu8_epi16(__m128i a)
            => ConvertToVector128Int16(v8u(a));

        /// <summary> __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepu8_epi16(ref byte address)
            => ConvertToVector128Int16(refptr(ref address));

        /// <summary> __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepu8_epi32(__m128i a)
            => ConvertToVector128Int32(v8u(a));

        /// <summary> __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepu8_epi32(ref byte address)
            => ConvertToVector128Int32(refptr(ref address));

        /// <summary> __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm, xmm/m16</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepu8_epi64(__m128i a)
            => ConvertToVector128Int64(v8u(a));

        /// <summary> __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm, xmm/m16</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepu8_epi64(ref byte address)
            => ConvertToVector128Int64(refptr(ref address));

        /// <summary> __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepi8_epi16(__m128i a)
            => ConvertToVector128Int16(v8i(a));

        /// <summary> __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepi8_epi64(__m128i a)
            => ConvertToVector128Int64(v8i(a));

        /// <summary> __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepi8_epi16(ref sbyte address)
            => ConvertToVector128Int16(refptr(ref address));

        /// <summary> __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepi8_epi32(__m128i a)
            => ConvertToVector128Int32(v8i(a));

        /// <summary> __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepi16_epi32(__m128i a)
            => ConvertToVector128Int32(v16i(a));

        /// <summary> __m128i _mm_cvtepi16_epi64 (__m128i a) PMOVSXWD xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepi16_epi64(ref short address)
            => ConvertToVector128Int64(refptr(ref address));

        /// <summary> __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepi16_epi32(ref short address)
            => ConvertToVector128Int32(refptr(ref address));

        /// <summary> __m128i _mm_cvtepi16_epi64 (__m128i a) PMOVSXWQ xmm, xmm/m32</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepi16_epi64(__m128i a)
            => ConvertToVector128Int64(v16i(a));

        /// <summary> __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepu16_epi32(__m128i a)
            => ConvertToVector128Int32(v16u(a));
        
        /// <summary> __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepu16_epi64(ref ushort address)
            => ConvertToVector128Int64(refptr(ref address));

        /// <summary> __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepu16_epi64(__m128i a)
            => ConvertToVector128Int64(v16u(a));
        
        /// <summary> __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepi32_epi64(__m128i a)
            => ConvertToVector128Int64(v16i(a));

        /// <summary> __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepi32_epi64(ref int address)
            => ConvertToVector128Int64(refptr(ref address));

        /// <summary> __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static __m128i _mm_cvtepu32_epi64(__m128i a)
            => ConvertToVector128Int64(v32u(a));

        /// <summary> __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64</summary> 
        [MethodImpl(Inline)]
        public static unsafe __m128i _mm_cvtepu32_epi64(ref uint address)
            => ConvertToVector128Int64(refptr(ref address));        

        /// <summary> __m128d _mm_dp_pd (__m128d a, __m128d b, const int imm8) DPPD xmm, xmm/m128, imm8</summary> 
        [MethodImpl(Inline)]
        public static __m128d _mm_dp_pd(__m128d a, __m128d b, byte imm8)
            => DotProduct(a,b, imm8);

        /// <summary> __m128 _mm_dp_ps (__m128 a, __m128 b, const int imm8) DPPS xmm, xmm/m128, imm8</summary> 
        [MethodImpl(Inline)]
        public static __m128 _mm_dp_ps(__m128 a, __m128 b, byte imm8)
            => DotProduct(a,b, imm8);

        /// <summary> int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8</summary> 
        [MethodImpl(Inline)]
        public static int _mm_extract_epi8(__m128i a, byte index)
            => Extract(v8u(a), index);

        /// <summary> int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8</summary> 
        [MethodImpl(Inline)]
        public static int _mm_extract_epi32(__m128i a, byte index)
            => Extract(v32i(a), index);

        /// <summary> __int64 _mm_extract_epi64 (__m128i a, const int imm8) PEXTRQ reg/m64, xmm, imm8
        [MethodImpl(Inline)]
        public static long _mm_extract_epi64(__m128i a, byte index)
            => Extract(v64i(a), index);

        /// <summary> int _mm_extract_ps (__m128 a, const int imm8) EXTRACTPS xmm, xmm/m32, imm8</summary> 
        [MethodImpl(Inline)]
        public static float _mm_extract_ps(__m128 a, byte index)
            => Extract(a, index);

        /// <summary> __m128i _mm_max_epi32 (__m128i a, __m128i b) PMAXSD xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128i _mm_max_epi32(__m128i a, __m128i b)
            => Max(v32i(a), v32i(b));

        /// <summary> __m128i _mm_max_epi8 (__m128i a, __m128i b) PMAXSB xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128i _mm_max_epi8(__m128i a, __m128i b)
            => Max(v8i(a), v8i(b));

        /// <summary> __m128i _mm_max_epu16 (__m128i a, __m128i b) PMAXUW xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128i _mm_max_epu16(__m128i a, __m128i b)
            => Max(v16u(a), v16u(b));

        /// <summary> __m128i _mm_max_epu32 (__m128i a, __m128i b) PMAXUD xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128i _mm_max_epu32(__m128i a, __m128i b)
            => Max(v32u(a), v32u(b));

        #if false




        #endif


    }

/*



        /// <summary> __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8) PINSRB xmm, reg/m8, imm8
        [MethodImpl(Inline)]
        public static Vector128<byte> Insert(Vector128<byte> value, byte data, byte index);

        /// <summary> __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, imm8
        [MethodImpl(Inline)]
        public static Vector128<int> Insert(Vector128<int> value, int data, byte index);

        /// <summary> __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8) PINSRB xmm, reg/m8, imm8
        [MethodImpl(Inline)]
        public static Vector128<sbyte> Insert(Vector128<sbyte> value, sbyte data, byte index);

        /// <summary> __m128 _mm_insert_ps (__m128 a, __m128 b, const int imm8) INSERTPS xmm, xmm/m32, imm8
        [MethodImpl(Inline)]
        public static __m128 Insert(__m128 value, __m128 data, byte index);

        /// <summary> __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, imm8
        [MethodImpl(Inline)]
        public static Vector128<uint> Insert(Vector128<uint> value, uint data, byte index);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static __m128i LoadAlignedVector128NonTemporal(ref short address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<uint> LoadAlignedVector128NonTemporal(ref int address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<sbyte> LoadAlignedVector128NonTemporal(ref byte address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<ulong> LoadAlignedVector128NonTemporal(ref long address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<int> LoadAlignedVector128NonTemporal(ref int address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<byte> LoadAlignedVector128NonTemporal(ref byte address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<long> LoadAlignedVector128NonTemporal(ref long address);

        /// <summary> __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        [MethodImpl(Inline)]
        public static Vector128<short> LoadAlignedVector128NonTemporal(ref short address);


        /// <summary> __m128i _mm_min_epi32 (__m128i a, __m128i b) PMINSD xmm, xmm/m128
        [MethodImpl(Inline)]
        public static Vector128<int> Min(Vector128<int> a, Vector128<int> b);

        /// <summary> __m128i _mm_min_epi8 (__m128i a, __m128i b) PMINSB xmm, xmm/m128
        [MethodImpl(Inline)]
        public static Vector128<sbyte> Min(Vector128<sbyte> a, Vector128<sbyte> b);

        /// <summary> __m128i _mm_min_epu16 (__m128i a, __m128i b) PMINUW xmm, xmm/m128
        [MethodImpl(Inline)]
        public static Vector128<ushort> Min(Vector128<ushort> a, Vector128<ushort> b);

        /// <summary> __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        [MethodImpl(Inline)]
        public static Vector128<uint> Min(Vector128<uint> a, Vector128<uint> b);

        /// <summary> __m128i _mm_minpos_epu16 (__m128i a) PHMINPOSUW xmm, xmm/m128
        [MethodImpl(Inline)]
        public static Vector128<ushort> MinHorizontal(Vector128<ushort> a);

        /// <summary> __m128i _mm_mpsadbw_epu8 (__m128i a, __m128i b, const int imm8) MPSADBW xmm, xmm/m128, imm8
        public static Vector128<ushort> MultipleSumAbsoluteDifferences(Vector128<byte> a, Vector128<byte> right, byte mask);

        /// <summary> __m128i _mm_mul_epi32 (__m128i a, __m128i b) PMULDQ xmm, xmm/m128
        public static Vector128<long> Multiply(Vector128<int> a, Vector128<int> b);

        /// <summary> __m128i _mm_mullo_epi32 (__m128i a, __m128i b) PMULLD xmm, xmm/m128
        public static Vector128<int> MultiplyLow(Vector128<int> a, Vector128<int> b);

        /// <summary> __m128i _mm_mullo_epi32 (__m128i a, __m128i b) PMULLD xmm, xmm/m128
        public static Vector128<uint> MultiplyLow(Vector128<uint> a, Vector128<uint> b);

        /// <summary> __m128i _mm_packus_epi32 (__m128i a, __m128i b) PACKUSDW xmm, xmm/m128
        public static Vector128<ushort> PackUnsignedSaturate(Vector128<int> a, Vector128<int> b);

        /// <summary> _MM_FROUND_CUR_DIRECTION; ROUNDPD xmm, xmm/m128, imm8(4)
        public static __m128d RoundCurrentDirection(__m128d a);
        
        /// <summary> _MM_FROUND_CUR_DIRECTION; ROUNDPS xmm, xmm/m128, imm8(4)
        public static __m128 RoundCurrentDirection(__m128 a);

        /// <summary> __m128d _mm_round_sd (__m128d a, _MM_FROUND_CUR_DIRECTION) ROUNDSD xmm, xmm/m128, imm8(4)
        public static __m128d RoundCurrentDirectionScalar(__m128d a);

        /// <summary> __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_CUR_DIRECTION) ROUNDSD
        /// <summary> xmm, xmm/m128, imm8(4)
        public static __m128d RoundCurrentDirectionScalar(__m128d upper, __m128d a);

        /// <summary> __m128 _mm_round_ss (__m128 a, _MM_FROUND_CUR_DIRECTION) ROUNDSS xmm, xmm/m128, imm8(4) 
        public static __m128 RoundCurrentDirectionScalar(__m128 a);

        /// <summary> __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_CUR_DIRECTION) ROUNDSS xmm, xmm/m128, imm8(4)
        public static __m128 RoundCurrentDirectionScalar(__m128 upper, __m128 a);
        //
        
        /// <summary> __m128d _mm_round_pd (__m128d a, int rounding) ROUNDPD xmm, xmm/m128, imm8(8)
        /// <summary> _MM_FROUND_TO_NEAREST_INT |_MM_FROUND_NO_EXC
        public static __m128d RoundToNearestInteger(__m128d a);
        //
        
        /// <summary> __m128 _mm_round_ps (__m128 a, int rounding) ROUNDPS xmm, xmm/m128, imm8(8) _MM_FROUND_TO_NEAREST_INT
        /// <summary> |_MM_FROUND_NO_EXC
        public static __m128 RoundToNearestInteger(__m128 a);
        //
        
        /// <summary> __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC)
        /// <summary> ROUNDSS xmm, xmm/m128, imm8(8)
        public static __m128 RoundToNearestIntegerScalar(__m128 upper, __m128 a);
        //
        
        /// <summary> __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC)
        /// <summary> ROUNDSS xmm, xmm/m128, imm8(8) The above native signature does not exist. We
        /// <summary> provide this additional overload for the recommended use case of this intrinsic.
        public static __m128 RoundToNearestIntegerScalar(__m128 a);
        //
        
        /// <summary> __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_NEAREST_INT |_MM_FROUND_NO_EXC)
        /// <summary> ROUNDSD xmm, xmm/m128, imm8(8) The above native signature does not exist. We
        /// <summary> provide this additional overload for the recommended use case of this intrinsic.
        public static __m128d RoundToNearestIntegerScalar(__m128d a);
        //
        
        /// <summary> __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_NEAREST_INT |_MM_FROUND_NO_EXC)
        /// <summary> ROUNDSD xmm, xmm/m128, imm8(8)
        public static __m128d RoundToNearestIntegerScalar(__m128d upper, __m128d a);

        /// <summary> _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC; ROUNDPD xmm, xmm/m128, imm8(9)
        public static __m128d RoundToNegativeInfinity(__m128d a);

        /// <summary> _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC; ROUNDPS xmm, xmm/m128, imm8(9)
        public static __m128 RoundToNegativeInfinity(__m128 a);

        /// <summary> __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC) ROUNDSD
        /// <summary> xmm, xmm/m128, imm8(9) The above native signature does not exist. We provide
        /// <summary> this additional overload for the recommended use case of this intrinsic.
        public static __m128d RoundToNegativeInfinityScalar(__m128d a);

        /// <summary> __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC)
        /// <summary> ROUNDSD xmm, xmm/m128, imm8(9)
        public static __m128d RoundToNegativeInfinityScalar(__m128d upper, __m128d a);
        //
        
        /// <summary> __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC) ROUNDSS
        /// <summary> xmm, xmm/m128, imm8(9) The above native signature does not exist. We provide
        /// <summary> this additional overload for the recommended use case of this intrinsic.
        public static __m128 RoundToNegativeInfinityScalar(__m128 a);

        /// <summary> __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC) ROUNDSS xmm, xmm/m128, imm8(9)
        public static __m128 RoundToNegativeInfinityScalar(__m128 upper, __m128 a);

        /// <summary> _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC; ROUNDPS xmm, xmm/m128, imm8(10)
        public static __m128 RoundToPositiveInfinity(__m128 a);

        /// <summary> _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC; ROUNDPD xmm, xmm/m128, imm8(10)
        public static __m128d RoundToPositiveInfinity(__m128d a);

        /// <summary> __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC) ROUNDSD
        /// <summary> xmm, xmm/m128, imm8(10) The above native signature does not exist. We provide
        /// <summary> this additional overload for the recommended use case of this intrinsic.
        public static __m128d RoundToPositiveInfinityScalar(__m128d a);

        /// <summary> __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC)
        /// <summary> ROUNDSD xmm, xmm/m128, imm8(10)
        public static __m128d RoundToPositiveInfinityScalar(__m128d upper, __m128d a);

        /// <summary> __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) ROUNDSS
        /// <summary> xmm, xmm/m128, imm8(10) 
        public static __m128 RoundToPositiveInfinityScalar(__m128 a);

        /// <summary> __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) ROUNDSS xmm, xmm/m128, imm8(10)
        public static __m128 RoundToPositiveInfinityScalar(__m128 upper, __m128 a);

        /// <summary> _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC; ROUNDPD xmm, xmm/m128, imm8(11)
        public static __m128d RoundToZero(__m128d a);

        /// <summary> _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC; ROUNDPS xmm, xmm/m128, imm8(11)
        public static __m128 RoundToZero(__m128 a);

        /// <summary> __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC) ROUNDSD xmm, xmm/m128, imm8(11)
        public static __m128d RoundToZeroScalar(__m128d a);

        /// <summary> __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC) ROUNDSD xmm, xmm/m128, imm8(11)
        public static __m128d RoundToZeroScalar(__m128d upper, __m128d a);

        /// <summary> __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) ROUNDSS xmm, xmm/m128, imm8(11)
        public static __m128 RoundToZeroScalar(__m128 a);
 
        /// <summary> __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) ROUNDSS xmm, xmm/m128, imm8(11)
        public static __m128 RoundToZeroScalar(__m128 upper, __m128 a);
 

        public abstract class X64 : Sse2.X64
        {
            public static bool IsSupported { get; }

 
            /// <summary> __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64, imm8 
            public static Vector128<long> Insert(Vector128<long> value, long data, byte index);

            /// <summary> __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64,imm8 
            public static Vector128<ulong> Insert(Vector128<ulong> value, ulong data, byte index);
        }
    }

 */

}