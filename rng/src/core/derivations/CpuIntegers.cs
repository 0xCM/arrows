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
        /// Produces a random 128-bit cpu integer
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> CpuInt128<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => m128i.From(random.Span128<T>(1, domain, filter).Unblocked);

        /// <summary>
        /// Produces a random 128-bit cpu integer for which components satisfy specific upper/lower bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> CpuInt128<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => m128i.From(random.Span128<T>(1, (min,max), filter).Unblocked);

        /// <summary>
        /// Produces a random 128-bit cpu integer for which components satisfy specific upper/lower bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The range of potential component values</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> CpuInt128<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => m128i.From(random.Span128<T>(1, domain, filter).Unblocked);

        /// <summary>
        /// Produces a random 256-bit cpu integer
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The optional range from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m256i<T> CpuInt256<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => m256i.From(random.Span256<T>(1, domain, filter).Unblocked);

        /// <summary>
        /// Produces a random 256-bit cpu integer for which components satisfy specific upper/lower bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m256i<T> CpuInt256<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => m256i.From(random.Span256<T>(1, (min,max), filter).Unblocked);

        /// <summary>
        /// Produces a random 256-bit cpu integer for which components satisfy specific upper/lower bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The range of potential component values</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static m256i<T> CpuInt256<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => m256i.From(random.Span256<T>(1, domain, filter).Unblocked);
    }

}