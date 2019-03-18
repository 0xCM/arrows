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

    using C = Contracts;

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
}