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
    using System.Collections.Generic;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    
    using static zfunc;


    partial class dinx
    {        

        /// <summary>
        /// 00 -> 10 | 0 -> 2
        /// 01 -> 11 | 1 -> 3
        /// 02 -> 00 | 2 -> 0
        /// 03 -> 01 | 3 -> 1
        /// </summary>
        const byte MSwapHiLo = 0b_01_00_11_10;

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> swaphl(in Vec256<byte> src)
        {
            Vec256<byte> dst = default;
            dst = insert(extract128(src, 1), dst, 0);
            dst = insert(extract128(src, 0), dst, 1);
            return dst;         
            //perm4x64(src, MSwapHiLo);

        }

        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        ///<intrinsic>__m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256,</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<byte> perm4x64(in Vec256<byte> value, byte control)
            => perm4x64(value.As<ulong>(),control).As<byte>();

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> swaphl(in Vec256<long> src)
            => Permute4x64(src,MSwapHiLo);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> swaphl(in Vec256<ulong> src)
            => Permute4x64(src,MSwapHiLo);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> swaphl(in Vec256<double> src)
            => Permute4x64(src,MSwapHiLo);
    }

}