//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;
using static zcore;
using static zfunc;
using static nfunc;

using Array = Z0.NatArray;


public static partial class zcore
{

    /// <summary>
    /// Populates a semigroup seqeunce container
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static SemiSeq<T> semiseq<T>(IEnumerable<T> src)
        where T : struct, ISemigroup<T>
            => new SemiSeq<T>(src);

    /// <summary>
    /// Populates a semigroup seqeunce container
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static SemiSeq<T> semiseq<T>(params T[] src)
        where T : struct, ISemigroup<T>
            => new SemiSeq<T>(src);


    /// <summary>
    /// Constructs a variable-lenth slice from a parameter array
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="T">The element type </typeparam>
    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(params T[] src)
        where T : struct
            => new Slice<T>(src);

    /// <summary>
    /// Constructs a variable-lenth slice from a stream
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="T">The element type </typeparam>
    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(IEnumerable<T> src)
        where T : struct
            => new Slice<T>(src);

    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(Index<T> src)
        where T : struct
            => new Slice<T>(src);

    /// <summary>
    /// Constructs a Seq[T] from a parameter array
    /// </summary>
    /// <param name="src">The source items</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static Seq<T> seq<T>(params T[] src)
            => Seq.define(src);


    /// <summary>
    /// Constructs an index from a parameter array
    /// </summary>
    /// <param name="src">The source elements</param>
    /// <typeparam name="T">The element type/typeparam>
    [MethodImpl(Inline)]
    public static Index<T> index<T>(params T[] src)
        => new Index<T>(src);

    /// <summary>
    /// Allocates a target index, predicated on the common size of source indexes
    /// </summary>
    /// <param name="lhs">The left operand values</param>
    /// <param name="rhs">The right oprand values</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] target<T>(in T[] lhs, in T[] rhs)
        => alloc<T>(matchedLength(lhs,rhs));

    /// <summary>
    /// Allocates a target index, predicated on the common size of a source index
    /// </summary>
    /// <param name="lhs">The left operand values</param>
    /// <param name="rhs">The right oprand values</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] target<T>(in Index<T> lhs)
        => alloc<T>(lhs.Count);

    /// <summary>
    /// Constructs an array from a stream
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<T>(IEnumerable<T> src)
        => src.ToArray();



    /// <summary>
    /// Constructs a mutable dictionary 
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    [MethodImpl(Inline)]   
    public static Dictionary<K,V> dict<K,V>(params (K key, V value)[] src)
        => new Dictionary<K, V>();


    /// <summary>
    /// Constructs a concurrent bag with optional initial items
    /// </summary>
    /// <typeparam name="T">The bagged type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static ConcurrentBag<T> cbag<T>(params T[] initial)
        => new ConcurrentBag<T>(initial);



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
    /// Reverses the input sequence
    /// </summary>
    /// <param name="src">The input sequence</param>
    /// <typeparam name="T">The input sequence type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<T> reverse<T>(IEnumerable<T> src)
        => src.Reverse();

    /// <summary>
    /// Filters the input sequence via a supplied predicate
    /// </summary>
    /// <param name="src">The input sequence</param>
    /// <param name="f">The predicate used to test values from the input sequence</param>
    /// <typeparam name="T">The input sequence type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<T> filter<T>(IEnumerable<T> src, Func<T,bool> f)
        => src.Where(f);

    /// <summary>
    /// Filters the input sequence via a supplied predicate
    /// </summary>
    /// <param name="src">The input sequence</param>
    /// <param name="f">The predicate used to test values from the input sequence</param>
    /// <typeparam name="T">The input sequence type</typeparam>
    public static Slice<T> filter<T>(Slice<T> src, Func<T,bool> f)
        where T : struct
            => slice(src.Where(f));        

    /// <summary>
    /// Transforms a sequence in reverse order
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="f">The transformer</param>
    /// <typeparam name="S">The input sequence type</typeparam>
    /// <typeparam name="T">The output sequence type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<T> reverse<S,T>(IEnumerable<S> src, Func<S,T> f)
        => map(reverse(src),f);
}