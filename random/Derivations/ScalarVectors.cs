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
        /// Produces a generic random vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector<T> GenericVec<T>(this IRandomSource random, int len, Interval<T>? domain = null)
            where T : struct
        {
            var dst = Vector.Alloc<T>(len);
            if(domain != null)
                random.StreamTo(domain.Value, len, ref dst[0]);
            else
                random.StreamTo(len, ref dst[0]);            
            return dst;
        }

        /// <summary>
        /// Produces a generic random vector over one domain and converts it to a vector over another
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The vector length</param>
        /// <param name="domain">The domain over which random selection will occur</param>
        /// <param name="rep">A target domain representative</param>
        /// <typeparam name="S">The source domain type</typeparam>
        /// <typeparam name="T">The target domain type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<T> GenericVec<S,T>(this IRandomSource random, int len, Interval<S>? domain = null, T rep = default)        
            where S: struct
            where T : struct
                => random.GenericVec<S>(len,domain).Convert<T>();
        
        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IRandomSource random, Interval<T> domain, ref Vector<N,T> vector, N n = default)
            where T : struct
            where N : ITypeNat, new()
                => random.StreamTo<T>(domain, nati<N>(), ref vector.Unsized[0]);

        /// <summary>
        /// Populates a vector of natural length with random values from the source
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
        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,T>(this IRandomSource random, Interval<T> domain, N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var dst = Vector.Alloc<N,T>();
            random.Fill(domain, ref dst);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a pair of natural length vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The vector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static VectorPair<N,T> NatVecPair<N,T>(this IRandomSource random, N length = default)
            where T : struct
            where N : ITypeNat, new()
                => new VectorPair<N, T>(random.NatVec<N,T>(),random.NatVec<N,T>());

        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,S,T>(this IRandomSource random, Interval<S> domain, N n = default, T rep = default)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => random.NatVec<N,S>(domain).Convert<T>();

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,T>(this IRandomSource random,  N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var dst = Vector.Alloc<N,T>();
            random.Fill(ref dst);
            return dst;
        }
    }
}

