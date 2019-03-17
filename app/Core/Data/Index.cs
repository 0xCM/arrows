//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    /// <summary>
    /// Correlates a value with a key that uniquely identifies
    /// the value within some context
    /// </summary>
    public readonly struct KeyedValue<K,V>
    {
        /// <summary>
        /// The key that identifies the value
        /// </summary>
        /// <value></value>
        public K key {get;}

        /// <summary>
        /// The value identified by the key
        /// </summary>
        /// <value></value>
        public V value {get;}

        public KeyedValue(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
        public KeyedValue((K key, V value) kv)
        {
            this.key = kv.key;
            this.value = kv.value;
        }
        
    }

    /// <summary>
    /// Characterizes a type type that realizes an associative array
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    public interface AArray<K,V>
    {
        V item(K key);

        V this[K i] {get;}

        IEnumerable<KeyedValue<K,V>> items {get;}

    }

    /// <summary>
    /// Defines an associative array
    /// </summary>
    public readonly struct Index<K,V> : AArray<K,V>, IEnumerable<KeyedValue<K,V>>
    {
        IReadOnlyDictionary<K,V> _items {get;}
        
        IEnumerator<KeyedValue<K, V>> enumerator()
            => items.GetEnumerator();
        
        IEnumerator<KeyedValue<K, V>> IEnumerable<KeyedValue<K, V>>.GetEnumerator()
            => enumerator();
    
        IEnumerator IEnumerable.GetEnumerator()
            => enumerator();

        public Index(IEnumerable<(K key,V value)> items)
            => this._items = items.ToDictionary(x => x.key, x => x.value);

        public Index(IEnumerable<KeyedValue<K,V>> kvals)
            => this._items = kvals.ToDictionary(x => x.key, x => x.value);

        public V this[K key] => _items[key];   

        public V item(K key) => this[key];   

        /// <summary>
        /// Returns the value matching a specified key if it exists; otherwise,
        /// returns none
        /// </summary>
        /// <param name="key">The key to match</param>
        /// <returns></returns>
        public Option<V> lookup(K key)
            => _items.ContainsKey(key) ? _items[key] : none<V>();

        public IEnumerable<KeyedValue<K,V>> items 
            => from i in _items select kvp(i.Key,i.Value);

        /// <summary>
        /// Merges current items and supplied items to create a new index
        /// </summary>
        /// <param name="kvals">The keyed values to merge</param>
        /// <returns></returns>
        public Index<K,V> merge(IEnumerable<KeyedValue<K,V>> kvals)
            => new Index<K,V>(this.Union(kvals));
    }

    /// <summary>
    /// Defines an integrally-indexed associative array
    /// </summary>
    public readonly struct Index<V> : AArray<int,V>, IEnumerable<V>
    {
        IReadOnlyList<V> _items {get;}        

        public Index(IEnumerable<V> values)
            => this._items = values.ToList();

        public V item(int key) => this[key];

        IEnumerator<V> IEnumerable<V>.GetEnumerator()
            => _items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => _items.GetEnumerator();

        public V this[int key] => _items[key];   

        public IEnumerable<KeyedValue<int,V>> items 
            => mapi((k,v) => kvp(k,v), _items);
        
    }

}