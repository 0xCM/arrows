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

using static Core.Credit;
using static corefunc;


public static partial class corext
{
    /// <summary>
    /// Lifts a function to a unary operator
    /// </summary>
    /// <param name="f">The function to lift</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Core.UnaryOp<T> ToUnaryOp<T>(this Func<T,T> f)
        => new UnaryOp<T>(f);

    /// <summary>
    /// Lifts a function to a binary opeator operator
    /// </summary>
    /// <param name="f">The function to lift</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static BinaryOp<T> ToBinaryOp<T>(this Func<T,T,T> f, bool commutative = false)
            => commutative 
            ?  cast<BinaryOp<T>>(new CommutativeOp<T>(f)) 
            : new BinaryOp<T>(f);


}