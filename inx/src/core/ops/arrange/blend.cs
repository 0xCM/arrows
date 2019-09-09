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
        /// _mm_blend_epi16
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<short> blend(in Vec128<short> lhs, in Vec128<short> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// _mm_blend_epi16
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> blend(in Vec128<ushort> lhs, in Vec128<ushort> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<int> blend(in Vec128<int> lhs, in Vec128<int> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// _mm_blend_epi32
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> blend(in Vec128<uint> lhs, in Vec128<uint> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// _mm_blend_pd
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<float> blend(in Vec128<float> lhs, in Vec128<float> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// _mm_blend_pd
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<double> blend(in Vec128<double> lhs, in Vec128<double> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> blend(in Vec256<short> lhs, in Vec256<short> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// _mm256_blend_epi16
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> blend(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// _mm256_blend_epi32
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> blend(in Vec256<int> lhs, in Vec256<int> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm,  ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <algorithm>
        /// FOR j := 0 to 7
        ///     i := j*32
        ///     IF imm8[j]
        ///         dst[i+31:i] := b[i+31:i]
        ///     ELSE
        ///         dst[i+31:i] := a[i+31:i]
        ///     FI
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256<uint> blend(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// dst[i] = testbit(control[i],7) ? rhs[i] : lhs[i]
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <algorithm>
        /// FOR j := 0 to 31
        /// 	i := j*8
        /// 	IF mask[i+7]
        /// 		dst[i+7:i] := b[i+7:i]
        /// 	ELSE
        /// 		dst[i+7:i] := a[i+7:i]
        /// 	FI
        /// ENDFOR
        /// dst[MAX:256] := 0        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256<byte> blendv(in Vec256<byte> lhs, in Vec256<byte> rhs, in Vec256<byte> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> blendv(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, in Vec256<sbyte> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> blendv(in Vec256<short> lhs, in Vec256<short> rhs, in Vec256<short> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> blendv(in Vec256<ushort> lhs, in Vec256<ushort> rhs, in Vec256<ushort> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> blendv(in Vec256<int> lhs, in Vec256<int> rhs, in Vec256<int> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> blendv(in Vec256<uint> lhs, in Vec256<uint> rhs, in Vec256<uint> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<long> blendv(in Vec256<long> lhs, in Vec256<long> rhs, in Vec256<long> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> blendv(in Vec256<ulong> lhs, in Vec256<ulong> rhs, in Vec256<ulong> control)        
            => BlendVariable(lhs,rhs,control);
    }

}