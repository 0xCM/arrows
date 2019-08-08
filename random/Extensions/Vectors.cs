//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class RngX
    {
        /// <summary>
        /// Populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public static void Fill<N,T>(this IRandomSource random, Interval<T> domain, ref Vector<N,T> vector, N n = default)
            where T : struct
            where N : ITypeNat, new()
                => random.StreamTo<T>(domain, nati<N>(), ref vector.Unsized[0]);

        /// <summary>
        /// Populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public static void Fill<N,T>(this IRandomSource random, ref Vector<N,T> vector, N n = default)
            where T : struct
            where N : ITypeNat, new()
                => random.StreamTo<T>(nati<N>(), ref vector.Unsized[0]);

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector<N,T> NatVector<N,T>(this IRandomSource random, Interval<T> domain, N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var dst = Vector.Alloc<N,T>();
            random.Fill(domain, ref dst);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector<N,T> NatVector<N,T>(this IRandomSource random,  N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var dst = Vector.Alloc<N,T>();
            random.Fill(ref dst);
            return dst;
        }

    }

}

