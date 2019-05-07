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

        unsafe void StreamTo(Interval<T> domain, int count, void* dst, Func<T,bool> filter = null); 
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
        public static T[] Array128<T>(this IRandomizer random, int blocks = 1)
            where T : struct, IEquatable<T>
            => random.Array<T>(Z0.Vec128<T>.Length*blocks);

        /// <summary>
        /// Produces a random array that occupies 128 bits = 16 bytes of memory
        /// </summary>
        public static T[] Array256<T>(this IRandomizer random, int blocks = 1)
            where T : struct, IEquatable<T>
            => random.Array<T>(Z0.Vec256<T>.Length*blocks);

        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        public static Vec128<T> Vec128<T>(this IRandomizer random)        
            where T : struct, IEquatable<T>
                => Z0.Vec128.single<T>(random.Array128<T>());

        static Interval<T> domain<T>()
            where T : struct, IEquatable<T>
                => Defaults.get<T>().Domain;

        public static unsafe Span128<T> Span128<T>(this IRandomizer random, int blocks, Interval<T>? domain = null)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(Z0.Span128.blocklength<T>(blocks));
            var pDst = pvoid(ref dst[0]);
            random.StreamTo(domain ?? domain<T>(), blocks, pDst);
            return Z0.Span128.load(dst);
        }

        public static unsafe Span256<T> Span256<T>(this IRandomizer random, int blocks, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(Z0.Span256.blocklength<T>(blocks));            
            var pDst = pvoid(ref dst[0]);
            random.StreamTo(domain ?? domain<T>(), blocks, pDst);
            return Z0.Span256.load(dst);
        }

        /// <summary>
        /// Produces an array of 128-bit random vectors
        /// </summary>
        public static unsafe Vec128<T>[] Vec128<T>(this IRandomizer random, int count, Interval<T>? domain = null)        
            where T : struct, IEquatable<T>
        {
            var dst = alloc<Vec128<T>>(count);
            var vLen = Z0.Vec128<T>.Length;
            var src = random.Array<T>(domain ?? domain<T>(), vLen*count);
            for(var i = 0; i< count; i+= vLen)
                dst[i] = Z0.Vec128.single(src,i);
            return dst;
        }

        /// <summary>
        /// Produces a random 128-bit vector
        /// </summary>
        public static Vec256<T> Vec256<T>(this IRandomizer random)        
            where T : struct, IEquatable<T>
                => Z0.Vec256.single<T>(random.Array256<T>());

        public static R[] Array<R>(this IRandomizer random, int count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => random.Stream(domain<R>(), filter).TakeArray((int)count);

        public static R[] Array<R>(this IRandomizer random, uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => random.Stream(domain<R>(),filter).TakeArray((int)count);

        public static IEnumerable<R[]> Arrays<R>(this IRandomizer random, Interval<R> domain, int len, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
        {
            while(true)
                yield return random.Array<R>(domain,len,filter);
        }

        public static unsafe void StreamTo<T>(this IRandomizer random, Interval<T> domain, int count, void* pDst, Func<T,bool> filter = null)
            where T : struct, IEquatable<T>
                => random.Random<T>().StreamTo(domain, count, pDst);
    }
}