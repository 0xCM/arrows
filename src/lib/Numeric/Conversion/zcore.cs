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
using int32 = Z0.intg<int>;
using int16 = Z0.intg<short>;
using int8 = Z0.intg<sbyte>;
using uint64 = Z0.intg<ulong>;
using uint32 = Z0.intg<uint>;
using uint16 = Z0.intg<ushort>;
using uint8 = Z0.intg<byte>;

using Z0;
using static zcore;

partial class zcore
{
    
    /// <summary>
    /// Effects T[] => intg[T][]
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    [MethodImpl(Inline)]
    public static intg<T>[] intarray<T>(params T[] src)
        where T : IConvertible
    {
        var dst = new intg<T>[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = src[i];
        return dst;
    }

    /// <summary>
    /// Effects byte => intg[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<byte> u(byte x) 
        => x;

    /// <summary>
    /// Effects ushort => intg[ushort]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ushort> u(ushort x)
        => x;

    /// <summary>
    /// Effects uint => intg[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<uint> u(uint x)
        => x;

    /// <summary>
    /// Effects ulong => intg[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<ulong> u(ulong x)
        => x;

    /// <summary>
    /// Effects sbyte => intg[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<sbyte> z(sbyte x) 
        => x;

    /// <summary>
    /// Effects short => intg[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<short> z(short x)
        => x;

    /// <summary>
    /// Effects int => intg[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<int> z(int x)
        => x;

    /// <summary>
    /// Effects long => intg[long]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<long> z(long x)
        => x;

    /// <summary>
    /// Effects sbyte => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bigint bigint(sbyte x)
        => new bigint(x);

    /// <summary>
    /// Effects byte => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bigint bigint(byte x)
        => new bigint(x);

    /// <summary>
    /// Effects short => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bigint bigint(short x)
        => new bigint(x);

    /// <summary>
    /// Effects ushort => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bigint bigint(ushort x)
        => new bigint(x);

    /// <summary>
    /// Effects int => bigint
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bigint bigint(int x)
        => new bigint(x);

    /// <summary>
    /// Constructs an bigint from an int
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bigint bigint(uint x)
        => new bigint(x);

    /// <summary>
    /// Constructs an bigint from a long
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bigint bigint(long x)
        => new bigint(x);

    /// <summary>
    /// Constructs an bigint from an int
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bigint bigint(ulong x)
        => new bigint(x);

    /// <summary>
    /// Effects sbyte => int64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static int64 int32(sbyte x)
        => int64(x);

    /// <summary>
    /// Effects sbyte => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int32(byte x)
        => int64(x);

    /// <summary>
    /// Effects short => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int32(short x)
        => int64(x);

    /// <summary>
    /// Effects ushort => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int64(ushort x)
        => int64(x);

    /// <summary>
    /// Effects int => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int64(int x)
        => int64(x);

    /// <summary>
    /// Effects uint => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int64(uint x)
        => int64(x);

    /// <summary>
    /// Effects long => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int64(long x)
        => int64(x);

    /// <summary>
    /// Effects ulong => int64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static int64 int64(ulong x)
        => int64((long)x);

    /// <summary>
    /// Effects sbyte => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static floatg<double> float64(sbyte x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects byte => float64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static floatg<double> float64(byte x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects short => float64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static floatg<double> float64(short x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects ushort => float64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static floatg<double> float64(ushort x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects int => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static floatg<double> float64(int x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects uint => float64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static floatg<double> float64(uint x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects long => float64
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static floatg<double> float64(long x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects ulong => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static floatg<double> float64(ulong x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects float => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static floatg<double> float64(float x)
        => new floatg<double>(x);

    /// <summary>
    /// Effects double => float64
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
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

    
    /// <summary>
    /// Effects byte[] => intg[byte][]
    /// </summary>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]
    public static intg<byte>[] uints(params byte[] src)
        => intarray(src);

    /// <summary>
    /// Effects usnort[] => intg[ushort][]
    /// </summary>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]
    public static intg<ushort>[] uints(params ushort[] src)
        => intarray(src);

    /// <summary>
    /// Effects uint[] => intg[uint][]
    /// </summary>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]
    public static intg<uint>[] uints(params uint[] src)
        => intarray(src);

    /// <summary>
    /// Effects long[] => intg[ulong][]
    /// </summary>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]
    public static intg<ulong>[] uints(params ulong[] src)
        => intarray(src);

    [MethodImpl(Inline)]
    public static intg<sbyte>[] ints(params sbyte[] src)
        => intarray(src);


    [MethodImpl(Inline)]
    public static intg<short>[] ints(params short[] src)
        => intarray(src);


    [MethodImpl(Inline)]
    public static intg<int>[] ints(params int[] src)
        => intarray(src);


    [MethodImpl(Inline)]
    public static intg<long>[] ints(params long[] src)
        => intarray(src);


    [MethodImpl(Inline)]
    public static intg<byte> uintg(byte x) 
        => x;

    [MethodImpl(Inline)]
    public static intg<ushort> uintg(ushort x)
        => x;

    [MethodImpl(Inline)]
    public static intg<uint> uintg(uint x)
        => x;

    [MethodImpl(Inline)]
    public static intg<ulong> uintg(ulong x)
        => x;

    /// <summary>
    /// Effects sbyte => intg[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static intg<sbyte> intg(sbyte x) 
        => x;

    /// <summary>
    /// Effects short => intg[short]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static intg<short> intg(short x)
        => x;

    /// <summary>
    /// Effects int=> intg[int]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static intg<int> intg(int x)
        => x;

    /// <summary>
    /// Effects long => intg[long]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static intg<long> intg(long x)
        => x;

    /// <summary>
    /// Effects byte => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(byte x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects sbyte => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(sbyte x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects short => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(short x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects ushort => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ushort x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects int => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(int x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects uint => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(uint x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects long => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(long x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects ulong => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ulong x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects float => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(float x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects double => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(double x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects decimal => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(decimal x)
        where T: IConvertible
            => convert<T>(x);

    /// <summary>
    /// Effects byte => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> real(byte x)
        => x;

    /// <summary>
    /// Effects sbyte => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> real(sbyte x)
        => x;

    /// <summary>
    /// Effects short => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> real(short x)
        => x;

    /// <summary>
    /// Effects ushort => real[ushort]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> real(ushort x)
        => convert<ushort>(x);

    /// <summary>
    /// Effects int => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> real(int x)
        => x;

    /// <summary>
    /// Effects uint => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> real(uint x)
        => x;

    /// <summary>
    /// Effects long => real[long]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> real(long x)
        => x;

    /// <summary>
    /// Effects ulong => real[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> real(ulong x)
        => x;

    /// <summary>
    /// Effects float => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> real(float x)
        => x;

    /// <summary>
    /// Effects double => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> real(double x)
        => x;

    /// <summary>
    /// Effects decimal => real[decimal]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<decimal> real(decimal x)
        => x;
}