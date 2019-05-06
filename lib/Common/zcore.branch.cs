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
using static Z0.Traits;

partial class zcore
{
    /// <summary>
    /// Evaluates a predicate and then brances based on the outcome of the evaluation
    /// </summary>
    /// <typeparam name="X">The type of value to evaluate and subsequently process</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    /// <param name="test">The input value</param>
    /// <param name="predicate">The predicate that will determine the branch to invoke</param>
    /// <param name="true">The function to execute when the predicate evaulates to true</param>
    /// <param name="false">The function to evaluate when the predicate evaluates to false</param>
    [MethodImpl(Inline)]
    public static Y when<X, Y>(X test, Predicate<X> predicate, Func<X, Y> @true, Func<X, Y> @false)
        => predicate(test) ? @true(test) : @false(test);


    /// <summary>
    /// Maps the source <paramref name="x"/> to a value in the target space <typeparamref name="Y"/>
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <param name="x"></param>
    /// <param name="null"></param>
    /// <param name="else"></param>
    [MethodImpl(Inline)]
    public static Y ifnull<X, Y>(X x, Func<Y> @null, Func<X, Y> @else)
        => x == null ? @null() : @else(x);

    /// <summary>
    /// Evaluates a function over a value if the value is not null; otherwise,
    /// returns the default result value
    /// </summary>
    /// <typeparam name="S"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <param name="x"></param>
    /// <param name="f1"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T ifvalue<S, T>(S x, Func<S, T> f1, T @default = default)
        => x != null ? f1(x) : @default;

    /// <summary>
    /// Evaluates a function over a value if the value is not null; otherwise invokes
    /// a function that will produce a value that is within the expected range
    /// </summary>
    /// <typeparam name="S">The object type</typeparam>
    /// <typeparam name="T">The function result type</typeparam>
    /// <param name="x">The object to test</param>
    /// <param name="f1">The non-null evaluator</param>
    /// <param name="f2">The null evaluator</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T ifvalue<S, T>(S x, Func<S, T> f1, Func<T> f2)
        where S : class => (x != null) ? f1(x) : f2();

    /// <summary>
    /// Executes one action if a condition is true and another should it be false
    /// </summary>
    /// <param name="condition">Specifies whether some condition is true</param>
    /// <param name="true">The action to invoke when condition is true</param>
    /// <param name="false">The action to invoke when condition is false</param>
    [MethodImpl(Inline)]
    public static Unit on(bool condition, Action @true, Action @false = null)
    {
        if (condition)
            @true();
        else
            @false?.Invoke();

        return Unit.Value;
    }


}