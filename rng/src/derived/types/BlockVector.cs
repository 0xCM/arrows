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

    partial class RngD
    {
        /// <summary>
        /// Produces a blocked vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static BlockVector<T> BlockVec<T>(this IPolyrand random, int len, Interval<T>? domain = null)
            where T : struct
        {
            var dst = BlockVector.Alloc<T>(len);
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
        public static BlockVector<T> BlockVec<S,T>(this IPolyrand random, int len, Interval<S>? domain = null, T rep = default)        
            where S: struct
            where T : struct
                => random.BlockVec<S>(len,domain).Convert<T>();

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> BlockVec<N,T>(this IPolyrand random, Interval<T> domain, N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var dst = BlockVector.Alloc<N,T>();
            random.Fill(domain, ref dst);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="n">The natural vector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="S">The sample domain type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> BlockVec<N,S,T>(this IPolyrand random, Interval<S> domain, N n = default)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => random.BlockVec<N,S>(domain).Convert<T>();

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> BlockVec<N,T>(this IPolyrand random,  N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var dst = BlockVector.Alloc<N,T>();
            random.Fill(ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolyrand random, Interval<T> domain, ref BlockVector<N,T> vector, N n = default)
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
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolyrand random, ref BlockVector<N,T> vector, N n = default)
            where T : struct
            where N : ITypeNat, new()
                => random.StreamTo<T>(nati<N>(), ref vector.Unsized[0]);

    }
}

