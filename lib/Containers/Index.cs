//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zcore;

  




    /// <summary>
    /// Defines an associative array
    /// </summary>
    public readonly struct Index<K,V> : Contain.DiscreteContainer<Index<K,V>,KeyedValue<K,V>>, IEnumerable<KeyedValue<K,V>>
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

        public V this[K key] 
            => _items[key];   

        public V item(K key) 
            => this[key];   

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

        public int hash()
        {
            throw new NotImplementedException();
        }

        public bool eq(Index<K, V> rhs)
        {
            throw new NotImplementedException();
        }

        public bool neq(Index<K, V> rhs)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Index<K, V> other)
        {
            throw new NotImplementedException();
        }
    }

}

