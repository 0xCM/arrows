//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;


    [DisplayName("scenarios-intrinsic")]
    class IntrinsicScenarios
    {
        [MethodImpl(Inline | Optimize)]
        public static Vec128<sbyte> add1(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Add(lhs, rhs);
        
        [MethodImpl(Inline | Optimize)]
        public static Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Add(lhs, rhs);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vec256<long> permute4x64(in Vec256<long> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> permute4x64(in Vec256<ulong> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vec256<double> permute4x64(in Vec256<double> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<long> permute4x64(in Vector256<long> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<ulong> permute4x64(in Vector256<ulong> value, byte control)
            => Permute4x64(value,control);

        ///<intrinsic>__m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<double> permute4x64(in Vector256<double> value, byte control)
            => Permute4x64(value,control);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<long> shiftlw(in Vector256<long> src, byte count)
            => ShiftLeftLogical128BitLane(src, count);

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vector256<ulong> shiftlw(Vector256<ulong> src, byte count)
            => ShiftLeftLogical128BitLane(src, count); 

        /// <intrinsic>__m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8</intrinsic>
        [MethodImpl(Inline | Optimize)]
        public static Vec256<ulong> shiftlw(Vec256<ulong> src, byte count)
            => ShiftLeftLogical128BitLane(src, count); 

    }


}