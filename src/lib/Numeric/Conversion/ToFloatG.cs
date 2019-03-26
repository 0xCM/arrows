//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using System.Text;
using Z0;


using static zcore;

/// <summary>
/// Defines extensions to convert various types of values to floatg values
/// </summary>
public static class ToFloatGX
{
    /// <summary>
    /// x:byte => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this byte src)
        => src;

    /// <summary>
    /// x:byte => x:floatg[float]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<float> ToFloatG32(this byte src)
        => src;

    /// <summary>
    /// x:sbyte => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this sbyte src)
        => src;

    /// <summary>
    /// x:short => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this short src)
        => src;

    /// <summary>
    /// x:short => x:floatg[float]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<float> ToFloatG32(this short src)
        => src;

    /// <summary>
    /// x:ushort => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this ushort src)
        => src;

    /// <summary>
    /// x:ushort => x:floatg[float]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<float> ToFloatG32(this ushort src)
        => src;

    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this int src)
        => src;

    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this uint src)
        => src;

    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this long src)
        => src;

    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this ulong src)
        => src;

    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this BigInteger src)
        => (double)src;

    /// <summary>
    /// x:float => x:floatg[float]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<float> ToFloatG(this float src)
        => src;

    /// <summary>
    /// x:double => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this double src)
        => src;


    /// <summary>
    /// x:double => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG(this decimal src)
        => convert<double>(src);

    /// <summary>
    /// x:double => x:floatg[double]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<float> ToFloatG32(this decimal src)
        => convert<float>(src);

    /// <summary>
    /// x:sbyte => x:floatg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this sbyte src)
        => convert<T>(src);

    /// <summary>
    /// x:byte => x:floatg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this byte src)
        => convert<T>(src);

    /// <summary>
    /// x:short => x:floatg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this short src)
        => convert<T>(src);

    /// <summary>
    /// x:ushort => x:floatg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this ushort src)
        => convert<T>(src);

    /// <summary>
    /// x:int => x:floatg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this int src)
        => convert<T>(src);

    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this uint src)
        => convert<T>(src);


    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this long src)    
        => convert<T>(src);

    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this ulong src)
        => convert<T>(src);

    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this BigInteger src)
        => convert<T>(src);

    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this float src)
        => convert<T>(src);

    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this double src)
        => convert<T>(src);

    [MethodImpl(Inline)]   
    public static floatg<T> ToFloatG<T>(this decimal src)
        => convert<T>(src);


    [MethodImpl(Inline)]   
    public static floatg<double> ToFloatG<T>(this intg<T> src)
        => convert<double>(src.data);

    [MethodImpl(Inline)]   
    public static floatg<float> ToFloatG32<T>(this intg<T> src)
        => convert<float>(src.data);
}
