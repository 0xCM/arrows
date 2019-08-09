//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    partial class RngX
    {        
        /// <summary>
        /// Produces a random 128-bit intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Vec128<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span128<T>(1, domain, filter).LoadVec128();

        /// <summary>
        /// Produces a stream of random 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IEnumerable<Vec128<T>> Vec128Stream<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
        {
            while(true)
                yield return random.Vec128(domain,filter);
        }

        /// <summary>
        /// Produces a random 256-bit intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Vec256<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span256<T>(1, domain, filter).LoadVec256();

        /// <summary>
        /// Produces a stream of random 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IEnumerable<Vec256<T>> Vec256Stream<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
        {
            while(true)            
                yield return random.Vec256(domain,filter);
        }

        /// <summary>
        /// Produces a random <see cref='Z0.__m512'/> value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static __m512i m512i<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => __m512i.Define(random.Stream(domain, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());
        
        /// <summary>
        /// Produces a random <see cref='Z0.__m512'/> value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static __m512i m512i<T>(this IRandomSource random, Func<T,bool> filter = null)
            where T : struct
                => __m512i.Define(random.Stream<T>(null, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());
    }
}