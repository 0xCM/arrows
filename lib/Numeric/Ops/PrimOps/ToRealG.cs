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

partial class zcore
{
    /// <summary>
    /// Constructs a real number
    /// </summary>
    /// <param name="src">The primitive source</param>
    /// <typeparam name="T">The primitive type</typeparam>
    [MethodImpl(Inline)]   
    public static real<T> real<T>(T x)
        where T : struct, IEquatable<T>
            => new real<T>(x);

    /// <summary>
    /// Converts a stream of primitives to a stream of reals
    /// </summary>
    /// <param name="src">The primitive source</param>
    /// <typeparam name="T">The primitive type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<real<T>> reals<T>(IEnumerable<T> src)
        where T : struct, IEquatable<T>
            => src.ToReal();

    /// <summary>
    /// Converts a list of primitives to a list of reals
    /// </summary>
    /// <param name="src">The primitive source</param>
    /// <typeparam name="T">The primitive type</typeparam>
    [MethodImpl(Inline)]   
    public static IReadOnlyList<real<T>> reals<T>(IReadOnlyList<T> src)
        where T : struct, IEquatable<T>
            => map(src, x => real<T>(x));

    /// <summary>
    /// Effects T[] => realg[T][]
    /// </summary>
    /// <param name="src">The primitive source</param>
    /// <typeparam name="T">The primitive type</typeparam>
    [MethodImpl(Inline)]
    public static real<T>[] reals<T>(params T[] src)
        where T : struct, IEquatable<T>
    {
        var dst = new real<T>[src.Length];
        for(var i = 0; i<src.Length; i++)
            dst[i] = src[i];
        return dst;
    }

    /// <summary>
    /// Explicit alternative to implicit destructuring
    /// </summary>
    /// <param name="src">The source structure</param>
    /// <typeparam name="T">The underlying type</typeparam>
    /// <returns>The destructured (underlying) value</returns>
    [MethodImpl(Inline)]   
    public static T unwrap<T>(real<T> src)
        where T : struct, IEquatable<T>
            => src;

    /// <summary>
    /// Effects byte => real[T]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(byte src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<byte,T>(src);

    /// <summary>
    /// Effects sbyte => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(sbyte x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<sbyte,T>(x);

    /// <summary>
    /// Effects short => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(short x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<short,T>(x);

    /// <summary>
    /// Effects ushort => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ushort x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<ushort,T>(x);

    /// <summary>
    /// Effects int => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(int x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<int,T>(x);

    /// <summary>
    /// Effects uint => real[T]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(uint src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<uint,T>(src);

    /// <summary>
    /// Effects long => real[T]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(long src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<long,T>(src);

    /// <summary>
    /// Effects ulong => real[T]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(ulong src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<ulong,T>(src);

    /// <summary>
    /// Effects float => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(float x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<float,T>(x);

    /// <summary>
    /// Effects double => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(double x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<double,T>(x);

    /// <summary>
    /// Effects decimal => real[T]
    /// </summary>
    /// <param name="x">The source value</param>
    /// <typeparam name="T">The underlying target type</typeparam>
    [MethodImpl(Inline)]
    public static real<T> real<T>(decimal x)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<decimal,T>(x);


    /// <summary>
    /// Effects x:clrprim => real[sbyte]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<byte> real8ui<T>(T src)
        => ClrConverter.convert<T,byte>(src);

    /// <summary>
    /// Effects x:clrprim => real[sbyte]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<sbyte> real8i<T>(T src)
        => ClrConverter.convert<T,sbyte>(src);

    /// <summary>
    /// Effects x:clrprim => real[ushort]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<short> real16i<T>(T src)
        => ClrConverter.convert<T,short>(src);

    /// <summary>
    /// Effects x:clrprim => real[ushort]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<ushort> real16ui<T>(T src)
        => ClrConverter.convert<T,ushort>(src);

    /// <summary>
    /// Effects x:clrprim => real[uint]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<uint> real32ui<T>(T src)
        => ClrConverter.convert<T,uint>(src);

    /// <summary>
    /// Effects x:clrprim => real[long]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<long> real64i<T>(T src)
        => ClrConverter.convert<T,long>(src);

    /// <summary>
    /// Effects x:clrprim => real[ulong]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<ulong> real64ul<T>(T src)
        => ClrConverter.convert<T,ulong>(src);

    /// <summary>
    /// Effects x:clrprim => real[int]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<int> real32i<T>(T src)
        => ClrConverter.convert<T,int>(src);

