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

    /// <summary>
    /// Correlates a value with a key that uniquely identifies
    /// the value within some context
    /// </summary>
    public readonly struct KeyedValue<K,V> : Formattable
    {

        public static implicit operator KeyedValue<K,V>((K key, V value) src)
            => new KeyedValue<K,V>(src);

        public static implicit operator (K key, V value)(KeyedValue<K,V> src)
            => src.tuple;

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

        /// <summary>
        /// The key that identifies the value
        /// </summary>
        public readonly K key;

        /// <summary>
        /// The value identified by the key
        /// </summary>
        public readonly V value;

        public (K key, V value) tuple
            => this;

        public string format()
            => tuple.Format();
    }
}