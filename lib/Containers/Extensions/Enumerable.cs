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
    
    using static zcore;

    partial class xcore
    {

        /// <summary>
        /// Applies an action to each member of the collection
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to enumerate</param>
        /// <param name="action">The action to apply</param>
        /// <param name="pll">Indicates whether the action should be applied concurrently</param>
        [MethodImpl(Inline)]
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
        /// <param name="src"></param>
        public static IEnumerable<T> Reduce<T>(this IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(y => y);

        /// <summary>
        /// Prepends one or more items to the head of the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The sequence that will be prependend</param>
        /// <param name="preceding">The items that will be prepended</param>
        /// <returns></returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> src, params T[] preceding)
            => preceding.Concat(src);

        /// <summary>
        /// Partitions the sequence into subsequences of a maximum length
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="max"></param>
        public static IEnumerable<Index<T>> Partition<T>(this IEnumerable<T> items, int max)
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
                yield return list.ToIndex();
        }

        public static IEnumerable<ArraySegment<T>> Partition<T>(this T[] src, int width)
            => Arr.partition(src,width);
        
        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        public static IReadOnlyList<T> Map<S, T>(this IEnumerable<S> src, Func<S, T> f)
            => src.Select(item => f(item)).ToList();

        /// <summary>
        /// Creates a read-only list from list
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> ToReadOnlyList<T>(this List<T> src)
            => src;

        /// <summary>
        /// Creates a read-only list from a source sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> src)
            => src.ToList();


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
        public static T LastOrDefault<T>(this IEnumerable<T> src, T @default)
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
        /// Returns true if the predicate is satisfied by some item in the sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to search</param>
        /// <param name="f">The predicate to evaluate</param>
        /// <returns>True if the predicate is satisfied by some element in the supplied sequence</returns>
        [MethodImpl(Inline)]
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
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        [MethodImpl(Inline)]
        public static T Second<T>(this IEnumerable<T> items)
            => items.Skip(1).Take(1).Single();

        /// <summary>
        /// Returns the third term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        [MethodImpl(Inline)]
        public static T Third<T>(this IEnumerable<T> items)
            => items.Skip(2).Take(1).Single();

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise returns the default value
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="items"></param>
        [MethodImpl(Inline)]
        public static T SecondOrDefault<T>(this IEnumerable<T> items)
            => items.Take(2).LastOrDefault();

        /// <summary>
        /// Logically equivalent to <see cref="Enumerable.Single{TSource}(IEnumerable{TSource})"/>, but returns None
        /// in lieu of throwing an exception if there is not exactly one item in the sequence
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="values"></param>
        [MethodImpl(Inline)]
        public static Option<TValue> TryGetSingle<TValue>(this IEnumerable<TValue> values)
            => values.Count() == 1 ? values.Single() : none<TValue>();

        /// <summary>
        /// Logically equivalent to <see cref="Enumerable.Single{TSource}(IEnumerable{TSource})"/>, but returns None
        /// in lieu of throwing an exception if there is not exactly one item in the sequence
        /// </summary>
        /// <typeparam name="X">The stream item type</typeparam>
        /// <param name="stream">The stream to search</param>
        /// <param name="predicate">The predicate to match</param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static Option<X> TryGetFirst<X>(this IEnumerable<X> stream, Func<X, bool> predicate)
            => stream.FirstOrDefault(predicate);

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
    }
}