    /// <summary>
    /// Effects x:clrprim => real[float]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<float> real32f<T>(T src)
        => ClrConverter.convert<T,float>(src);

    /// <summary>
    /// Effects x:clrprim => real[double]
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static real<double> real64f<T>(T src)
        => ClrConverter.convert<T,double>(src);

}


namespace Z0
{


    using static zcore;


    partial class xcore
    {
        /// <summary>
        /// Converts an array of primitives to an array of reals
        /// </summary>
        /// <param name="src">The primitive source</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T>[] ToReal<T>(this T[] src)
            where T : struct, IEquatable<T>
                => src.Select(x => real<T>(x)).ToArray();        

        /// <summary>
        /// Converts a stream of primitives to a stream of reals
        /// </summary>
        /// <param name="src">The primitive source</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static IEnumerable<real<T>> ToReal<T>(this IEnumerable<T> src)
            where T : struct, IEquatable<T>
                => map(src,x => real<T>(x));

        /// <summary>
        /// Converts a list of primitives to a list of reals
        /// </summary>
        /// <param name="src">The primitive source</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static Index<real<T>> ToReal<T>(this Index<T> src)
            where T : struct, IEquatable<T>
                => map(src,x => real<T>(x));

        /// <summary>
        /// x:byte => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal32(this byte src)
            => src;

        /// <summary>
        /// x:short => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToRealF32(this short src)
            => src;

        /// <summary>
        /// x:ushort => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToRealF32(this ushort src)
            => src;

        /// <summary>
        /// x:float => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToRealF32(this float src)
            => src;

        /// <summary>
        /// x:double => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal32(this decimal src)
            => ClrConverter.convert<decimal,float>(src);

        /// <summary>
        /// x:byte => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this byte src)
            => src;

        /// <summary>
        /// x:sbyte => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this sbyte src)
            => src;

        /// <summary>
        /// x:short => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this short src)
            => src;


        /// <summary>
        /// x:ushort => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this ushort src)
            => src;


        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this int src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this uint src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this long src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this ulong src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this BigInteger src)
            => (double)src;


        /// <summary>
        /// x:double => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this double src)
            => src;

        /// <summary>
        /// x:double => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64(this decimal src)
            => ClrConverter.convert<decimal,double>(src);

        /// <summary>
        /// x:sbyte => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this sbyte src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<sbyte,T>(src);

        /// <summary>
        /// x:byte => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this byte src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<byte,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this short src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<short,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this ushort src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<ushort,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this int src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<int,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this uint src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<uint,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this long src)    
            where T : struct, IEquatable<T>
                => ClrConverter.convert<long,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this ulong src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<ulong,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this BigInteger src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<BigInteger,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this float src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<float,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this double src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<double,T>(src);

        /// <summary>
        /// Converts a primitive source value to a generically-typed real
        /// </summary>
        /// <param name="src">The primitive source value</param>
        /// <typeparam name="T">The primitive target type</typeparam>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this decimal src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<decimal,T>(src);

        /// <summary>
        /// Converts a generic integer ro a real[double]
        /// </summary>
        /// <param name="src">The generic integer value</param>
        /// <typeparam name="T">The underlying integral primitive</typeparam>
        [MethodImpl(Inline)]   
        public static real<double> ToRealF64<T>(this intg<T> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<T,double>(src);

        /// <summary>
        /// Converts a generic integer ro a real[float]
        /// </summary>
        /// <param name="src">The generic integer value</param>
        /// <typeparam name="T">The underlying integral primitive</typeparam>
        [MethodImpl(Inline)]   
        public static real<float> ToRealF32<T>(this intg<T> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<T,float>(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<byte>> ToReal(this IEnumerable<byte> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<sbyte>> ToReal(this IEnumerable<sbyte> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<short>> ToReal(this IEnumerable<short> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<ushort>> ToReal(this IEnumerable<ushort> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<int>> ToReal(this IEnumerable<int> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<uint>> ToReal(this IEnumerable<uint> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<long>> ToReal(this IEnumerable<long> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<ulong>> ToReal(this IEnumerable<ulong> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<float>> ToReal(this IEnumerable<float> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<double>> ToReal(this IEnumerable<double> src)
            => reals(src);

        [MethodImpl(Inline)]   
        public static IEnumerable<real<decimal>> ToReal(this IEnumerable<decimal> src)
            => reals(src);
    }
}

