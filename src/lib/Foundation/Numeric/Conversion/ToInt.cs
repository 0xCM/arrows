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

using C = Z0.Contracts;

using static corefunc;
using static Z0.Operations;


/// <summary>
/// Defines extensions to convert various types of values to System.Int32
/// </summary>
public static class ToIntX
{
    [MethodImpl(Inline)]   
    public static int ToInt(this byte src)
        => src;

    [MethodImpl(Inline)]   
    public static int ToInt(this sbyte src)
        => src;

    [MethodImpl(Inline)]   
    public static int ToInt(this short src)
        => src;

    [MethodImpl(Inline)]   
    public static int ToInt(this ushort src)
        => src;

    [MethodImpl(Inline)]   
    public static int ToInt(this int src)
        => src;

    [MethodImpl(Inline)]   
    public static int ToInt(this uint src)
        => (int)src;

    [MethodImpl(Inline)]   
    public static int ToInt(this long src)
        => (int)src;

    [MethodImpl(Inline)]   
    public static int ToInt(this ulong src)
        => (int)src;

    [MethodImpl(Inline)]   
    public static int ToInt(this float src)
        => (int)src;


   [MethodImpl(Inline)]   
    public static int ToInt(this double src)
        => (int)src;

   [MethodImpl(Inline)]   
    public static int ToInt(this decimal src)
        => (int)src;

    [MethodImpl(Inline)]   
    public static int ToInt(this byte? src)
        => (src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this sbyte? src)
        => (src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this short? src)
        => (src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this ushort? src)
        => (src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this int? src)
        => (src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this uint? src)
        => (int)(src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this long? src)
        => (int)(src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this ulong? src)
        => (int)(src ?? 0);

    [MethodImpl(Inline)]   
    public static int ToInt(this float? src)
        => (int)(src ?? 0);

   [MethodImpl(Inline)]   
    public static int ToInt(this double? src)
        => (int)src;

   [MethodImpl(Inline)]   
    public static int ToInt(this decimal? src)
        => (int)src;

    /// <summary>
    /// x:intg[byte] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static int ToInt(this intg<byte> src)
        => (int)src.data;

    /// <summary>
    /// x:intg[sbyte] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static int ToInt(this intg<sbyte> src)
        => (int)src.data;

    /// <summary>
    /// x:intg[short] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static int ToInt(this intg<short> src)
        => src;

    /// <summary>
    /// x:intg[ushort] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static int ToInt(this intg<ushort> src)
        => src;

    /// <summary>
    /// x:intg[int] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static int ToInt(this intg<int> src)
        => src;

    [MethodImpl(Inline)]   
    public static int ToInt(this intg<uint> src)
        => (int)src.data;

    [MethodImpl(Inline)]   
    public static int ToInt(this intg<long> src)
        => (int)src.data;

    [MethodImpl(Inline)]   
    public static int ToInt(this intg<ulong> src)
        => (int)src.data;


   [MethodImpl(Inline)]   
    public static int ToInt(this floatg<double> src)
        => (int)src.data;


   [MethodImpl(Inline)]   
    public static int ToInt(this floatg<float> src)
        => (int)src.data;

   [MethodImpl(Inline)]   
    public static int ToInt<T>(this floatg<T> src)
        => convert<int>(src.data);

}