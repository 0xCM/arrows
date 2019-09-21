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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendw</remarks>
        [MethodImpl(Inline)]
        public static Vec128<short> blend(in Vec128<short> x, in Vec128<short> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> blend(in Vec128<ushort> x, in Vec128<ushort> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<int> blend(in Vec128<int> x, in Vec128<int> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> blend(in Vec128<uint> x, in Vec128<uint> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> blend(in Vec256<short> x, in Vec256<short> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendw</remarks>
        [MethodImpl(Inline)]
        public static Vec256<ushort> blend(in Vec256<ushort> x, in Vec256<ushort> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// _mm256_blend_epi32
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> blend(in Vec256<int> x, in Vec256<int> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/vpblendd</remarks>
        [MethodImpl(Inline)]
        public static Vec256<uint> blend(in Vec256<uint> x, in Vec256<uint> y, byte control)        
            => Blend(x,y,control);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Creates a target vector from source components as determined by the hi bit of each 
        /// corresponding control vector component: dst[i] = testbit(control[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vec256<byte> blendv(in Vec256<byte> x, in Vec256<byte> y, in Vec256<byte> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> blendv(in Vec256<sbyte> x, in Vec256<sbyte> y, in Vec256<sbyte> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> blendv(in Vec256<short> x, in Vec256<short> y, in Vec256<short> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> blendv(in Vec256<ushort> x, in Vec256<ushort> y, in Vec256<ushort> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> blendv(in Vec256<int> x, in Vec256<int> y, in Vec256<int> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> blendv(in Vec256<uint> x, in Vec256<uint> y, in Vec256<uint> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<long> blendv(in Vec256<long> x, in Vec256<long> y, in Vec256<long> control)        
            => BlendVariable(x,y,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> blendv(in Vec256<ulong> x, in Vec256<ulong> y, in Vec256<ulong> control)        
            => BlendVariable(x,y,control);
    }

}