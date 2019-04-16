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
        /// Constructs a set from a sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The item sequence</param>
        /// <returns></returns>
        public static ISet<T> ToSet<T>(this IEnumerable<T> items)
            => new HashSet<T>(items);

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
    }
}