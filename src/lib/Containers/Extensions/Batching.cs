//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;



    using static Z0.Bibliography;
    using static zcore;


    partial class xcore
    {


        /// <summary>
        /// Runs through a <see cref="IEnumerable{T}"/> in batches
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="source">The item source</param>
        /// <param name="max">The maximum number of elements per batch</param>
        /// <returns></returns>
        /// <remarks>
        /// Implementation inspired from https://github.com/morelinq/MoreLINQ
        /// </remarks>
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int max)
        {
            var buffer = default(T[]);
            var count = 0;
            var sw = default(Stopwatch);

            foreach (var item in source)
            {
                if (buffer == null)
                {
                    sw = Stopwatch.StartNew();
                    buffer = new T[max];
                }

                buffer[count++] = item;

                if (count != max)
                    continue;
                var elapsed = sw.ElapsedMilliseconds;
                yield return buffer.ToList();

                buffer = null;
                count = 0;
            }

            if (buffer != null && count > 0)
                yield return buffer.Take(count);
        }

        /// <summary>
        /// Applies the supplied processor to blocks of at most <paramref name="batchSize"/> items at a time yielded from the enumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The items to process</param>
        /// <param name="processor">The processor</param>
        /// <param name="batchSize">The block size</param>
        public static void ProcessBatches<T>(this IEnumerable<T> items, Action<IReadOnlyList<T>> processor, int batchSize, Action<int> processed)
        {
            var batch = new List<T>(batchSize);
            foreach (var item in items)
            {
                batch.Add(item);
                if (batch.Count == batchSize)
                {
                    processor(batch);
                    processed(batch.Count);
                    batch.Clear();
                }
            }

            if (batch.Count != 0)
            {
                processor(batch);
                processed(batch.Count);
            }

            batch.Clear();
        }

        /// <summary>
        /// Applies the supplied processor to blocks of at most <paramref name="batchSize"/> items at a time yielded from the enumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The items to process</param>
        /// <param name="processor">The processor</param>
        /// <param name="batchSize">The block size</param>
        public static void ProcessBatches<T>(this IEnumerable<T> items, Action<IReadOnlyList<T>> processor, int batchSize)
            => items.ProcessBatches(processor, batchSize, (count) => { });


    }
}