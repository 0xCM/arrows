//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Executes an action if condition is false
    /// </summary>
    /// <param name="condition">Specifies whether some condition is true</param>
    /// <param name="@false">The action to invoke when condition is false</param>
    [MethodImpl(Inline)]
    public static Unit onFalse(bool condition, Action @false)
    {
        if(!condition)
            @false();
        return Unit.Value;
    }

    /// <summary>
    /// Executes an action if condition is true
    /// </summary>
    /// <param name="condition">Specifies whether some condition is true</param>
    /// <param name="@false">The action to invoke when condition is false</param>
    [MethodImpl(Inline)]
    public static Unit onTrue(bool condition, Action @true)
    {
        if(condition)
            @true();
        return Unit.Value;
    }

    /// <summary>
    /// Invokes an action if the supplied value is not null
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    /// <param name="value">The potentially null value</param>
    /// <param name="a">The action to invoke if possible</param>
    [MethodImpl(Inline)]
    public static Unit onValue<V>(V value, Action<V> a)
    {
        if (value != null)
            a(value);

        return Unit.Value;
    }

    /// <summary>
    /// Returns true if the input is false, false otherwise
    /// </summary>
    /// <param name="a">The value to test</param>
    [MethodImpl(Inline)]   
    public static bool not(bool a) 
        => !a;

    /// <summary>
    /// Executes one of two functions depending on the evaulation criterion
    /// </summary>
    /// <typeparam name="X">The function input type</typeparam>
    /// <typeparam name="Y">The function output type</typeparam>
    /// <param name="criterion">The criterion on which to branch</param>
    /// <param name="value">The value to supply to the chosen function</param>
    /// <param name="onTrue">The function to evaulate when the criterion is true</param>
    /// <param name="onFalse">The function to evaulate when the criterion is false</param>
    [MethodImpl(Inline)]
    public static Y ifelse<X, Y>(bool criterion, X value, Func<X, Y> onTrue, Func<X, Y> onFalse)
        => criterion ? onTrue(value) : onFalse(value);

    /// <summary>
    /// Executes one of two functions depending on the evaulation criterion
    /// </summary>
    /// <typeparam name="X">The function input type</typeparam>
    /// <param name="criterion">The criterion on which to branch</param>
    /// <param name="true">The function to evaulate when the criterion is true</param>
    /// <param name="false">The function to evaulate when the criterion is false</param>
    [MethodImpl(Inline)]
    public static X ifelse<X>(bool criterion, Func<X> @true, Func<X> @false)
        => criterion ? @true() : @false();

    /// <summary>
    /// Executes a function if the criterion is true, otherwise returns the supplied value
    /// </summary>
    /// <typeparam name="T">The function input/output type</typeparam>
    /// <param name="criterion">The criterion on which to branch</param>
    /// <param name="value">The value to supply to the chosen function</param>
    /// <param name="onTrue">The function to evaulate when the criterion is true</param>
    [MethodImpl(Inline)]
    public static T ifTrue<T>(bool criterion, T value, Func<T, T> onTrue)
        => criterion ? onTrue(value) : value;

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

    /// <summary>
    /// Applies f(v) if v is of type X otherwise applies unmatched(v)
    /// </summary>
    /// <typeparam name="X">The match type</typeparam>
    /// <typeparam name="Y">The evaluation type</typeparam>
    /// <param name="v">The candidate value</param>
    /// <param name="f">The function to apply if matched</param>
    /// <param name="u">The function to apply if unmatched</param>
    /// <returns></returns>
    public static Y ifType<X, Y>(object v, Func<X, Y> f, Func<object, Y> u)
    {
        switch (v)
        {
            case X x:
                return f(x);
            default:
                return u(v);
        }
    }

    /// <summary>
    /// Applies f(v) if v is of type X otherwise returns None
    /// </summary>
    /// <typeparam name="X">The match type</typeparam>
    /// <typeparam name="Y">The evaluation type</typeparam>
    /// <param name="v">The candidate value</param>
    /// <param name="f">The function to apply if matched</param>
    public static Option<Y> ifType<X, Y>(object v, Func<X, Y> f)
    {
        switch (v)
        {
            case X x:
                return f(x);
            default:
                return none<Y>();
        }
    }

    /// <summary>
    /// Applies f(X left, X right) if possible, otherwise returns None
    /// </summary>
    /// <typeparam name="X">The right input type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    /// <param name="v">The value to be evaluated </param>
    /// <param name="f">The function to apply</param>
    /// <returns></returns>
    public static Option<Y> ifType<X, Y>((object candididate, X right) v, Func<(X left, X right), Y> f)
    {
        switch (v.candididate)
        {
            case X x:
                return f((x, v.right));
            default:
                return none<Y>();
        }
    }

    /// <summary>
    /// Applies f(X left, X right) if possible, otherwise applies f(candidate)
    /// </summary>
    /// <typeparam name="X">The right input type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    /// <param name="v">The value to be evaluated </param>
    /// <param name="f">The function to apply</param>
    /// <param name="else">The alternate</param>
    public static Y ifType<X, Y>((object candididate, X right) v, Func<(X left, X right), Y> f, Func<object, Y> @else)
    {
        switch (v.candididate)
        {
            case X x:
                return f((x, v.right));
            default:
                return @else(v.candididate);
        }
    }
}