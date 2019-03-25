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



    using static Z0.Credit;
    using static corefunc;


    public static class ContainerX
    {
        /// <summary>
        /// Defines a window over a 1-d array beginning at a specified index 
        /// for a specified length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The 0-based starting index</param>
        /// <param name="len">The length of the segment</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> Segment<T>(this T[] src, uint start, uint len)
            => new ArraySegment<T>(src, (int)start, (int)len);

        /// <summary>
        /// Attaches a 0-based integer sequence to the input value sequence and
        /// yield the paired sequence elements
        /// </summary>
        /// <param name="i">The index of the paired value</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<(int i, T value)> Iteri<T>(this IEnumerable<T> items)
            => iteri(items);


        /// <summary>
        /// Partitions the source sequence into segments of natural length
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The segment length</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<IReadOnlyList<T>> Partition<N,T>(this IEnumerable<T> src)
            where N : TypeNat, new()
                => partition<N,T>(src);    
        
        /// <summary>
        /// Constructs a sequence of singleton sequences from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<IEnumerable<T>> Singletons<T>(this IEnumerable<T> src)
            => singletons(src);

        /// <summary>
        /// Constructs a slice from a supplied sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<T> ToSlice<T>(this IEnumerable<T> src)
            => Slice.define(src);

        /// <summary>
        /// Constructs a slice with natural length from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> ToSlice<N,T>(this IEnumerable<T> src)
            where N : TypeNat, new()
            => Slice.define<N,T>(src);

        /// <summary>
        /// Wraps an enumerable with a sequence structure
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static Seq<T> ToSeq<T>(this IEnumerable<T> src)
                => Seq.define(src);

        /// <summary>
        /// Reifies an enumerable as a finite sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static FiniteSeq<T> ToFiniteSeq<T>(this IEnumerable<T> src)
            where T : IEquatable<T>
                => Seq.finite(src);

        /// <summary>
        /// Returns the first element of the sequence that satisifies the predicate, if any.
        /// </summary>
        /// <param name="src">The sequence to search</param>
        /// <param name="predicate">The predicate to satiisfy</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>A valued option, if found; otherwise, none</returns>
        [MethodImpl(Inline)]
        public static Option<T> TryFind<T>(this IEnumerable<T> src, Func<T,bool> predicate)
            => src.FirstOrDefault(predicate);


        /// <summary>
        /// Creates a transformed array
        /// </summary>
        /// <typeparam name="S">The source item type</typeparam>
        /// <typeparam name="T">The target item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="transform">The transformation function</param>
        /// <returns></returns>
        public static T[] ToArray<S, T>(this IEnumerable<S> src, Func<S, T> transform)
            => src.Select(transform).ToArray();


        /// <summary>
        /// Returns a segment of an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static T[] SubArray<T>(this T[] input, int startIndex, int length)
        {
            var result = new List<T>();
            for (int i = startIndex; i < length; i++)
                result.Add(input[i]);
            return result.ToArray();
        }

        /// <summary>
        /// Creates a new array by appending the elements determined by the second array
        /// to the elements determined by the first array
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <param name="head">The first array</param>
        /// <param name="tail">The second array</param>
        /// <returns></returns>
        public static X[] Append<X>(this X[] head, X[] tail)
        {
            var result = new X[head.Length + tail.Length];
            Array.Copy(head, 0, result, 0, head.Length);
            Array.Copy(tail, 0, result, head.Length, tail.Length);
            return result;
        }

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The position of the first element of the source array </param>
        /// <param name="endpos">The position of the last element of the source array</param>
        /// <returns></returns>
        public static T[] Subset<T>(this T[] src, int startpos, int endpos)
        {
            var len = endpos - startpos + 1;
            var dst = new T[len];
            Array.Copy(src, startpos, dst, 0, len);
            return dst;
        }

        /// <summary>
        /// Applies an action to each member of the collection
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to enumerate</param>
        /// <param name="action">The action to apply</param>
        /// <param name="pll">Indicates whether the action should be applied concurrently</param>
        public static void Iterate<T>(this IEnumerable<T> items, Action<T> action, bool pll = false)
        {
            if (pll)
                items.AsParallel().ForAll(action);
            else
                foreach (var item in items)
                    action(item);
        }
        /// <summary>
        /// Convenience wrapper for Enumerable.SelectMany that yields a sequence of elements from a sequence of sequences
        /// </summary>
        /// <typeparam name="T">The sequence element type</typeparam>
        /// <param name="x"></param>
        /// <returns></returns>
        public static IEnumerable<T> Reduce<T>(this IEnumerable<IEnumerable<T>> x)
            => x.SelectMany(y => y);

        /// <summary>
        /// Prepends one or more items to the head of the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The sequence that will be prependend</param>
        /// <param name="preceding">The items that will be prepended</param>
        /// <returns></returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> items, params T[] preceding)
            => preceding.Concat(items);

        /// <summary>
        /// Partitions the sequence into subsequences of a maximum length
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IReadOnlyList<T>> Partition<T>(this IEnumerable<T> items, int max)
        {
            var list = new List<T>();
            foreach (var item in items)
            {
                list.Add(item);
                if (list.Count == max)
                {
                    yield return list;
                    list = new List<T>();
                }
            }
            if (list.Count != 0)
                yield return list;
        }

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        public static IReadOnlyList<T> Map<S, T>(this IEnumerable<S> src, Func<S, T> f)
            => src.Select(item => f(item)).ToReadOnlyList();

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The type of input element</typeparam>
        /// <typeparam name="T">The type of output element</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        /// <param name="max">The maximum number of elements from the sequence to map</param>      
        internal static IReadOnlyList<T> ApplyI<S, T>(this IEnumerable<S> src, int max, Func<int, S, T> f)
        {
            var dstList = new List<T>();
            var srcList = src.ToList();
            for (int i = 0; i < max; i++)
                dstList.Add(f(i, srcList[i]));
            return dstList;
        }

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The type of input element</typeparam>
        /// <typeparam name="T">The type of output element</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="mapper">The mapping function</param>
        /// <param name="limit">The inclusive upper bound of the index</param>      
        public static IReadOnlyList<T> Mapi<S, T>(this IEnumerable<S> src, int limit,
            Func<int, S, T> mapper) => src.ApplyI(limit, mapper);

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="TSource">The type of input element</typeparam>
        /// <typeparam name="TResult">The type of output element</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="mapper">The mapping function</param>
        public static IReadOnlyList<TResult> Mapi<TSource, TResult>(this IEnumerable<TSource> src, Func<int, TSource, TResult> mapper)
        {
            var dstList = new List<TResult>();
            var srcList = src.ToList();
            for (int i = 0; i < srcList.Count; i++)
                dstList.Add(mapper(i, srcList[i]));
            return dstList;
        }

        /// <summary>
        /// Creates a read-only list from a source sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <returns></returns>
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> src)
            => src.ToReadOnlyList();

        /// <summary>
        /// Returnes the first element if any exist or the suppllied default if none do
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to search</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        /// <returns></returns>
        public static T FirstOrDefault<T>(this IEnumerable<T> items, T @default)
            => items.Any() ? items.First() : @default;

        /// <summary>
        /// Returns true if the predicate is satisfied by some item in the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to search</param>
        /// <param name="f">The predicate to evaluate</param>
        /// <returns>True if the predicate is satisfied by some element in the supplied sequence</returns>
        public static bool Exists<T>(this IEnumerable<T> items, Predicate<T> f)
        {
            foreach (var item in items)
                if (f(item))
                    return true;
            return false;
        }

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
        /// Determines whether a collection contains any elements
        /// </summary>
        /// <typeparam name="T">The type of item contained by the collection</typeparam>
        /// <param name="collection">The collection to examine</param>
        public static bool IsEmpty<T>(this IReadOnlyCollection<T> collection)
             => collection.Count == 0;

        /// <summary>
        /// Determines whether a collection contains at least one element
        /// </summary>
        /// <typeparam name="T">The type of item contained by the collection</typeparam>
        /// <param name="collection">The collection to examine</param>
        /// <returns></returns>
        public static bool IsNonEmpty<T>(this IReadOnlyCollection<T> collection)
            => collection.Count != 0;

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


        /// <summary>
        /// Applies a function to the first item in the list that satisfies the predicate if such an item exists.
        /// If no such item exists, the function is applied to the default value of the item
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <typeparam name="R">The function result type</typeparam>
        /// <param name="items">The items to search</param>
        /// <param name="predicate">The predicate applied during the search</param>
        /// <param name="f">The function to apply to the identified item</param>
        /// <returns></returns>
        public static R OnFirstOrDefault<T, R>(this IEnumerable<T> items, Predicate<T> predicate, Func<T, R> f) =>
            f(items.FirstOrDefault(x => predicate(x)));

        //Prime numbers to use when generating a hash code. Taken from John Skeet's answer on SO:
        //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        const int P1 = 17;
        const int P2 = 23;

        /// <summary>
        /// Helper to compute hash code from a collection of items
        /// </summary>
        /// <typeparam name="S">The item type</typeparam>
        /// <param name="items">The items</param>
        /// <returns></returns>
        public static int GetHashCodeAggregate<S>(this IEnumerable<S> items)
        {
            if (items == null)
                return 0;

            unchecked
            {
                var hash = P1;
                foreach (var item in items)
                    hash = hash * P2 + item.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T Second<T>(this IEnumerable<T> items)
            => items.Skip(1).Take(1).Single();

        /// <summary>
        /// Returns the third term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T Third<T>(this IEnumerable<T> items)
            => items.Skip(2).Take(1).Single();

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise returns the default value
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T SecondOrDefault<T>(this IEnumerable<T> items)
            => items.Take(2).LastOrDefault();

        /// <summary>
        /// Logically equivalent to <see cref="Enumerable.Single{TSource}(IEnumerable{TSource})"/>, but returns None
        /// in lieu of throwing an exception if there is not exactly one item in the sequence
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Option<TValue> TryGetSingle<TValue>(this IEnumerable<TValue> values)
            => values.Count() == 1 ? values.Single() : none<TValue>();

        /// <summary>
        /// Logically equivalent to <see cref="Enumerable.Single{TSource}(IEnumerable{TSource})"/>, but returns None
        /// in lieu of throwing an exception if there is not exactly one item in the sequence
        /// </summary>
        /// <typeparam name="X">The stream item type</typeparam>
        /// <param name="stream">The stream to search</param>
        /// <param name="predicate">The predicate to match</param>
        /// <returns></returns>
        public static Option<X> TryGetSingle<X>(this IEnumerable<X> stream, Func<X, bool> predicate)
        {
            var satisfied = stream.Where(predicate).ToList();
            if (satisfied.Count != 1)
                return none<X>();
            else
                return satisfied[0];
        }

        /// <summary>
        /// Searches for the first element in the stream that satisfies a predicate and returns the
        /// element if found; otherwise, returns None
        /// </summary>
        /// <typeparam name="X">The stream item type</typeparam>
        /// <param name="stream">The stream to search</param>
        /// <param name="predicate">The predicate to match</param>
        /// <returns></returns>
        public static Option<X> TryGetFirst<X>(this IEnumerable<X> stream, Func<X, bool> predicate)
            => stream.FirstOrDefault(predicate);

        /// <summary>
        /// Constructs a set from a sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The item sequence</param>
        /// <returns></returns>
        public static ISet<T> ToSet<T>(this IEnumerable<T> items)
            => new HashSet<T>(items);

        /// <summary>
        /// Adds items to a list
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="list">The list to modify</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
            => items.Iterate(item => list.Add(item));

        /// <summary>
        /// Constructs a set from a sequence projection
        /// </summary>
        /// <typeparam name="T">The source element type</typeparam>
        /// <typeparam name="U">The targert element type</typeparam>
        /// <param name="items">The item sequence</param>
        /// <returns></returns>
        public static ISet<U> ToSet<T, U>(this IEnumerable<T> items, Func<T, U> selector)
            => new HashSet<U>(items.Select(selector));

        /// <summary>
        /// Constructs a readonly set from a sequence
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static HashSet<T> ToReadOnlySet<T>(this IEnumerable<T> items)
            => items.ToHashSet();

        /// <summary>
        /// Adds a stream of items to a set
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="set">The set to which items will be added</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<T>(this ISet<T> set, IEnumerable<T> items)
            => items.Iterate(item => set.Add(item));

        /// <summary>
        /// Determines whether a set is empty
        /// </summary>
        /// <typeparam name="T">The type of element that may be contained in the set</typeparam>
        /// <param name="set">The set under examination</param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this ISet<T> set)
            => set.Count == 0;

        /// <summary>
        /// Determines whether a set is nonempty
        /// </summary>
        /// <typeparam name="T">The type of element that may be contained in the set</typeparam>
        /// <param name="set">The set under examination</param>
        /// <returns></returns>
        public static bool IsNonEmpty<T>(this ISet<T> set)
            => set.Count != 0;
        /// <summary>
        /// Produces a set that is formed from the union of the input set and sequenced items
        /// </summary>
        /// <typeparam name="T">The type of element that may be contained in the set</typeparam>
        /// <param name="set">The set that will be joined with the sequence</param>
        /// <param name="items">The sequendce that will be joined with the set</param>
        /// <returns></returns>
        public static ISet<T> Union<T>(this ISet<T> set, IEnumerable<T> items)
            => new HashSet<T>(Enumerable.Union(set, items));

        /// <summary>
        /// Combines a stream with an exising set
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="set">The set that will be joined with the stream</param>
        /// <param name="stream">The stream that will be joined with the set</param>
        /// <returns></returns>
        public static ISet<T> Intersect<T>(this ISet<T> set, IEnumerable<T> stream)
            => new HashSet<T>(Enumerable.Intersect(set, stream));

        /// <summary>
        /// Enqueues a stream
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="queue">The destination queue</param>
        /// <param name="items">The items to enqueue</param>
        public static void Enqueue<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
                queue.Enqueue(item);
        }

        /// <summary>
        /// Removes a specified number of items from a queue
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="queue">The queue from which items will be removed</param>
        /// <param name="count">The (maximum) number of items to remove</param>
        /// <returns></returns>
        public static IEnumerable<T> Dequeue<T>(this Queue<T> queue, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (queue.Count != 0)
                    yield return queue.Dequeue();
            }
        }

        /// <summary>
        /// Pops all items off the queue
        /// </summary>
        /// <typeparam name="T">The type of value contained int he queue</typeparam>
        /// <param name="q">The queue to manipulate</param>
        /// <returns></returns>
        public static IEnumerable<T> Dequeue<T>(this ConcurrentQueue<T> q)
        {
            var item = default(T);
            var go = true;
            while (go)
            {
                if (q.TryDequeue(out item))
                    yield return item;
                else
                    go = false;
            }
        }

        /// <summary>
        /// Pushes a sequence of items into queue and returns the number of items enqueued
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="q">The queue to manipulate</param>
        /// <param name="items">The items to place on the qeeue</param>
        /// <returns></returns>
        public static int Enqueue<T>(this ConcurrentQueue<T> q, IEnumerable<T> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                q.Enqueue(item);
                count++;
            }
            return count;
        }

        /// <summary>
        /// Pops a sequence of items off a queue
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="q">The queue to manipulate</param>
        /// <param name="max">The maximum number of items to remove</param>
        /// <returns></returns>
        public static IEnumerable<T> Dequeue<T>(this ConcurrentQueue<T> q, int max)
            => q.Dequeue().Take(max);

        /// <summary>
        /// Removes an element from the queue if one exists
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="q">the queue</param>
        /// <returns></returns>
        public static Option<T> TryPop<T>(this Queue<T> q)
            => q.IsEmpty() ? none<T>() : some(q.Dequeue());

        /// <summary>
        /// Removes an element from the queue if one exists
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="q">the queue</param>
        /// <returns></returns>
        public static Option<T> TryPop<T>(this ConcurrentQueue<T> q)
            => q.TryDequeue(out T next) ? some(next) : none<T>();


        /// <summary>
        /// Applies a function over designated items in an indexed sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src"></param>
        /// <param name="minidx">The minimum index</param>
        /// <param name="maxidx">The maximum index</param>
        /// <param name="f">The mapping function</param>
        /// <returns></returns>
        public static IReadOnlyList<T> MapRange<S, T>(this IReadOnlyList<S> src, int minidx, int maxidx, Func<S, T> f)
        {
            var dst = new List<T>();
            for (int i = minidx; i <= maxidx; i++)
                dst.Add(f(src[i]));
            return dst;
        }

        /// <summary>
        /// Determines whether to lists of value objects are equal
        /// </summary>
        /// <typeparam name="T">The type of value object</typeparam>
        /// <param name="x">The first list</param>
        /// <param name="y">The second list</param>
        /// <returns></returns>
        public static bool DeepEqualityWith<T>(this IReadOnlyList<T> x, IReadOnlyList<T> y)
        {
            if (x == null || y == null || x.Count != y.Count)
                return false;

            for (int i = 0; i < x.Count; i++)
            {
                //Yes, either x[i] or y[i} could be null but that would be a pretty
                //stupid list and we might as well blow up so we can fix whatever
                //mechanism is adding null items to the list
                if (!x[i].Equals(y[i]))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// A functional rendition of <see cref="ConcurrentBag{T}.TryTake(out T)"/> 
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="source">The collection to search</param>
        /// <returns></returns>
        public static Option<T> TryTake<T>(this ConcurrentBag<T> source)
            => (source.TryTake(out T element)) ? some(element) : none<T>();


        /// <summary>
        /// Adds a collection of items to a bag
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="bag">The destination bag</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<T>(this ConcurrentBag<T> bag, IEnumerable<T> items)
            => items.Iterate(item => bag.Add(item));

        /// <summary>
        /// Creates a read-only dictionary from the supplied enumerable and selector
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="this">The extended type</param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IReadOnlyDictionary<K, V> ToReadOnlyDictionary<K, V>(this IEnumerable<V> @this, 
            Func<V, K> keySelector) => @this.ToDictionary(keySelector);

        /// <summary>
        /// Creates a read-only dictionary from an existing mutable dictionary
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="this">The extended type</param>
        /// <returns></returns>
        public static IReadOnlyDictionary<K, V> ToReadOnlyDictionary<K, V>(this IDictionary<K, V> @this)
            => new Dictionary<K, V>(@this);

        /// <summary>
        /// Creates a read-only dictionary from a stream of tuples
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="this">The extended type</param>
        /// <returns></returns>
        public static IReadOnlyDictionary<K, V> ToReadOnlyDictionary<K, V>(this IEnumerable<(K key, V value)> @this)
            => @this.ToDictionary(x => x.key, x => x.value);

        /// <summary>
        /// Creates a concurrent dictionary from the input sequence
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="values">The input sequence</param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<K, V>(this IEnumerable<V> values, Func<V, K> keySelector)
            => new ConcurrentDictionary<K, V>(
                from value in values select new KeyValuePair<K, V>(keySelector(value), value));

        /// <summary>
        /// Creates a concurrent dictionary from the input sequence
        /// </summary>
        /// <typeparam name="S">The input sequence type</typeparam>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The type of the indexed valuie</typeparam>
        /// <param name="sources">The input sequence</param>
        /// <param name="keySelector">Function that selects the key</param>
        /// <param name="valueSelector">Function that selects the value</param>
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<S, K, V>(this IEnumerable<S> sources, 
            Func<S, K> keySelector, Func<S, V> valueSelector)
                => new ConcurrentDictionary<K, V>
                        (from item in sources select new KeyValuePair<K, V>(keySelector(item), valueSelector(item)));

        /// <summary>
        /// Addes the entries of the source dictionary to the destination dictionary
        /// </summary>
        /// <typeparam name="TKey">The common dictionary key type</typeparam>
        /// <typeparam name="TValue">The common dictionary value type</typeparam>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dst, IReadOnlyDictionary<TKey, TValue> src)
                => src.Iterate(s => dst.Add(s.Key, s.Value));


        /// <summary>
        /// Addes the key-value pairs to the extended dictionary
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="dict">The extended dictionary</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<K, V>(this IDictionary<K, V> dict, IEnumerable<KeyValuePair<K, V>> items)
            => items.Iterate( item => dict.Add(item));

        /// <summary>
        /// Determines whether the dictionary has any the keys that are specified in a set
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="subject">The dictionary to evaluate</param>
        /// <param name="keys">The keys to check</param>
        /// <returns></returns>
        public static bool HasAnyKey<K, V>(this IReadOnlyDictionary<K, V> subject, IEnumerable<K> keys)
            => keys.Intersect(subject.Keys).Any();

        /// <summary>
        /// A <see cref="ConcurrentDictionary{TKey, TValue}"/> constructor function
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="d">The source dictionary</param>
        /// <returns></returns>
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<K, V>(this IDictionary<K, V> d)
            => new ConcurrentDictionary<K, V>(d);

        /// <summary>
        /// Determines whether the dictionary has all of the keys that are specified in a set
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="subject">The dictionary to evaluate</param>
        /// <param name="keys">The keys to check</param>
        /// <returns></returns>
        public static bool HasAllKeys<K, V>(this IReadOnlyDictionary<K, V> subject, IEnumerable<K> keys)
            => keys.Count(k => subject.ContainsKey(k)) == keys.Count();

        /// <summary>
        /// Gets an item with the specified key from the dictionary if it exists or creates the item and adds it to the dictionary,
        /// returning the newly created item
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="dictionary">The dictionary to query and/or modify</param>
        /// <param name="key">The key</param>
        /// <param name="factory">Delegate that produces a value given a key</param>
        /// <returns></returns>
        /// <remarks>
        /// This is not thread-safe. If you need that, use the concurrent collections
        /// </remarks>
        public static V GetOrAdd<K, V>(this IDictionary<K, V> dictionary, K key, Func<K, V> factory)
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key];
            var value = factory(key);
            dictionary[key] = value;
            return value;
        }


        static Option<Y> guard<X, Y>(X x, Func<X, bool> predicate, Func<X, Option<Y>> f)
            => predicate(x) ? f(x) : none<Y>();

        /// <summary>
        /// Retrieves the key-identified value if possible
        /// </summary>
        /// <typeparam name="TKey">The key</typeparam>
        /// <typeparam name="TValue">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        /// <returns></returns>
        public static Option<TValue> TryFind<TKey, TValue>(this IDictionary<TKey, TValue> subject, TKey key)
            => guard(key,
                k => k != null,
                k => subject.TryGetValue(k, out TValue value)
                    ? some(value)
                    : none<TValue>());

        /// <summary>
        /// Retrieves the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        /// <returns></returns>
        public static Option<V> TryFind<K, V>(this IReadOnlyDictionary<K, V> subject, K key)
                => key == null ? none<V>()
                : (subject.TryGetValue(key, out V value)
                ? some(value) : none<V>());

        /// <summary>
        /// Removes the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        /// <returns></returns>
        public static Option<V> TryRemove<K, V>(this ConcurrentDictionary<K, V> subject, K key)
            => guard(key,
                k => k != null,
                k => subject.TryRemove(k, out V value)
                    ? some(value)
                    : none<V>());

        /// <summary>
        /// Determines whether two lists have identitical content
        /// </summary>
        /// <typeparam name="T">The list item type</typeparam>
        /// <param name="l1">The first list</param>
        /// <param name="l2">The second list</param>
        /// <returns></returns>
        public static bool ContentEquals<T>(this IReadOnlyList<T> l1, IReadOnlyList<T> l2)
        {
            if (l1.Count != l2.Count)
                return false;

            for (var i = 0; i < l2.Count; i++)
            {
                var left = l1[i];
                var right = l2[i];
                var same = Equals(left, right);
                if (!same)
                    return false;
            }
            return true;

        }

        /// <summary>
        /// Retrieves a range of elements of a specified length, starting with a specified index, if possible
        /// Otherwise; returns either an empty list or a maximal subset
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source items</param>
        /// <param name="startidx">The first index</param>
        /// <param name="length">The maximum number of elements to yield</param>
        /// <returns></returns>
        public static IEnumerable<T> GetRange<T>(this IReadOnlyList<T> source, int startidx, int length)
        {
            var current = 0;        
            for (var i = startidx; i < source.Count && current < length; i++)
            {
                yield return source[i];
                current++;
            }
        }
    }
}