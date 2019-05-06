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

partial class zcore
{


    /// <summary>
    /// Aplies an action to the sequence of generic integers min,min+1,...,max - 1
    /// </summary>
    /// <param name="min">The inclusive lower bound of the sequence</param>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    [MethodImpl(Inline)]
    public static void iterg<T>(intg<T> min, intg<T> max, Action<intg<T>> f)
        where T : struct, IEquatable<T>
    {
       for(var i = min; i< max; i++) 
            f(i);
    }

    /// <summary>
    /// Aplies an action to the sequence of generic integers 0,2,...,max - 1
    /// </summary>
    /// <param name="max">The non-inclusive upper bound of the sequence
    /// over intergers over which iteration will occur</param>
    /// <param name="f">The action to be applied to each  value</param>
    [MethodImpl(Inline)]
    public static void iterg<T>(intg<T> max, Action<intg<T>> f)
        where T : struct, IEquatable<T>
    {
       for(var i = max.zero; i< max; i++) 
            f(i);
    }

}