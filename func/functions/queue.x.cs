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
    
    using static zfunc;

    partial class xfunc
    {

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
        /// Removes an element from the queue if one exists
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="q">the queue</param>
        public static Option<T> TryPop<T>(this Queue<T> q)
            => q.IsEmpty() ? none<T>() : some(q.Dequeue());

    }

}