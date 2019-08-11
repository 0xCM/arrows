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
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector<T> GenericVector<T>(this IRandomSource random, int len, Interval<T>? domain = null)
            where T : struct
        {
            var dst = Vector.Alloc<T>(len);
            if(domain != null)
                random.StreamTo(domain.Value, len, ref dst[0]);
            else
                random.StreamTo(len, ref dst[0]);
            
            return dst;
        }

        public static Vector<T> GenericVector<S,T>(this IRandomSource random, int len, Interval<S>? domain = null, T rep = default)        
            where S: struct
            where T : struct
                => random.GenericVector<S>(len,domain).Convert<T>();
        
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

        public static Vector<N,T> NatVector<N,S,T>(this IRandomSource random, Interval<S> domain, N n = default, T rep = default)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => random.NatVector<N,S>(domain).Convert<T>();

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

