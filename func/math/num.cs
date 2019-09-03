//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

partial class zfunc
{
    
    /// <summary>
    /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
    /// </summary>
    /// <param name="x0">The lower bound</param>
    /// <param name="x1">The upper bound</param>
    /// <param name="step">The step size</param>
    /// <typeparam name="T">The primal type</typeparam>
    public static IEnumerable<T> range<T>(T x0, T x1, T? step = null)
        where T : struct
    {
        if(typeof(T) == typeof(sbyte))
        {
            var min = int8(x0);
            var max = int8(x1);
            var _step = int8(step) ??(sbyte)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(byte))
        {
            var min = uint8(x0);
            var max = uint8(x1);
            var _step = uint8(step) ??(byte)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(short))
        {
            var min = int16(x0);
            var max = int16(x1);
            var _step = int16(step) ?? (short)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(ushort))
        {
            var min = uint16(x0);
            var max = uint16(x1);
            var _step = uint16(step) ?? (ushort)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(int))
        {
            var min = int32(x0);
            var max = int32(x1);
            var _step = int32(step) ?? 1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(uint))
        {
            var min = uint32(x0);
            var max = uint32(x1);
            var _step = uint32(step) ?? 1u;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(long))
        {
            var min = int64(x0);
            var max = int64(x1);
            var _step = int64(step) ?? 1L;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(ulong))
        {
            var min = uint64(x0);
            var max = uint64(x1);
            var _step = uint64(step) ?? 1ul;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(float))
        {
            var min = float32(x0);
            var max = float32(x1);
            var _step = float32(step) ?? 1f;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(double))
        {
            var min = float64(x0);
            var max = float64(x1);
            var _step = float64(step) ?? 1d;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else
            throw unsupported<T>();
    }

    /// <summary>
    /// Defines a generic complex number
    /// </summary>
    /// <param name="re">The real part</param>
    /// <param name="im">The imaginary part</param>
    /// <typeparam name="T">The underlying primal type</typeparam>
    [MethodImpl(Inline)]
    public static Complex<T> complex<T>(T re, T im = default)
        where T : struct, IEquatable<T>
            => ComplexNumber.Define(re,im);

    /// <summary>
    /// Defines a scalar sequence {0,1,...,count-1}
    /// </summary>
    /// <param name="count">The number of elements in the sequence</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> range<T>(T count)
        where T : struct
            => range(default(T), count);
}