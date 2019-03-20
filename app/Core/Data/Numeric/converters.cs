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
using static Core.Operations;

partial class corefunc
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
        => new int64(x);

    /// <summary>
    /// Effects sbyte => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int32(byte x)
        => new int64(x);

    /// <summary>
    /// Effects short => int64
    /// </summary>
    /// <param name="x">The source value</param>
    public static int64 int32(short x)
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
        => intg((uint)x);

    /// <summary>
    /// Effects sbyte => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(byte x)
        => intg((uint)x);

    /// <summary>
    /// Effects short => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(short x)
        => intg((uint)x);

    /// <summary>
    /// Effects ushort => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(ushort x)
        => intg((uint)x);

    /// <summary>
    /// Effects int => intg[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(int x)
        => intg((uint)x);

    /// <summary>
    /// Effects uint => intg[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> uint32g(uint x)
        => intg((uint)x);

    /// <summary>
    /// Effects sbyte => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(sbyte x)
        => intg((ulong)x);

    /// <summary>
    /// Effects sbyte => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(byte x)
        => intg((ulong)x);

    /// <summary>
    /// Effects short => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(short x)
        => intg((ulong)x);

    /// <summary>
    /// Effects ushort => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(ushort x)
        => intg((ulong)x);

    /// <summary>
    /// Effects int => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(int x)
        => intg((ulong)x);

    /// <summary>
    /// Effects uint => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(uint x)
        => intg((ulong)x);

    /// <summary>
    /// Effects ulong => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> uint64g(ulong x)
        => x;

}