//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class RngX
    {
        /// <summary>
        /// Samples a memory segment of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The number of elements in the segment</param>
        /// <param name="domain">The sample domain, if specified</param>
        /// <param name="filter">The filter, if specified</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> Memory<T>(this IRandomSource random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var stream = domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>();
            return stream.TakeMemory(length);
        }

    }

}