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
        /// Partitions the sequence into subsequences of a maximum length
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="max"></param>
        public static IEnumerable<T[]> Partition<T>(this IEnumerable<T> items, int max)
        {
            var list = new List<T>();
            foreach (var item in items)
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

        public static IEnumerable<ArraySegment<T>> Partition<T>(this T[] src, int width)
        {
            var count = src.Length / width;
            var overflow = src.Length % width;
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

    }

}