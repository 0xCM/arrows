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
using static Z0.Bibliography;
using static Z0.Traits;


public static partial class zcore
{
    /// <summary>
    /// Reduces a sequence to a single value via a supplied operator
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="f">The reduction operator</param>
    /// <param name="a0">The seed value</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T fold<T>(IEnumerable<T> src, Func<T,T,T> f, T a0 = default(T))
    {
        var cumulant = a0;
        foreach(var item in src)
            cumulant = f(cumulant,item);            
        return cumulant;
    }

    /// <summary>
    /// Raises a baise to a power
    /// </summary>
    /// <param name="@base">The base value</param>
    /// <param name="exp">The exponent value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static uint pow(uint @base, uint exp)
        => fold(repeat(@base, exp), (x,y) => x*y);


    /// <summary>
    /// Constructs a pair enumerator from two distict enumerables
    /// </summary>
    /// <param name="left">The left sequence</param>
    /// <param name="right">The right sequence</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static (IEnumerator<T> left, IEnumerator<T> right) enumerator<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
        => (lhs.GetEnumerator(),rhs.GetEnumerator());

    /// <summary>
    /// Advances paired enumerators
    /// </summary>
    /// <param name="left">The left enumerator</param>
    /// <param name="right">The right enumerator</param>
    /// <typeparam name="T"></typeparam>
    /// <returns>Returns false if either enumerator as advanced past the end of its respective sequence</returns>
    [MethodImpl(Inline)]   
    public static bool next<T>((IEnumerator<T> left, IEnumerator<T> right) enumerator)
        => enumerator.left.MoveNext() && enumerator.right.MoveNext();

    /// <summary>
    /// Obtains the current pair from a paired enumerator
    /// </summary>
    /// <param name="left">The left enumerator</param>
    /// <param name="right">The right enumerator</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static (T left, T right) current<T>((IEnumerator<T> left, IEnumerator<T> right) enumerator)
        => (enumerator.left.Current, enumerator.right.Current);

    public static IEnumerable<(T left, T right)> zip<T>(IEnumerable<T> lhs, IEnumerable<T> rhs)
    {
        var e = enumerator<T>(lhs,rhs);
        while(next(e))
            yield return current(e);                
    }

    /// <summary>
    /// Zips the source sequences and fuses elements componentwise via a binary operator
    /// to determine the result sequence
    /// </summary>
    /// <param name="lhs">The first sequence</param>
    /// <param name="rhs">The second sequence</param>
    /// <param name="f">The binary operator that fuses positional pairs</param>
    /// <typeparam name="T">The squence type</typeparam>
    /// <returns></returns>
    public static IEnumerable<T> zip<T>(IEnumerable<T> lhs, IEnumerable<T> rhs, Func<T,T,T> f)
        => from pair in zip(lhs,rhs) select f(pair.left, pair.right);

    
    /// <summary>
    /// Evaluates a binary predicate over a sequence of pairs and returns true if any
    /// elements of the sequence satisfy the predicate
    /// </summary>
    /// <param name="left">The left pair component</param>
    /// <param name="right">The right pair component</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static bool any<T>(IEnumerable<(T left, T right)> src, Func<T,T,bool> predicate)
        => src.Any(pair => predicate(pair.left, pair.right));

    [MethodImpl(Inline)]   
    public static bool any<T>(IEnumerable<T> src, Func<T,bool> predicate)
        => src.Any(predicate);

    /// <summary>
    /// If possible, returns the first value in the sequence that matches a predicate;
    /// otherwise returns none
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="predicate">The predicate to evaluate over sequence elements</param>
    /// <typeparam name="T">The element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)] 
    public static Option<T> first<T>(IEnumerable<T> src, Func<T,bool> predicate)
        => src.FirstOrDefault(predicate);

    /// <summary>
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The input element type</typeparam>
    /// <typeparam name="B">The output element type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static IEnumerable<B> map<A,B>(IEnumerable<A> src, Func<A,B> f)
        => src.Select(x => f(x));


    /// <summary>
    /// Applies a function to a value
    /// </summary>
    /// <param name="x">The source value</param>
    /// <param name="f">The function to apply</param>
    /// <typeparam name="X">The source value type</typeparam>
    /// <typeparam name="Y">The output value type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Y apply<X,Y>(X x,Func<X,Y> f)
        => f(x);

    /// <summary>
    /// Applies a function to elements of an input sequence to produce 
    /// a transformed output sequence
    /// </summary>
    /// <param name="f">The function to be applied</param>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="A">The source value type</typeparam>
    /// <typeparam name="B">The target value type</typeparam>
    /// <returns>The transformed sequence</returns>
    public static IEnumerable<B> mapi<A,B>(Func<int,A,B> f, IEnumerable<A> src)
    {
        var i = 0;
        foreach(var item in src)
            yield return f(i++,item);
    }


