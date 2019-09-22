//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    public static class YmmPattern
    {
        public static YMM Increments<T>(T first = default, params Swap[] swaps)
            where T : unmanaged
                => YmmPattern<T>.Increments();

        public static YMM Decrements<T>(T first = default, params Swap[] swaps)
            where T : unmanaged
                => YmmPattern<T>.Decrements();

        public static ref readonly YMM Increasing<T>()
            where T : unmanaged
                => ref YmmPattern<T>.Increasing;

        public static ref readonly YMM Decreasing<T>()
            where T : unmanaged
                => ref YmmPattern<T>.Decreasing;

    }

    static class YmmPattern<T>
        where T : unmanaged
    {
        static readonly int Length = YMM.CellCount<T>();

        public static readonly YMM Increasing = Increments();

        public static readonly YMM Decreasing = Decrements(convert<T>(Length - 1));

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static YMM Increments(T first = default, params Swap[] swaps)
        {
            
            var dst = Span256.Alloc<T>(Length);
            var val = first;
            for(var i=0; i < dst.Length; i++)
            {
                dst[i] = val;
                gmath.inc(ref val);
            }
            return YMM.From(dst.Swap(swaps));
        }

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static YMM Decrements(T last = default, params Swap[] swaps)
        {
            var dst = Span256.Alloc<T>(Length);
            var val = last;
            for(var i=0; i<dst.Length; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return YMM.From(dst.Swap(swaps));
        }

    }

}