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
/// Defines extensions to convert various types of values to System.Int32
/// </summary>
public static class ToUInt64X
{

    /// <summary>
    /// x:intg[byte] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<byte> src)
        => (ulong)src;

    /// <summary>
    /// x:intg[sbyte] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<sbyte> src)
        => (ulong)src;

    /// <summary>
    /// x:intg[short] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<short> src)
        => (ulong)src;

    /// <summary>
    /// x:intg[ushort] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<ushort> src)
        => src;

    /// <summary>
    /// x:intg[int] => x:int
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<int> src)
        => (ulong)src;

    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<uint> src)
        => (ulong)src;

    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<long> src)
        => (ulong)src;

    [MethodImpl(Inline)]   
    public static ulong ToUInt64(this intg<ulong> src)
        => src;

   [MethodImpl(Inline)]   
    public static ulong ToUInt64(this double src)
        => (ulong)src;

   [MethodImpl(Inline)]   
    public static ulong ToUInt64(this floatg<double> src)
        => (ulong)src;

   [MethodImpl(Inline)]   
    public static ulong ToUInt64(this float src)
        => (ulong)src;

   [MethodImpl(Inline)]   
    public static ulong ToUInt64(this floatg<float> src)
        => (ulong)src;

   [MethodImpl(Inline)]   
    public static ulong ToUInt64(this decimal src)
        => (ulong)src;

   [MethodImpl(Inline)]   
    public static int ToInt<T>(this floatg<T> src)
        => convert<int>(unwrap(src));

}