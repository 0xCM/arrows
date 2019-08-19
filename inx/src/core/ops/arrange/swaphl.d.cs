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
        const byte SwapHiLoMask = 0b_01_00_11_10;

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> swaphl(in Vec256<byte> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> swaphl(in Vec256<sbyte> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> swaphl(in Vec256<short> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> swaphl(in Vec256<ushort> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> swaphl(in Vec256<int> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> swaphl(in Vec256<uint> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> swaphl(in Vec256<long> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> swaphl(in Vec256<ulong> src)
            => perm4x64(src, SwapHiLoMask);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> swaphl(in Vec256<double> src)
            => perm4x64(src, SwapHiLoMask);


    }

}