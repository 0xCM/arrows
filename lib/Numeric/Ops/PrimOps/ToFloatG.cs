//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;


    using static zcore;

    partial class xcore
    {
        /// <summary>
        /// x:intg[x] => x:floatg[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<float> ToFloatG32<T>(this intg<T> src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<T,float>(src);

        /// <summary>
        /// x:intg[x] => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64<T>(this intg<T> src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<T,double>(src);

        /// <summary>
        /// x:ushort => x:floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this ushort src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<ushort,T>(src);

        /// <summary>
        /// x:int => x:floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this int src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<int,T>(src);

        /// <summary>
        /// x:uint => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this uint src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<uint,T>(src);

        /// <summary>
        /// x:long => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this long src)    
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<long,T>(src);

        /// <summary>
        /// x:long => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this ulong src)
            where T : struct, IEquatable<T>
            => ConvertG.toFloat<ulong,T>(src);

        /// <summary>
        /// x:BigInteger => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this BigInteger src)
            where T : struct, IEquatable<T>
            => ConvertG.toFloat<BigInteger,T>(src);

        /// <summary>
        /// x:float => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this float src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<float,T>(src);

        /// <summary>
        /// x:double => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this double src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<double,T>(src);

        /// <summary>
        /// x:decimal => floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this decimal src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<decimal,T>(src);

        /// <summary>
        /// x:sbyte => x:floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this sbyte src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<sbyte,T>(src);

        /// <summary>
        /// x:byte => x:floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this byte src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<byte,T>(src);

        /// <summary>
        /// x:short => x:floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<T> ToFloatG<T>(this short src)
            where T : struct, IEquatable<T>
                => ConvertG.toFloat<short,T>(src);

        /// <summary>
        /// x:byte => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this byte src)
            => src;

        /// <summary>
        /// x:sbyte => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this sbyte src)
            => src;

        /// <summary>
        /// x:short => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this short src)
            => src;

        /// <summary>
        /// x:ushort => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this ushort src)
            => src;


        /// <summary>
        /// x:int=> x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this int src)
            => src;

        /// <summary>
        /// x:uint => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this uint src)
            => src;

        /// <summary>
        /// x:long => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this long src)
            => src;

        /// <summary>
        /// x:ulong => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this ulong src)
            => src;

        /// <summary>
        /// x:BigInteger => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this BigInteger src)
             => ConvertG.toFloat<BigInteger, double>(src);


        /// <summary>
        /// x:double => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this double src)
            => src;

        /// <summary>
        /// x:double => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<double> ToFloatG64(this decimal src)
             => ConvertG.toFloat<decimal, double>(src);

        /// <summary>
        /// x:byte => x:floatg[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<float> ToFloatG32(this byte src)
            => src;

        /// <summary>
        /// x:short => x:floatg[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<float> ToFloatG32(this short src)
            => src;

        /// <summary>
        /// x:ushort => x:floatg[float]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static floatg<float> ToFloatG32(this ushort src)
            => src;

        /// <summary>
        /// x:float => x:floatg[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<float> ToFloatG32(this float src)
            => src;

        /// <summary>
        /// x:double => x:floatg[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static floatg<float> ToFloatG32(this decimal src)
             => ConvertG.toFloat<decimal, float>(src);

    }
}