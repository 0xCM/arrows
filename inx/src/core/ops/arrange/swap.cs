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

        [MethodImpl(Inline)]
        public static Vec256<int> swap(Vec256<int> src, byte i, byte j)
        {
            Span<int> control = stackalloc int[Vec256<int>.Length];
            for(byte k=0; k<control.Length; k++)
            {
                if(k == i)        
                    control[k] = j;
                else if(k == j)
                    control[k] = i;
                else
                    control[k] = k;
            }
            return perm8x32(src, Vec256.Load(control));
        }

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
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> swaphl(in Vec256<sbyte> src)
        {
            Vec256<sbyte> dst = default;
            dst = insert(extract128(src, 1), dst, 0);
            dst = insert(extract128(src, 0), dst, 1);
            return dst;         
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> swaphl(in Vec256<short> src)
        {
            Vec256<short> dst = default;
            dst = insert(extract128(src, 1), dst, 0);
            dst = insert(extract128(src, 0), dst, 1);
            return dst;         
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> swaphl(in Vec256<ushort> src)
        {
            Vec256<ushort> dst = default;
            dst = insert(extract128(src, 1), dst, 0);
            dst = insert(extract128(src, 0), dst, 1);
            return dst;         
        }

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