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
using static zfunc;


partial class zcore
{

    /// <summary>
    /// Determines whether two lists, adjudicated by positional elemental equality, are equal
    /// </summary>
    /// <typeparam name="T">The type of value object</typeparam>
    /// <param name="lhs">The first list</param>
    /// <param name="rhs">The second list</param>
    public static bool eq<T>(Index<T> lhs, Index<T> rhs)
        where T : Equatable<T>, new()
    {    
        if (lhs.Count != rhs.Count)
            return false;

        for (int i = 0; i < lhs.Count; i++)
            if(lhs[i].neq(rhs[i]))
                return false;
        return true;
    }

    /// <summary>
    /// Determines whether two sequences, adjudicated by positional elemental equality, are equal
    /// </summary>
    /// <typeparam name="T">The type of value object</typeparam>
    /// <param name="lhs">The first list</param>
    /// <param name="rhs">The second list</param>
   public static bool eq<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        where T : Equatable<T>, new()
    {    
        
        var lenum = lhs.GetEnumerator();
        var renum = rhs.GetEnumerator();
        var lnext = lenum.MoveNext();
        var rnext = renum.MoveNext();
        while(lnext || rnext)
        {
            if( (lnext & not(rnext)) || (rnext && not(lnext)))
                return false;
            
            if(lenum.Current.neq(renum.Current))
                return false;

            lnext = lenum.MoveNext();
            rnext = renum.MoveNext();
        }

        return true;
    }
 
}