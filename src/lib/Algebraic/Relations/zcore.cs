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
    /// Constructs a finite set from supplied members
    /// </summary>
    /// <param name="members">The defining members</param>
    /// <typeparam name="T">The member type</typeparam>
    /// <returns></returns>
    public static FiniteSet<T> set<T>(params T[] members)
        where T : Equality<T>, new()
            => new FiniteSet<T>(members);

    /// <summary>
    /// Constructs a finite set from supplied sequence
    /// </summary>
    /// <param name="members">The defining members</param>
    /// <typeparam name="T">The member type</typeparam>
    /// <returns></returns>
    public static FiniteSet<T> set<T>(IEnumerable<T> members)
        where T : Equality<T>, new()
            => new FiniteSet<T>(members);

}
