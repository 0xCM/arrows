//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using System.Text;
using Core;

using C = Core.Contracts;

using static corefunc;
using static Core.Operations;


public static class intgX
{
    public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<intg<T>> src)
        => src.Select(x => x.data).ToList();

    public static intg<T> ToIntG<T>(this byte src)
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this sbyte src)
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this short src)
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this ushort src)
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this int src)
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this uint src)
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this long src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this ulong src)
        => (T)Convert.ChangeType(src,typeof(T));

}

