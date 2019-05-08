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
using System.Reflection;

using Z0;
using static Z0.Traits;
using static zfunc;

partial class zcore
{
    /// <summary>
    /// Gets the literal values for an enum type
    /// </summary>
    /// <typeparam name="T">The enum type</typeparam>
    public static IEnumerable<T> literals<T>()
        where T : Enum
            => type<T>().GetEnumValues().AsQueryable().Cast<T>();

    /// <summary>
    /// Reduces a stream to a single value via an additive monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T foldA<T>(IEnumerable<T> src)
        where T : struct, Structures.IMonoidA<T>
    {
        
        var cumulant = default(T).zero;
        foreach(var item in src)
            cumulant = cumulant.add(item);            
        return cumulant;
    }
                
    /// <summary>
    /// Reduces a stream to a single value via a multiplicative monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T foldM<T>(IEnumerable<T> src)
        where T : struct, Structures.IMonoidM<T>
    {        
        var cumulant = default(T).one;
        foreach(var item in src)
            cumulant = cumulant.mul(item);            
        return cumulant;
    }
                
    /// <summary>
    /// Reduces a stream to a single value via a specified monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T fold<T>(IEnumerable<T> src, Operative.IMonoidalOps<T> monoid)
        where T : struct, IEquatable<T>
    {
        
        var cumulant = monoid.identity;
        foreach(var item in src)
            cumulant = monoid.compose(cumulant, item);            
        return cumulant;
    }
                    
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
    /// Constructs a pair enumerator from two distict enumerables
    /// </summary>
    /// <param name="left">The left sequence</param>
    /// <param name="right">The right sequence</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static (IEnumerator<T> left, IEnumerator<T> right) enumerator<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        => (lhs.GetEnumerator(),rhs.GetEnumerator());

    /// <summary>
    /// Advances paired enumerators
    /// </summary>
    /// <param name="left">The left enumerator</param>
    /// <param name="right">The right enumerator</param>
    /// <typeparam name="T"></typeparam>
    /// <returns>Returns false if either enumerator as advanced past the end of its respective sequence</returns>
    [MethodImpl(Inline)]   
    public static bool next<T>((IEnumerator<T> left, IEnumerator<T> right) enumerator)
        => enumerator.left.MoveNext() && enumerator.right.MoveNext();

    /// <summary>
    /// Obtains the current pair from a paired enumerator
    /// </summary>
    /// <param name="left">The left enumerator</param>
    /// <param name="right">The right enumerator</param>
    /// <typeparam name="T"></typeparam>
    [MethodImpl(Inline)]   
    public static (T left, T right) current<T>((IEnumerator<T> left, IEnumerator<T> right) enumerator)
        => (enumerator.left.Current, enumerator.right.Current);
    
    /// <summary>
    /// Evaluates a binary predicate over a sequence of pairs and returns true if any
    /// elements of the sequence satisfy the predicate
    /// </summary>
    /// <param name="left">The left pair component</param>
    /// <param name="right">The right pair component</param>
    /// <typeparam name="T">The sequence element type</typeparam>
    [MethodImpl(Inline)]   
    public static bool any<T>(IEnumerable<(T left, T right)> src, Func<T,T,bool> predicate)
        => src.Any(pair => predicate(pair.left, pair.right));

    /// <summary>
    /// Returns true if an element is found in the soruce sequence that 
    /// satisfies a predicate. 
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="predicate">The predcicate to eveluate</param>
    /// <typeparam name="T">The sequence element type</typeparam>
    [MethodImpl(Inline)]   
    public static bool any<T>(IEnumerable<T> src, Func<T,bool> predicate)
        => src.Any(predicate);

    /// <summary>
    /// If possible, returns the first value in the sequence that matches a predicate;
    /// otherwise returns none
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="predicate">The predicate to evaluate over sequence elements</param>
    /// <typeparam name="T">The sequence element type</typeparam>
    [MethodImpl(Inline)] 
    public static Option<T> first<T>(IEnumerable<T> src, Func<T,bool> predicate)
        => src.FirstOrDefault(predicate);

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