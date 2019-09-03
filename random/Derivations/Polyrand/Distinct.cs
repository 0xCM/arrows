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
        /// Samples the source values without replacement
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="source">The data source</param>
        /// <param name="count">The number of values to sample</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<T> SampleDistinct<T>(this IPolyrand random,  T[] source, int count)
        {
            var indices = random.SampleDistinct(source.Length, count);
            foreach(var i in indices)
                yield return source[i];
        }

        public static HashSet<T> SampleDistinct<T>(this IPolyrand random, T pool, int count)
            where T : struct
        {
            var src = random.Stream(default(T), pool);
            var set = src.Take(count).ToHashSet();
            while(set.Count < count)
                set.AddRange(src.Take(count / 2));
            return set;
        }

        public static HashSet<T> SampleDistinct<T>(this IPolyrand random, T pool, T count)
            where T : struct
        {
            var src = random.Stream(default(T), pool);
            var _count = convert<T,int>(count);
            var set = src.Take(_count).ToHashSet();
            while(set.Count < _count)
                set.AddRange(src.Take(_count / 2));
            return set;
        }

        /// <summary>
        /// Takes a specified number of distinct points from a source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to take</param>
        /// <typeparam name="T">The element type</typeparam>
        public static HashSet<T> SampleDistinct<T>(this IPolyrand random, int count)
            where T : struct
        {
            var stream = random.Stream<T>();
            var set = stream.Take(count).ToHashSet();
            while(set.Count < count)
                set.AddRange(stream.Take(set.Count - count));
            return set;
        }

        /// <summary>
        /// Takes a specified number of distinct points from a source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to take</param>
        /// <typeparam name="T">The element type</typeparam>
        public static HashSet<T> TakeSet<T>(this IPointSource<T> random, int count)
            where T : struct
        {
            var src =  random.Stream();
            var set = src.Take(count).ToHashSet();
            while(set.Count < count)
                set.AddRange(src.Take(count / 2));
            return set;
        }


    }

}