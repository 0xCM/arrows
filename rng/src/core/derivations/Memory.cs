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
        /// Allocates and produces a memory segment populated with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
            => (domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>()).TakeMemory(length);

        /// <summary>
        /// Allocates and produces a memory segment populated with random values constrained to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The sample domain</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : struct
                => random.Stream<T>(domain).TakeMemory(length);

        /// <summary>
        /// Allocates and produces a punctured memory segment populated with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The number of elements in the segment</param>
        /// <param name="domain">The sample domain, if specified</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> NonZeroMemory<T>(this IPolyrand random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Memory<T>(samples, domain, gmath.nonzero);        
    }

}