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

using Z0;
using static zcore;

partial class zcore
{
    /// <summary>
    /// Explicit alternative to implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(intg<T> src)
        => src;

    /// <summary>
    /// Explicit alternative to implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(real<T> src)
        => src;

    /// <summary>
    /// Explicit alternative to implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(floatg<T> src)
        => src;

    /// <summary>
    /// Explicitly invokes the (T) implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(num<T> src)
        => src;
    
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
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(byte x)
        => x.ToIntG<byte>().digits();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(ushort x)
        => x.ToIntG<ushort>().digits();

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


    // !!! x : unsigned => intg[x]
    // !!! --------------------------------------------------------------------

    #region x : unsigned => intg[x] 
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


    // !!! x : signed => intg[x]
    // !!! --------------------------------------------------------------------

    #region x : unsigned => intg[x] 

    /// <summary>
    /// Effects sbyte => intg[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static intg<sbyte> z(sbyte x) 
        => x;

    #endregion


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

    #endregion
    
    
    // !!! clrint => BigInteger
    // !!! --------------------------------------------------------------------

    # region clrint => BigInteger

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
    /// Constructs an bigint from an int
    /// </summary>
    /// <param name="x">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static bigint bigint(float x)
        => new bigint((int)x);

    #endregion


    // !!! clrnumber => floatg[double]
    // !!! --------------------------------------------------------------------

    #region clrint => floatg[double]  

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

    # endregion


    // !!! clrint => intg[uint]
    // !!! --------------------------------------------------------------------

    #region clrint => intg[uint] 

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

    #endregion


    // !!! clrint => intg[ulong]
    // !!! --------------------------------------------------------------------

    # region clrint => intg[ulong]

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

    #endregion


    // !!! [clrint] => [ingt[clrint]]
    // !!! --------------------------------------------------------------------

    # region [clrint] => [ingt[clrint]]

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

    # endregion


    /// <summary>
    /// Effects byte => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> ureal(byte x) 
        => x;

    /// <summary>
    /// Effects ushort => real[ushort]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> ureal(ushort x)
        => x;

    /// <summary>
    /// Effects uint => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> ureal(uint x)
        => x;

    /// <summary>
    /// Effects ulong => real[ulong]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> ureal(ulong x)
        => x;


    /// <summary>
    /// Effects byte => intg[byte]
    /// </summary>
    /// <param name="x">The source value</param>
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
    /// Effects sbyte => intg[sbyte]
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

    // !!! x:clrnumber => real[x:T]
    // !!! --------------------------------------------------------------------

    #region x:clrnumber => real[x:T]
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

    #endregion

    // !!! x:clrnumber => real[x:byte]
    // !!! --------------------------------------------------------------------
    
    #region x:clrnumber => real[x:byte]

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

    #endregion

    // !!! real[X] => real[byte]
    // !!! --------------------------------------------------------------------

    #region real[X] => real[byte]

