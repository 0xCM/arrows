//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this sbyte src)
            where T : struct
                => convert<T>(src);
        
        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this byte src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this short src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this ushort src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this int src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this uint src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this long src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this ulong src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this float src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this double src)
            where T : struct
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<sbyte> src)
            where T : struct
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<byte> src)
            where T : struct
                => from item in src select convert<T>(item);
        
        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<short> src)
            where T : struct
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<ushort> src)
            where T : struct
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<int> src)
            where T : struct
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<uint> src)
            where T : struct
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<long> src)
            where T : struct
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<ulong> src)
            where T : struct            
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<float> src)
            where T : struct            
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<double> src)
            where T : struct            
                => from item in src select convert<T>(item);
 
        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        static Span<T> Convert<S,T>(this ReadOnlySpan<S> src)
            where S : struct
            where T : struct
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                convert(src[i], out dst[i]);
            return dst;
        }

        static T[] Convert<S,T>(this S[] src)
            where S : struct
            where T : struct
        {
            var dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                convert(src[i], out dst[i]);
            return dst;
        }

        static Span<T> Convert<S,T>(this Span<S> src)
            where S : struct
            where T : struct
                => src.ReadOnly().Convert<S,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<sbyte> src)
            where T : struct
                => src.Convert<sbyte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<byte> src)
            where T : struct
                => src.Convert<byte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<short> src)
            where T : struct
                => src.Convert<short,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<ushort> src)
            where T : struct
                => src.Convert<ushort,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<int> src)
            where T : struct
                => src.Convert<int,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<uint> src)
            where T : struct
                => src.Convert<uint,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<long> src)
            where T : struct
                => src.Convert<long,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<ulong> src)
            where T : struct
                => src.Convert<ulong,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<float> src)
            where T : struct
                => src.Convert<float,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<double> src)
            where T : struct
                => src.Convert<double,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<sbyte> src)
            where T : struct
                => src.Convert<sbyte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<byte> src)
            where T : struct
                => src.Convert<byte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<short> src)
            where T : struct
                => src.Convert<short,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<ushort> src)
            where T : struct
                => src.Convert<ushort,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<int> src)
            where T : struct
                => src.Convert<int,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<uint> src)
            where T : struct
                => src.Convert<uint,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<long> src)
            where T : struct
                => src.Convert<long,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<ulong> src)
            where T : struct
                => src.Convert<ulong,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<float> src)
            where T : struct
                => src.Convert<float,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<double> src)
            where T : struct
                => src.Convert<double,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this sbyte[] src)
            where T : struct
                => src.Convert<sbyte,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this byte[] src)
            where T : struct
                => src.Convert<byte,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this short[] src)
            where T : struct
                => src.Convert<short,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this ushort[] src)
            where T : struct
                => src.Convert<ushort,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this int[] src)
            where T : struct
                => src.Convert<int,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this uint[] src)
            where T : struct
                => src.Convert<uint,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this long[] src)
            where T : struct
                => src.Convert<long,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this ulong[] src)
            where T : struct
                => src.Convert<ulong,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this float[] src)
            where T : struct
                => src.Convert<float,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this double[] src)
            where T : struct
                => src.Convert<double,T>();

    }
}