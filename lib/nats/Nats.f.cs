//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static zcore;

public static class nats
{
    const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    static IEnumerable<ulong> range(ulong first, ulong last)
    {
        var current = first;
        if(first < last)
            while(current<= last)
                yield return current++;
        else
            while(current >= last)
                yield return current--;
    }

    /// <summary>
    /// Computes the integral divisors of a number, exluding 1 and the number itself
    /// </summary>
    /// <param name="src">The source value</param>
    static IEnumerable<ulong> divisors(ulong src)
    {        
        if(src != 0 && src != 1)
        {
            var upper = src/2 + 1;
            var candidates = range(2ul, upper);
            foreach(var c in candidates)
                if(src % c == 0 )
                    yield return c;
        }    
    }

    /// <summary>
    /// Determines whether an integer is prime
    /// </summary>
    /// <param name="x">The integer to examine</param>
    /// <typeparam name="T">The underlying integer type</typeparam>
    [MethodImpl(Inline)]   
    public static bool prime(ulong x)
    {
        var upperBound = x.ToFloatG64().sqrt().ceiling();
        return divisors(x).Count() == 0;
    }                

    /// <summary>
    /// Retrieves the value of the natural number associated with a typenat
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static ulong natu<N>() 
        where N : ITypeNat, new()
            => new N().value; 

    /// <summary>
    /// Retrieves the value of a type natural represented as a signed integer
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static int nati<N>() 
        where N : ITypeNat, new()
            => (int)natu<N>();

    /// <summary>
    /// Retrieves the value of a type natural represented as an usigned int
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static uint natui<N>() 
        where N : ITypeNat, new()
            => (uint)natu<N>();

    /// <summary>
    /// Retrieves the value of a type natural represented as an integer
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static int nati<N>(N rep) 
        where N : ITypeNat, new()
            => (int)rep.value;

    /// <summary>
    /// Constructs a natural representative
    /// </summary>
    /// <typeparam name="K">The representative type</typeparam>
    [MethodImpl(Inline)]   
    public static K natrep<K>()
        where K : ITypeNat,new()
            => new K(); 

    /// <summary>
    /// Constructs a 1-component natural dimension
    /// </summary>
    /// <typeparam name="K">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K> dim<K>()
        where K : ITypeNat, new()
            => Dim.define<K>();

    /// <summary>
    /// Constructs a 1-component natural dimension
    /// </summary>
    /// <typeparam name="K">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K> dim<K>(K k)
        where K : ITypeNat, new()
            => Dim.define<K>();

    /// <summary>
    /// Constructs a 2-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2> dim<K1,K2>()
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
            => Dim.define<K1,K2>();

    /// <summary>
    /// Constructs a 2-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2> dim<K1,K2>(K1 k1, K2 k2)
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
            => Dim.define<K1,K2>();

    /// <summary>
    /// Constructs a 3-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    /// <typeparam name="K3">The type of the third component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2,K3> dim<K1,K2,K3>()
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
            => Dim.define<K1,K2,K3>();

    /// <summary>
    /// Constructs a 3-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    /// <typeparam name="K3">The type of the third component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2,K3> dim<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
            => Dim.define<K1,K2,K3>();

    /// <summary>
    /// Demands truth that is enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool demand(bool x, string message = null)
        => x ? x : throw new Exception(message ?? "demand failed");


    /// <summary>
    /// Converts a 3-vector to a 3-tuple
    /// </summary>
    /// <param name="x1">The first coorinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <param name="x4">The fourth coordinate</param>
    /// <param name="x3">The third coordinate</param>
    /// <typeparam name="T">The coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static (T x1, T x2, T x3, T x4) tuple<T>(Vector<N4,T> v)
        where T : struct, IEquatable<T>
            => (v[0], v[1], v[2], v[3]);

    /// <summary>
    /// Converts an homogenous 4-tuple to a 4-vector
    /// </summary>
    /// <param name="x1">The first coorinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <param name="x3">The third coordinate</param>
    /// <param name="x4">The fourth coordinate</param>
    /// <typeparam name="T">The coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static Vector<N4,T> vector<T>((T x1, T x2, T x3, T x4) x)
        where T : struct, IEquatable<T>
            => vector<N4,T>(x.x1, x.x2,x.x3,x.x4);

    /// <summary>
    /// Converts an homogenous 2-tuple to a 2-vector
    /// </summary>
    /// <param name="x1">The first coorinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <typeparam name="T">The coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static Vector<N2,T> vector<T>((T x1, T x2) x)
        where T : struct, IEquatable<T>
            => vector<N2,T>(x.x1, x.x2);

    /// <summary>
    /// Replicates a given value a specified number of times
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <typeparam name="N">The natural count type</typeparam>
    /// <typeparam name="T">The replicant type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] repeat<N,T>(T value)
        where N : ITypeNat, new()
        => zfunc.repeat(value, natu<N>());
}