    /// <summary>
    /// Transforms a function (S,T) -> U to a function S -> (T -> U)
    /// </summary>
    /// <typeparam name="S">The first argument type</typeparam>
    /// <typeparam name="T">The second argument type</typeparam>
    /// <typeparam name="U">The codomain</typeparam>
    [MethodImpl(Inline)]
    public static Func<S,T,U> curry<S,T,U>(Func<(S,T), U> f)
    {        
        U g(S a, T b) => f((a,b));        
        return g;
    }

    /// <summary>
    /// Transforms a function S -> (T -> U) to a function (S,T) -> U
    /// </summary>
    /// <typeparam name="S">The first argument type</typeparam>
    /// <typeparam name="T">The second argument type</typeparam>
    /// <typeparam name="U">The codomain</typeparam>
    [MethodImpl(Inline)]
    public static Func<(S,T),U> uncurry<S,T,U>(Func<S,T,U> f)
    {        
        U g((S a, T b) x) => f(x.a,x.b);
        return g;
    }


    /// <summary>
    /// Creates a <see cref="lazy{T}(Func{T})"/>.
    /// </summary>
    /// <param name="factory">A function that creates an instance of the lazy object</param>
    [MethodImpl(Inline)]
    public static Lazy<T> lazy<T>(Func<T> factory)
        => new Lazy<T>(factory);

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
    /// Returns the supplied value if not null, otherwise invokes a function to provide
    /// a non-null value as a replacement
    /// </summary>
    /// <typeparam name="T">The object type</typeparam>
    /// <param name="x">The object to test</param>
    /// <param name="replace">The function that yields a replacement value in the event that the supplied value is null</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T ifNull<T>(T x, Func<T> replace)
        where T : class => x ?? replace();

    /// <summary>
    /// Maps the source <paramref name="x"/> to a value in the target space <typeparamref name="Y"/>
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <param name="x"></param>
    /// <param name="null"></param>
    /// <param name="else"></param>
    [MethodImpl(Inline)]
    public static Y ifNull<X, Y>(X x, Func<Y> @null, Func<X, Y> @else)
        => x == null ? @null() : @else(x);

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
    /// Evaluates a function over a value if the value is not null; otherwise,
    /// returns the default result value
    /// </summary>
    /// <typeparam name="S"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <param name="x"></param>
    /// <param name="f1"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static T ifNotNull<S, T>(S x, Func<S, T> f1, T @default = default)
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
    public static T ifNotNull<S, T>(S x, Func<S, T> f1, Func<T> f2)
        where S : class => (x != null) ? f1(x) : f2();


    /// <summary>
    /// Executes one of two functions depending on the evaulation criterion
    /// </summary>
    /// <typeparam name="X">The function input type</typeparam>
    /// <typeparam name="Y">The function output type</typeparam>
    /// <param name="criterion">The criterion on which to branch</param>
    /// <param name="value">The value to supply to the chosen function</param>
    /// <param name="onTrue">The function to evaulate when the criterion is true</param>
    /// <param name="onFalse">The function to evaulate when the criterion is false</param>
    /// <returns></returns>
    [DebuggerStepperBoundary, MethodImpl(Inline)]
    public static Y ifElse<X, Y>(bool criterion, X value, Func<X, Y> onTrue, Func<X, Y> onFalse)
        => criterion ? onTrue(value) : onFalse(value);

    /// <summary>
    /// Executes one of two functions depending on the evaulation criterion
    /// </summary>
    /// <typeparam name="X">The function input type</typeparam>
    /// <param name="criterion">The criterion on which to branch</param>
    /// <param name="onTrue">The function to evaulate when the criterion is true</param>
    /// <param name="onFalse">The function to evaulate when the criterion is false</param>
    /// <returns></returns>
    [DebuggerStepperBoundary, MethodImpl(Inline)]
    public static X ifElse<X>(bool criterion, Func<X> onTrue, Func<X> onFalse)
        => criterion ? onTrue() : onFalse();

    /// <summary>
    /// Executes a function if the criterion is true, otherwise returns the supplied value
    /// </summary>
    /// <typeparam name="T">The function input/output type</typeparam>
    /// <param name="criterion">The criterion on which to branch</param>
    /// <param name="value">The value to supply to the chosen function</param>
    /// <param name="onTrue">The function to evaulate when the criterion is true</param>
    /// <returns></returns>
    [DebuggerStepperBoundary, MethodImpl(Inline)]
    public static T ifTrue<T>(bool criterion, T value, Func<T, T> onTrue)
        => criterion ? onTrue(value) : value;


    /// <summary>
    /// Returns the source <paramref name="x"/> if not null; otherwise returns <paramref name="replacement"/>
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <param name="x"></param>
    /// <param name="replacement"></param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static X ifNullValue<X>(X? x, X replacement)
        where X : struct
            => x == null ? replacement : (X)x;

}