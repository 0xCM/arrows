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
using static Z0.Bibliography;
using static Z0.Traits;


partial class zcore
{

    /// <summary>
    /// Determines whether two lists, adjudicated by positional elemental equality, are equal
    /// </summary>
    /// <typeparam name="T">The type of value object</typeparam>
    /// <param name="lhs">The first list</param>
    /// <param name="rhs">The second list</param>
    /// <returns></returns>
    public static bool eq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
        where T : Traits.Equatable<T>, new()
    {    
        if (lhs == null || rhs == null || lhs.Count != rhs.Count)
            return false;

        var equality = new T();

        for (int i = 0; i < lhs.Count; i++)
            if(equality.neq(lhs[i], rhs[i]))
                return false;
        return true;
    }

    /// <summary>
    /// Determines whether two sequences, adjudicated by positional elemental equality, are equal
    /// </summary>
    /// <typeparam name="T">The type of value object</typeparam>
    /// <param name="lhs">The first list</param>
    /// <param name="rhs">The second list</param>
    /// <returns></returns>
   public static bool eq<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T : Traits.Equatable<T>, new()
    {    
        
        var equality = new T(); //ops<T,Traits.Equatable<T>>();
        var lenum = lhs.GetEnumerator();
        var renum = rhs.GetEnumerator();
        var lnext = lenum.MoveNext();
        var rnext = renum.MoveNext();
        while(lnext || rnext)
        {
            if( (lnext & not(rnext)) || (rnext && not(lnext)))
                return false;
            
            if(equality.neq(lenum.Current, renum.Current))
                return false;

            lnext = lenum.MoveNext();
            rnext = renum.MoveNext();
        }

        return true;
    }
 
}