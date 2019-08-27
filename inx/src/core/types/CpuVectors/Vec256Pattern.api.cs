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
    
    using static zfunc;

    public static class Vec256Pattern
    {
        
        /// <summary>
        /// Retruns a reference to a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern M will
        /// describe a permutation that has the following effect: permute(X,M) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec256<T> LaneMerge<T>()
            where T : struct
                => ref Vec256Pattern<T>.LaneMerge;

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [0, 1, ..., N - 1]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec256<T> Increasing<T>()
            where T : struct
                => ref Vec256Pattern<T>.Increasing;

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [N - 1, N - 2, , ..., 0]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec256<T> Decreasing<T>()
            where T : struct
                => ref Vec256Pattern<T>.Decrements;

        /// <summary>
        /// Describes a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec256<T> ClearAlt<T>()
            where T : struct
                => ref Vec256Pattern<T>.ClearAlt;

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Increments<T>(T first = default, params Swap[] swaps)
            where T : struct  
        {
            var n = Vec256<T>.Length;
            var dst = Span256.Alloc<T>(n);
            var val = first;
            for(var i=0; i < n; i++)
            {
                dst[i] = val;
                gmath.inc(ref val);
            }
            return Vec256.Load(dst.Swap(swaps));
        }

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec256<T> Decrements<T>(T last = default, params Swap[] swaps)
            where T : struct  
        {
            var n = Vec256<T>.Length;
            var dst = Span256.Alloc<T>(n);
            var val = last;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return Vec256.Load(dst.Swap(swaps));
        }


        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Alternate<T>(T a, T b)
            where T : struct
        {            
            var n = Vec256<T>.Length;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
                dst[i] = even(i) ? a : b;
            return Vec256.Load(ref head(dst));
        }
    }
}