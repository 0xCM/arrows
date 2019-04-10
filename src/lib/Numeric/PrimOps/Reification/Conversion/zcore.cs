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
    /// Converts from one value to another, provided the 
    /// required conversion operation is defined; otherwise,
    /// raises an error
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public static T convert<S,T>(S src)
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
            => ClrConversion.convert<S,T>(src);

    /// <summary>
    /// Vectorized conversion
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="src">The source array</param>
    public static IReadOnlyList<T> convert<S,T>(IReadOnlyList<S> src)
        => ClrConversion.convert<S,T>(src);

    /// <summary>
    /// Constructs a generic integer
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T src)
        where T : struct, IEquatable<T>
            => new intg<T>(src);

    [MethodImpl(Inline)]   
    public static intg<T> enumg<T>(Enum src)
        where T : struct, IEquatable<T>
            => (T)Convert.ChangeType(src, type<T>());    
    
    /// <summary>
    /// Constructs a generic number
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static num<T> numg<T>(T x)
        where T : struct, IEquatable<T>
            => new num<T>(x);

    /// <summary>
    /// Constructs a generic float
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static floatg<T> floatg<T>(T x)
        where T : struct, IEquatable<T>
            => new floatg<T>(x);

    /// <summary>
    /// Explicit alternative to implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(intg<T> src)
        where T : struct, IEquatable<T>
            => src;


    /// <summary>
    /// Explicit alternative to implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(floatg<T> src)
        where T : struct, IEquatable<T>
            => src;

    /// <summary>
    /// Explicitly invokes the (T) implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(num<T> src)
        where T : struct, IEquatable<T>
            => src;
    
    /// <summary>
    /// Effects T[] => intg[T][]
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The underlying integral type</typeparam>
    [MethodImpl(Inline)]
    public static intg<T>[] ints<T>(params T[] src)
        where T : struct, IEquatable<T>
    {
        var dst = new intg<T>[src.Length];
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
        where T : struct, IEquatable<T>
    {
        var dst = new floatg<T>[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = src[i];
        return dst;
    }

    [MethodImpl(Inline)]   
    public static IReadOnlyList<floatg<T>> floats<T>(IReadOnlyList<T> src)
        where T : struct, IEquatable<T>
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


    [MethodImpl(Inline)]
    public static bigint bigint<T>(T src)
        => ClrConversion.convert<T,bigint>(src);

    [MethodImpl(Inline)]
    public static floatg<float> floatg32<T>(T src)
        => ClrConversion.convert<T,float>(src);

    [MethodImpl(Inline)]
    public static floatg<double> floatg64<T>(T src)
        => ClrConversion.convert<T,double>(src);

    [MethodImpl(Inline)]
    public static intg<ulong> intg64u<T>(T x)
        => ClrConversion.convert<T,ulong>(x);

    [MethodImpl(Inline)]
    public static intg<uint> intg32u<T>(T x)
        => ClrConversion.convert<T,uint>(x);
}
    
    