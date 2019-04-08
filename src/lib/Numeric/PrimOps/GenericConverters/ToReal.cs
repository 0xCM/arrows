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
        [MethodImpl(Inline)]   
        public static real<T>[] ToReal<T>(this T[] src)
            where T : struct, IEquatable<T>
                => src.Select(x => real<T>(x)).ToArray();        

        [MethodImpl(Inline)]   
        public static IEnumerable<real<T>> ToReal<T>(this IEnumerable<T> src)
            where T : struct, IEquatable<T>
                => src.Select(x => real<T>(x));

        /// <summary>
        /// x:byte => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToReal(this byte src)
            => src;

        /// <summary>
        /// x:byte => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal32(this byte src)
            => src;

        /// <summary>
        /// x:sbyte => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToReal(this sbyte src)
            => src;

        /// <summary>
        /// x:short => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToReal(this short src)
            => src;

        /// <summary>
        /// x:short => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal32(this short src)
            => src;

        /// <summary>
        /// x:ushort => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToReal(this ushort src)
            => src;

        /// <summary>
        /// x:ushort => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal32(this ushort src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToReal(this int src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToReal(this uint src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToReal(this long src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToReal(this ulong src)
            => src;

        [MethodImpl(Inline)]   
        public static real<double> ToReal(this BigInteger src)
            => (double)src;

        /// <summary>
        /// x:float => x:real[float]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal(this float src)
            => src;

        /// <summary>
        /// x:double => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToReal(this double src)
            => src;


        /// <summary>
        /// x:double => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<double> ToReal(this decimal src)
            => ClrConvert.apply<decimal,double>(src);

        /// <summary>
        /// x:double => x:real[double]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<float> ToReal32(this decimal src)
            => ClrConvert.apply<decimal,float>(src);

        /// <summary>
        /// x:sbyte => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this sbyte src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<sbyte,T>(src);

        /// <summary>
        /// x:byte => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this byte src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<byte,T>(src);

        /// <summary>
        /// x:short => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this short src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<short,T>(src);

        /// <summary>
        /// x:ushort => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this ushort src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<ushort,T>(src);

        /// <summary>
        /// x:int => x:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this int src)
            where T : struct, IEquatable<T>
            => ClrConvert.apply<int,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this uint src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<uint,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this long src)    
            where T : struct, IEquatable<T>
                => ClrConvert.apply<long,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this ulong src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<ulong,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this BigInteger src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<BigInteger,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this float src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<float,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this double src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<double,T>(src);

        [MethodImpl(Inline)]   
        public static real<T> ToReal<T>(this decimal src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<decimal,T>(src);

        [MethodImpl(Inline)]   
        public static real<double> ToReal<T>(this intg<T> src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<T,double>(src);

        [MethodImpl(Inline)]   
        public static real<float> ToReal32<T>(this intg<T> src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<T,float>(src);

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