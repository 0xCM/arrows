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

    /// <summary>
    /// Defines an api for accessing/specifying 128-bit pattern vectors
    /// </summary>
    public static class Vec128Pattern
    {
        /// <summary>
        /// Defines a vector of 32 or 64-bit floating point values where each component 
        /// has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        public static ref readonly Vec128<T> FpSignMask<T>()
            where T : struct
                => ref Vec128Pattern<T>.FpSignMask;

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [0, 1, ..., N - 1]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec128<T> Increasing<T>()
            where T : struct
                => ref Vec128Pattern<T>.Increasing;

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [N - 1, N - 2, , ..., 0]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec128<T> Decreasing<T>()
            where T : struct
                => ref Vec128Pattern<T>.Decreasing;

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Increments<T>(T first = default, params Swap[] swaps)
            where T : struct  
                => Vec128Pattern<T>.Increments(first,swaps);

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec128<T> Decrements<T>(T last = default, params Swap[] swaps)
            where T : struct  
                => Vec128Pattern<T>.Decrements(last, swaps);

        /// <summary>
        /// Creates a mask that, when applied to a source vector, effects a sequence of transpositions
        /// </summary>
        /// <param name="swaps">The transpositions</param>
        [MethodImpl(Inline)]
        public static Vec128<T> Swap<T>(params Swap[] swaps)
            where T : struct  
                => Vec128.Increments(default(T), swaps);

    }


}