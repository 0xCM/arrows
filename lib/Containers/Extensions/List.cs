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
    using static zfunc;
    using static mfunc;

    partial class xcore
    {
 
        /// <summary>
        /// Determines whether a collection contains any elements
        /// </summary>
        /// <typeparam name="T">The type of item contained by the collection</typeparam>
        /// <param name="collection">The collection to examine</param>
        [MethodImpl(Inline)]
        public static bool IsEmpty<T>(this IReadOnlyCollection<T> collection)
             => collection.Count == 0;

        /// <summary>
        /// Determines whether a collection contains at least one element
        /// </summary>
        /// <typeparam name="T">The type of item contained by the collection</typeparam>
        /// <param name="collection">The collection to examine</param>
        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
        public static List<T> Append<T>(this List<T> src, params T[] items)
        {
            src.AddRange(items);
            return src;
        }
    }
}