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
using Array = Z0.array;

public static partial class zcore
{

    /// <summary>
    /// Populates a semigroup seqeunce container
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static SemiSeq<T> semiseq<T>(IEnumerable<T> src)
        where T : Structures.Semigroup<T>, new()
            => new SemiSeq<T>(src);

    /// <summary>
    /// Populates a semigroup seqeunce container
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static SemiSeq<T> semiseq<T>(params T[] src)
        where T : Structures.Semigroup<T>, new()
            => new SemiSeq<T>(src);


    /// <summary>
    /// Constructs a variable-lenth slice from a parameter array
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="T">The element type </typeparam>
    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(params T[] src)
            => new Slice<T>(src);

    /// <summary>
    /// Constructs a variable-lenth slice from a stream
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="T">The element type </typeparam>
    [MethodImpl(Inline)]   
    public static Z0.Slice<T> slice<T>(IEnumerable<T> src)
            => new Slice<T>(src);

    /// <summary>
    /// Constructs a slice of natural lengh from a stream
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="N">The natural type</typeparam>
    /// <typeparam name="T">The element type </typeparam>
    [MethodImpl(Inline)]   
    public static Z0.Slice<N,T> slice<N,T>(IEnumerable<T> src)
        where N : TypeNat, new()
            => new Slice<N,T>(src);

    /// <summary>
    /// Constructs a slice of natural lengh from a parameter array
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="N">The natural type</typeparam>
    /// <typeparam name="T">The element type </typeparam>
    [MethodImpl(Inline)]   
    public static Z0.Slice<N,T> slice<N,T>(params T[] src)
        where N : TypeNat, new()
            => new Slice<N,T>(src);

    /// <summary>
    /// Constructs a Seq[T] from a parameter array
    /// </summary>
    /// <param name="src">The source items</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static Seq<T> seq<T>(params T[] src)
            => Seq.define(src);

    /// <summary>
    /// Consructs an enumerable from a parameter array
    /// </summary>
    /// <param name="src">The source items</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> items<T>(params T[] src)
        => src;

    /// <summary>
    /// Constructs an index from a parameter array
    /// </summary>
    /// <param name="src">The source elements</param>
    /// <typeparam name="T">The element type/typeparam>
    [MethodImpl(Inline)]
    public static Index<T> list<T>(params T[] src)
        => new Index<T>(src);

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<T>(long len = 0)
        => new T[len];


    /// <summary>
    /// Concatentates two arrays
    /// </summary>
    /// <param name="lhs">The first array of bytes</param>
    /// <param name="rhs">The second array of bytes</param>
    public static T[] concat<T>(T[] lhs, T[] rhs)
        => Array.concat(lhs,rhs);

    /// <summary>
    /// Concatentates a parameter array of byte arrays
    /// </summary>
    public static byte[] concat(params byte[][] src)
        => Array.concat(src);

    /// <summary>
    /// Concatenates a sequence of byte arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    public static byte[] concat(IEnumerable<byte[]> src)
        => Array.concat(src);

    /// <summary>
    /// Concatenates a sequence of parameter arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    public static T[] concat<T>(params T[][] src)
        => Array.concat(src);

    /// <summary>
    /// Concatenates a sequence of arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    public static T[] concat<T>(IEnumerable<T[]> src)
        => Array.concat(src);

    /// <summary>
    /// Reflects variable number of arguments from a parms array back as
    /// a standard array
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<T>(params T[] src)
        => src;

    /// <summary>
    /// Constructs an N-array from a parameter array
    /// </summary>
    /// <param name="src">The element source</param>
    /// <typeparam name="N">The length type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Array<N,T> array<N,T>(params T[] src)
        where N : TypeNat, new()
            => NArray.define<N,T>(src);

    /// <summary>
    /// Constructs an N-array from a parameter array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <param name="src">The element source</param>
    /// <typeparam name="N">The length type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Array<N,T> array<N,T>(N len, params T[] src)
        where N : TypeNat, new()
            => NArray.define(len,src);

