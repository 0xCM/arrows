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
    /// Aplies an action to the sequence of integers min,min+1,...,max - 1
    /// </summary>
    /// <param name="min">The inclusive lower bound of the sequence</param>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    [MethodImpl(Inline)]
    public static void iter(int min, int max, Action<int> f)
    {
       for(var i = min; i< max; i++) 
            f(i);
    }

    /// <summary>
    /// Aplies an action to the sequence of integers min,min+1,...,max - 1
    /// </summary>
    /// <param name="min">The inclusive lower bound of the sequence</param>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    [MethodImpl(Inline)]
    public static void iter(long min, long max, Action<long> f)
    {
       for(var i = min; i< max; i++) 
            f(i);
    }

    /// <summary>
    /// Applies an action to the increasing sequence of integers 0,1,2,...,count - 1
    /// </summary>
    /// <param name="count">The number of times the action will be invoked
    /// <param name="f">The action to be applied to each value</param>
    [MethodImpl(Inline)]
    public static void iter(int count, Action<int> f)
    {
       for(var i = 0; i< count; i++) 
            f(i);
    }

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

    [MethodImpl(Inline)]
    public static void iter(int start, int limit, int step, Action<int> f)
    {
        for(var i = start; i < limit; i += step)   
            f(i);             
    }

    // [MethodImpl(Inline)]
    // public static IEnumerable<int> range(int start, int limit, int step)
    // {
    //     for(var i = start; i< limit; i += step)
    //         yield return i;
    // }

}