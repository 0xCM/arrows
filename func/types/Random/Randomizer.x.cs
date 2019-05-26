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

    using static zfunc;

    public static class RandomizerX
    {

        public static IRandomizer<T> Random<T>(this IRandomizer random)
            where T : struct
                => (IRandomizer<T>)(random);

        public static IEnumerable<T> Stream<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => filter != null 
                ? random.Random<T>().Stream(Randomizer.Domain(domain)).Where(filter) 
                : random.Random<T>().Stream(Randomizer.Domain(domain));

        public static unsafe void StreamTo<T>(this IRandomizer random, int length, Interval<T>? domain, Func<T,bool> filter, void* pDst)
            where T : struct
                => random.Random<T>().StreamTo(Randomizer.Domain(domain), length, pDst, filter);

        public static T Single<T>(this IRandomizer src, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => src.Stream<T>(domain).Single();

        public static unsafe Span<T> Span<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {            
            var dst = span<T>(length);
            random.StreamTo(length, Randomizer.Domain(domain), filter, Unsafe.AsPointer(ref dst[0]));
            return dst;
        }

        public static T[] Array<T>(this IRandomizer random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(Randomizer.Domain(domain), filter).TakeArray((int)length);

    }

}