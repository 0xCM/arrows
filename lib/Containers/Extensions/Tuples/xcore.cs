//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zcore;
    using static zfunc;
    using static nats;

    partial class xcore
    {

        /// <summary>
        /// Converts an homogenous 2-tuple to a 2-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N2,T> ToVector<T>(this (T x1, T x2) x)
            where T : struct, IEquatable<T>
            => vector(x);

        /// <summary>
        /// Converts a 2-vector to a 2-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2) ToTuple<T>(this Vector<N2,T> v)
            where T : struct, IEquatable<T>
                => (v[0], v[1]);

        /// <summary>
        /// Converts an homogenous 3-tuple to a 3-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N3,T> ToVector<T>(this (T x1, T x2, T x3) x)
            where T : struct, IEquatable<T>
                => vector<N3,T>(x.x1, x.x2,x.x3);

        /// <summary>
        /// Converts a 3-vector to a 3-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2, T x3) ToTuple<T>(this Vector<N3,T> v)
            where T : struct, IEquatable<T>
                => (v[0], v[1], v[2]);

        /// <summary>
        /// Converts an homogenous 4-tuple to a 4-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <param name="x4">The fourth coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N4,T> ToVector<T>(this (T x1, T x2, T x3, T x4) x)
            where T : struct, IEquatable<T>
                => vector(x);


        /// <summary>
        /// Converts a 3-vector to a 3-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x4">The fourth coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2, T x3, T x4) ToTuple<T>(this Vector<N4,T> v)
            where T : struct, IEquatable<T>
                => tuple(v);

        /// <summary>
        /// Transforms a sequence of key-value pairs into a sequence of tuples
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<(K key, V value)> ToTuples<K,V>(this IEnumerable<KeyValuePair<K,V>> pairs)
            => tuples(pairs);

        [MethodImpl(Inline)]
        public static string Format<X,Y>(this (X x,Y y) src)
            => paren(src.x.ToString(), ",", src.y.ToString());
        
        public static string Format<X,Y>(this IEnumerable<(X x,Y y)> src)
            => string.Join(", ", src.Select(x => x.Format()));
    }
}