//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;

    partial class Traits
    {
        
        /// <summary>
        /// Characterizes a set indexed by another set
        /// </summary>
        /// <typeparam name="I">The indexing set</typeparam>
        /// <typeparam name="X">The indexed set</typeparam>
        public interface Index<I,T> : Container<KeyedValue<I,T>>
        {
            /// <summary>
            /// Retrives an indexed value
            /// </summary>
            /// <param name="index">The index value</param>
            /// <returns>The indexed value</returns>
            T item(I index);

            /// <summary>
            /// Retrives an indexed value via an index operator
            /// </summary>
            /// <param name="index">The index value</param>
            /// <returns>The indexed value</returns>
            T  this[I ix] {get;}
        }



    }


    /// <summary>
    /// Defines an associative array
    /// </summary>
    public readonly struct Index<K,V> : Traits.Index<K,V>, IEnumerable<KeyedValue<K,V>>
    {
        IReadOnlyDictionary<K,V> _items {get;}
        
        IEnumerator<KeyedValue<K, V>> enumerator()
            => content.GetEnumerator();
        
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

        public IEnumerable<KeyedValue<K,V>> content 
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
    public readonly struct Index<V> : Traits.Index<int,V>, IEnumerable<V>
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

        public IEnumerable<KeyedValue<int,V>> content
            => mapi((k,v) => kvp(k,v), _items);        
    }
}