    /// <summary>
    /// Constructs an array of natural length from an enumerable
    /// </summary>
    /// <param name="src">The source values</param>
    /// <typeparam name="N">The natural length type</typeparam>
    /// <typeparam name="T">Then element type</typeparam>
    [MethodImpl(Inline)]
    public static Array<N,T> array<N,T>(IEnumerable<T> src)
        where N : TypeNat, new()
            => NArray.define<N,T>(src);

    /// <summary>
    /// Constructs an array of natural length from an enumerable
    /// </summary>
    /// <param name="src">The source values</param>
    /// <typeparam name="N">The natural length type</typeparam>
    /// <typeparam name="T">Then element type</typeparam>
    [MethodImpl(Inline)]
    public static Array<N,T> array<N,T>(N len, IEnumerable<T> src)
        where N : TypeNat, new()
            => NArray.define(len,src);

    /// <summary>
    /// Constructs a mutable dictionary 
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    [MethodImpl(Inline)]   
    public static Dictionary<K,V> dict<K,V>(params (K key, V value)[] src)
        => new Dictionary<K, V>();

    /// <summary>
    /// Constructs integrally-keyed associative array
    /// </summary>
    /// <param name="src">The source values</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static Index<T> index<T>(IEnumerable<T> src)
        => new Index<T>(src);

    /// <summary>
    /// Constructs an empty concurrent index 
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    [MethodImpl(Inline)]   
    public static ConcurrentIndex<K,V> cindex<K,V>()
        => new ConcurrentIndex<K,V>();

    /// <summary>
    /// Constructs a concurrent bag with optional initial items
    /// </summary>
    /// <typeparam name="T">The bagged type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static ConcurrentBag<T> cbag<T>(params T[] initial)
        => new ConcurrentBag<T>(initial);

    /// <summary>
    /// Constructs an associative array
    /// </summary>
    /// <param name="items">Item tuples that will be indexed/stored</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    [MethodImpl(Inline)]   
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
    /// Partitions a seequence into segments of a specified natural width
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public static IEnumerable<IReadOnlyList<T>> partition<W,T>(IEnumerable<T> src)
        where W : TypeNat, new()
    {
        var width = natval<W>();
        var sement = new T[width];
        var current = 0UL;
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

    /// <summary>
    /// Transforms a sequence of elements into a sequence of singleton sequences 
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<IEnumerable<T>> singletons<T>(IEnumerable<T> src)
        => from item in src select items(item);

    /// <summary>
    /// Constructs an array filled with a replicated value
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <param name="count">The number of replicants</param>
    /// <typeparam name="T">The replicant type</typeparam>
    /// <returns></returns>
    public static T[] repeat<T>(T value, ulong count)
    {
        var dst = array<T>((uint)count);
        for(var idx = 0U; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    public static T[] repeat<T>(T value, int count)
    {
        var dst = array<T>(count);
        for(var idx = 0; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    public static T[] repeat<T>(T value, uint count)
    {
        var dst = array<T>(count);
        for(var idx = 0; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    /// <summary>
    /// Replicates a given value a specified number of times
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <typeparam name="N">The natural count type</typeparam>
    /// <typeparam name="T">The replicant type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] repeat<N,T>(T value)
        where N : TypeNat, new()
        => repeat(value, natval<N>());

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
        where T : Equatable<T>, new()
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


    /// <summary>
    /// Iterates over the supplied items, invoking a receiver for each
    /// </summary>
    /// <param name="src">The source items</param>
    /// <param name="f">The receiver</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static Unit iter<T>(IEnumerable<T> items, Action<T> action, bool pll = false)
    {
        if (pll)
            items.AsParallel().ForAll(item => action(item));
        else
            foreach (var item in items)
                action(item);
        return Unit.Value;
    }

    /// <summary>
    /// Attaches a 0-based integer sequence to the input value sequence and
    /// yield the paired sequence elements
    /// </summary>
    /// <param name="i">The index of the paired value</param>
    /// <param name="value">The indexed value</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]   
    public static IEnumerable<(int i, T value)> iteri<T>(IEnumerable<T> items)
    {
        var idx = 0;
        foreach(var item in items)
            yield return (idx++, item);
    }

}