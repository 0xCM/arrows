//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {

        /// <summary>
        /// Partitions the source into sub-arrays of a maximum length
        /// </summary>
        /// <param name="src"></param>
        /// <param name="max"></param>
        /// <typeparam name="T"></typeparam>
        public static IEnumerable<T[]> Partition<T>(this IEnumerable<T> src, int max)
        {
            var list = new List<T>();
            foreach (var item in src)
            {
                list.Add(item);
                if (list.Count == max)
                {
                    yield return list.ToArray();
                    list = new List<T>();
                }
            }
            if (list.Count != 0)
                yield return list.ToArray();
        }

        /// <summary>
        /// Partitions the source array into a sequence of array segments
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="width">The maximal segment width</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<ArraySegment<T>> Partition<T>(this T[] src, int width)
        {
            var count = Math.DivRem(src.Length,width, out int overflow);            
            for(var i = 0; i < count; i++)
                yield return new ArraySegment<T>(src, i*width, width);                    

            if(overflow != 0)
            {
                var last = alloc<T>(width);
                for(var i = count; i< src.Length; i++)
                    last[i] = src[i];
                yield return new ArraySegment<T>(last);
            }
        }

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

            foreach (var item in source)
            {
                if (buffer == null)
                    buffer = new T[max];

                buffer[count++] = item;

                if (count != max)
                    continue;
                yield return buffer;

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
       
        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        public static T[] Map<S, T>(this IEnumerable<S> src, Func<S, T> f)
            => src.Select(item => f(item)).ToArray();

        /// <summary>
        /// Constructs an integrally-indexed stream from a source stream
        /// </summary>
        /// <param name="index">The 0-based element index</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<(int index, T value)> Index<T>(this IEnumerable<T> src)
        {
            var i = 0;
            var it = src.GetEnumerator();            
            while(it.MoveNext())
                yield return (i++, it.Current);
        }
            
        /// <summary>
        /// Transforms an array via an indexed mapping function
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] Mapi<S, T>(this S[] src, Func<int,S, T> f)
        {
            var dst = new T[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(i,src[i]);
            return dst;
        }

        /// <summary>
        /// Transforms an array via an indexed mapping function with optional parallellism
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The mapping function</param>
        /// <param name="pll">Specifies whether the map the source values in parallell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] Mapi<S, T>(this S[] src, Func<int,S, T> f, bool pll)
        {
            if(!pll)
                return src.Mapi(f);
            
            var dst = new T[src.Length];
            var pllQuery = from index in range(src.Length).AsParallel()
                            select (index, value: f(index, src[index]));
            var results = pllQuery.ToArray();
            foreach(var result in results)
                dst[result.index] = result.value;
            return dst;
        }

        /// <summary>
        /// Creates a read-only list from a source sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> src)
            => src.ToList();

        /// <summary>
        /// Creates a multiset from a source sequence
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The data type</typeparam>
        public static Multiset<T> ToMultiSet<T>(this IEnumerable<T> src)
            => new Multiset<T>(src);

        /// <summary>
        /// Returns the first element if it exists; otherwise returns the supplied default
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The items to search</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        [MethodImpl(Inline)]
        public static T FirstOrDefault<T>(this IEnumerable<T> src, T @default)
            => src.Any() ? src.First() : @default;

        /// <summary>
        /// Returns the first element if it exists; otherwise returns the value supplied
        /// by invoking the default function
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The items to search</param>
        /// <param name="default">The function invoked to produce a default value</param>
        [MethodImpl(Inline)]
        public static T FirstOrDefault<T>(this IEnumerable<T> src, Func<T> @default)
            => src.Any() ? src.First() : @default();

        /// <summary>
        /// Returns the last element if it exists; otherwise returns the supplied default
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        [MethodImpl(Inline)]
        public static T LastOrDefault<T>(this IEnumerable<T> src, T @default = default)
            => src.Any() ? src.Last() : @default;

        /// <summary>
        /// Returns the last element if it exists; otherwise returns the value supplied
        /// by invoking the default function
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="default">The function invoked to produce a default value</param>
        [MethodImpl(Inline)]
        public static T LastOrDefault<T>(this IEnumerable<T> src, Func<T> @default)
            => src.Any() ? src.Last() : @default();

        /// <summary>
        /// Splits the input into two parts according to a supplied predicate
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to evaluate</param>
        /// <param name="predicate">The predicate used in the evaluation</param>
        /// <returns>A 2-tuple whose first member reflects the items that evaluated to false 
        /// and whose second member reflects the items that evaluated to true</returns>
        public static (IEnumerable<T> @false, IEnumerable<T> @true) Split<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            var f = new List<T>();
            var t = new List<T>();
            foreach (var item in items)
                if (predicate(item))
                    t.Add(item);
                else
                    f.Add(item);
            return (f, t);
        }

        /// <summary>
        /// Applies a function to the first item in the list that satisfies the predicate if such an item exists.
        /// If no such item exists, the function is applied to the default value of the item
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="R">The function result type</typeparam>
        /// <param name="items">The items to search</param>
        /// <param name="predicate">The predicate applied during the search</param>
        /// <param name="f">The function to apply to the identified item</param>
        [MethodImpl(Inline)]
        public static R OnFirstOrDefault<T, R>(this IEnumerable<T> items, Predicate<T> predicate, Func<T, R> f) 
            => f(items.FirstOrDefault(x => predicate(x)));

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static T Second<T>(this IEnumerable<T> src)
            => src.Skip(1).Take(1).Single();

        /// <summary>
        /// Returns the third term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static T Third<T>(this IEnumerable<T> src)
            => src.Skip(2).Take(1).Single();

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise returns the default value
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        [MethodImpl(Inline)]
        public static T SecondOrDefault<T>(this IEnumerable<T> items)
            => items.Take(2).LastOrDefault();

        /// <summary>
        /// Constructs a sequence of singleton sequences from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]   
        public static IEnumerable<IEnumerable<T>> Singletons<T>(this IEnumerable<T> src)
            => singletons(src);


        /// <summary>
        /// Determines whether two streams are identical
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="lhs">The first sequence</param>
        /// <param name="rhs">The second sequence</param>
        public static bool Eq<T>(this IEnumerable<T> lhs, IEnumerable<T> rhs)
            => System.Linq.Enumerable.SequenceEqual(lhs,rhs);            

        /// <summary>
        /// Forces enumerable evaluation
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)] 
        public static T[] Force<T>(this IEnumerable<T> src)
            => src.ToArray();

        /// <summary>
        /// Reduces a stream of element streams to an element stream
        /// </summary>
        /// <param name="src">The element streams</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static IEnumerable<T> Reduce<T>(this IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(y => y);

        /// <summary>
        /// Prepends one or more items to the head of the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The sequence that will be prependend</param>
        /// <param name="preceding">The items that will be prepended</param>
        [MethodImpl(Inline)]   
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> src, params T[] preceding)
            => preceding.Concat(src);
  
        /// <summary>
        /// Interleaves a specified value between each element of the source
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="x">The value to interleave</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Intersperse<T>(this IEnumerable<T> src, T x)
        {
            foreach(var item in src)
            {
                yield return item;
                yield return x;
            }
        }

        /// <summary>
        /// Applies the effect to each item in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="effect">The side-effect</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Effects<T>(this IEnumerable<T> src, Action<T> effect)
        {
            foreach(var item in src)
                effect(item);
        }

        /// <summary>
        /// Enumerates stream elements in pairs, until one of the streams is exhausted,
        /// invoking a traversal action for each enumerated pair
        /// </summary>
        /// <param name="lhs">The left stream</param>
        /// <param name="rhs">The right stream</param>
        /// <param name="effect">The side-effect</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void Effects<T>(this IEnumerable<T> lhs, IEnumerable<T> rhs, Action<T,T> effect)
        {
            var lenum = lhs.GetEnumerator();
            var renum = rhs.GetEnumerator();

            while(lenum.MoveNext() && renum.MoveNext())
                effect(lenum.Current, renum.Current);            

        }

        [MethodImpl(Inline)]   
        public static (IEnumerable<T> x, IEnumerable<T> y) Duplicate<T>(this IEnumerable<T> src)
            => (src, src);
        
        public static IEnumerable<T> Transform<S,T>(this IEnumerable<S> src, params Func<S,T>[] transformers)
            => src.Select(item => transformers.Select(t => t(item))).SelectMany(x => x);

    }
}