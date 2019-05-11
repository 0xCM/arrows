//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    
    using static zfunc;


    partial class xfunc
    {
        /// <summary>
        /// A <see cref="ConcurrentDictionary{TKey, TValue}"/> constructor function
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="d">The source dictionary</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<K, V>(this IDictionary<K, V> d)
            => new ConcurrentDictionary<K, V>(d);

        /// <summary>
        /// Creates a concurrent dictionary from the input sequence
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="values">The input sequence</param>
        /// <param name="keySelector"></param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<S, K, V>(this IEnumerable<S> sources, 
            Func<S, K> keySelector, Func<S, V> valueSelector)
                => new ConcurrentDictionary<K, V>
                        (from item in sources select new KeyValuePair<K, V>(keySelector(item), valueSelector(item)));

        /// <summary>
        /// Removes the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Option<V> TryRemove<K, V>(this ConcurrentDictionary<K, V> subject, K key)
            => guard(key,
                k => k != null,
                k => subject.TryRemove(k, out V value)
                    ? some(value)
                    : none<V>());

        /// <summary>
        /// Adds a collection of items to a bag
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="bag">The destination bag</param>
        /// <param name="items">The items to add</param>
        [MethodImpl(Inline)]
        public static void AddRange<T>(this ConcurrentBag<T> bag, IEnumerable<T> items)
            => items.Iterate(item => bag.Add(item));


        /// <summary>
        /// A functional rendition of <see cref="ConcurrentBag{T}.TryTake(out T)"/> 
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="source">The collection to search</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Option<T> TryTake<T>(this ConcurrentBag<T> source)
            => (source.TryTake(out T element)) ? some(element) : none<T>();

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
        public static Option<T> TryPop<T>(this ConcurrentQueue<T> q)
            => q.TryDequeue(out T next) ? some(next) : none<T>();

    }

}