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
    /// Defines an integrally-indexed associative array
    /// </summary>
    public readonly struct Index<T> : IReadOnlyList<T>, IEquatable<Index<T>>
    {
        public static readonly Index<T> Empty = new Index<T>(new T[]{});
        
        readonly T[] data;

        readonly ArraySegment<T>? segment;

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(in T[] src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(in ArraySegment<T> src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(in List<T> src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](in Index<T> src)
            => src.AsArray();

        [MethodImpl(Inline)]
        public Index(in T[] src)
        {
            this.data = src;
            this.segment = null;
        }
            
        [MethodImpl(Inline)]
        public Index(in ArraySegment<T> src)
        {
            this.data = null;
            this.segment = src;
        }

        [MethodImpl(Inline)]
        public Index(in List<T> src)
        {
            this.data = src.ToArray();
            this.segment = null;
        }

        [MethodImpl(Inline)]
        public T item(int key) 
            => segment.HasValue ? segment.Value[key] : data[key];
            
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => ( (data ?? segment ?? new T[]{}) as IReadOnlyList<T>).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => data.GetEnumerator();

        public bool Equals(Index<T> rhs)
        {        
            if(rhs.Length != this.Length)
                return false;
            
            if(rhs.IsEmpty)
                return true;

            for(var i= 0; i< Length; i++)
                if(!item(i).Equals(rhs.item(i))) 
                    return false;
            return true;
        }

        public T this[int key] 
        {
            [MethodImpl(Inline)]
            get => item(key);
        }
            
        public int Length
            => data?.Length ?? 0;

        public int Count 
            => data?.Length ?? 0;

        [MethodImpl(Inline)]
        public T[] AsArray()
            => data ?? segment?.ToArray() ?? new T[]{};

        public bool IsEmpty
            => Count == 0;            

        public bool IsNonEmpty
            => Count != 0;            

    }



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

