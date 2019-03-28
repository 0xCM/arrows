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
        /// Determines whether two lists, adjudicated by positional elemental equality, are equal
        /// </summary>
        /// <typeparam name="T">The type of value object</typeparam>
        /// <param name="lhs">The first list</param>
        /// <param name="rhs">The second list</param>
        /// <returns></returns>
        public static bool DeepEquals<T>(this IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : Traits.Equatable<T>
                => eq(lhs,rhs);

        /// <summary>
        /// Determines whether two sequence, adjudicated by positional elemental equality, are equal
        /// </summary>
        /// <typeparam name="T">The type of value object</typeparam>
        /// <param name="lhs">The first list</param>
        /// <param name="rhs">The second list</param>
        /// <returns></returns>
        public static bool DeepEquals<T>(this IEnumerable<T> lhs, IEnumerable<T> rhs)
            where T : Traits.Equatable<T>
                => eq(lhs,rhs);

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
        /// Adds items to a list
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="list">The list to modify</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
            => items.Iterate(item => list.Add(item));

    }
}