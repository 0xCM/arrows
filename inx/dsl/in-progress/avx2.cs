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

    #pragma warning disable 626
    #if false
    partial class x86
    {
        //
        // Summary:
        //     __m256i _mm256_abs_epi8 (__m256i a) VPABSB ymm, ymm/m256
        public static m256i _mm256_abs_epi8(in m256i value);
        //
        // Summary:
        //     __m256i _mm256_abs_epi16 (__m256i a) VPABSW ymm, ymm/m256
        public static m256i _mm256_abs_epi16(in m256i value);
        //
        // Summary:
        //     __m256i _mm256_abs_epi32 (__m256i a) VPABSD ymm, ymm/m256
        public static m256i _mm256_abs_epi32(in m256i value);
        //
        // Summary:
        //     __m256i _mm256_add_epi64 (__m256i a, __m256i b) VPADDQ ymm, ymm, ymm/m256
        //public static m256i _mm256_add_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi32 (__m256i a, __m256i b) VPADDD ymm, ymm, ymm/m256
        public static m256i _mm256_add_epi32(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi16 (__m256i a, __m256i b) VPADDW ymm, ymm, ymm/m256
        public static m256i _mm256_add_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi8 (__m256i a, __m256i b) VPADDB ymm, ymm, ymm/m256
        public static m256i _mm256_add_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi64 (__m256i a, __m256i b) VPADDQ ymm, ymm, ymm/m256
        //public static m256i _mm256_add_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi16 (__m256i a, __m256i b) VPADDW ymm, ymm, ymm/m256
        //public static m256i _mm256_add_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi8 (__m256i a, __m256i b) VPADDB ymm, ymm, ymm/m256
        //public static m256i _mm256_add_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_add_epi32 (__m256i a, __m256i b) VPADDD ymm, ymm, ymm/m256
        //public static m256i _mm256_add_epi32(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_adds_epu8 (__m256i a, __m256i b) VPADDUSB ymm, ymm, ymm/m256
        public static m256i _mm256_adds_epu8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_adds_epi16 (__m256i a, __m256i b) VPADDSW ymm, ymm, ymm/m256
        public static m256i _mm256_adds_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_adds_epi8 (__m256i a, __m256i b) VPADDSB ymm, ymm, ymm/m256
        public static m256i _mm256_adds_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_adds_epu16 (__m256i a, __m256i b) VPADDUSW ymm, ymm, ymm/m256
        public static m256i _mm256_adds_epu16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count) VPALIGNR ymm,
        //     ymm, ymm/m256, imm8 This intrinsic generates VPALIGNR that operates over bytes
        //     rather than elements of the vectors.
        public static m256i _mm256_alignr_epi8(in m256i left, in m256i right, byte mask);
        //
        // Summary:
        //     __m256i _mm256_and_si256 (__m256i a, __m256i b) VPAND ymm, ymm, ymm/m256
        public static m256i _mm256_and_si256(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        public static m256i _mm256_andnot_si256(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_avg_epu8 (__m256i a, __m256i b) VPAVGB ymm, ymm, ymm/m256
        public static m256i _mm256_avg_epu8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_avg_epu16 (__m256i a, __m256i b) VPAVGW ymm, ymm, ymm/m256
        public static m256i _mm256_avg_epu16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm,
        //     xmm, xmm/m128, imm8
        public static m128i _mm_blend_epi32(in m128i left, in m128i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm,
        //     ymm, ymm/m256, imm8
        public static m256i _mm256_blend_epi16(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm,
        //     ymm, ymm/m256, imm8
        public static m256i _mm256_blend_epi32(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,
        //     ymm, ymm/m256, ymm This intrinsic generates VPBLENDVB that needs a BYTE mask-vector,
        //     so users should correctly set each mask byte for the selected elements.
        public static m256i _mm256_blendv_epi8(in m256i left, in m256i right, in m256i mask);
        //
        // Summary:
        //     __m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, in m64 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastq_epi64(ref ulong source);
        //
        // Summary:
        //     __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, xmm
        public static Vector128<ushort> _mm_broadcastw_epi16(Vector128<ushort> value);
        //
        // Summary:
        //     __m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, in m32 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastd_epi32(ref uint source);
        //
        // Summary:
        //     __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, in m16 The above native
        //     signature does not directly correspond to the managed signature.
        public static Vector128<ushort> BroadcastScalarToVector128(ref ushort source);
        //
        // Summary:
        //     __m128i _mm_broadcastb_epi8 (__m128i a) VPBROADCASTB xmm, in m8 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastb_epi8(ref sbyte source);
        //
        // Summary:
        //     __m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, xmm
        public static m128i _mm_broadcastq_epi64(in m128i value);
        //
        // Summary:
        //     __m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, xmm
        public static m128i _mm_broadcastd_epi32(in m128i value);
        //
        // Summary:
        //     __m128 _mm_broadcastss_ps (__m128 a) VBROADCASTSS xmm, xmm
        public static m128d _mm_broadcastss_ps(in m128d value);
        //
        // Summary:
        //     __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, in m16 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastw_epi16(ref short source);
        //
        // Summary:
        //     __m128i _mm_broadcastb_epi8 (__m128i a) VPBROADCASTB xmm, xmm
        public static m128i _mm_broadcastb_epi8(in m128i value);
        //
        // Summary:
        //     __m128i _mm_broadcastd_epi32 (__m128i a) VPBROADCASTD xmm, in m32 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastd_epi32(ref int source);
        //
        // Summary:
        //     __m128i _mm_broadcastq_epi64 (__m128i a) VPBROADCASTQ xmm, in m64 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastq_epi64(ref long source);
        //
        // Summary:
        //     __m128i _mm_broadcastb_epi8 (__m128i a) VPBROADCASTB xmm, in m8 The above native
        //     signature does not directly correspond to the managed signature.
        public static m128i _mm_broadcastb_epi8(ref byte source);
        //
        // Summary:
        //     __m128d _mm_broadcastsd_pd (__m128d a) VMOVDDUP xmm, xmm
        public static m128d _mm_broadcastsd_pd(in m128d value);
        //
        // Summary:
        //     __m128i _mm_broadcastw_epi16 (__m128i a) VPBROADCASTW xmm, xmm
        public static m128i _mm_broadcastw_epi16(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, in m64 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i _mm256_broadcastq_epi64(ref ulong source);
        //
        // Summary:
        //     __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, in m32 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref uint source);
        //
        // Summary:
        //     __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, in m16 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref ushort source);
        //
        // Summary:
        //     __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, in m8 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref sbyte source);
        //
        // Summary:
        //     __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, xmm
        public static m256i BroadcastScalarToVector256(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, xmm
        public static m256i BroadcastScalarToVector256(Vector128<ushort> value);
        //
        // Summary:
        //     __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, xmm
        public static m256i BroadcastScalarToVector256(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, xmm
        public static m256i BroadcastScalarToVector256(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, xmm
        public static m256i BroadcastScalarToVector256(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, xmm
        public static m256i BroadcastScalarToVector256(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, in m8 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref byte source);
        //
        // Summary:
        //     __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, in m16 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref short source);
        //
        // Summary:
        //     __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, in m32 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref int source);
        //
        // Summary:
        //     __m256 _mm256_broadcastss_ps (__m128 a) VBROADCASTSS ymm, xmm
        public static m256 BroadcastScalarToVector256(in m128d value);
        //
        // Summary:
        //     __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, xmm
        public static m256i _mm256_broadcastb_epi8(in m128i value);
        //
        // Summary:
        //     __m256d _mm256_broadcastsd_pd (__m128d a) VBROADCASTSD ymm, xmm
        public static m256d _mm256_broadcastsd_pd(in m128d value);
        //
        // Summary:
        //     __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, xmm
        public static m256i _mm256_broadcastw_epi16(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, in m64 The above native
        //     signature does not directly correspond to the managed signature.
        public static m256i BroadcastScalarToVector256(ref long source);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref byte address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref int address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref long address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref sbyte address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref ushort address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref uint address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref ulong address);
        //
        // Summary:
        //     __m256i _mm256_broadcastsi128_si256 (__m128i a) VBROADCASTI128 ymm, in m128 The
        //     above native signature does not directly correspond to the managed signature.
        public static m256i BroadcastVector128ToVector256(ref short address);
        //
        // Summary:
        //     __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        public static m256i CompareEqual(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        public static m256i _mm256_cmpeq_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        public static m256i _mm256_cmpeq_epi32(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        public static m256i CompareEqual(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        public static m256i CompareEqual(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        public static m256i CompareEqual(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpgt_epi16 (__m256i a, __m256i b) VPCMPGTW ymm, ymm, ymm/m256
        public static m256i CompareGreaterThan(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        public static m256i CompareGreaterThan(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        public static m256i CompareGreaterThan(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        public static m256i CompareGreaterThan(in m256i left, in m256i right);
        //
        // Summary:
        //     int _mm256_cvtsi256_si32 (__m256i a) MOVD reg/m32, xmm
        public static int _mm256_cvtsi256_si32(in m256i value)
            => ConvertToInt32(value);
        //
        // Summary:
        //     int _mm256_cvtsi256_si32 (__m256i a) MOVD reg/m32, xmm
        public static uint ConvertToUInt32(in m256i value);
        public static m256i ConvertToVector256Int16(ref byte address);
        public static m256i ConvertToVector256Int16(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        public static m256i _mm256_cvtepi8_epi16(in m128i value);
        public static m256i _mm256_cvtepi8_epi16(ref sbyte address);
        public static m256i _mm256_cvtepi16_epi32(ref ushort address);
        public static m256i _mm256_cvtepi8_epi32(ref sbyte address);
        public static m256i _mm256_cvtepi16_epi32(Vector128<ushort> value);
        public static m256i _mm256_cvtepi16_epi32(ref short address);
        //
        // Summary:
        //     __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        public static m256i _mm256_cvtepi16_epi32(in m128i value);
        public static m256i _mm256_cvtepi8_epi32(ref byte address);
        //
        // Summary:
        //     __m256i _mm256_cvtepi8_epi32 (__m128i a) VPMOVSXBD ymm, xmm/m128
        public static m256i _mm256_cvtepi8_epi32(in m128i value);
        public static m256i ConvertToVector256Int64(ref uint address);
        public static m256i _mm256_cvtepi16_epi64(ref ushort address);
        public static m256i _mm256_cvtepi8_epi64(ref sbyte address);
        public static m256i _mm256_cvtepi16_epi64(Vector128<ushort> value);
        //
        // Summary:
        //     __m256i _mm256_cvtepi16_epi64 (__m128i a) VPMOVSXWQ ymm, xmm/m128
        public static m256i _mm256_cvtepi16_epi64(in m128i value);
        //
        // Summary:
        //     __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        public static m256i _mm256_cvtepi32_epi64(in m128i value)
            => ConvertToVector256Int64(value);

        public static m256i _mm256_cvtepi8_epi64(ref byte address);
            => ConvertToVector256Int64(address);        

        public static m256i _mm256_cvtepi32_epi64(ref int address)
            => ConvertToVector256Int64(address);      

        public static m256i _mm256_cvtepi16_epi64(ref short address)
            => ConvertToVector256Int64(address);        

        //
        // Summary:
        //     __m256i _mm256_cvtepi8_epi64 (__m128i a) VPMOVSXBQ ymm, xmm/m128
        public static m256i ConvertToVector256Int64(in m128i value);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static Vector128<ushort> ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,
        //     ymm, imm8
        public static m128i ExtractVector128(in m256i value, byte index);
        //
        // Summary:
        //     __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref ulong baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i32gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERDQ xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref ulong baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm256_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m256i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm32y, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref uint baseAddress, in m256i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref uint baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref uint baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128 _mm256_mask_i64gather_ps (__m128 src, float const* base_addr, __m256i
        //     vindex, __m128 mask, const int scale) VGATHERQPS xmm, vm32y, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherMaskVector128(in m128d source, ref float baseAddress, in m256i index, in m128d mask, byte scale);
        //
        // Summary:
        //     __m128 _mm_mask_i64gather_ps (__m128 src, float const* base_addr, __m128i vindex,
        //     __m128 mask, const int scale) VGATHERQPS xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherMaskVector128(in m128d source, ref float baseAddress, in m128i index, in m128d mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref long baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i32gather_epi64 (__m128i src, __int64 const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERDQ xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref long baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm256_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m256i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm32y, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref int baseAddress, in m256i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref int baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i
        //     vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherMaskVector128(in m128i source, ref int baseAddress, in m128i index, in m128i mask, byte scale);
        //
        // Summary:
        //     __m128d _mm_mask_i64gather_pd (__m128d src, double const* base_addr, __m128i
        //     vindex, __m128d mask, const int scale) VGATHERQPD xmm, vm64x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherMaskVector128(in m128d source, ref double baseAddress, in m128i index, in m128d mask, byte scale);
        //
        // Summary:
        //     __m128d _mm_mask_i32gather_pd (__m128d src, double const* base_addr, __m128i
        //     vindex, __m128d mask, const int scale) VGATHERDPD xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherMaskVector128(in m128d source, ref double baseAddress, in m128i index, in m128d mask, byte scale);
        //
        // Summary:
        //     __m128 _mm_mask_i32gather_ps (__m128 src, float const* base_addr, __m128i vindex,
        //     __m128 mask, const int scale) VGATHERDPS xmm, vm32x, xmm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherMaskVector128(in m128d source, ref float baseAddress, in m128i index, in m128d mask, byte scale);
        //
        // Summary:
        //     __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i
        //     vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherMaskVector256(in m256i source, ref ulong baseAddress, in m256i index, in m256i mask, byte scale);
        //
        // Summary:
        //     __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i
        //     vindex, __m256i mask, const int scale) VPGATHERDQ ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherMaskVector256(in m256i source, ref ulong baseAddress, in m128i index, in m256i mask, byte scale);
        //
        // Summary:
        //     __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i
        //     vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherMaskVector256(in m256i source, ref uint baseAddress, in m256i index, in m256i mask, byte scale);
        //
        // Summary:
        //     __m256 _mm256_mask_i32gather_ps (__m256 src, float const* base_addr, __m256i
        //     vindex, __m256 mask, const int scale) VPGATHERDPS ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256 GatherMaskVector256(in m256 source, ref float baseAddress, in m256i index, in m256 mask, byte scale);
        //
        // Summary:
        //     __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i
        //     vindex, __m256i mask, const int scale) VPGATHERDQ ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherMaskVector256(in m256i source, ref long baseAddress, in m128i index, in m256i mask, byte scale);
        //
        // Summary:
        //     __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i
        //     vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherMaskVector256(in m256i source, ref int baseAddress, in m256i index, in m256i mask, byte scale);
        //
        // Summary:
        //     __m256d _mm256_mask_i64gather_pd (__m256d src, double const* base_addr, __m256i
        //     vindex, __m256d mask, const int scale) VGATHERQPD ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256d GatherMaskVector256(in m256d source, ref double baseAddress, in m256i index, in m256d mask, byte scale);
        //
        // Summary:
        //     __m256d _mm256_mask_i32gather_pd (__m256d src, double const* base_addr, __m128i
        //     vindex, __m256d mask, const int scale) VPGATHERDPD ymm, vm32y, ymm The scale
        //     parameter should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will
        //     be thrown.
        public static m256d GatherMaskVector256(in m256d source, ref double baseAddress, in m128i index, in m256d mask, byte scale);
        //
        // Summary:
        //     __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i
        //     vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm The scale parameter
        //     should be 1, 2, 4 or 8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherMaskVector256(in m256i source, ref long baseAddress, in m256i index, in m256i mask, byte scale);
        //
        // Summary:
        //     __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERQQ xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref ulong baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERDQ xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref ulong baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int
        //     scale) VPGATHERQD xmm, vm64y, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref uint baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int
        //     scale) VPGATHERQD xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref uint baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int
        //     scale) VPGATHERDD xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref uint baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128 _mm256_i64gather_ps (float const* base_addr, __m256i vindex, const int
        //     scale) VGATHERQPS xmm, vm64y, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherVector128(ref float baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m128 _mm_i64gather_ps (float const* base_addr, __m128i vindex, const int scale)
        //     VGATHERQPS xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or 8, otherwise,
        //     ArgumentOutOfRangeException will be thrown.
        public static m128d GatherVector128(ref float baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERQQ xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref long baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERDQ xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref long baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int
        //     scale) VPGATHERQD xmm, vm64y, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref int baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int
        //     scale) VPGATHERQD xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref int baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int
        //     scale) VPGATHERDD xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128i GatherVector128(ref int baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128d _mm_i64gather_pd (double const* base_addr, __m128i vindex, const int
        //     scale) VGATHERQPD xmm, vm64x, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherVector128(ref double baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128d _mm_i32gather_pd (double const* base_addr, __m128i vindex, const int
        //     scale) VGATHERDPD xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m128d GatherVector128(ref double baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m128 _mm_i32gather_ps (float const* base_addr, __m128i vindex, const int scale)
        //     VGATHERDPS xmm, vm32x, xmm The scale parameter should be 1, 2, 4 or 8, otherwise,
        //     ArgumentOutOfRangeException will be thrown.
        public static m128d GatherVector128(ref float baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const
        //     int scale) VPGATHERQQ ymm, vm64y, ymm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherVector256(ref ulong baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERDQ ymm, vm32y, ymm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherVector256(ref ulong baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int
        //     scale) VPGATHERDD ymm, vm32y, ymm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherVector256(ref uint baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m256 _mm256_i32gather_ps (float const* base_addr, __m256i vindex, const int
        //     scale) VGATHERDPS ymm, vm32y, ymm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256 GatherVector256(ref float baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const
        //     int scale) VPGATHERDQ ymm, vm32y, ymm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherVector256(ref long baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int
        //     scale) VPGATHERDD ymm, vm32y, ymm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherVector256(ref int baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m256d _mm256_i64gather_pd (double const* base_addr, __m256i vindex, const int
        //     scale) VGATHERQPD ymm, vm64y, ymm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256d GatherVector256(ref double baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m256d _mm256_i32gather_pd (double const* base_addr, __m128i vindex, const int
        //     scale) VGATHERDPD ymm, vm32y, ymm The scale parameter should be 1, 2, 4 or 8,
        //     otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256d GatherVector256(ref double baseAddress, in m128i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const
        //     int scale) VPGATHERQQ ymm, vm64y, ymm The scale parameter should be 1, 2, 4 or
        //     8, otherwise, ArgumentOutOfRangeException will be thrown.
        public static m256i GatherVector256(ref long baseAddress, in m256i index, byte scale);
        //
        // Summary:
        //     __m256i _mm256_hadd_epi16 (__m256i a, __m256i b) VPHADDW ymm, ymm, ymm/m256
        public static m256i HorizontalAdd(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_hadd_epi32 (__m256i a, __m256i b) VPHADDD ymm, ymm, ymm/m256
        public static m256i HorizontalAdd(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_hadds_epi16 (__m256i a, __m256i b) VPHADDSW ymm, ymm, ymm/m256
        public static m256i HorizontalAddSaturate(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_hsub_epi16 (__m256i a, __m256i b) VPHSUBW ymm, ymm, ymm/m256
        public static m256i HorizontalSubtract(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_hsub_epi32 (__m256i a, __m256i b) VPHSUBD ymm, ymm, ymm/m256
        public static m256i HorizontalSubtract(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_hsubs_epi16 (__m256i a, __m256i b) VPHSUBSW ymm, ymm, ymm/m256
        public static m256i HorizontalSubtractSaturate(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i InsertVector128(in m256i value, Vector128<ushort> data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i _mm256_inserti128_si256(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i _mm256_inserti128_si256(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128
        //     ymm, ymm, xmm, imm8
        public static m256i _mm256_inserti128_si256(in m256i value, in m128i data, byte index);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i _mm256_stream_load_si256(ref ulong address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i _mm256_stream_load_si256(ref ushort address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i _mm256_stream_load_si256(ref sbyte address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i LoadAlignedVector256NonTemporal(ref uint address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i LoadAlignedVector256NonTemporal(ref int address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i LoadAlignedVector256NonTemporal(ref short address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i LoadAlignedVector256NonTemporal(ref byte address);
        //
        // Summary:
        //     __m256i _mm256_stream_load_si256 (__m256i const* mem_addr) VMOVNTDQA ymm, in m256
        public static m256i LoadAlignedVector256NonTemporal(ref long address);
        //
        // Summary:
        //     __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm,
        //     xmm, in m128
        public static m128i MaskLoad(ref int address, in m128i mask);
        //
        // Summary:
        //     __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD
        //     ymm, ymm, in m256
        public static m256i MaskLoad(ref int address, in m256i mask);
        //
        // Summary:
        //     __m128i _mm_maskload_epi64 (__int64 const* mem_addr, __m128i mask) VPMASKMOVQ
        //     xmm, xmm, in m128
        public static m128i MaskLoad(ref long address, in m128i mask);
        //
        // Summary:
        //     __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ
        //     ymm, ymm, in m256
        public static m256i MaskLoad(ref long address, in m256i mask);
        //
        // Summary:
        //     __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm,
        //     xmm, in m128
        public static m128i MaskLoad(ref uint address, in m128i mask);
        //
        // Summary:
        //     __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD
        //     ymm, ymm, in m256
        public static m256i MaskLoad(ref uint address, in m256i mask);
        //
        // Summary:
        //     __m128i _mm_maskload_epi64 (__int64 const* mem_addr, __m128i mask) VPMASKMOVQ
        //     xmm, xmm, in m128
        public static m128i MaskLoad(ref ulong address, in m128i mask);
        //
        // Summary:
        //     __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ
        //     ymm, ymm, in m256
        public static m256i MaskLoad(ref ulong address, in m256i mask);
        //
        // Summary:
        //     void _mm_maskstore_epi64 (__int64* mem_addr, __m128i mask, __m128i a) VPMASKMOVQ
        //     m128, xmm, xmm
        public static void MaskStore(ref ulong address, in m128i mask, in m128i source);
        //
        // Summary:
        //     void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ
        //     m256, ymm, ymm
        public static void MaskStore(ref ulong address, in m256i mask, in m256i source);
        //
        // Summary:
        //     void _mm256_maskstore_epi32 (ref int mem_addr, __m256i mask, __m256i a) VPMASKMOVD
        //     m256, ymm, ymm
        public static void MaskStore(ref uint address, in m256i mask, in m256i source);
        //
        // Summary:
        //     void _mm256_maskstore_epi32 (ref int mem_addr, __m256i mask, __m256i a) VPMASKMOVD
        //     m256, ymm, ymm
        public static void MaskStore(ref int address, in m256i mask, in m256i source);
        //
        // Summary:
        //     void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ
        //     m256, ymm, ymm
        public static void MaskStore(ref long address, in m256i mask, in m256i source);
        //
        // Summary:
        //     void _mm_maskstore_epi32 (ref int mem_addr, __m128i mask, __m128i a) VPMASKMOVD
        //     m128, xmm, xmm
        public static void MaskStore(ref uint address, in m128i mask, in m128i source);
        //
        // Summary:
        //     void _mm_maskstore_epi32 (ref int mem_addr, __m128i mask, __m128i a) VPMASKMOVD
        //     m128, xmm, xmm
        public static void MaskStore(ref int address, in m128i mask, in m128i source);
        //
        // Summary:
        //     void _mm_maskstore_epi64 (__int64* mem_addr, __m128i mask, __m128i a) VPMASKMOVQ
        //     m128, xmm, xmm
        public static void MaskStore(ref long address, in m128i mask, in m128i source);
        //
        // Summary:
        //     __m256i _mm256_max_epu8 (__m256i a, __m256i b) VPMAXUB ymm, ymm, ymm/m256
        public static m256i Max(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_max_epi16 (__m256i a, __m256i b) VPMAXSW ymm, ymm, ymm/m256
        public static m256i Max(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_max_epi32 (__m256i a, __m256i b) VPMAXSD ymm, ymm, ymm/m256
        public static m256i Max(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_max_epi8 (__m256i a, __m256i b) VPMAXSB ymm, ymm, ymm/m256
        public static m256i Max(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_max_epu16 (__m256i a, __m256i b) VPMAXUW ymm, ymm, ymm/m256
        public static m256i Max(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_max_epu32 (__m256i a, __m256i b) VPMAXUD ymm, ymm, ymm/m256
        public static m256i Max(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_min_epu32 (__m256i a, __m256i b) VPMINUD ymm, ymm, ymm/m256
        public static m256i Min(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_min_epu16 (__m256i a, __m256i b) VPMINUW ymm, ymm, ymm/m256
        public static m256i Min(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_min_epi32 (__m256i a, __m256i b) VPMINSD ymm, ymm, ymm/m256
        public static m256i Min(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_min_epu8 (__m256i a, __m256i b) VPMINUB ymm, ymm, ymm/m256
        public static m256i Min(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_min_epi8 (__m256i a, __m256i b) VPMINSB ymm, ymm, ymm/m256
        public static m256i Min(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_min_epi16 (__m256i a, __m256i b) VPMINSW ymm, ymm, ymm/m256
        public static m256i Min(in m256i left, in m256i right);
        //
        // Summary:
        //     int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        public static int MoveMask(in m256i value);
        //
        // Summary:
        //     int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        public static int MoveMask(in m256i value);
        //
        // Summary:
        //     __m256i _mm256_mpsadbw_epu8 (__m256i a, __m256i b, const int imm8) VMPSADBW ymm,
        //     ymm, ymm/m256, imm8
        public static m256i _mm256_mpsadbw_epu8(in m256i left, in m256i right, byte mask)
            => MultipleSumAbsoluteDifferences(left,right,mask);
        //
        // Summary:
        //     __m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256
        public static m256i Multiply(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256
        public static m256i Multiply(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_maddubs_epi16 (__m256i a, __m256i b) VPMADDUBSW ymm, ymm, ymm/m256
        public static m256i MultiplyAddAdjacent(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_madd_epi16 (__m256i a, __m256i b) VPMADDWD ymm, ymm, ymm/m256
        public static m256i MultiplyAddAdjacent(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mulhi_epi16 (__m256i a, __m256i b) VPMULHW ymm, ymm, ymm/m256
        public static m256i MultiplyHigh(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mulhi_epu16 (__m256i a, __m256i b) VPMULHUW ymm, ymm, ymm/m256
        public static m256i MultiplyHigh(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mulhrs_epi16 (__m256i a, __m256i b) VPMULHRSW ymm, ymm, ymm/m256
        public static m256i MultiplyHighRoundScale(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mullo_epi16 (__m256i a, __m256i b) VPMULLW ymm, ymm, ymm/m256
        public static m256i MultiplyLow(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mullo_epi32 (__m256i a, __m256i b) VPMULLD ymm, ymm, ymm/m256
        public static m256i MultiplyLow(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mullo_epi16 (__m256i a, __m256i b) VPMULLW ymm, ymm, ymm/m256
        public static m256i MultiplyLow(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_mullo_epi32 (__m256i a, __m256i b) VPMULLD ymm, ymm, ymm/m256
        public static m256i MultiplyLow(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256
        public static m256i Or(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_packs_epi16 (__m256i a, __m256i b) VPACKSSWB ymm, ymm, ymm/m256
        public static m256i PackSignedSaturate(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_packs_epi32 (__m256i a, __m256i b) VPACKSSDW ymm, ymm, ymm/m256
        public static m256i PackSignedSaturate(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_packus_epi16 (__m256i a, __m256i b) VPACKUSWB ymm, ymm, ymm/m256
        public static m256i PackUnsignedSaturate(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_packus_epi32 (__m256i a, __m256i b) VPACKUSDW ymm, ymm, ymm/m256
        public static m256i PackUnsignedSaturate(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128
        //     ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        // Summary:
        //     __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256,
        //     imm8
        public static m256d Permute4x64(in m256d value, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,
        //     imm8
        public static m256i Permute4x64(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,
        //     imm8
        public static m256i Permute4x64(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256,
        //     ymm
        public static m256i PermuteVar8x32(in m256i left, in m256i control);
        //
        // Summary:
        //     __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx) VPERMPS ymm, ymm/m256,
        //     ymm
        public static m256 PermuteVar8x32(in m256 left, in m256i control);
        //
        // Summary:
        //     __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256,
        //     ymm
        public static m256i PermuteVar8x32(in m256i left, in m256i control);
        //
        // Summary:
        //     __m256i _mm256_sll_epi64 (__m256i a, __m128i count) VPSLLQ ymm, ymm, xmm/m128
        public static m256i ShiftLeftLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        public static m256i ShiftLeftLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        public static m256i ShiftLeftLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128
        public static m256i ShiftLeftLogical(in m256i value, Vector128<ushort> count);
        //
        // Summary:
        //     __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        public static m256i ShiftLeftLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_sll_epi64 (__m256i a, __m128i count) VPSLLQ ymm, ymm, xmm/m128
        public static m256i ShiftLeftLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        public static m256i ShiftLeftLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128
        public static m256i ShiftLeftLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        public static m256i ShiftLeftLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        public static m256i ShiftLeftLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        public static m256i ShiftLeftLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        public static m256i ShiftLeftLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        public static m256i ShiftLeftLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        public static m256i ShiftLeftLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        public static m128i ShiftLeftLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        public static m128i ShiftLeftLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        public static m128i ShiftLeftLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        public static m128i ShiftLeftLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        public static m256i ShiftLeftLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_srai_epi16 (__m256i a, int imm8) VPSRAW ymm, ymm, imm8
        public static m256i ShiftRightArithmetic(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srai_epi32 (__m256i a, int imm8) VPSRAD ymm, ymm, imm8
        public static m256i ShiftRightArithmetic(in m256i value, byte count);
        //
        // Summary:
        //     _mm256_sra_epi32 (__m256i a, __m128i count) VPSRAD ymm, ymm, xmm/m128
        public static m256i ShiftRightArithmetic(in m256i value, in m128i count);
        //
        // Summary:
        //     _mm256_sra_epi16 (__m256i a, __m128i count) VPSRAW ymm, ymm, xmm/m128
        public static m256i ShiftRightArithmetic(in m256i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_srav_epi32 (__m128i a, __m128i count) VPSRAVD xmm, xmm, xmm/m128
        public static m128i ShiftRightArithmeticVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_srav_epi32 (__m256i a, __m256i count) VPSRAVD ymm, ymm, ymm/m256
        public static m256i ShiftRightArithmeticVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        public static m256i ShiftRightLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        public static m256i ShiftRightLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        public static m256i ShiftRightLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        public static m256i ShiftRightLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_srl_epi16 (__m256i a, __m128i count) VPSRLW ymm, ymm, xmm/m128
        public static m256i ShiftRightLogical(in m256i value, Vector128<ushort> count);
        //
        // Summary:
        //     __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        public static m256i ShiftRightLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        public static m256i ShiftRightLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        public static m256i ShiftRightLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        public static m256i ShiftRightLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srl_epi16 (__m256i a, __m128i count) VPSRLW ymm, ymm, xmm/m128
        public static m256i ShiftRightLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        public static m256i ShiftRightLogical(in m256i value, byte count);
        //
        // Summary:
        //     __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        public static m256i ShiftRightLogical(in m256i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m256i _mm256_bsrli_epi128 (__m256i a, const int imm8) VPSRLDQ ymm, ymm, imm8
        public static m256i ShiftRightLogical128BitLane(in m256i value, byte numBytes);
        //
        // Summary:
        //     __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        public static m128i ShiftRightLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        public static m128i ShiftRightLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        public static m128i ShiftRightLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        public static m128i ShiftRightLogicalVariable(in m128i value, in m128i count);
        //
        // Summary:
        //     __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        public static m256i ShiftRightLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        public static m256i ShiftRightLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        public static m256i ShiftRightLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        public static m256i ShiftRightLogicalVariable(in m256i value, in m256i count);
        //
        // Summary:
        //     __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256,
        //     imm8
        public static m256i Shuffle(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256,
        //     imm8
        public static m256i Shuffle(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        public static m256i Shuffle(in m256i value, in m256i mask);
        //
        // Summary:
        //     __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        public static m256i Shuffle(in m256i value, in m256i mask);
        //
        // Summary:
        //     __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8) VPSHUFHW ymm, ymm/m256,
        //     imm8
        public static m256i ShuffleHigh(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_shufflehi_epi16 (__m256i a, const int imm8) VPSHUFHW ymm, ymm/m256,
        //     imm8
        public static m256i ShuffleHigh(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8) VPSHUFLW ymm, ymm/m256,
        //     imm8
        public static m256i ShuffleLow(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_shufflelo_epi16 (__m256i a, const int imm8) VPSHUFLW ymm, ymm/m256,
        //     imm8
        public static m256i ShuffleLow(in m256i value, byte control);
        //
        // Summary:
        //     __m256i _mm256_sign_epi16 (__m256i a, __m256i b) VPSIGNW ymm, ymm, ymm/m256
        public static m256i Sign(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sign_epi32 (__m256i a, __m256i b) VPSIGND ymm, ymm, ymm/m256
        public static m256i Sign(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sign_epi8 (__m256i a, __m256i b) VPSIGNB ymm, ymm, ymm/m256
        public static m256i Sign(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        public static m256i Subtract(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        public static m256i Subtract(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        public static m256i Subtract(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        public static m256i _mm256_sub_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        public static m256i _mm256_sub_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        public static m256i Subtract(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        public static m256i _mm256_sub_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        public static m256i _mm256_sub_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_subs_epu8 (__m256i a, __m256i b) VPSUBUSB ymm, ymm, ymm/m256
        public static m256i _mm256_subs_epu8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_subs_epi16 (__m256i a, __m256i b) VPSUBSW ymm, ymm, ymm/m256
        public static m256i _mm256_subs_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_subs_epi8 (__m256i a, __m256i b) VPSUBSB ymm, ymm, ymm/m256
        public static m256i _mm256_subs_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_subs_epu16 (__m256i a, __m256i b) VPSUBUSW ymm, ymm, ymm/m256
        public static m256i _mm256_subs_epu16(in m256i left, in m256i right)
            => SubtractSaturate(left,right);
        //
        // Summary:
        //     __m256i _mm256_sad_epu8 (__m256i a, __m256i b) VPSADBW ymm, ymm, ymm/m256
        public static m256i _mm256_sad_epu8(in m256i left, in m256i right)
            => SumAbsoluteDifferences(left, right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpackhi_epi64(in m256i left, in m256i right)
            => UnpackHigh(left,right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        public static m256i UnpackHigh(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        public static m256i _mm256_unpackhi_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpackhi_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpackhi_epi32(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256
        public static m256i _mm256_unpackhi_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256
        public static m256i _mm256_unpackhi_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi32(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi32(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi16(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi8(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256
        public static m256i _mm256_unpacklo_epi64(in m256i left, in m256i right);
        //
        // Summary:
        //     __m256i _mm256_xor_si256 (__m256i a, __m256i b) VPXOR ymm, ymm, ymm/m256
        public static m256i _mm256_xor_si256(in m256i left, in m256i right);
 

    }
    #endif
}
