//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class RandomSizedX
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
        /// Produces a random <see cref='Z0.M512'/> value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static M512 M512<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => m512.define(random.Stream(domain, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());

        /// <summary>
        /// Produces a random <see cref='Z0.M256i'/> value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m256i M256i<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
                => default;
        
        /// <summary>
        /// Produces a random <see cref='Z0.M512'/> value
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static M512 M512<T>(this IRandomSource random, Func<T,bool> filter = null)
            where T : struct
                => m512.define(random.Stream<T>(null, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());
    }
}