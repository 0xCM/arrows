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
    /// Constructs a generic integer
    /// </summary>
    /// <param name="value">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T value)
        => new intg<T>(value);

    /// <summary>
    /// Constructs a generic number
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static num<T> numg<T>(T x)
        => new num<T>(x);

    /// <summary>
    /// Constructs a real number
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static real<T> real<T>(T x)
            => new real<T>(x);


    /// <summary>
    /// Constructs a generic float
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static floatg<T> floatg<T>(T x)
            => new floatg<T>(x);


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
    public static intg<T>[] ints<T>(params T[] src)
    {
        var dst = new intg<T>[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = src[i];
        return dst;
    }

    [MethodImpl(Inline)]   
    public static IReadOnlyList<real<T>> reals<T>(IReadOnlyList<T> src)
        => map(src, x => real<T>(x));

    /// <summary>
    /// Effects T[] => realg[T][]
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    [MethodImpl(Inline)]
    public static real<T>[] reals<T>(params T[] src)
    {
        var dst = new real<T>[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = src[i];
        return dst;
    }

    /// <summary>
    /// Effects T[] => floatg[T][]
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    [MethodImpl(Inline)]
    public static floatg<T>[] floats<T>(params T[] src)
    {
        var dst = new floatg<T>[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = src[i];
        return dst;
    }

    [MethodImpl(Inline)]   
    public static IReadOnlyList<floatg<T>> floats<T>(IReadOnlyList<T> src)
        => map(src, x => floatg<T>(x));

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
    [MethodImpl(Inline)]
    public static byte[] digits(ulong x)
        => x.ToIntG<ulong>().digits();

    [MethodImpl(Inline)]
    public static IEnumerable<real<T>> reals<T>(IEnumerable<T> src)
        where T : IConvertible
            => src.ToReal();

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
    /// Effects byte => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(byte x)
        => ClrConvert.apply<byte,T>(x);

    /// <summary>
    /// Effects sbyte => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(sbyte x)
        => ClrConvert.apply<sbyte,T>(x);

    /// <summary>
    /// Effects short => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(short x)
        => ClrConvert.apply<short,T>(x);

    /// <summary>
    /// Effects ushort => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ushort x)
        => ClrConvert.apply<ushort,T>(x);

    /// <summary>
    /// Effects int => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(int x)
        => ClrConvert.apply<int,T>(x);

    /// <summary>
    /// Effects uint => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(uint x)
        => ClrConvert.apply<uint,T>(x);

    /// <summary>
    /// Effects long => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(long x)
        => ClrConvert.apply<long,T>(x);

    /// <summary>
    /// Effects ulong => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ulong x)
        => ClrConvert.apply<ulong,T>(x);

    /// <summary>
    /// Effects float => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(float x)
        => ClrConvert.apply<float,T>(x);

    /// <summary>
    /// Effects double => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(double x)
        => ClrConvert.apply<double,T>(x);

    /// <summary>
    /// Effects decimal => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(decimal x)
        => ClrConvert.apply<decimal,T>(x);


    [MethodImpl(Inline)]
    public static bigint bigint<T>(T src)
        => ClrConvert.apply<T,bigint>(src);

    [MethodImpl(Inline)]
    public static floatg<float> floatg32<T>(T src)
        => ClrConvert.apply<T,float>(src);

    [MethodImpl(Inline)]
    public static floatg<double> floatg64<T>(T src)
        => ClrConvert.apply<T,double>(src);



    [MethodImpl(Inline)]
    public static intg<ulong> intg64u<T>(T x)
        => ClrConvert.apply<T,ulong>(x);

    [MethodImpl(Inline)]
    public static intg<uint> intg32u<T>(T x)
        => ClrConvert.apply<T,uint>(x);

    /// <summary>
    /// Effects x:clrprim => real[sbyte]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<byte> real8ui<T>(T src)
        => ClrConvert.apply<T,byte>(src);

    /// <summary>
    /// Effects x:clrprim => real[sbyte]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<sbyte> real8i<T>(T src)
        => ClrConvert.apply<T,sbyte>(src);

    /// <summary>
    /// Effects x:clrprim => real[ushort]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<short> real16i<T>(T src)
        => ClrConvert.apply<T,short>(src);

    /// <summary>
    /// Effects x:clrprim => real[ushort]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<ushort> real16ui<T>(T src)
        => ClrConvert.apply<T,ushort>(src);

    /// <summary>
    /// Effects x:clrprim => real[uint]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<uint> real32ui<T>(T src)
        => ClrConvert.apply<T,uint>(src);

    /// <summary>
    /// Effects x:clrprim => real[long]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<long> real64i<T>(T src)
        => ClrConvert.apply<T,long>(src);

    /// <summary>
    /// Effects x:clrprim => real[ulong]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<ulong> real64ul<T>(T src)
        => ClrConvert.apply<T,ulong>(src);

    /// <summary>
    /// Effects x:clrprim => real[int]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<int> real32i<T>(T src)
        => ClrConvert.apply<T,int>(src);

    /// <summary>
    /// Effects x:clrprim => real[float]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<float> real32f<T>(T src)
        => ClrConvert.apply<T,float>(src);

    /// <summary>
    /// Effects x:clrprim => real[double]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<double> real64f<T>(T src)
        => ClrConvert.apply<T,double>(src);

}
    
    