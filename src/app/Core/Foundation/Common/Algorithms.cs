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
using static Core.Credit;
using static corefunc;
using static Core.Traits;


public static partial class corefunc
{
    /// <summary>
    /// Reduces a sequence to a single value via a supplied operator
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="f">The reduction operator</param>
    /// <param name="a0">The seed value</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T fold<T>(IEnumerable<T> src, Func<T,T,T> f, T a0 = default(T))
    {
        var cumulant = a0;
        foreach(var item in src)
            cumulant = f(cumulant,item);            
        return cumulant;
    }

    /// <summary>
    /// Raises a baise to a power
    /// </summary>
    /// <param name="@base">The base value</param>
    /// <param name="exp">The exponent value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static uint pow(uint @base, uint exp)
        => fold(repeat(@base, exp), (x,y) => x*y);


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
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static (T left, T right) current<T>((IEnumerator<T> left, IEnumerator<T> right) enumerator)
        => (enumerator.left.Current, enumerator.right.Current);

    public static IEnumerable<(T left, T right)> zip<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
    {
        var e = enumerator<T>(lhs,rhs);
        while(next(e))
            yield return current(e);                
    }

    /// <summary>
    /// Zips the source sequences and fuses elements componentwise via a binary operator
    /// to determine the result sequence
    /// </summary>
    /// <param name="lhs">The first sequence</param>
    /// <param name="rhs">The second sequence</param>
    /// <param name="f">The binary operator that fuses positional pairs</param>
    /// <typeparam name="T">The squence type</typeparam>
    /// <returns></returns>
    public static IEnumerable<T> zip<T>(IEnumerable<T> lhs, IEnumerable<T> rhs, Func<T,T,T> f)
        => from pair in zip(lhs,rhs) select f(pair.left, pair.right);

    
    /// <summary>
    /// Evaluates a binary predicate over a sequence of pairs and returns true if any
    /// elements of the sequence satisfy the predicate
    /// </summary>
    /// <param name="left">The left pair component</param>
    /// <param name="right">The right pair component</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool any<T>(IEnumerable<(T left, T right)> src, Func<T,T,bool> predicate)
        => src.Any(pair => predicate(pair.left, pair.right));

    [MethodImpl(Inline)]   
    public static bool any<T>(IEnumerable<T> src, Func<T,bool> predicate)
        => src.Any(predicate);

    /// <summary>
    /// If possible, returns the first value in the sequence that matches a predicate;
    /// otherwise returns none
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="predicate">The predicate to evaluate over sequence elements</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)] 
    public static Option<T> first<T>(IEnumerable<T> src, Func<T,bool> predicate)
        => src.FirstOrDefault(predicate);

    /// <summary>
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The input element type</typeparam>
    /// <typeparam name="B">The output element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<B> map<A,B>(IEnumerable<A> src, Func<A,B> f)
        => src.Select(x => f(x));

    /// <summary>
    /// Applies a function to a potential value
    /// </summary>
    /// <param name="src">The potential value</param>
    /// <param name="f">The function to apply</param>
    /// <typeparam name="X">The source type</typeparam>
    /// <typeparam name="Y">The target type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<Y> map<X,Y>(Option<X> src, Func<X,Y> f)
        => src.trymap(f);

    /// <summary>
    /// Applies a function to a value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="f">The function to apply</param>
    /// <typeparam name="X">The source value type</typeparam>
    /// <typeparam name="Y">The output value type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Y map<X,Y>(X x,Func<X,Y> f)
        => f(x);

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
    public static void iter<T>(IEnumerable<T> src, Action<T> f)
    {
        foreach(var item in src)
            f(item);
    }

    /// <summary>
    /// Attaches a 0-based integer sequence to the input value sequence and
    /// yield the paired sequence elements
    /// </summary>
    /// <param name="i">The index of the paired value</param>
    /// <param name="value">The indexed value</param>
    /// <typeparam name="T">The item type</typeparam>
    public static IEnumerable<(int i, T value)> iteri<T>(IEnumerable<T> items)
    {
        var idx = 0;
        foreach(var item in items)
            yield return (idx++, item);
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
    
}