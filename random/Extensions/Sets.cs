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
        /// Retrieves a set of distinct random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of distinct elements in the resulting set</param>
        public static HashSet<T> TakeSet<T>(this IRandomSource random, int count)
            where T : struct
        {
            var stream = random.Stream<T>();
            var set = stream.Take(count).ToHashSet();
            while(set.Count < count)
                set.AddRange(stream.Take(set.Count - count));
            return set;
        }

        public static HashSet<T> TakeSet<T>(this IRandomSource<T> random, int count)
            where T : struct
        {
            var stream = random.Stream();
            var set = stream.Take(count).ToHashSet();
            while(set.Count < count)
                set.AddRange(stream.Take(set.Count - count));
            return set;
        }

    }

}