    /// <summary>
    /// Effects identity transformation
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<byte> x)
        => x;

    /// <summary>
    /// Effects real[sbyte] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<sbyte> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<short> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<ushort> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<int> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<uint> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<long> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<ulong> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<float> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<double> x)
        => (byte)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[byte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<byte> uint8(real<decimal> x)
        => (byte)unwrap(x);

    #endregion

    // !!! real[X] => real[sbyte]
    // !!! --------------------------------------------------------------------

    #region real[X] => real[sbyte]

    /// <summary>
    /// Effects real[byte] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<byte> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects identity transformation
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<sbyte> x)
        => x;

    /// <summary>
    /// Effects real[short] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<short> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<ushort> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<int> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<uint> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<long> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<ulong> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<float> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<double> x)
        => (sbyte)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[sbyte]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<sbyte> int8(real<decimal> x)
        => (sbyte)unwrap(x);

    #endregion

    // !!! real[X] => real[short]
    // !!! --------------------------------------------------------------------

    #region real[X] => real[short]

    /// <summary>
    /// Effects real[byte] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<byte> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<sbyte> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[short], the identity transformation
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<short> x)
        => x;

    /// <summary>
    /// Effects real[ushort] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<ushort> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<int> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<uint> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<long> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<ulong> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<float> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<double> x)
        => (short)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<short> int16(real<decimal> x)
        => (short)unwrap(x);

    #endregion 
    
    // !!! real[X] => real[ushort]
    // !!! --------------------------------------------------------------------
 
    #region real[X] => real[ushort]

    /// <summary>
    /// Effects real[byte] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<byte> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<sbyte> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[short], the identity transformation
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<short> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[short], the identity transformation
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<ushort> x)
        => x;

    /// <summary>
    /// Effects real[int] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<int> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<uint> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<long> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<ulong> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<float> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<double> x)
        => (ushort)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[short]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ushort> uint16(real<decimal> x)
        => (ushort)unwrap(x);

    #endregion
    
    // !!! real[X] => real[uint]
    // !!! -------------------------------------------------------------------- 

    #region real[X] => real[uint]

    /// <summary>
    /// Effects real[byte] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<byte> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<sbyte> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<short> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<ushort> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<int> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<uint> x)
        => x;

    /// <summary>
    /// Effects real[long] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<long> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<ulong> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<float> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<double> x)
        => (uint)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[uint]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<uint> uint32(real<decimal> x)
        => (uint)unwrap(x);

    #endregion

    // !!! real[X] => real[long]
    // !!! -------------------------------------------------------------------- 

    #region real[X] => real[long]

    /// <summary>
    /// Effects real[byte] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<byte> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<sbyte> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<short> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<ushort> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<int> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<uint> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<long> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<ulong> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<float> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<double> x)
        => (long)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<long> int64(real<decimal> x)
        => (long)unwrap(x);

    #endregion


    // !!! real[X] => real[ulong]
    // !!! -------------------------------------------------------------------- 

    #region real[X] => real[ulong]

    /// <summary>
    /// Effects real[byte] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<byte> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<sbyte> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<short> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<ushort> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<int> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<uint> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<long> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<ulong> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<float> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<double> x)
        => (ulong)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<ulong> uint64(real<decimal> x)
        => (ulong)unwrap(x);

    #endregion


    // !!! real[X] => real[int]
    // !!! -------------------------------------------------------------------- 

    #region real[X] => real[float]

    /// <summary>
    /// Effects real[byte] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<byte> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<sbyte> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<short> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<ushort> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[int] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<int> x)
        => x;

    /// <summary>
    /// Effects real[uint] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<uint> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<long> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<ulong> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<float> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<double> x)
        => (int)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[int]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<int> int32(real<decimal> x)
        => (int)unwrap(x);

    #endregion

    // !!! real[X] => real[float]
    // !!! -------------------------------------------------------------------- 

    #region real[X] => real[double] 
    /// <summary>
    /// Effects real[byte] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<byte> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<sbyte> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<short> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<ushort> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<int> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<uint> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<long> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<ulong> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<float> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<double> x)
        => (float)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[float]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<float> float32(real<decimal> x)
        => (float)unwrap(x);

    #endregion

    // !!! real[X] => real[double]
    // !!! -------------------------------------------------------------------- 

    #region real[X] => real[double]
    /// <summary>
    /// Effects real[byte] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<byte> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[sbyte] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<sbyte> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[short] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<short> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[ushort] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<ushort> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<int> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[uint] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<uint> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[long] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<long> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[ulong] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<ulong> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[float] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<float> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[double] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<double> x)
        => (double)unwrap(x);

    /// <summary>
    /// Effects real[decimal] => real[double]
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static real<double> float64(real<decimal> x)
        => (double)unwrap(x);
    #endregion

    // !!! [x] => [real[x]]
    // !!! -------------------------------------------------------------------- 


    #region [x] => [real[x]]

    [MethodImpl(Inline)]   
    public static IEnumerable<real<byte>> reals(IEnumerable<byte> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<sbyte>> reals(IEnumerable<sbyte> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<short>> reals(IEnumerable<short> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<ushort>> reals(IEnumerable<ushort> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<int>> reals(IEnumerable<int> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<uint>> reals(IEnumerable<uint> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<long>> reals(IEnumerable<long> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<ulong>> reals(IEnumerable<ulong> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<float>> reals(IEnumerable<float> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<double>> reals(IEnumerable<double> src)
        => from x in src select real(x);

    [MethodImpl(Inline)]   
    public static IEnumerable<real<decimal>> reals(IEnumerable<decimal> src)
        => from x in src select real(x);

    #endregion
}
    
    