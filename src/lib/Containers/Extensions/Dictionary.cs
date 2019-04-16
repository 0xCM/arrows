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
        /// Constructs a mutable dictionary from a sequence of key-value pairs
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <returns></returns>
        public static Dictionary<K,V> ToDictionary<K,V>(this IEnumerable<(K key, V value)> src)
            => new Dictionary<K,V>(src.Select(x => new KeyValuePair<K,V>(x.key,x.value)));

        /// <summary>
        /// Creates a read-only dictionary from the supplied enumerable and selector
        /// </summary>
        /// <param name="this">The extended type</param>
        /// <param name="keySelector"></param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
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
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        /// <returns></returns>
        public static Option<V> TryFind<K, V>(this Dictionary<K, V> subject, K key)
            => guard(key,
                k => k != null,
                k => subject.TryGetValue(k, out V value)
                    ? some(value)
                    : none<V>());

        /// <summary>
        /// Retrieves the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        /// <returns></returns>
        public static Option<V> TryFind<K, V>(this IDictionary<K, V> subject, K key)
            => guard(key,
                k => k != null,
                k => subject.TryGetValue(k, out V value)
                    ? some(value)
                    : none<V>());

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

    }


}