//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    using static corefunc;

    /// <summary>
    /// Defines a concurrent key-value store 
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">Tye value type</typeparam>
    public class ConcurrentIndex<K,V> 
    {
        /// <summary>
        /// The backing store
        /// </summary>
        readonly ConcurrentDictionary<K,V> storage;

        /// <summary>
        /// Creates a new index
        /// </summary>
        /// <param name="storage">The optionally populated storage</param>
        public ConcurrentIndex(ConcurrentDictionary<K,V> storage = null)
            => this.storage = storage ?? new ConcurrentDictionary<K, V>();

        /// <summary>
        /// Returns either an existing indexed value or the value created
        /// by invoking the supplied producer; in the latter case, the
        /// newly-created value is added to the index prior to return
        /// </summary>
        /// <param name="key"></param>
        /// <param name="producer"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public V GetOrAdd(K key, Func<K,V> producer)
            => storage.GetOrAdd(key,producer);

        [MethodImpl(Inline)]
        public Option<V> TryGet(K key)
            => storage.TryGetValue(key, out V value) 
            ? value : none<V>();

        [MethodImpl(Inline)]
        public bool TryAdd(K key, Func<K,V> producer)
            => storage.TryAdd(key, producer(key));


        /// <summary>
        /// Determines whether the index has an entry for a specified key
        /// </summary>
        /// <param name="key">The key to check</param>
        [MethodImpl(Inline)]
        public bool Exists(K key)
            => storage.ContainsKey(key);

        /// <summary>
        /// Unconditionally sets a specified key/value pair, overwriting
        /// any extant current value
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="producer">The function that produces the value corresponding
        /// to the key</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public V Set(K key, Func<K,V> producer)    
        {
            var value = producer(key);
            storage[key] = value;
            return value;
        }    

        public V this[K key] 
            => storage[key];

        [MethodImpl(Inline)]
        public Option<(K key,V value)> TrySet(K key, V value)    
            => storage.TryAdd(key, value) 
            ? (key,value) : none<(K,V)>();


        /// <summary>
        /// Finds the first key, if any, that satisifes a specified predicate
        /// </summary>
        [MethodImpl(Inline)]
        public Option<K> FirstKey(Func<K,bool> predicate)
            => storage.Keys.FirstOrDefault(k => predicate(k));

        public ConcurrentIndex<K,V> AddRange(IEnumerable<K> keys, Func<K,V> producer)
        {
            var current = new ConcurrentDictionary<K,V>();
            keys.AsParallel().ForAll(k => 
                TrySet(k, producer(k))
                    .OnSome(result => current.TryAdd(result.key, result.value)));

            return new ConcurrentIndex<K,V>(current);
        }

        public IEnumerable<(K key,V value)> KeyedValues
            => from item in storage select (item.Key, item.Value);

    }
}