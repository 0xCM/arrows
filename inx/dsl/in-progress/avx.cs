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

    partial class x86
    {
        [MethodImpl(Inline)]
        public static m128i _mm256_castsi256_si128(in m256i a)
        {
            m128i dst = default;
            dst.x0 = a.x0;
            dst.x1 = a.x1;
            return dst;
        }

        #if false

        
        //<intrinsic> __m256d _mm256_add_pd (__m256d a, __m256d b) VADDPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d Add(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_add_ps (__m256 a, __m256 b) VADDPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 Add(in m256 left, in m256 right);
        
        //<intrinsic> __m256d _mm256_addsub_pd (__m256d a, __m256d b) VADDSUBPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d AddSubtract(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_addsub_ps (__m256 a, __m256 b) VADDSUBPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 AddSubtract(in m256 left, in m256 right);
        
        //<intrinsic> __m256d _mm256_and_pd (__m256d a, __m256d b) VANDPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d And(in m256d left, in m256d right)
            => And(left,right);

        //<intrinsic> __m256 _mm256_and_ps (__m256 a, __m256 b) VANDPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 And(in m256 left, in m256 right)
            => And(left,right);

        //<intrinsic> __m256d _mm256_andnot_pd (__m256d a, __m256d b) VANDNPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d AndNot(in m256d left, in m256d right)
            => AndNot(left,right);
        
        //<intrinsic> __m256 _mm256_andnot_ps (__m256 a, __m256 b) VANDNPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 AndNot(in m256 left, in m256 right)
            => AndNot(left,right);
        
        //<intrinsic> __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8 </intrinsic>
        public static m256d Blend(in m256d left, in m256d right, byte control)
            => Blend(left, right, control);
        
        //<intrinsic> __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8) VBLENDPS ymm, ymm, ymm/m256, imm8 </intrinsic>
        public static m256 Blend(in m256 left, in m256 right, byte control)
            => Blend(left, right, control);
        
        //<intrinsic> __m256d _mm256_blendv_pd (__m256d a, __m256d b, __m256d mask) VBLENDVPD ymm, ymm, ymm/m256, ymm </intrinsic>
        public static m256d BlendVariable(in m256d left, in m256d right, in m256d mask)
            => BlendVariable(left, right, mask);
        
        //<intrinsic> __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm </intrinsic>
        public static m256 BlendVariable(in m256 left, in m256 right, in m256 mask)
            => BlendVariable(left, right, mask);
        
        //<intrinsic> __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, in m32 </intrinsic>
        public static m128 BroadcastScalarToVector128(ref float source)
            => BroadcastScalarToVector128(source);
        
        //<intrinsic> __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, in m64 </intrinsic>
        public static m256d BroadcastScalarToVector256(ref double source)
            => BroadcastScalarToVector256(source);
        
        //<intrinsic> __m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, in m32 </intrinsic>
        public static m256 BroadcastScalarToVector256(ref float source)
            => BroadcastScalarToVector256(source);
        
        //<intrinsic> __m256d _mm256_broadcast_pd (__m128d const * mem_addr) VBROADCASTF128, ymm, in m128 </intrinsic>
        public static m256d BroadcastVector128ToVector256(ref double address)
            => BroadcastVector128ToVector256(address);
        
        //<intrinsic> __m256 _mm256_broadcast_ps (__m128 const * mem_addr) VBROADCASTF128, ymm, in m128 </intrinsic>
        public static m256 BroadcastVector128ToVector256(ref float address);
        
        //<intrinsic> __m256 _mm256_ceil_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(10) </intrinsic>
        public static m256 Ceiling(in m256 value)
            => Ceiling(value);
        
        //<intrinsic> __m256d _mm256_ceil_pd (__m256d a) VROUNDPD ymm, ymm/m256, imm8(10) </intrinsic>
        public static m256d Ceiling(in m256d value)
            => Ceiling(value);
        
        //<intrinsic> __m128d _mm_cmp_pd (__m128d a, __m128d b, const int imm8) VCMPPD xmm, xmm, xmm/m128, imm8 </intrinsic>
        public static m128d Compare(in m128d left, in m128d right, FloatComparisonMode mode);
        
        //<intrinsic> __m128 _mm_cmp_ps (__m128 a, __m128 b, const int imm8) VCMPPS xmm, xmm, xmm/m128, imm8 </intrinsic>
        public static m128 Compare(in m128 left, in m128 right, FloatComparisonMode mode);
        
        //<intrinsic> __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm, ymm/m256, imm8 </intrinsic>
        public static m256d Compare(in m256d left, in m256d right, FloatComparisonMode mode);
        
        //<intrinsic> __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8 </intrinsic>
        public static m256 Compare(in m256 left, in m256 right, FloatComparisonMode mode);
        
        //<intrinsic> __m128d _mm_cmp_sd (__m128d a, __m128d b, const int imm8) VCMPSS xmm, xmm, xmm/m32, imm8 </intrinsic>
        public static m128d CompareScalar(in m128d left, in m128d right, FloatComparisonMode mode);
        
        //<intrinsic> __m128 _mm_cmp_ss (__m128 a, __m128 b, const int imm8) VCMPSD xmm, xmm, xmm/m64, imm8 </intrinsic>
        public static m128 CompareScalar(in m128 left, in m128 right, FloatComparisonMode mode);
        
        //<intrinsic> __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256 </intrinsic>
        public static m128i ConvertToVector128Int32(in m256d value);
        
        //<intrinsic> __m128i _mm256_cvttpd_epi32 (__m256d a) VCVTTPD2DQ xmm, ymm/m256 </intrinsic>
        public static m128i ConvertToVector128Int32WithTruncation(in m256d value);
        
        //<intrinsic> __m128 _mm256_cvtpd_ps (__m256d a) VCVTPD2PS xmm, ymm/m256 </intrinsic>
        public static m128 ConvertToVector128Single(in m256d value);
        
        //<intrinsic> __m256d _mm256_cvtepi32_pd (__m128i a) VCVTDQ2PD ymm, xmm/m128 </intrinsic>
        public static m256d ConvertToVector256Double(in m128i value);
        
        //<intrinsic> __m256d _mm256_cvtps_pd (__m128 a) VCVTPS2PD ymm, xmm/m128 </intrinsic>
        public static m256d ConvertToVector256Double(in m128 value);
        
        //<intrinsic> __m256i _mm256_cvtps_epi32 (__m256 a) VCVTPS2DQ ymm, ymm/m256 </intrinsic>
        public static m128i ConvertToVector256Int32(in m256 value);
        
        //<intrinsic> __m256i _mm256_cvttps_epi32 (__m256 a) VCVTTPS2DQ ymm, ymm/m256 </intrinsic>
        public static m128i ConvertToVector256Int32WithTruncation(in m256 value);
        
        //<intrinsic> __m256 _mm256_cvtepi32_ps (__m256i a) VCVTDQ2PS ymm, ymm/m256 </intrinsic>
        public static m256 ConvertToVector256Single(in m128i value);
        
        //<intrinsic> __m256d _mm256_div_pd (__m256d a, __m256d b) VDIVPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d Divide(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_div_ps (__m256 a, __m256 b) VDIVPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 Divide(in m256 left, in m256 right);
        
        //<intrinsic> __m256 _mm256_dp_ps (__m256 a, __m256 b, const int imm8) VDPPS ymm, ymm, ymm/m256, imm8 </intrinsic>
        public static m256 DotProduct(in m256 left, in m256 right, byte control);
        
        //<intrinsic> __m256d _mm256_movedup_pd (__m256d a) VMOVDDUP ymm, ymm/m256 </intrinsic>
        public static m256d DuplicateEvenIndexed(in m256d value);
        
        //<intrinsic> __m256 _mm256_moveldup_ps (__m256 a) VMOVSLDUP ymm, ymm/m256 </intrinsic>
        public static m256 DuplicateEvenIndexed(in m256 value);
        
        //<intrinsic> __m256 _mm256_movehdup_ps (__m256 a) VMOVSHDUP ymm, ymm/m256 </intrinsic>
        public static m256 DuplicateOddIndexed(in m256 value);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m128 _mm256_extractf128_ps (__m256 a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128 ExtractVector128(in m256 value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static Vector128<sbyte> ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m128i value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m128d _mm256_extractf128_pd (__m256d a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128d ExtractVector128(in m256d value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m128i _mm256_extractf128_si256 (__m256i a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8 </intrinsic>
        public static m128i ExtractVector128(in m256i value, byte index);
        
        //<intrinsic> __m256d _mm256_floor_pd (__m256d a) VROUNDPS ymm, ymm/m256, imm8(9) </intrinsic>
        public static m256d Floor(in m256d value);
        
        //<intrinsic> __m256 _mm256_floor_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(9) </intrinsic>
        public static m256 Floor(in m256 value);
        
        //<intrinsic> __m256d _mm256_hadd_pd (__m256d a, __m256d b) VHADDPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d HorizontalAdd(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_hadd_ps (__m256 a, __m256 b) VHADDPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 HorizontalAdd(in m256 left, in m256 right);
        
        //<intrinsic> __m256d _mm256_hsub_pd (__m256d a, __m256d b) VHSUBPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d HorizontalSubtract(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_hsub_ps (__m256 a, __m256 b) VHSUBPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 HorizontalSubtract(in m256 left, in m256 right);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        
        //<intrinsic> __m256 _mm256_insertf128_ps (__m256 a, __m128 b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256 InsertVector128(in m256 value, in m128 data, byte index);
        
        //<intrinsic> __m256d _mm256_insertf128_pd (__m256d a, __m128d b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256d InsertVector128(in m256d value, in m128d data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, Vector128<sbyte> data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m128i InsertVector128(in m128i value, in m128i data, byte index);
        
        //<intrinsic> __m256i _mm256_insertf128_si256 (__m256i a, __m128i b, int imm8) VINSERTF128 ymm, ymm, xmm/m128, imm8 </intrinsic>
        public static m256i InsertVector128(in m256i value, in m128i data, byte index);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref ulong address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref ushort address);
        
        //<intrinsic> __m256 _mm256_load_ps (float const * mem_addr) VMOVAPS ymm, ymm/m256 </intrinsic>
        public static m256 LoadAlignedVector256(ref float address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref sbyte address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref uint address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m128i LoadAlignedVector256(ref int address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref short address);
        
        //<intrinsic> __m256d _mm256_load_pd (double const * mem_addr) VMOVAPD ymm, ymm/m256 </intrinsic>
        public static m256d LoadAlignedVector256(ref double address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref byte address);
        
        //<intrinsic> __m256i _mm256_load_si256 (__m256i const * mem_addr) VMOVDQA ymm, in m256 </intrinsic>
        public static m256i LoadAlignedVector256(ref long address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref ulong address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref byte address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m128i LoadDquVector256(ref int address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref long address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref sbyte address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref ushort address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref uint address);
        
        //<intrinsic> __m256i _mm256_lddqu_si256 (__m256i const * mem_addr) VLDDQU ymm, in m256 </intrinsic>
        public static m256i LoadDquVector256(ref short address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m128i LoadVector256(ref int address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref ulong address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref ushort address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref uint address);
        
        //<intrinsic> __m256 _mm256_loadu_ps (float const * mem_addr) VMOVUPS ymm, ymm/m256 </intrinsic>
        public static m256 LoadVector256(ref float address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref short address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref long address);
        
        //<intrinsic> __m256d _mm256_loadu_pd (double const * mem_addr) VMOVUPD ymm, ymm/m256 </intrinsic>
        public static m256d LoadVector256(ref double address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref byte address);
        
        //<intrinsic> __m256i _mm256_loadu_si256 (__m256i const * mem_addr) VMOVDQU ymm, in m256 </intrinsic>
        public static m256i LoadVector256(ref sbyte address);
        
        //<intrinsic> __m128d _mm_maskload_pd (double const * mem_addr, __m128i mask) VMASKMOVPD xmm, xmm, in m128 </intrinsic>
        public static m128d MaskLoad(ref double address, in m128d mask);
        
        //<intrinsic> __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, in m256 </intrinsic>
        public static m256d MaskLoad(ref double address, in m256d mask);
        
        //<intrinsic> __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,
        //<intrinsic> xmm, in m128
        public static m128 MaskLoad(ref float address, in m128 mask);
        //
        
        //<intrinsic> __m256 _mm256_maskload_ps (float const * mem_addr, __m256i mask) VMASKMOVPS ymm, ymm, in m256
        public static m256 MaskLoad(ref float address, in m256 mask);
        
        //<intrinsic> void _mm256_maskstore_ps (float * mem_addr, __m256i mask, __m256 a) VMASKMOVPS
        //<intrinsic> m256, ymm, ymm
        public static void MaskStore(ref float address, in m256 mask, in m256 source);
        //
        
        //<intrinsic> void _mm_maskstore_ps (float * mem_addr, __m128i mask, __m128 a) VMASKMOVPS m128,
        //<intrinsic> xmm, xmm
        public static void MaskStore(ref float address, in m128 mask, in m128 source);
        //
        
        //<intrinsic> void _mm_maskstore_pd (double * mem_addr, __m128i mask, __m128d a) VMASKMOVPD
        //<intrinsic> m128, xmm, xmm
        public static void MaskStore(ref double address, in m128d mask, in m128d source);
        //
        
        //<intrinsic> void _mm256_maskstore_pd (double * mem_addr, __m256i mask, __m256d a) VMASKMOVPD
        //<intrinsic> m256, ymm, ymm
        public static void MaskStore(ref double address, in m256d mask, in m256d source);
        //
        
        //<intrinsic> __m256d _mm256_max_pd (__m256d a, __m256d b) VMAXPD ymm, ymm, ymm/m256
        public static m256d Max(in m256d left, in m256d right);
        //
        
        //<intrinsic> __m256 _mm256_max_ps (__m256 a, __m256 b) VMAXPS ymm, ymm, ymm/m256
        public static m256 Max(in m256 left, in m256 right);
        //
        
        //<intrinsic> __m256d _mm256_min_pd (__m256d a, __m256d b) VMINPD ymm, ymm, ymm/m256
        public static m256d Min(in m256d left, in m256d right);
        //
        
        //<intrinsic> __m256 _mm256_min_ps (__m256 a, __m256 b) VMINPS ymm, ymm, ymm/m256
        public static m256 Min(in m256 left, in m256 right);
        //
        
        //<intrinsic> int _mm256_movemask_pd (__m256d a) VMOVMSKPD reg, ymm
        public static int MoveMask(in m256d value);
        //
        
        //<intrinsic> int _mm256_movemask_ps (__m256 a) VMOVMSKPS reg, ymm
        public static int MoveMask(in m256 value);
        //
        
        //<intrinsic> __m256d _mm256_mul_pd (__m256d a, __m256d b) VMULPD ymm, ymm, ymm/m256
        public static m256d Multiply(in m256d left, in m256d right);
        //
        
        //<intrinsic> __m256 _mm256_mul_ps (__m256 a, __m256 b) VMULPS ymm, ymm, ymm/m256
        public static m256 Multiply(in m256 left, in m256 right);
        //
        
        //<intrinsic> __m256 _mm256_or_ps (__m256 a, __m256 b) VORPS ymm, ymm, ymm/m256
        public static m256 Or(in m256 left, in m256 right);
        //
        
        //<intrinsic> __m256d _mm256_or_pd (__m256d a, __m256d b) VORPD ymm, ymm, ymm/m256
        public static m256d Or(in m256d left, in m256d right);
        //
        
        //<intrinsic> __m256 _mm256_permute_ps (__m256 a, int imm8) VPERMILPS ymm, ymm, imm8
        public static m256 Permute(in m256 value, byte control);
        //
        
        //<intrinsic> __m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8
        public static m128d Permute(in m128d value, byte control);
        //
        
        //<intrinsic> __m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8
        public static m128 Permute(in m128 value, byte control);
        //
        
        //<intrinsic> __m256d _mm256_permute_pd (__m256d a, int imm8) VPERMILPD ymm, ymm, imm8
        public static m256d Permute(in m256d value, byte control);
        //
        
        //<intrinsic> __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm,
        //<intrinsic> ymm, ymm/m256, imm8
        public static m256d Permute2x128(in m256d left, in m256d right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m128i Permute2x128(in m128i left, in m128i right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm,
        //<intrinsic> ymm, ymm/m256, imm8
        public static m256 Permute2x128(in m256 left, in m256 right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256i _mm256_permute2f128_si256 (__m256i a, __m256i b, int imm8) VPERM2F128
        //<intrinsic> ymm, ymm, ymm/m256, imm8
        public static m256i Permute2x128(in m256i left, in m256i right, byte control);
        //
        
        //<intrinsic> __m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256
        public static m256 PermuteVar(in m256 left, in m128i control);
        //
        
        //<intrinsic> __m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128
        public static m128d PermuteVar(in m128d left, in m128i control);
        //
        
        //<intrinsic> __m128 _mm_permutevar_ps (__m128 a, __m128i b) VPERMILPS xmm, xmm, xmm/m128
        public static m128 PermuteVar(in m128 left, in m128i control);
        
        //<intrinsic> __m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256
        public static m256d PermuteVar(in m256d left, in m256i control);
        
        //<intrinsic> __m256 _mm256_rcp_ps (__m256 a) VRCPPS ymm, ymm/m256
        public static m256 Reciprocal(in m256 value);
        
        //<intrinsic> __m256 _mm256_rsqrt_ps (__m256 a) VRSQRTPS ymm, ymm/m256
        public static m256 ReciprocalSqrt(in m256 value);
        
        //<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_CUR_DIRECTION) VROUNDPD ymm, ymm/m256,
        //<intrinsic> imm8(4)
        public static m256d RoundCurrentDirection(in m256d value);
        
        //<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_CUR_DIRECTION) VROUNDPS ymm, ymm/m256, imm8(4)
        public static m256 RoundCurrentDirection(in m256 value);
        
        //<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC)
        //<intrinsic> VROUNDPD ymm, ymm/m256, imm8(8)
        public static m256d RoundToNearestInteger(in m256d value);
        //
        
        //<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_NEAREST_INT | _MM_FROUND_NO_EXC)
        //<intrinsic> VROUNDPS ymm, ymm/m256, imm8(8)
        public static m256 RoundToNearestInteger(in m256 value);
        //
        
        //<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC)
        //<intrinsic> VROUNDPD ymm, ymm/m256, imm8(9)
        public static m256d RoundToNegativeInfinity(in m256d value);
        //
        
        //<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_NEG_INF | _MM_FROUND_NO_EXC)
        //<intrinsic> VROUNDPS ymm, ymm/m256, imm8(9)
        public static m256 RoundToNegativeInfinity(in m256 value);
        
        //<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) VROUNDPD ymm, ymm/m256, imm8(10)
        public static m256d RoundToPositiveInfinity(in m256d value);
        
        //<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_POS_INF | _MM_FROUND_NO_EXC) VROUNDPS ymm, ymm/m256, imm8(10)
        public static m256 RoundToPositiveInfinity(in m256 value);
        
        //<intrinsic> __m256 _mm256_round_ps (__m256 a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) VROUNDPS
        //<intrinsic> ymm, ymm/m256, imm8(11)
        public static m256 RoundToZero(in m256 value);
        //
        
        //<intrinsic> __m256d _mm256_round_pd (__m256d a, _MM_FROUND_TO_ZERO | _MM_FROUND_NO_EXC) VROUNDPD
        //<intrinsic> ymm, ymm/m256, imm8(11)
        public static m256d RoundToZero(in m256d value);
        //
        
        //<intrinsic> __m256d _mm256_shuffle_pd (__m256d a, __m256d b, const int imm8) VSHUFPD ymm,
        //<intrinsic> ymm, ymm/m256, imm8
        public static m256d Shuffle(in m256d value, in m256d right, byte control);
        //
        
        //<intrinsic> __m256 _mm256_shuffle_ps (__m256 a, __m256 b, const int imm8) VSHUFPS ymm, ymm,
        //<intrinsic> ymm/m256, imm8
        public static m256 Shuffle(in m256 value, in m256 right, byte control);
        //
        
        //<intrinsic> __m256d _mm256_sqrt_pd (__m256d a) VSQRTPD ymm, ymm/m256
        public static m256d Sqrt(in m256d value);
        //
        
        //<intrinsic> __m256 _mm256_sqrt_ps (__m256 a) VSQRTPS ymm, ymm/m256
        public static m256 Sqrt(in m256 value);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref ulong address, in m256i source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref uint address, in m256i source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref ushort address, in m256i source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref sbyte address, in m256i source);
        
        //<intrinsic> void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm <intrinsic>
        public static void Store(ref float address, in m256 source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref int address, in m128i source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref short address, in m256i source);
        
        //<intrinsic> void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm <intrinsic>
        public static void Store(ref double address, in m256d source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref byte address, in m256i source);
        
        //<intrinsic> void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm <intrinsic>
        public static void Store(ref long address, in m256i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref ushort address, in m256i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref ulong address, in m256i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref uint address, in m256i source);
        
        //<intrinsic> void _mm256_store_ps (float * mem_addr, __m256 a) VMOVAPS m256, ymm <intrinsic>
        public static void StoreAligned(ref float address, in m256 source);
        
        //<intrinsic> void _mm256_store_pd (double * mem_addr, __m256d a) VMOVAPD m256, ymm <intrinsic>
        public static void StoreAligned(ref double address, in m256d source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref long address, in m256i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref int address, in m128i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref short address, in m256i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref byte address, in m256i source);
        
        //<intrinsic> void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm <intrinsic>
        public static void StoreAligned(ref sbyte address, in m256i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref ulong address, in m256i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref ushort address, in m256i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref uint address, in m256i source);
        
        //<intrinsic> void _mm256_stream_ps (float * mem_addr, __m256 a) MOVNTPS m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref float address, in m256 source);
        
        //<intrinsic> void _mm256_stream_pd (double * mem_addr, __m256d a) MOVNTPD m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref double address, in m256d source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref long address, in m256i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref sbyte address, in m256i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref byte address, in m256i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref int address, in m128i source);
        
        //<intrinsic> void _mm256_stream_si256 (__m256i * mem_addr, __m256i a) VMOVNTDQ m256, ymm <intrinsic>
        public static void StoreAlignedNonTemporal(ref short address, in m256i source);
        
        //<intrinsic> __m256d _mm256_sub_pd (__m256d a, __m256d b) VSUBPD ymm, ymm, ymm/m256 <intrinsic>
        public static m256d Subtract(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_sub_ps (__m256 a, __m256 b) VSUBPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 Subtract(in m256 left, in m256 right);
        
        //<intrinsic> int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestC(in m256i left, in m256i right);        
        
        //<intrinsic> int _mm256_testc_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool TestC(in m256 left, in m256 right);
               
        //<intrinsic> int _mm256_testc_pd (__m256d a, __m256d b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool TestC(in m256d left, in m256d right);
                
        //<intrinsic> int _mm_testc_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128 </intrinsic>
        public static bool TestC(in m128 left, in m128 right);
        
        //<intrinsic> int _mm_testc_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128 </intrinsic>
        public static bool TestC(in m128d left, in m128d right);
        
        //<intrinsic> int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestC(in m128i left, in m128i right);
        
        //<intrinsic> int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in m256i left, in m256i right);
        
        //<intrinsic> int _mm256_testnzc_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in m256 left, in m256 right);
                
        //<intrinsic> int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in m256i left, in m256i right);
                
        //<intrinsic> int _mm256_testnzc_pd (__m256d a, __m256d b) VTESTPD ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in m256d left, in m256d right);        
        
        //<intrinsic> int _mm_testnzc_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128 </intrinsic>
        public static bool TestNotZAndNotC(in m128 left, in m128 right);
        
        //<intrinsic> int _mm_testnzc_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128 </intrinsic>
        public static bool TestNotZAndNotC(in m128d left, in m128d right);
        
        //<intrinsic> int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestNotZAndNotC(in m128i left, in m128i right);
        
        //<intrinsic> int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestZ(in m256i left, in m256i right);
                
        //<intrinsic> int _mm256_testz_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256 </intrinsic>
        public static bool TestZ(in m256 left, in m256 right);
                            
        //<intrinsic> int _mm256_testz_pd (__m256d a, __m256d b) VTESTPD ymm, ymm/m256 </intrinsic>
        public static bool TestZ(in m256d left, in m256d right);
                
        //<intrinsic> int _mm_testz_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128 </intrinsic>
        public static bool TestZ(in m128 left, in m128 right);
        
        //<intrinsic> int _mm_testz_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128 </intrinsic>
        public static bool TestZ(in m128d left, in m128d right);
        
        //<intrinsic> int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256 </intrinsic>
        public static bool TestZ(in m128i left, in m128i right);
        
        //<intrinsic> __m256d _mm256_unpackhi_pd (__m256d a, __m256d b) VUNPCKHPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d UnpackHigh(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_unpackhi_ps (__m256 a, __m256 b) VUNPCKHPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 UnpackHigh(in m256 left, in m256 right);
        
        //<intrinsic> __m256d _mm256_unpacklo_pd (__m256d a, __m256d b) VUNPCKLPD ymm, ymm, ymm/m256 </intrinsic>
        public static m256d UnpackLow(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_unpacklo_ps (__m256 a, __m256 b) VUNPCKLPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 UnpackLow(in m256 left, in m256 right);
        
        //<intrinsic> __m256d _mm256_xor_pd (__m256d a, __m256d b) VXORPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256d Xor(in m256d left, in m256d right);
        
        //<intrinsic> __m256 _mm256_xor_ps (__m256 a, __m256 b) VXORPS ymm, ymm, ymm/m256 </intrinsic>
        public static m256 Xor(in m256 left, in m256 right);
                         
        #endif

    }


}
