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
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;


    partial class UniformRandom
    {
        public static IEnumerable<T> Stream<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(domain,filter);


        [MethodImpl(Inline)]
        public static IEnumerable<T> NonZeroStream<T>(this IRandomSource random, Interval<T>? domain = null)
                where T : struct
                    => random.UniformStream(domain, gmath.nonzero);

        public static void StreamTo<T>(this IRandomSource random, Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : struct
        {
            var it = random.Stream<T>(domain,filter).Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }

    }

}