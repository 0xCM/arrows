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
    
    using static zfunc;    

    partial class x86
    {
        ///<intrinsic>int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static bool _mm_testz_si128(in __m128i a, in __m128i b)
            => TestZ(v64i(a),v64i(b));        

    }

/*

        //     __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        public static Vector128<double> Blend(Vector128<double> left, Vector128<double> right, byte control);

        //     __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128 imm8
        public static Vector128<short> Blend(Vector128<short> left, Vector128<short> right, byte control);

        //     __m128 _mm_blend_ps (__m128 a, __m128 b, const int imm8) BLENDPS xmm, xmm/m128, imm8
        public static Vector128<float> Blend(Vector128<float> left, Vector128<float> right, byte control);

        //     __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128 imm8
        public static Vector128<ushort> Blend(Vector128<ushort> left, Vector128<ushort> right, byte control);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        public static Vector128<byte> BlendVariable(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask);

        //     __m128d _mm_blendv_pd (__m128d a, __m128d b, __m128d mask) BLENDVPD xmm, xmm/m128, xmm0
        public static Vector128<double> BlendVariable(Vector128<double> left, Vector128<double> right, Vector128<double> mask);
        
        // This intrinsic generates PBLENDVB that needs a BYTE mask-vector, so users should correctly set each mask byte for the selected elements.
        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm 
        public static Vector128<short> BlendVariable(Vector128<short> left, Vector128<short> right, Vector128<short> mask);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128,
        //     xmm This intrinsic generates PBLENDVB that needs a BYTE mask-vector, so users
        //     should correctly set each mask byte for the selected elements.
        public static Vector128<int> BlendVariable(Vector128<int> left, Vector128<int> right, Vector128<int> mask);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128,xmm 
        public static Vector128<long> BlendVariable(Vector128<long> left, Vector128<long> right, Vector128<long> mask);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        public static Vector128<sbyte> BlendVariable(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask);

        //     __m128 _mm_blendv_ps (__m128 a, __m128 b, __m128 mask) BLENDVPS xmm, xmm/m128, xmm0
        public static Vector128<float> BlendVariable(Vector128<float> left, Vector128<float> right, Vector128<float> mask);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm 
        public static Vector128<ushort> BlendVariable(Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> mask);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm 
        public static Vector128<uint> BlendVariable(Vector128<uint> left, Vector128<uint> right, Vector128<uint> mask);

        //     __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm 
        public static Vector128<ulong> BlendVariable(Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> mask);

        //     __m128d _mm_ceil_pd (__m128d a) ROUNDPD xmm, xmm/m128, imm8(10)
        public static Vector128<double> Ceiling(Vector128<double> value);

        //     __m128 _mm_ceil_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(10)
        public static Vector128<float> Ceiling(Vector128<float> value);

        //     __m128d _mm_ceil_sd (__m128d a) ROUNDSD xmm, xmm/m128, imm8(10) The above native
        //     signature does not exist. We provide this additional overload for the recommended
        //     use case of this intrinsic.
        public static Vector128<double> CeilingScalar(Vector128<double> value);

        //     __m128d _mm_ceil_sd (__m128d a, __m128d b) ROUNDSD xmm, xmm/m128, imm8(10)
        public static Vector128<double> CeilingScalar(Vector128<double> upper, Vector128<double> value);

        //     __m128 _mm_ceil_ss (__m128 a) ROUNDSD xmm, xmm/m128, imm8(10) The above native
        //     signature does not exist. We provide this additional overload for the recommended
        //     use case of this intrinsic.
        public static Vector128<float> CeilingScalar(Vector128<float> value);

        //     __m128 _mm_ceil_ss (__m128 a, __m128 b) ROUNDSS xmm, xmm/m128, imm8(10)
        public static Vector128<float> CeilingScalar(Vector128<float> upper, Vector128<float> value);

        //     __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right);

        //     __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right);
        public static Vector128<short> ConvertToVector128Int16(byte* address);

        //     __m128i _mm_cvtepu8_epi16 (__m128i a) PMOVZXBW xmm, xmm/m64
        public static Vector128<short> ConvertToVector128Int16(Vector128<byte> value);

        //     __m128i _mm_cvtepi8_epi16 (__m128i a) PMOVSXBW xmm, xmm/m64
        public static Vector128<short> ConvertToVector128Int16(Vector128<sbyte> value);
        public static Vector128<short> ConvertToVector128Int16(sbyte* address);

        //     __m128i _mm_cvtepu16_epi32 (__m128i a) PMOVZXWD xmm, xmm/m64
        public static Vector128<int> ConvertToVector128Int32(Vector128<ushort> value);
        public static Vector128<int> ConvertToVector128Int32(sbyte* address);

        //     __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        public static Vector128<int> ConvertToVector128Int32(Vector128<sbyte> value);
        public static Vector128<int> ConvertToVector128Int32(ushort* address);

        //     __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        public static Vector128<int> ConvertToVector128Int32(Vector128<byte> value);
        public static Vector128<int> ConvertToVector128Int32(short* address);
        public static Vector128<int> ConvertToVector128Int32(byte* address);

        //     __m128i _mm_cvtepi16_epi32 (__m128i a) PMOVSXWD xmm, xmm/m64
        public static Vector128<int> ConvertToVector128Int32(Vector128<short> value);
        public static Vector128<long> ConvertToVector128Int64(uint* address);
        public static Vector128<long> ConvertToVector128Int64(ushort* address);
        public static Vector128<long> ConvertToVector128Int64(sbyte* address);

        //     __m128i _mm_cvtepu32_epi64 (__m128i a) PMOVZXDQ xmm, xmm/m64
        public static Vector128<long> ConvertToVector128Int64(Vector128<uint> value);

        //     __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32
        public static Vector128<long> ConvertToVector128Int64(Vector128<ushort> value);

        //     __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16
        public static Vector128<long> ConvertToVector128Int64(Vector128<sbyte> value);

        //     __m128i _mm_cvtepi16_epi64 (__m128i a) PMOVSXWQ xmm, xmm/m32
        public static Vector128<long> ConvertToVector128Int64(Vector128<short> value);

        //     __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm, xmm/m16
        public static Vector128<long> ConvertToVector128Int64(Vector128<byte> value);
        public static Vector128<long> ConvertToVector128Int64(int* address);
        public static Vector128<long> ConvertToVector128Int64(short* address);
        public static Vector128<long> ConvertToVector128Int64(byte* address);

        //     __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        public static Vector128<long> ConvertToVector128Int64(Vector128<int> value);

        //     __m128d _mm_dp_pd (__m128d a, __m128d b, const int imm8) DPPD xmm, xmm/m128, imm8
        public static Vector128<double> DotProduct(Vector128<double> left, Vector128<double> right, byte control);

        //     __m128 _mm_dp_ps (__m128 a, __m128 b, const int imm8) DPPS xmm, xmm/m128, imm8
        public static Vector128<float> DotProduct(Vector128<float> left, Vector128<float> right, byte control);

        //     int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        public static uint Extract(Vector128<uint> value, byte index);

        //     int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        public static byte Extract(Vector128<byte> value, byte index);

        //     int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        public static int Extract(Vector128<int> value, byte index);

        //     int _mm_extract_ps (__m128 a, const int imm8) EXTRACTPS xmm, xmm/m32, imm8
        public static float Extract(Vector128<float> value, byte index);

        //     __m128d _mm_floor_pd (__m128d a) ROUNDPD xmm, xmm/m128, imm8(9)
        public static Vector128<double> Floor(Vector128<double> value);

        //     __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        public static Vector128<float> Floor(Vector128<float> value);

        //     __m128d _mm_floor_sd (__m128d a) ROUNDSD xmm, xmm/m128, imm8(9) The above native
        //     signature does not exist. We provide this additional overload for the recommended
        //     use case of this intrinsic.
        public static Vector128<double> FloorScalar(Vector128<double> value);

        //     __m128d _mm_floor_sd (__m128d a, __m128d b) ROUNDSD xmm, xmm/m128, imm8(9)
        public static Vector128<double> FloorScalar(Vector128<double> upper, Vector128<double> value);

        //     __m128 _mm_floor_ss (__m128 a) ROUNDSS xmm, xmm/m128, imm8(9) The above native
        //     signature does not exist. We provide this additional overload for the recommended
        //     use case of this intrinsic.
        public static Vector128<float> FloorScalar(Vector128<float> value);

        //     __m128 _mm_floor_ss (__m128 a, __m128 b) ROUNDSS xmm, xmm/m128, imm8(9)
        public static Vector128<float> FloorScalar(Vector128<float> upper, Vector128<float> value);

        //     __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8) PINSRB xmm, reg/m8, imm8
        public static Vector128<byte> Insert(Vector128<byte> value, byte data, byte index);

        //     __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, imm8
        public static Vector128<int> Insert(Vector128<int> value, int data, byte index);

        //     __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8) PINSRB xmm, reg/m8, imm8
        public static Vector128<sbyte> Insert(Vector128<sbyte> value, sbyte data, byte index);

        //     __m128 _mm_insert_ps (__m128 a, __m128 b, const int imm8) INSERTPS xmm, xmm/m32, imm8
        public static Vector128<float> Insert(Vector128<float> value, Vector128<float> data, byte index);

        //     __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, imm8
        public static Vector128<uint> Insert(Vector128<uint> value, uint data, byte index);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<ushort> LoadAlignedVector128NonTemporal(ushort* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<uint> LoadAlignedVector128NonTemporal(uint* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<sbyte> LoadAlignedVector128NonTemporal(sbyte* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<ulong> LoadAlignedVector128NonTemporal(ulong* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<int> LoadAlignedVector128NonTemporal(int* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<byte> LoadAlignedVector128NonTemporal(byte* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<long> LoadAlignedVector128NonTemporal(long* address);

        //     __m128i _mm_stream_load_si128 (const __m128i* mem_addr) MOVNTDQA xmm, m128
        public static Vector128<short> LoadAlignedVector128NonTemporal(short* address);

        //     __m128i _mm_max_epi32 (__m128i a, __m128i b) PMAXSD xmm, xmm/m128
        public static Vector128<int> Max(Vector128<int> left, Vector128<int> right);

        //     __m128i _mm_max_epi8 (__m128i a, __m128i b) PMAXSB xmm, xmm/m128
        public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right);

        //     __m128i _mm_max_epu16 (__m128i a, __m128i b) PMAXUW xmm, xmm/m128
        public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right);

        //     __m128i _mm_max_epu32 (__m128i a, __m128i b) PMAXUD xmm, xmm/m128
        public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right);

        //     __m128i _mm_min_epi32 (__m128i a, __m128i b) PMINSD xmm, xmm/m128
        public static Vector128<int> Min(Vector128<int> left, Vector128<int> right);

        //     __m128i _mm_min_epi8 (__m128i a, __m128i b) PMINSB xmm, xmm/m128
        public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right);

        //     __m128i _mm_min_epu16 (__m128i a, __m128i b) PMINUW xmm, xmm/m128
        public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right);

        //     __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right);

        //     __m128i _mm_minpos_epu16 (__m128i a) PHMINPOSUW xmm, xmm/m128
        public static Vector128<ushort> MinHorizontal(Vector128<ushort> value);

        //     __m128i _mm_mpsadbw_epu8 (__m128i a, __m128i b, const int imm8) MPSADBW xmm, xmm/m128, imm8
        public static Vector128<ushort> MultipleSumAbsoluteDifferences(Vector128<byte> left, Vector128<byte> right, byte mask);

        //     __m128i _mm_mul_epi32 (__m128i a, __m128i b) PMULDQ xmm, xmm/m128
        public static Vector128<long> Multiply(Vector128<int> left, Vector128<int> right);

        //     __m128i _mm_mullo_epi32 (__m128i a, __m128i b) PMULLD xmm, xmm/m128
        public static Vector128<int> MultiplyLow(Vector128<int> left, Vector128<int> right);

        //     __m128i _mm_mullo_epi32 (__m128i a, __m128i b) PMULLD xmm, xmm/m128
        public static Vector128<uint> MultiplyLow(Vector128<uint> left, Vector128<uint> right);

        //     __m128i _mm_packus_epi32 (__m128i a, __m128i b) PACKUSDW xmm, xmm/m128
        public static Vector128<ushort> PackUnsignedSaturate(Vector128<int> left, Vector128<int> right);

        //     _MM_FROUND_CUR_DIRECTION; ROUNDPD xmm, xmm/m128, imm8(4)
        public static Vector128<double> RoundCurrentDirection(Vector128<double> value);
        //
        // Summary:
        //     _MM_FROUND_CUR_DIRECTION; ROUNDPS xmm, xmm/m128, imm8(4)
        public static Vector128<float> RoundCurrentDirection(Vector128<float> value);

        //     __m128d _mm_round_sd (__m128d a, _MM_FROUND_CUR_DIRECTION) ROUNDSD xmm, xmm/m128,
        //     imm8(4) The above native signature does not exist. We provide this additional
        //     overload for the recommended use case of this intrinsic.
        public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> value);

        //     __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_CUR_DIRECTION) ROUNDSD
        //     xmm, xmm/m128, imm8(4)
        public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> upper, Vector128<double> value);

        //     __m128 _mm_round_ss (__m128 a, _MM_FROUND_CUR_DIRECTION) ROUNDSS xmm, xmm/m128,
        //     imm8(4) The above native signature does not exist. We provide this additional
        //     overload for the recommended use case of this intrinsic.
        public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> value);

        //     __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_CUR_DIRECTION) ROUNDSS xmm, xmm/m128, imm8(4)
        public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> upper, Vector128<float> value);
        //
        // Summary:
        //     __m128d _mm_round_pd (__m128d a, int rounding) ROUNDPD xmm, xmm/m128, imm8(8)
        //     _MM_FROUND_TO_NEAREST_INT |_MM_FROUND_NO_EXC
        public static Vector128<double> RoundToNearestInteger(Vector128<double> value);
        //
        // Summary:
        //     __m128 _mm_round_ps (__m128 a, int rounding) ROUNDPS xmm, xmm/m128, imm8(8) _MM_FROUND_TO_NEAREST_INT
        //     |_MM_FROUND_NO_EXC
        public static Vector128<float> RoundToNearestInteger(Vector128<float> value);
        //
        // Summary:
        //     __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC)
        //     ROUNDSS xmm, xmm/m128, imm8(8)
        public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> upper, Vector128<float> value);
        //
        // Summary:
        //     __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC)
        //     ROUNDSS xmm, xmm/m128, imm8(8) The above native signature does not exist. We
        //     provide this additional overload for the recommended use case of this intrinsic.
        public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> value);
        //
        // Summary:
        //     __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_NEAREST_INT |_MM_FROUND_NO_EXC)
        //     ROUNDSD xmm, xmm/m128, imm8(8) The above native signature does not exist. We
        //     provide this additional overload for the recommended use case of this intrinsic.
        public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> value);
        //
        // Summary:
        //     __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_NEAREST_INT |_MM_FROUND_NO_EXC)
        //     ROUNDSD xmm, xmm/m128, imm8(8)
        public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> upper, Vector128<double> value);
        //
        // Summary:
        //     _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC; ROUNDPD xmm, xmm/m128, imm8(9)
        public static Vector128<double> RoundToNegativeInfinity(Vector128<double> value);
        //
        // Summary:
        //     _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC; ROUNDPS xmm, xmm/m128, imm8(9)
        public static Vector128<float> RoundToNegativeInfinity(Vector128<float> value);
        //
        // Summary:
        //     __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC) ROUNDSD
        //     xmm, xmm/m128, imm8(9) The above native signature does not exist. We provide
        //     this additional overload for the recommended use case of this intrinsic.
        public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> value);
        //
        // Summary:
        //     __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_NEG_INF |_MM_FROUND_NO_EXC)
        //     ROUNDSD xmm, xmm/m128, imm8(9)
        public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> upper, Vector128<double> value);
        //
        // Summary:
        //     __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC) ROUNDSS
        //     xmm, xmm/m128, imm8(9) The above native signature does not exist. We provide
        //     this additional overload for the recommended use case of this intrinsic.
        public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> value);

        //     __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC) ROUNDSS xmm, xmm/m128, imm8(9)
        public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> upper, Vector128<float> value);

        //     _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC; ROUNDPS xmm, xmm/m128, imm8(10)
        public static Vector128<float> RoundToPositiveInfinity(Vector128<float> value);

        //     _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC; ROUNDPD xmm, xmm/m128, imm8(10)
        public static Vector128<double> RoundToPositiveInfinity(Vector128<double> value);

        //     __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC) ROUNDSD
        //     xmm, xmm/m128, imm8(10) The above native signature does not exist. We provide
        //     this additional overload for the recommended use case of this intrinsic.
        public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> value);

        //     __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_POS_INF |_MM_FROUND_NO_EXC)
        //     ROUNDSD xmm, xmm/m128, imm8(10)
        public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> upper, Vector128<double> value);

        //     __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) ROUNDSS
        //     xmm, xmm/m128, imm8(10) The above native signature does not exist. We provide
        //     this additional overload for the recommended use case of this intrinsic.
        public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> value);

        //     __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC)
        //     ROUNDSS xmm, xmm/m128, imm8(10)
        public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> upper, Vector128<float> value);
        //
        // Summary:
        //     _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC; ROUNDPD xmm, xmm/m128, imm8(11)
        public static Vector128<double> RoundToZero(Vector128<double> value);

        //     _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC; ROUNDPS xmm, xmm/m128, imm8(11)
        public static Vector128<float> RoundToZero(Vector128<float> value);

        //     __m128d _mm_round_sd (__m128d a, _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC) ROUNDSD
        //     xmm, xmm/m128, imm8(11) The above native signature does not exist. We provide
        //     this additional overload for the recommended use case of this intrinsic.
        public static Vector128<double> RoundToZeroScalar(Vector128<double> value);

        //     __m128d _mm_round_sd (__m128d a, __m128d b, _MM_FROUND_TO_ZERO |_MM_FROUND_NO_EXC)
        //     ROUNDSD xmm, xmm/m128, imm8(11)
        public static Vector128<double> RoundToZeroScalar(Vector128<double> upper, Vector128<double> value);

        //     __m128 _mm_round_ss (__m128 a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) ROUNDSS
        //     xmm, xmm/m128, imm8(11) The above native signature does not exist. We provide
        //     this additional overload for the recommended use case of this intrinsic.
        public static Vector128<float> RoundToZeroScalar(Vector128<float> value);
 
        //     __m128 _mm_round_ss (__m128 a, __m128 b, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) ROUNDSS xmm, xmm/m128, imm8(11)
        public static Vector128<float> RoundToZeroScalar(Vector128<float> upper, Vector128<float> value);
        public static bool TestC(Vector128<uint> left, Vector128<uint> right);
        public static bool TestC(Vector128<ushort> left, Vector128<ushort> right);
 
        //     int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        public static bool TestC(Vector128<sbyte> left, Vector128<sbyte> right);
        public static bool TestC(Vector128<ulong> left, Vector128<ulong> right);
        public static bool TestC(Vector128<int> left, Vector128<int> right);
        public static bool TestC(Vector128<short> left, Vector128<short> right);
        public static bool TestC(Vector128<byte> left, Vector128<byte> right);
        public static bool TestC(Vector128<long> left, Vector128<long> right);
        public static bool TestNotZAndNotC(Vector128<uint> left, Vector128<uint> right);
        public static bool TestNotZAndNotC(Vector128<ushort> left, Vector128<ushort> right);
 
        //     int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        public static bool TestNotZAndNotC(Vector128<sbyte> left, Vector128<sbyte> right);
        public static bool TestNotZAndNotC(Vector128<ulong> left, Vector128<ulong> right);
        public static bool TestNotZAndNotC(Vector128<int> left, Vector128<int> right);
        public static bool TestNotZAndNotC(Vector128<short> left, Vector128<short> right);
        public static bool TestNotZAndNotC(Vector128<byte> left, Vector128<byte> right);
        public static bool TestNotZAndNotC(Vector128<long> left, Vector128<long> right);
        public static bool TestZ(Vector128<byte> left, Vector128<byte> right);
        public static bool TestZ(Vector128<short> left, Vector128<short> right);
        public static bool TestZ(Vector128<int> left, Vector128<int> right);
        public static bool TestZ(Vector128<long> left, Vector128<long> right);
 
        //     int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        public static bool TestZ(Vector128<sbyte> left, Vector128<sbyte> right);
        public static bool TestZ(Vector128<ushort> left, Vector128<ushort> right);
        public static bool TestZ(Vector128<uint> left, Vector128<uint> right);
        public static bool TestZ(Vector128<ulong> left, Vector128<ulong> right);

        public abstract class X64 : Sse2.X64
        {
            public static bool IsSupported { get; }

            //     __int64 _mm_extract_epi64 (__m128i a, const int imm8) PEXTRQ reg/m64, xmm, imm8
            public static long Extract(Vector128<long> value, byte index);
 
            //     __int64 _mm_extract_epi64 (__m128i a, const int imm8) PEXTRQ reg/m64, xmm, imm8
            public static ulong Extract(Vector128<ulong> value, byte index);
 
            //     __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64, imm8 
            public static Vector128<long> Insert(Vector128<long> value, long data, byte index);

            //     __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64,imm8 
            public static Vector128<ulong> Insert(Vector128<ulong> value, ulong data, byte index);
        }
    }

 */

}