//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

using static Z0.Credit;
using static corefunc;


public static partial class corext
{


    /// <summary>
    /// Formats the source as a braced list
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static string Embrace<T>(this IEnumerable<T> src)
        => embrace(string.Join(',',src));

    /// <summary>
    /// Defines an unsigned alterantive to the intrinsic Count property
    /// </summary>
    /// <param name="src">The source list</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static uint Length<T>(this IReadOnlyList<T> src)
        => (uint)src.Count;


}