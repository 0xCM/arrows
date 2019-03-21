//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Core;
using Symbols;
using C = Core.Contracts;

using static Core.Credit;
using static corefunc;


public static partial class corext
{
    /// <summary>
    /// Defines a window over a 1-d array beginning at a specified index for a specified length
    /// 
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="start">The 0-based starting index</param>
    /// <param name="len">The length of the segment</param>
    /// <typeparam name="T">The element type</typeparam>
    public static IReadOnlyList<T> Segment<T>(this T[] src, int start, int len)
        => new ArraySegment<T>(src, start, len);

    /// <summary>
    /// Lifts a function to a unary operator
    /// </summary>
    /// <param name="f">The function to lift</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Core.UnaryOp<T> ToUnaryOp<T>(this Func<T,T> f)
        => new Reify.UnaryOp<T>(f);

    /// <summary>
    /// Lifts a function to a binary opeator operator
    /// </summary>
    /// <param name="f">The function to lift</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static BinaryOp<T> ToBinaryOp<T>(this Func<T,T,T> f, bool commutative = false)
            => commutative 
            ?  cast<BinaryOp<T>>(new Reify.CommutativeOp<T>(f)) 
            : new Reify.BinaryOp<T>(f);

    /// <summary>
    /// Attaches a 0-based integer sequence to the input value sequence and
    /// yield the paired sequence elements
    /// </summary>
    /// <param name="i">The index of the paired value</param>
    /// <param name="value">The indexed value</param>
    /// <typeparam name="T">The item type</typeparam>
    public static IEnumerable<(int i, T value)> Iteri<T>(this IEnumerable<T> items)
        => iteri(items);

    public static IEnumerable<IReadOnlyList<T>> Partition<W,T>(this IEnumerable<T> src)
        where W : TypeNat
            => partition<W,T>(src);    

    public static string Embrace<T>(this IEnumerable<T> src)
        => embrace(string.Join(',',src));
}