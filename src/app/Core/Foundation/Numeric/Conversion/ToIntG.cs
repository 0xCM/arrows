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
using Core;

using C = Core.Contracts;

using static corefunc;
using static Core.Operations;



/// <summary>
/// Defines extensions to convert various types of values to floatg values
/// </summary>
public static class ToIntGX
{
    /// <summary>
    /// x:byte => x:intg[byte]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<byte> ToIntG(this byte src)
        => src;


    [MethodImpl(Inline)]   
    public static intg<sbyte> ToIntG(this sbyte src)
        => src;


    [MethodImpl(Inline)]   
    public static intg<short> ToIntG(this short src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<ushort> ToIntG(this ushort src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<int> ToIntG(this int src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<uint> ToIntG(this uint src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<long> ToIntG(this long src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<ulong> ToIntG(this ulong src)
        => src;

    [MethodImpl(Inline)]   
    public static intg<BigInteger> ToIntG(this BigInteger src)
        => src;

    /// <summary>
    /// x:byte => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>

    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this byte src)
        => convert<T>(src);

    /// <summary>
    /// x:sbyte => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this sbyte src)
        => convert<T>(src);


    /// <summary>
    /// x:short => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this short src)
        => convert<T>(src);
    
    /// <summary>
    /// x:ushort => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]       
    public static intg<T> ToIntG<T>(this ushort src)
        => convert<T>(src);

    /// <summary>
    /// x:int => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this int src)
        => convert<T>(src);

    /// <summary>
    /// x:uint => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this uint src)
        => convert<T>(src);

    /// <summary>
    /// x:long=> x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this long src)    
        => convert<T>(src);

    /// <summary>
    /// x:ulong => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this ulong src)
        => convert<T>(src);

    /// <summary>
    /// x:float => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this float src)
        => convert<T>(src);

    /// <summary>
    /// x:double => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this double src)
        => convert<T>(src);

    /// <summary>
    /// x:decimal => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    public static intg<T> ToIntG<T>(this decimal src)
        => convert<T>(src);


    /// <summary>
    /// x:intg[byte] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<byte> src)
        => convert<T>(src.data);

    /// <summary>
    /// x:intg[sbyte] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<sbyte> src)
        => convert<T>(src.data);


    /// <summary>
    /// x:intg[short] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<short> src)
        => convert<T>(src.data);
    
    /// <summary>
    /// x:intg[ushort] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]       
    public static intg<T> ToIntG<T>(this intg<ushort> src)
        => convert<T>(src.data);

    /// <summary>
    /// x:intg[int] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<int> src)
        => convert<T>(src.data);

    /// <summary>
    /// x:intg[uint] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<uint> src)
        => convert<T>(src.data);

    /// <summary>
    /// x:intg[long] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<long> src)    
        => convert<T>(src.data);

    /// <summary>
    /// x:intg[ulong] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static intg<T> ToIntG<T>(this intg<ulong> src)
        => convert<T>(src.data);

    
    /// <summary>
    /// x:floatg[float] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    public static intg<T> ToIntG<T>(this floatg<float> src)
        => convert<T>(src.data);

    /// <summary>
    /// x:floatg[float] => x:intg[T]
    /// </summary>
    /// <param name="src">The source value</param>
    public static intg<T> ToIntG<T>(this floatg<double> src)
        => convert<T>(src.data);


}

