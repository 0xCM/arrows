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


partial class zfunc
{

   /// <summary>
    /// Constructs a non-valued option
    /// </summary>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<A> none<A>() 
        => Option.none<A>();
    
    /// <summary>
    /// Constructs a valued option
    /// </summary>
    /// <param name="value">The option value</param>
    /// <typeparam name="A">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<A> some<A>(A value) 
        => new Option<A>(value);


    /// <summary>
    /// Evaluates a function if a predicate is satisfied; otherwise, returns None
    /// </summary>
    /// <typeparam name="X">The type of value to evaluate</typeparam>
    /// <typeparam name="Y">The evaluation type</typeparam>
    /// <param name="x">The point of evaluation</param>
    /// <param name="predicate">A precondition for evaulation to proceed</param>
    /// <param name="f">The evaluation function</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<Y> guard<X, Y>(X x, Func<X, bool> predicate, Func<X, Option<Y>> f)
        => predicate(x) ? f(x) : none<Y>();

    /// <summary>
    /// Casts a value if possible, otherwise returns failure
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="item">The object to cast</param>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static Option<T> tryCast<T>(object item)
        => item is T ? some((T)item) : none<T>();

    /// <summary>
    /// Evaluates a function within a try block and returns the value of the computation if 
    /// successful; otherwise, returns None together with the reported exceptions
    /// </summary>
    /// <typeparam name="T">The result type</typeparam>
    /// <param name="f">The function to evaluate</param>
    /// <returns></returns>
    public static Option<T> Try<T>(Func<T> f, Action<Exception> error = null)
    {
        try
        {
            return f();
        }
        catch (Exception e)
        {
            error?.Invoke(e);
            return none<T>();
        }
    }

    /// <summary>
    /// Evaluates a function within a try block and returns the value of the computation if 
    /// successful; otherwise, returns None together with the reported exception
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="F"></param>
    [MethodImpl(Inline)]   
    public static Option<T> Try<T>(Func<Option<T>> F, Action<Exception> error = null)
    {
        try
        {
            return F();
        }
        catch (Exception e)
        {
            error?.Invoke(e);
            return none<T>();
        }
    }

    /// <summary>
    /// Evaluates a function within a try block and returns the value of the computation if 
    /// successful; otherwise, returns None together with the reported exception
    /// </summary>
    /// <typeparam name="X">The input type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    /// <param name="x">The input value</param>
    /// <param name="f">The function to evaluate</param>
    [MethodImpl(Inline)]   
    public static Option<Y> Try<X, Y>(X x, Func<X, Y> f, Action<Exception> onerror = null)
    {
        try
        {
            return f(x);
        }
        catch (Exception e)
        {
            onerror?.Invoke(e);
            return none<Y>();
        }
    }

    /// <summary>
    /// Evaulates a function within a try + using block
    /// </summary>
    /// <typeparam name="X">The input value type</typeparam>
    /// <typeparam name="Y">The function output type</typeparam>
    /// <param name="resource"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public static Option<Y> Use<X, Y>(X resource, Func<X, Y> f,Action<Exception> error = null)
        where X : IDisposable
    {
        try
        {
            using (resource)
            {
                return f(resource);
            }
        }
        catch (Exception e)
        {
            error?.Invoke(e);
            return none<Y>();
        }
    }




}