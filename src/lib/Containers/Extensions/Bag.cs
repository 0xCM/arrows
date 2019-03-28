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
        /// Adds a collection of items to a bag
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="bag">The destination bag</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<T>(this ConcurrentBag<T> bag, IEnumerable<T> items)
            => items.Iterate(item => bag.Add(item));


        /// <summary>
        /// A functional rendition of <see cref="ConcurrentBag{T}.TryTake(out T)"/> 
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="source">The collection to search</param>
        /// <returns></returns>
        public static Option<T> TryTake<T>(this ConcurrentBag<T> source)
            => (source.TryTake(out T element)) ? some(element) : none<T>();



    }

}