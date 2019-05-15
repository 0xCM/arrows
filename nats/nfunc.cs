//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static zfunc;

public static class nfunc
{
    internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    internal const MethodImplOptions NoInline = MethodImplOptions.NoInlining;
    
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
        var upperBound = Math.Ceiling(Math.Sqrt(x));
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
        where T : struct
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
        where T : struct
            => vector<N4,T>(x.x1, x.x2,x.x3,x.x4);

    /// <summary>
    /// Converts an homogenous 2-tuple to a 2-vector
    /// </summary>
    /// <param name="x1">The first coorinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <typeparam name="T">The coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static Vector<N2,T> vector<T>((T x1, T x2) x)
        where T : struct
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

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The vector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(params T[] components)
        where N : ITypeNat, new()
        where T : struct
            => new Z0.Vector<N,T>(components);

    /// <summary>
    /// Constructs a vector where each component has the same value
    /// </summary>
    /// <param name="component">The value assigned to each component</param>
    /// <typeparam name="N">The vector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(T component)
        where N : ITypeNat, new()
        where T : struct
            => new Vector<N,T>(repeat<N,T>(component));

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components">The components with which to construct the vector</param>
    /// <typeparam name="N">The vector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(IEnumerable<T> src)
        where N : ITypeNat, new()
        where T : struct
                => new Vector<N,T>(src);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Vector<N,T> vector<N,T>(N len, IEnumerable<T> components)
        where N : ITypeNat, new()
        where T : struct
            => vector(len,components);

    /// <summary>
    /// Constructs a vector characterized by length and component type
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    /// <remarks>No allocation occurs during construction</remarks>
    public static Vector<N,T> vector<N,T>(N len, IReadOnlyList<T> components)
        where N : ITypeNat, new()
        where T : struct
            => vector(len,components);

    /// <summary>
    /// Constructs a covector from sequence of components
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The covector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(Dim<N> dim, params T[] components)
        where N : ITypeNat, new()
        where T : struct
            => Covector.define<N,T>(dim, components);

    /// <summary>
    /// Constructs a covector from a sequence of components
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The covector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(IEnumerable<T> components)
        where N : ITypeNat, new()
        where T : struct
            => Covector.define<N,T>(components);

    /// <summary>
    /// Constructs a covector from a component parameter array
    /// </summary>
    /// <param name="components"></param>
    /// <typeparam name="N">The covector length</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [MethodImpl(Inline)]   
    public static Covector<N,T> covector<N,T>(params T[] components)
        where N : ITypeNat, new()
        where T : struct  
            => Covector.define<N,T>(components);

    /// <summary>
    /// Constructs a slice of natural length from a parameter array
    /// </summary>
    /// <param name="src">The source data</param>
    /// <typeparam name="T">The individual type</typeparam>
    /// <typeparam name="N">The natural length type</typeparam>
    [MethodImpl(Inline)]
    public static Slice<N,T> slice<N,T>(params T[] src)
        where N : ITypeNat, new() 
        where T : struct
            => new Slice<N,T>(src);


    /// <summary>
    /// Constructs a slice of natural length from a stream
    /// </summary>
    /// <param name="src">The source data</param>
    /// <typeparam name="T">The individual type</typeparam>
    /// <typeparam name="N">The natural length type</typeparam>
    [MethodImpl(Inline)]
    public static Slice<N,T> slice<N,T>(IEnumerable<T> src)
        where N : ITypeNat, new() 
        where T : struct
            => new Slice<N,T>(src);


    /// <summary>
    /// Constructs a vector from the componentwise-sum of two others
    /// </summary>
    /// <param name="lhs">The first vector</param>
    /// <param name="lhs">The second vector</param>
    /// <typeparam name="N">The common vector length</typeparam>
    /// <typeparam name="T">The common component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
        where N : ITypeNat, new() 
        where T : struct, ISemiring<T>
            =>  lhs.fuse(rhs, (x,y) => x.add(y));

    /// <summary>
    /// Constructs a vector from the componentwise-product of two others
    /// </summary>
    /// <param name="lhs">The first vector</param>
    /// <param name="lhs">The second vector</param>
    /// <typeparam name="N">The common vector length</typeparam>
    /// <typeparam name="T">The common component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
        where N : ITypeNat, new() 
        where T : struct, ISemiring<T>
            =>  lhs.fuse(rhs, (x,y) => x.mul(y));

    [MethodImpl(Inline)]
    public static Vector<N,bool> equality<N,T>(Vector<N,T> lhs, Vector<N,T> rhs)
        where N : ITypeNat, new() 
        where T : struct
            => vector<N,bool>(lhs == rhs);

    [MethodImpl(Inline)]
    public static Vector<N,bool>[] equality<N,T>(Vector<N,T>[] lhs, Vector<N,T>[] rhs)
        where N : ITypeNat, new() 
        where T : struct
            => fuse(lhs, rhs, (v1,v2) =>  vector<N,bool>(v1 == v2));


    [MethodImpl(Inline)]
    public static T reduce<N,T>(Slice<N,T> s, Func<T,T,T> reducer)
            where N : Z0.ITypeNat, new()
            where T : struct, ISemiring<T>
                => fold(s.data,reducer);


    [MethodImpl(Inline)]
    public static T sum<N,T>(Slice<N,T> x)
        where N : Z0.ITypeNat, new() 
        where T : struct, ISemiring<T>
            => reduce(x, (a,b) => a.add(b));


    /// <summary>
    /// Constructs a bit vector from a bit parameter array
    /// </summary>
    /// <param name="src">The bit source</param>

    [MethodImpl(Inline)]   
    public static BitVector<N> bitvector<N>(params Bit[] src)
        where N : ITypeNat, new()
            => BitVector.Define<N>(src);

    /// <summary>
    /// Constructs a bit vector from a parameter array of integers
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]   
    public static BitVector<N> bitvector<N>(params uint[] src)
        where N : ITypeNat, new()
            => BitVector.Define<N>(map(src, x => x == 0 ? Bit.Off : Bit.On));

    /// <summary>
    /// Constructs a bit vector of natural length 8 from a parameter array of integers
    /// where there constructed vector is left-padded with zeros should there be
    /// fewer than 8 bits specified
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]   
    public static BitVector<N8> bytevector(params uint[] src)
        => BitVector.Define<N8>(map(src, x => x == 0 ? Bit.Off : Bit.On));

    /// <summary>
    /// Defines a bitvector of natural length 8 from a parameter array of binary digits
    /// </summary>
    /// <param name="src">The source digits</param>
    [MethodImpl(Inline)]   
    public static BitVector<N8> bytevector(params BinaryDigit[] src)
        => BitVector.Define<N8>(map(src, x => x == 0 ? Bit.Off : Bit.On));
}