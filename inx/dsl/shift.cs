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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class x86
    {
        /// <summary>
        ///  Right-shifts the components of a common value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="imm8"></param>
        /// <intrinsic>__m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_srli_epi64(in m256i a, byte imm8)
            => ShiftRightLogical(v64i(a), imm8);

        /// <summary>
        ///  Left-shifts the components of a common value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="imm8"></param>
        /// <intrinsic>__m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_slli_epi64(in m256i a, byte imm8)
            => ShiftLeftLogical(v64i(a), imm8);

        /// <summary>
        ///  Right-shifts the components of the first vector by the values specified by the corresponding components in the second
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>__m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_srlv_epi32(in m256i a, in m256i b)
            => ShiftRightLogicalVariable(v32u(a),v32u(b));
    
        /// <summary>
        ///  Left-shifts the components of the first vector by the values specified by the corresponding components in the second
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>_mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_sllv_epi32(in m256i a, in m256i b)
            => ShiftLeftLogicalVariable(v32u(a),v32u(b));
        
    }
}