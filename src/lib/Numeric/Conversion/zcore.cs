//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using bigint = Z0.intg<System.Numerics.BigInteger>;
using int64 = Z0.intg<long>;

using Z0;
using static zcore;



partial class zcore
{

    /// <summary>
    /// Effects sbyte => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(sbyte x)
        => new bigint(x);

    /// <summary>
    /// Effects byte => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(byte x)
        => new bigint(x);

    /// <summary>
    /// Effects short => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(short x)
        => new bigint(x);

    /// <summary>
    /// Effects ushort => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(ushort x)
        => new bigint(x);

    /// <summary>
    /// Effects int => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(int x)
        => new bigint(x);

    /// <summary>
    /// Constructs an bigint from an int
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(uint x)
        => new bigint(x);

    /// <summary>
    /// Constructs an bigint from a long
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(long x)
        => new bigint(x);

    /// <summary>
    /// Constructs an bigint from an int
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static bigint bigint(ulong x)
        => new bigint(x);

    /// <summary>
    /// Effects sbyte => int64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static int64 int32(sbyte x)
        => int64(x);

    /// <summary>
    /// Effects sbyte => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int32(byte x)
        => int64(x);

    /// <summary>
    /// Effects short => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int32(short x)
        => int64(x);

    /// <summary>
    /// Effects ushort => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(ushort x)
        => int64(x);

    /// <summary>
    /// Effects int => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(int x)
        => int64(x);

    /// <summary>
    /// Effects uint => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(uint x)
        => int64(x);

    /// <summary>
    /// Effects long => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(long x)
        => int64(x);

    /// <summary>
    /// Effects ulong => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(ulong x)
        => int64((long)x);

    /// <summary>
    /// Effects sbyte => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(sbyte x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects byte => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(byte x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects short => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(short x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects ushort => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(ushort x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects int => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(int x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects uint => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(uint x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects long => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(long x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects ulong => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(ulong x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects float => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(float x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects double => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static floatg<double> float64(double x)
        => new floatg<double>(x);


    /// <summary>
    /// Effects byte => intg[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<byte> byteg(byte x)
        => x;

    /// <summary>
    /// Effects sbyte => intg<uint>
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(sbyte x)
        => (uint)x;

    /// <summary>
    /// Effects sbyte => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(byte x)
        => (uint)x;

    /// <summary>
    /// Effects short => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(short x)
        => (uint)x;

    /// <summary>
    /// Effects ushort => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(ushort x)
        => (uint)x;

    /// <summary>
    /// Effects int => intg[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(int x)
        => (uint)x;

    /// <summary>
    /// Effects uint => intg[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(uint x)
        => (uint)x;

    /// <summary>
    /// Effects sbyte => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(sbyte x)
        => (ulong)x;

    /// <summary>
    /// Effects sbyte => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(byte x)
        => (ulong)x;

    /// <summary>
    /// Effects short => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(short x)
        => (ulong)x;

    /// <summary>
    /// Effects ushort => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(ushort x)
        => (ulong)x;

    /// <summary>
    /// Effects int => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(int x)
        => (ulong)x;

    /// <summary>
    /// Effects uint => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(uint x)
        => (ulong)x;

    /// <summary>
    /// Effects ulong => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(ulong x)
        => x;

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(uint x)
        => x.ToIntG<uint>().digits();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(ulong x)
        => x.ToIntG<ulong>().digits();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(ushort x)
        => x.ToIntG<ushort>().digits();

    [MethodImpl(Inline)]
    public static intg<T> min<T>(intg<T> x, intg<T> y)
        => x < y ? x : y;


    [MethodImpl(Inline)]
    public static intg<T> max<T>(intg<T> x, intg<T> y)
        => x > y ? x : y;

}