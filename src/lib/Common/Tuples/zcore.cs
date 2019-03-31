//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zcore
{
    /// <summary>
    /// Maps a function over a 2-tuple
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X">The projected type</typeparam>
    /// <param name="x">The input value</param>
    /// <param name="f">The function to apply</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static X tmap<X1, X2, X>((X1 x1, X2 x2) x, Func<X1, X2, X> f)
        => f(x.x1, x.x2);

    /// <summary>
    /// Maps two functions over respective over respective 2-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2) tmap<X1, X2, Y1, Y2>((X1 x1, X2 x2) x, Func<X1, Y1> f1, Func<X2, Y2> f2)
        => (f1(x.x1), f2(x.x2));

    /// <summary>
    /// Maps a function over a 3-tuple
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X">The projected type</typeparam>
    /// <param name="x">The input value</param>
    /// <param name="f">The function to apply</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static X tmap<X1, X2, X3, X>((X1 x1, X2 x2, X3 x3) x, Func<X1, X2, X3, X> f)
        => f(x.x1, x.x2, x.x3);

    /// <summary>
    /// Maps three functions over respective over respective 3-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the second coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <typeparam name="Y3">The return type of the third function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <param name="f3">The function applied to the third coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2, Y3 y3) tmap<X1, X2, X3, Y1, Y2, Y3>((X1 x1, X2 x2, X3 x3) x, Func<X1, Y1> f1, Func<X2, Y2> f2, Func<X3, Y3> f3)
            => (f1(x.x1), f2(x.x2), f3(x.x3));

    /// <summary>
    /// Maps four functions over respective over respective 4-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the second coordinate</typeparam>
    /// <typeparam name="X4">The type of the second coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <typeparam name="Y3">The return type of the third function</typeparam>
    /// <typeparam name="Y4">The return type of the third function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <param name="f3">The function applied to the third coordinate</param>
    /// <param name="f4">The function applied to the fourth coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2, Y3 y3, Y4 y4) tmap<X1, X2, X3, X4, Y1, Y2, Y3, Y4>((X1 x1, X2 x2, X3 x3, X4 x4) x,
        Func<X1, Y1> f1, Func<X2, Y2> f2, Func<X3, Y3> f3, Func<X4, Y4> f4)
            => (f1(x.x1), f2(x.x2), f3(x.x3), f4(x.x4));

    /// <summary>
    /// Maps five functions over respective over respective 5-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <typeparam name="Y3">The return type of the third function</typeparam>
    /// <typeparam name="Y4">The return type of the fourth function</typeparam>
    /// <typeparam name="Y5">The return type of the fifth function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <param name="f3">The function applied to the third coordinate</param>
    /// <param name="f4">The function applied to the fourth coordinate</param>
    /// <param name="f5">The function applied to the fifth coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2, Y3 y3, Y4 y4, Y5 y5) tmap<X1, X2, X3, X4, X5, Y1, Y2, Y3, Y4, Y5>((X1 x1, X2 x2, X3 x3, X4 x4, X5 x5) x,
        Func<X1, Y1> f1, Func<X2, Y2> f2, Func<X3, Y3> f3, Func<X4, Y4> f4, Func<X5, Y5> f5)
            => (f1(x.x1), f2(x.x2), f3(x.x3), f4(x.x4), f5(x.x5));

    /// <summary>
    /// Maps six functions over respective over respective 6-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <typeparam name="X6">The type of the sixth coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <typeparam name="Y3">The return type of the third function</typeparam>
    /// <typeparam name="Y4">The return type of the fourth function</typeparam>
    /// <typeparam name="Y5">The return type of the fifth function</typeparam>
    /// <typeparam name="Y6">The return type of the sixth function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <param name="f3">The function applied to the third coordinate</param>
    /// <param name="f4">The function applied to the fourth coordinate</param>
    /// <param name="f5">The function applied to the fifth coordinate</param>
    /// <param name="f6">The function applied to the sixth coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2, Y3 y3, Y4 y4, Y5 y5, Y6 y6) tmap<X1, X2, X3, X4, X5, X6, Y1, Y2, Y3, Y4, Y5, Y6>((X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6) x,
        Func<X1, Y1> f1, Func<X2, Y2> f2, Func<X3, Y3> f3, Func<X4, Y4> f4, Func<X5, Y5> f5, Func<X6, Y6> f6)
            => (f1(x.x1), f2(x.x2), f3(x.x3), f4(x.x4), f5(x.x5), f6(x.x6));

    /// <summary>
    /// Maps seven functions over respective over respective 7-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <typeparam name="X6">The type of the sixth coordinate</typeparam>
    /// <typeparam name="X7">The type of the seventh coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <typeparam name="Y3">The return type of the third function</typeparam>
    /// <typeparam name="Y4">The return type of the fourth function</typeparam>
    /// <typeparam name="Y5">The return type of the fifth function</typeparam>
    /// <typeparam name="Y6">The return type of the sixth function</typeparam>
    /// <typeparam name="Y7">The return type of the seventh function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <param name="f3">The function applied to the third coordinate</param>
    /// <param name="f4">The function applied to the fourth coordinate</param>
    /// <param name="f5">The function applied to the fifth coordinate</param>
    /// <param name="f6">The function applied to the sixth coordinate</param>
    /// <param name="f7">The function applied to the seventh coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2, Y3 y3, Y4 y4, Y5 y5, Y6 y6, Y7 y7) tmap<X1, X2, X3, X4, X5, X6, X7, Y1, Y2, Y3, Y4, Y5, Y6, Y7>((X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6, X7 x7) x,
        Func<X1, Y1> f1, Func<X2, Y2> f2, Func<X3, Y3> f3, Func<X4, Y4> f4, Func<X5, Y5> f5, Func<X6, Y6> f6, Func<X7, Y7> f7)
            => (f1(x.x1), f2(x.x2), f3(x.x3), f4(x.x4), f5(x.x5), f6(x.x6), f7(x.x7));

    /// <summary>
    /// Maps seven functions over respective over respective 7-tuple coordinate values
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <typeparam name="X6">The type of the sixth coordinate</typeparam>
    /// <typeparam name="X7">The type of the seventh coordinate</typeparam>
    /// <typeparam name="X8">The type of the eighth coordinate</typeparam>
    /// <typeparam name="Y1">The return type of the first function</typeparam>
    /// <typeparam name="Y2">The return type of the second function</typeparam>
    /// <typeparam name="Y3">The return type of the third function</typeparam>
    /// <typeparam name="Y4">The return type of the fourth function</typeparam>
    /// <typeparam name="Y5">The return type of the fifth function</typeparam>
    /// <typeparam name="Y6">The return type of the sixth function</typeparam>
    /// <typeparam name="Y7">The return type of the seventh function</typeparam>
    /// <typeparam name="Y8">The return type of the eighth function</typeparam>
    /// <param name="x">The input tuple</param>
    /// <param name="f1">The function applied to the first coordinate</param>
    /// <param name="f2">The function applied to the second coordinate</param>
    /// <param name="f3">The function applied to the third coordinate</param>
    /// <param name="f4">The function applied to the fourth coordinate</param>
    /// <param name="f5">The function applied to the fifth coordinate</param>
    /// <param name="f6">The function applied to the sixth coordinate</param>
    /// <param name="f7">The function applied to the seventh coordinate</param>
    /// <param name="f8">The function applied to the eighth coordinate</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (Y1 y1, Y2 y2, Y3 y3, Y4 y4, Y5 y5, Y6 y6, Y7 y7, Y8 y8) tmap<X1, X2, X3, X4, X5, X6, X7, X8, Y1, Y2, Y3, Y4, Y5, Y6, Y7, Y8>((X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6, X7 x7, X8 x8) x,
        Func<X1, Y1> f1, Func<X2, Y2> f2, Func<X3, Y3> f3, Func<X4, Y4> f4, Func<X5, Y5> f5, Func<X6, Y6> f6, Func<X7, Y7> f7, Func<X8,Y8> f8)
            => (f1(x.x1), f2(x.x2), f3(x.x3), f4(x.x4), f5(x.x5), f6(x.x6), f7(x.x7), f8(x.x8));


    /// <summary>
    /// Casts a 3-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <param name="tuples">The tuples to cast</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2) cast<X1, X2>((object x1, object x2) x)
        => tmap(x, cast<X1>, cast<X2>);

    /// <summary>
    /// Casts a 3-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <param name="x">The source tuple</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2, X3 x3) cast<X1, X2, X3>((object x1, object x2, object x3) x)
        => tmap(x, cast<X1>, cast<X2>, cast<X3>);

    /// <summary>
    /// Casts a 4-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <typeparam name="X4">The target type of the fourth coordinate</typeparam>
    /// <param name="x">The source tuple</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2, X3 x3, X4 x4) cast<X1, X2, X3, X4>((object x1, object x2, object x3, object x4) x)
        => tmap(x, cast<X1>, cast<X2>, cast<X3>, cast<X4>);

    /// <summary>
    /// Casts a 5-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <typeparam name="X4">The target type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The target type of the fifth coordinate</typeparam>
    /// <param name="x">The source tuple</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2, X3 x3, X4 x4, X5 x5) cast<X1, X2, X3, X4, X5>((object x1, object x2, object x3, object x4, object x5) x)
        => tmap(x, cast<X1>, cast<X2>, cast<X3>, cast<X4>, cast<X5>);

    /// <summary>
    /// Casts a 6-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <typeparam name="X4">The target type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The target type of the fifth coordinate</typeparam>
    /// <typeparam name="X6">The target type of the sixth coordinate</typeparam>
    /// <param name="x">The source tuple</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6) cast<X1, X2, X3, X4, X5, X6>((object x1, object x2, object x3, object x4, object x5, object x6) x)
        => tmap(x, cast<X1>, cast<X2>, cast<X3>, cast<X4>, cast<X5>, cast<X6>);

    /// <summary>
    /// Casts a 7-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <typeparam name="X4">The target type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The target type of the fifth coordinate</typeparam>
    /// <typeparam name="X6">The target type of the sixth coordinate</typeparam>
    /// <typeparam name="X7">The target type of the seventh coordinate</typeparam>
    /// <param name="x">The source tuple</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6, X7 x7) cast<X1, X2, X3, X4, X5, X6, X7>((object x1, object x2, object x3, object x4, object x5, object x6, object x7) x)
        => tmap(x, cast<X1>, cast<X2>, cast<X3>, cast<X4>, cast<X5>, cast<X6>, cast<X7>);

    /// <summary>
    /// Casts an 8-tuple
    /// </summary>
    /// <typeparam name="X1">The target type of the first coordinate</typeparam>
    /// <typeparam name="X2">The target type of the second coordinate</typeparam>
    /// <typeparam name="X3">The target type of the third coordinate</typeparam>
    /// <typeparam name="X4">The target type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The target type of the fifth coordinate</typeparam>
    /// <typeparam name="X6">The target type of the sixth coordinate</typeparam>
    /// <typeparam name="X7">The target type of the seventh coordinate</typeparam>
    /// <param name="x">The source tuple</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static (X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6, X7 x7, X8 x8) cast<X1, X2, X3, X4, X5, X6, X7, X8>((object x1, object x2, object x3, object x4, object x5, object x6, object x7, object x8) x)
        => tmap(x, cast<X1>, cast<X2>, cast<X3>, cast<X4>, cast<X5>, cast<X6>, cast<X7>, cast<X8>);

    /// <summary>
    /// Determines the tuple's style, if possible; otherwise, returns None
    /// </summary>
    /// <param name="text">The putative tuple representation</param>
    /// <returns></returns>
    static Option<TupleFormat> style(string text)
        => text.EnclosedBy(lparen(), rparen()) ? some(TupleFormat.Coordinate)
        : text.EnclosedBy(lbracket(), rbracket()) ? some(TupleFormat.List)
        : text.EnclosedBy(lbrace(), rbrace()) ? some(TupleFormat.Record)
        : none<TupleFormat>();

    static char leftBound(TupleFormat style)
        => (style == TupleFormat.Coordinate ? lparen()
        : style == TupleFormat.List ? lbracket()
        : style == TupleFormat.Record ? lbrace()
        : lparen())[0];

    static char rightBound(TupleFormat style)
        => (style == TupleFormat.Coordinate ? rparen()
        : style == TupleFormat.List ? rbracket()
        : style == TupleFormat.Record ? rbrace()
        : rparen())[0];

    static char[] bounds(TupleFormat style)
        => array(leftBound(style), rightBound(style));

    /// <summary>
    /// Gets the boundary production function as determined by a style
    /// </summary>
    /// <param name="style">The tuple representation style</param>
    /// <returns></returns>
    internal static Func<string, string> boundaryFn(TupleFormat style)
        => style == TupleFormat.List ? new Func<string, string>(bracket)
        : style == TupleFormat.Record ? new Func<string, string>(embrace)
        : new Func<string, string>(x => paren(x));


    /// <summary>
    /// Parses a tuple of the form (x1,x2)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    /// <returns></returns>
    public static Option<(X1 x1, X2 x2)> parse<X1, X2>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 3
           from x1 in try_parse<X1>(components[0])
           from x2 in try_parse<X2>(components[1])
           select (x1, x2);

    /// <summary>
    /// Parses a tuple in when represented in canonical form (x1,x2,x3)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    /// <returns></returns>
    public static Option<(X1 x1, X2 x2, X3 x3)> parse<X1, X2, X3>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 3
           from x1 in try_parse<X1>(components[0])
           from x2 in try_parse<X2>(components[1])
           from x3 in try_parse<X3>(components[2])
           select (x1, x2, x3);

    /// <summary>
    /// Parses a tuple of the form (x1,x2,x3,x4)
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    /// <returns></returns>
    public static Option<(X1 x1, X2 x2, X3 x3, X4 x4)> parse<X1, X2, X3, X4>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 4
           from x1 in try_parse<X1>(components[0])
           from x2 in try_parse<X2>(components[1])
           from x3 in try_parse<X3>(components[2])
           from x4 in try_parse<X4>(components[3])
           select (x1, x2, x3, x4);

    /// <summary>
    /// Parses a tuple in when represented in canonical form
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    /// <returns></returns>
    public static Option<(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5)> parse<X1, X2, X3, X4, X5>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 5           
           from x1 in try_parse<X1>(components[0])
           from x2 in try_parse<X2>(components[1])
           from x3 in try_parse<X3>(components[2])
           from x4 in try_parse<X4>(components[3])
           from x5 in try_parse<X5>(components[4])
           select (x1, x2, x3, x4, x5);

    /// <summary>
    /// Parses a tuple in when represented in canonical form
    /// </summary>
    /// <typeparam name="X1">The type of the first coordinate</typeparam>
    /// <typeparam name="X2">The type of the second coordinate</typeparam>
    /// <typeparam name="X3">The type of the third coordinate</typeparam>
    /// <typeparam name="X4">The type of the fourth coordinate</typeparam>
    /// <typeparam name="X5">The type of the fifth coordinate</typeparam>
    /// <param name="text">The text to parse</param>
    /// <returns></returns>
    public static Option<(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6)> parse<X1, X2, X3, X4, X5, X6>(string text)
        => from style in style(text)
           let components = text.Trim(bounds(style)).Split(',')
           where components.Length == 5
           from x1 in try_parse<X1>(components[0])
           from x2 in try_parse<X2>(components[1])
           from x3 in try_parse<X3>(components[2])
           from x4 in try_parse<X4>(components[3])
           from x5 in try_parse<X5>(components[4])
           from x6 in try_parse<X6>(components[5])
           select (x1, x2, x3, x4, x5, x6);

        /// <summary>
        /// Converts a 3-vector to a 3-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x4">The fourth coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2, T x3, T x4) tuple<T>(Vector<N4,T> v)
            where T : Equality<T>, new()
                => (v[0], v[1], v[2], v[3]);

        /// <summary>
        /// Converts an homogenous 4-tuple to a 4-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <param name="x4">The fourth coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N4,T> vector<T>((T x1, T x2, T x3, T x4) x)
            where T : Equality<T>, new()
                => vector<N4,T>(x.x1, x.x2,x.x3,x.x4);

    /// <summary>
    /// Transforms a sequence of key-value pairs into a sequence of tuples
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<(K key, V value)> tuples<K,V>(IEnumerable<KeyValuePair<K,V>> pairs)
        => pairs.Select(p => (p.Key,p.Value));

    /// <summary>
    /// Converts an homogenous 2-tuple to a 2-vector
    /// </summary>
    /// <param name="x1">The first coorinate</param>
    /// <param name="x2">The second coordinate</param>
    /// <typeparam name="T">The coordinate type</typeparam>
    [MethodImpl(Inline)]
    public static Vector<N2,T> vector<T>((T x1, T x2) x)
        where T : Equality<T>, new()
            => vector<N2,T>(x.x1, x.x2);

}