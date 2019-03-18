//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    
    /// <summary>
    /// Characterizes a type type that realizes an associative array
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    public interface Map<K,V>
    {
        V item(K key);

        V this[K i] {get;}

        IEnumerable<KeyedValue<K,V>> items {get;}

    }

    
}