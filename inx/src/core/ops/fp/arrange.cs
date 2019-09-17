//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        ///<summary>__m128 _mm_shuffle_ps (__m128 a, __m128 b, unsigned int control) SHUFPS xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> shuffle(in Vec128<float> lhs, in Vec128<float> rhs,  byte control)
            => Shuffle(lhs,rhs, control);

        ///<summary>__m128d _mm_shuffle_pd (__m128d a, __m128d b, int immediate) SHUFPD xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> shuffle(in Vec128<double> lhs, in Vec128<double> rhs, byte control)
            =>  Shuffle(lhs,rhs, control);

        ///<summary>__m128 _mm_permute_ps (__m128 a, int imm8) VPERMILPS xmm, xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> permute(in Vec128<float> value, byte control)
            => Permute(value, control);

        ///<summary>__m128d _mm_permute_pd (__m128d a, int imm8) VPERMILPD xmm, xmm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> permute(in Vec128<double> value, byte control)
            => Permute(value, control);

        ///<summary>__m256 _mm256_permute_ps (__m256 a, int imm8) VPERMILPS ymm, ymm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<float> permute(in Vec256<float> value, byte control)
            => Permute(value, control);

        ///<summary>__m256d _mm256_permute_pd (__m256d a, int imm8) VPERMILPD ymm, ymm, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec256<double> permute(in Vec256<double> value, byte control)
            => Permute(value, control);

        ///<summary>__m128 _mm_permutevar_ps (__m128 a, __m128i b) VPERMILPS xmm, xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> permvar(in Vec128<float> lhs, in Vec128<int> control)
            => PermuteVar(lhs, control);

        ///<summary>__m128d _mm_permutevar_pd (__m128d a, __m128i b) VPERMILPD xmm, xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> permvar(in Vec128<double> lhs, in Vec128<long> control)
            => PermuteVar(lhs, control);

        ///<summary>__m256 _mm256_permutevar_ps (__m256 a, __m256i b) VPERMILPS ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<float> permvar(Vec256<float> lhs, in Vec256<int> control)
            => PermuteVar(lhs, control);

        ///<summary>__m256d _mm256_permutevar_pd (__m256d a, __m256i b) VPERMILPD ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<double> permvar(Vec256<double> lhs, in Vec256<long> control)
            => PermuteVar(lhs, control);

        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        [MethodImpl(Inline)]
        public static Vec256<double> perm4x64(in Vec256<double> value, byte control)
            => Permute4x64(value,control); 

        /// <summary>
        /// __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8) VBLENDPS ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<float> blend(in Vec256<float> lhs, in Vec256<float> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<double> blend(in Vec256<double> lhs, in Vec256<double> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <summary>
        ///  __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm,ymm/m256, ymm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<float> blendv(in Vec256<float> lhs, in Vec256<float> rhs, in Vec256<float> control)        
            => BlendVariable(lhs,rhs,control);

        /// <summary>
        /// _mm256_blendv_ps
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<double> blendv(in Vec256<double> lhs, in Vec256<double> rhs, in Vec256<double> control)        
            => BlendVariable(lhs,rhs,control);
 
         /// <summary>
        /// Transposes a 4x4 matrix of floats, adapted from MSVC intrinsic headers
        /// </summary>
        /// <param name="row0">The first row</param>
        /// <param name="row1">The second row</param>
        /// <param name="row2">The third row</param>
        /// <param name="row3">The fourth row</param>
        [MethodImpl(Inline)]
        public static void transpose(ref Vec128<float> row0,ref Vec128<float> row1,ref Vec128<float> row2,ref Vec128<float> row3)
        {
            var tmp0 = Shuffle(row0,row1, 0x44);
            var tmp2 = Shuffle(row0, row1, 0xEE);
            var tmp1 = Shuffle(row2, row3, 0x44);
            var tmp3 = Shuffle(row2,row3, 0xEE);
            row0 = Shuffle(tmp0,tmp1, 0x88);
            row1 = Shuffle(tmp0,tmp1, 0xDD);
            row2 = Shuffle(tmp2,tmp3, 0x88);
            row3 = Shuffle(tmp2, tmp3, 0xDD);
        }    

        /// <summary>
        /// __m256 _mm256_broadcast_ss (float const * mem_addr) VBROADCASTSS ymm, m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<float> broadcast(in float src, out Vec256<float> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }

        /// <summary>
        /// __m256d _mm256_broadcast_sd (double const * mem_addr) VBROADCASTSD ymm, m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe ref Vec256<double> broadcast(in double src, out Vec256<double> dst)
        {
            dst = BroadcastScalarToVector256(refptr(ref asRef(in src)));
            return ref dst;
        }
 
        /// <summary>
        /// __m128 _mm_broadcast_ss (float const * mem_addr) VBROADCASTSS xmm, m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<float> broadcast(in float src, out Vec128<float> dst)
        {
            dst = BroadcastScalarToVector128(refptr(ref asRef(in src)));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<double> broadcast(in double src, out Vec128<double> dst)
        {
            dst = Vec128.FromParts(src,src);
            return ref dst;
        }

        /// <summary>
        /// __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<float> maskload(ref float src, Vec128<float> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> maskload(ref double src, Vec128<double> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<float> maskload(ref float src, Vec256<float> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<double> maskload(ref double src, Vec256<double> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// void _mm_maskstore_ps (float * mem_addr, __m128i mask, __m128 a) VMASKMOVPS m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(Vec128<float> src, Vec128<float> mask, ref float dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm_maskstore_pd (double * mem_addr, __m128i mask, __m128d a) VMASKMOVPD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(Vec128<double> src, Vec128<double> mask, ref double dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_ps (float * mem_addr, __m256i mask, __m256 a) VMASKMOVPS m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(Vec256<float> src, Vec256<float> mask, ref float dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_pd (double * mem_addr, __m256i mask, __m256d a) VMASKMOVPD m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void maskstore(Vec256<double> src, Vec256<double> mask, ref double dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// __m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm
        /// Moves the lower single-precision (32-bit) floating-point element from b to the lower element of dst, and copy 
        /// the upper 3 elements from a to the upper elements of dst.
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<float> movescalar(in Vec128<float> lhs, in Vec128<float> rhs)
            => MoveScalar(rhs,lhs);

        /// <summary>
        /// __m128d _mm_move_sd (__m128d a, __m128d b) MOVSD xmm, xmm
        /// Moves the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy 
        /// the upper element from "a" to the upper element of "dst"
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> movescalar(in Vec128<double> lhs, in Vec128<double> rhs)
            => MoveScalar(lhs,rhs);

        /// <summary>
        /// _mm256_insertf128_ps: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<float> insert(in Vec128<float> src, in Vec256<float> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// _mm256_insertf128_pd: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<double> insert(in Vec128<double> src, in Vec256<double> dst, byte index)        
            => InsertVector128(dst,src,index);

        /// <summary>
        /// __m128 _mm_unpacklo_ps (__m128 a, __m128 b) UNPCKLPS xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> unpacklo(in Vec128<float> lhs, in Vec128<float> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m128d _mm_unpacklo_pd (__m128d a, __m128d b) UNPCKLPD xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> unpacklo(in Vec128<double> lhs, in Vec128<double> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256 _mm256_unpacklo_ps (__m256 a, __m256 b) VUNPCKLPS ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> unpacklo(in Vec256<float> lhs, in Vec256<float> rhs)
            => UnpackLow(lhs,rhs);

        /// <summary>
        /// __m256d _mm256_unpacklo_pd (__m256d a, __m256d b) VUNPCKLPD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> unpacklo(in Vec256<double> lhs, in Vec256<double> rhs)
            => UnpackLow(lhs,rhs);
 
         /// <summary>
        /// __m128 _mm_unpackhi_ps (__m128 a, __m128 b) UNPCKHPS xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> unpackhi(in Vec128<float> lhs, in Vec128<float> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m128d _mm_unpackhi_pd (__m128d a, __m128d b) UNPCKHPD xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> unpackhi(in Vec128<double> lhs, in Vec128<double> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256 _mm256_unpackhi_ps (__m256 a, __m256 b) VUNPCKHPS ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> unpackhi(in Vec256<float> lhs, in Vec256<float> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256d _mm256_unpackhi_pd (__m256d a, __m256d b) VUNPCKHPD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> unpackhi(in Vec256<double> lhs, in Vec256<double> rhs)
            => UnpackHigh(lhs,rhs);

    }
}