//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;
using static zfunc;


partial class zcore
{

    /// <summary>
    /// Constructs a finite set from the (presumeably) finite source sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The set member type</typeparam>
    /// <returns></returns>
    public static FiniteSet<T> ToFiniteSet<T>(this IEnumerable<T> src)
        where T : ISemigroup<T>, new()
            => new FiniteSet<T>(src);

    /// <summary>
    /// Partitons a finite sequence of items via an equivalence relation
    /// </summary>
    /// <param name="relation">The partitioning relation</param>
    /// <param name="items">The items to partition</param>
    /// <typeparam name="T">The item type</typeparam>
    public static IEnumerable<FiniteEquivalenceClass<T>> Partition<T>(this IEquivalenceOps<T> relation, IEnumerable<T> items)
        where T : ISemigroup<T>, new()

    {
        var classes = cindex<T, ConcurrentBag<T>>();
        foreach(var item in items)
        {
            classes.FirstKey(k => relation.related(item,k))
                    .OnNone(() => classes.TryAdd(item, k => cbag(k)))
                    .OnSome(k => classes[k].Add(item));
        }

        return classes.KeyedValues.Select(kvp => new FiniteEquivalenceClass<T>(kvp.key,relation, kvp.value ));
    }


    /// <summary>
    /// Determines whether two sequences, adjudicated by positional elemental equality, are equal
    /// </summary>
    /// <typeparam name="T">The type of value object</typeparam>
    /// <param name="lhs">The first list</param>
    /// <param name="rhs">The second list</param>
    public static bool eq<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T : IEquatable<T>, new()
    {    
        
        var lenum = lhs.GetEnumerator();
        var renum = rhs.GetEnumerator();
        var lnext = lenum.MoveNext();
        var rnext = renum.MoveNext();
        while(lnext || rnext)
        {
            if( (lnext & not(rnext)) || (rnext && not(lnext)))
                return false;
            
            if(!lenum.Current.Equals(renum.Current))
                return false;

            lnext = lenum.MoveNext();
            rnext = renum.MoveNext();
        }

        return true;
    } 
}