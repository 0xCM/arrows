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
    public static frac<T> frac<T>(T over, T under)
        where T : new()
            => new frac<T>(over,under);

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
    public static int64 int64(sbyte x)
        => new int64(x);

    /// <summary>
    /// Effects sbyte => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(byte x)
        => new int64(x);

    /// <summary>
    /// Effects short => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(short x)
        => new int64(x);

    /// <summary>
    /// Effects ushort => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(ushort x)
        => new int64(x);

    /// <summary>
    /// Effects int => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(int x)
        => new int64(x);

    /// <summary>
    /// Effects uint => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(uint x)
        => new int64(x);

    /// <summary>
    /// Effects long => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(long x)
        => new int64(x);

    /// <summary>
    /// Effects ulong => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int64(ulong x)
        => new int64((long)x);

    /// <summary>
    /// Effects sbyte => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(sbyte x)
        => new float64(x);

    /// <summary>
    /// Effects byte => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(byte x)
        => new float64(x);

    /// <summary>
    /// Effects short => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(short x)
        => new float64(x);

    /// <summary>
    /// Effects ushort => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(ushort x)
        => new float64(x);

    /// <summary>
    /// Effects int => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(int x)
        => new float64(x);

    /// <summary>
    /// Effects uint => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(uint x)
        => new float64(x);

    /// <summary>
    /// Effects long => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(long x)
        => new float64(x);

    /// <summary>
    /// Effects ulong => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(ulong x)
        => new float64(x);

    /// <summary>
    /// Effects float => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(float x)
        => new float64(x);

    /// <summary>
    /// Effects double => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    public static float64 float64(double x)
        => new float64(x);

    
}

public static class bits
{
    public static uint hi(ulong x)
        => (uint)(x >> 32);

    public static uint lo(ulong x)
        => (uint)x;
    public static ulong uint64(uint hi, uint lo)
        => (ulong)hi << 32 | (ulong)lo;



}