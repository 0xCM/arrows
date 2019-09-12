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
        /// Allocates and fills a memory span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random vaue tyep</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> MemorySpan<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged        
                => random.Memory(length,domain,filter);        

        /// <summary>
        /// Allocates and fills a memory span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random vaue tyep</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> MemorySpan<T>(this IPolyrand random, int length, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged        
                => random.Memory(length, (min,max), filter);        

        /// <summary>
        /// Allocates and produces a memory span populated with random values constrained to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The sample domain</param>
        /// <typeparam name="T">The primal random vaue tyep</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> MemorySpan<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : struct
                => random.Memory(length,domain);
    }
}