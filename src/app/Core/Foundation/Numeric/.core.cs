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


using static corefunc;
using static Core.Operations;

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
        where T : Traits.Integer<T>, new()
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
            => new num<T>(x);

    /// <summary>
    /// Renders a generic number as a bitstring
    /// </summary>
    /// <param name="src">The source number</param>
    /// <typeparam name="T">The unerlying numeric type</typeparam>
    public static string bitstring<T>(num<T> src)
            => src.bitstring();

    /// <summary>
    /// Enumerates generic integers inclusively between specified first and last values.
    /// If the first value is greater than the last, the range will be constructed
    /// in descending order.
    /// </summary>
    /// <param name="first">The first integer to yeild</param>
    /// <param name="last">The last integer to yield</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    /// <returns></returns>
    public static IEnumerable<intg<T>> rangeG<T>(intg<T> first, intg<T> last)
    {
        var current = first;
        if(first < last)
        {
            while(current <= last)
                yield return current++;
        }
        else
        {
            while(current >= last)
                yield return current--;
        }
    }

    /// <summary>
    /// Enumerates integers inclusively between specified first and last values.
    /// If the first value is greater than the last, the range will be constructed
    /// in descending order.
    /// </summary>
    /// <param name="first">The first integer to yeild</param>
    /// <param name="last">The last integer to yield</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    public static IEnumerable<T> range<T>(intg<T> first, intg<T> last)
            => rangeG(first,last).Unwrap();

    /// <summary>
    /// Defines an integeral value of natural modulus
    /// </summary>
    /// <typeparam name="N">The modulus type</typeparam>
    /// <typeparam name="T">The integral type</typeparam>
    /// <returns></returns>
    public static mod<N,T> mod<N,T>(T lhs)
        where N : TypeNat, new()
            => new mod<N,T>(lhs);
}

