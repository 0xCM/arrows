//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class RngX
    {
        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeArray(length);

        /// <summary>
        /// Produces an array of random values between specified lower and upper bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="min">The inclusive minimum potential value</param>
        /// <param name="min">The exclusive maximum potential value</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, T min, T max, Func<T,bool> filter = null)
            where T : struct
                => random.Stream((min,max),filter).TakeArray(length);
         
        /// <summary>
        /// Produces a pnuncured array of random values that excludes 0
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] NonZeroArray<T>(this IPolyrand random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);        
    }

}