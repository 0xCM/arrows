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

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]   
    public static HashSet<T> set<T>(params T[] src)
        => new HashSet<T>(src);

    [MethodImpl(Inline)]   
    public static IEnumerable<T> map<S,T>(IEnumerable<S> src, Func<S,T> f)
        => src.Select(x => f(x));

    [MethodImpl(Inline)]   
    public static T[] map<S,T>(S[] src, Func<S,T> f)
    {
        var dst = new T[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = f(src[i]);
        return dst;
    }    

    /// <summary>
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <typeparam name="B">The target value type</typeparam>
    /// <returns>The transformed sequence</returns>
    public static IEnumerable<B> mapi<A,B>(Func<int,A,B> f, IEnumerable<A> src)
    {
        var i = 0;
        foreach(var item in src)
            yield return f(i++,item);
    }

    /// <summary>
    /// Applies a function to a value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="f">The function to apply</param>
    /// <typeparam name="X">The source value type</typeparam>
    /// <typeparam name="Y">The output value type</typeparam>
    [MethodImpl(Inline)]   
    public static Y apply<X,Y>(X x,Func<X,Y> f)
        => f(x);

    /// <summary>
    /// Reduces a sequence to a single value via a supplied operator
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="f">The reduction operator</param>
    /// <param name="a0">The seed value</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static T fold<T>(IEnumerable<T> src, Func<T,T,T> f, T a0 = default(T))
    {
        var cumulant = a0;
        foreach(var item in src)
            cumulant = f(cumulant,item);            
        return cumulant;
    }

    /// <summary>
    /// Transforms a function (S,T) -> U to a function S -> (T -> U)
    /// </summary>
    /// <typeparam name="S">The first argument type</typeparam>
    /// <typeparam name="T">The second argument type</typeparam>
    /// <typeparam name="U">The codomain</typeparam>
    [MethodImpl(Inline)]
    public static Func<S,T,U> curry<S,T,U>(Func<(S,T), U> f)
    {        
        U g(S a, T b) => f((a,b));        
        return g;
    }

    /// <summary>
    /// Transforms a function S -> (T -> U) to a function (S,T) -> U
    /// </summary>
    /// <typeparam name="S">The first argument type</typeparam>
    /// <typeparam name="T">The second argument type</typeparam>
    /// <typeparam name="U">The codomain</typeparam>
    [MethodImpl(Inline)]
    public static Func<(S,T),U> uncurry<S,T,U>(Func<S,T,U> f)
    {        
        U g((S a, T b) x) => f(x.a,x.b);
        return g;
    }

    /// <summary>
    /// Creates a deferred value
    /// </summary>
    /// <param name="factory">A function that produces a value upon demeand</param>
    [MethodImpl(Inline)]
    public static Lazy<T> defer<T>(Func<T> factory)
        => new Lazy<T>(factory);
}