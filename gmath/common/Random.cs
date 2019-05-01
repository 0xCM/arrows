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

    using static zcore;


    public interface IRandomizer 
    {
        
    }

    public interface IRandomizer<T> : IRandomizer
        where T : struct, IEquatable<T>
    {
        IEnumerable<T> stream(Interval<T> domain);
        
        IEnumerable<T> stream(T min, T max); 

        IEnumerable<T> stream();       
    }
    
    public static class RandomX
    {
        public static IRandomizer<T> Random<T>(this IRandomizer random)
            where T : struct, IEquatable<T>
                => (IRandomizer<T>)(random);

        public static IEnumerable<R> Stream<R>(this IRandomizer random, Interval<R> domain, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                 => filter != null 
                 ? random.Random<R>().stream(domain).Where(filter) 
                 : random.Random<R>().stream(domain);

        public static R[] Array<R>(this IRandomizer random, Interval<R> domain, int count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => random.Stream(domain,filter).TakeArray(count);

        public static R[] Array<R>(this IRandomizer random, Interval<R> domain, uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => random.Stream(domain,filter).TakeArray((int)count);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array128<T>(this IRandomizer random)
            where T : struct, IEquatable<T>
            => random.Array<T>(Z0.Vec128<T>.Length);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array256<T>(this IRandomizer random)
            where T : struct, IEquatable<T>
            => random.Array<T>(Z0.Vec256<T>.Length);

        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        public static Vec128<T> Vec128<T>(this IRandomizer random)        
            where T : struct, IEquatable<T>
                => Z0.Vec128.single<T>(random.Array128<T>());

        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        public static Vec256<T> Vec256<T>(this IRandomizer random)        
            where T : struct, IEquatable<T>
                => Z0.Vec256.single<T>(random.Array256<T>());

        public static R[] Array<R>(this IRandomizer random, int count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => random.Stream(Defaults.get<R>().Domain,filter).TakeArray((int)count);

        public static R[] Array<R>(this IRandomizer random, uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => random.Stream(Defaults.get<R>().Domain,filter).TakeArray((int)count);

        public static IEnumerable<R[]> Arrays<R>(this IRandomizer random, Interval<R> domain, int len, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
        {
            while(true)
                yield return random.Array<R>(domain,len,filter);
        }


    }


}