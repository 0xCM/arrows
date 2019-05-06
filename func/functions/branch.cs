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


}