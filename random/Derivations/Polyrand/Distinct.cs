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
        /// Samples an indexed set without replacement
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="sourceCount">The total number of items in the set</param>
        /// <param name="sampleCount">The number of items to draw</param>
        /// <remarks>Derived from MsInfer algorithm</remarks>
        public static IEnumerable<int> SampleDistinct(this IPolyrand random, int sourceCount, int sampleCount)
        {
            if(gmath.gt(sampleCount, sourceCount))
                throw new ArgumentException($"The count of of distinct values {sampleCount} exceeds the number of values in the source {sourceCount}");

            var set = new HashSet<int>();
            if (sampleCount > sourceCount / 2)
            {
                var src = alloc<int>(sourceCount, i => i);
                random.Shuffle(src);
                for (int i = 0; i < sampleCount; i++)
                    set.Add(src[i]);
            }
            else
            {
                // use rejection
                for (int i = 0; i < sampleCount; i++)
                {
                    while (true)
                    {
                        int item = random.Next(sourceCount);
                        if (!set.Contains(item))
                        {
                            set.Add(item);
                            break;
                        }
                    }
                }
            }
            return set;
        }

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

        public static IEnumerable<T> SampleDistinct<T>(this IPolyrand random,  T sourceCount, T sampleCount)
            where T : struct
        {            
            var indices = random.SampleDistinct(convert<T,int>(sourceCount), convert<T,int>(sampleCount));
            foreach(var i in indices)
                yield return convert<int,T>(i);
        }
    }

}