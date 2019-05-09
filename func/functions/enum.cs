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
    /// <summary>
    /// Consructs an enumerable from a parameter array
    /// </summary>
    /// <param name="src">The source items</param>
    /// <typeparam name="T">The item type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> items<T>(params T[] src)
        => src;

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


}