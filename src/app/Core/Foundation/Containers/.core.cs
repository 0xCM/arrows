//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Core;
using static corefunc;


public static partial class corefunc
{

    /// <summary>
    /// Constructs an associative array
    /// </summary>
    /// <param name="items">Item tuples that will be indexed/stored</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<K,V> index<K,V>(IEnumerable<(K key,V value)> items)
        => new Index<K,V>(items);

    /// <summary>
    /// Constructs an associative array
    /// </summary>
    /// <param name="items">Keyed values that will be indexed/stored</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<K,V> index<K,V>(IEnumerable<KeyedValue<K,V>> items)
        => new Index<K,V>(items);

    /// <summary>
    /// Constructs an integrally-indexed associative array
    /// </summary>
    /// <param name="value">The value</param>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<V> index<V>(IEnumerable<V> items)
        => new Index<V>(items);

    /// <summary>
    /// Constructs an index from a collection of of 2-tuples
    /// </summary>
    /// <param name="src">The collection of 2-tuples from which to construct an index</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static Index<K,V> index<K,V>((K key, V value)[] src)
        => new Index<K,V>(map(src,kvp));

    /// <summary>
    /// Constructs a keyed value
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    public static KeyedValue<K,V> kvp<K,V>(K key, V value)
        => new KeyedValue<K,V>(key,value);

    /// <summary>
    /// Constructs a keyed value from a 2-tuple
    /// </summary>
    /// <param name="kv">The source tuple</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static KeyedValue<K,V> kvp<K,V>( (K key, V value) kv)
        => new KeyedValue<K,V>(kv);

    /// <summary>
    /// Constructs integrally-keyed associative array, otherwise known
    /// as a list from a parameter array
    /// </summary>
    /// <param name="values"></param>
    /// <typeparam name="A"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Index<A> list<A>(params A[] values)
        => new Index<A>(values);

    /// <summary>
    /// Allocates a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T[] array<T>(long len)
        => new T[len];

    /// <summary>
    /// Allocates and fills a naturally-sized array
    /// </summary>
    /// <param name="data">The source data</param>
    /// <typeparam name="N">The length type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
   [MethodImpl(Inline)]
    public static Array<N,T> array<N,T>(params T[] data)
        where N : TypeNat, new()
            => new Array<N,T>(data);

   [MethodImpl(Inline)]
    public static IEnumerable<T> seq<T>(params T[] items)
        => items;

    /// <summary>
    /// Partitions a seequence into segments of a specified natural width
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    public static IEnumerable<IReadOnlyList<T>> partition<W,T>(IEnumerable<T> src)
        where W : TypeNat, new()
    {
        var width = natval<W>();
        var sement = new T[width];
        var current = 0;
        foreach(var item in src)
        {
            if(current == width)
            {
                current = 0;
                yield return sement;
                sement = new T[width];
            }
                
            sement[current++] = item;
        }

        for(var i = current; i < width; i++)
            sement[i] = default(T);
        
        yield return sement;
    }



}