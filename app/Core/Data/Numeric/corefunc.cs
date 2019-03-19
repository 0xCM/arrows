//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using Core;

using C = Core.Contracts;

using static corefunc;
using static Core.MathOps;

partial class corefunc
{
    /// <summary>
    /// Constructs a rational number
    /// </summary>
    /// <param name="over">The numerator</param>
    /// <param name="under">The denominator</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static fraction<T> frac<T>(T over, T under)
        where T : new()
            => new fraction<T>(over,under);

    /// <summary>
    /// Constructs a generic integer
    /// </summary>
    /// <param name="value">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T value)
        where T : new()
            => new intg<T>(value);

    /// <summary>
    /// Constructs a generic number
    /// </summary>
    /// <param name="value">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]   
    public static num<T> numg<T>(T x)
        where T : new()
        => num.define(x);



    public static string bitstring<T>(num<T> src)
        where T : new()
            => src.bitstring();

    /// <summary>
    /// Enumerates the integers inclusively between specified min and max values 
    /// </summary>
    /// <param name="min">The first integer to yeild</param>
    /// <param name="max">The last integer to yield</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    /// <returns></returns>
    public static IEnumerable<intg<T>> range<T>(intg<T> min, intg<T> max)
        where T : new()
    {
        var current = min;
        while(current <= max)
            yield return current++;
    }

}

