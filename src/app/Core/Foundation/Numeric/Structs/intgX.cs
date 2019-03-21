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
        where T : new() => src.Select(x => x.data).ToList();

    public static intg<T> ToIntG<T>(this byte src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this sbyte src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this short src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this ushort src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this int src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this uint src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this long src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

    public static intg<T> ToIntG<T>(this ulong src)
        where T : new()
        => (T)Convert.ChangeType(src,typeof(T));

}

