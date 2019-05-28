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

    using static As;
    using static zfunc;
    
    public static class RandomX
    {

        public static IEnumerable<T> NonZeroStream<T>(this IRandomizer random, Interval<T>? domain = null)
                where T : struct
                    => random.Stream(domain, gmath.nonzero);

       public static T NonZeroSingle<T>(this IRandomizer src, Interval<T>? domain = null)
            where T : struct
                => src.NonZeroStream<T>(domain).Single();
         
        public static T[] NonZeroArray<T>(this IRandomizer random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);        

        public static unsafe Span<T> NonZeroSpan<T>(this IRandomizer random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);        

        public static Span128<T> NonZeroSpan128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, gmath.nonzero);

        public static Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain,  bool nonzero = false)
            where T : struct
        {
            Func<T,bool> filter = nonzero ? new Func<T,bool>(gmath.nonzero) : null;
            return random.Span128<T>(blocks, domain, filter);
        }

        public static Span256<T> NonZeroSpan256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, gmath.nonzero);

    }
}