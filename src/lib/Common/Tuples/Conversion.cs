//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;

    public static class TupleConvertX
    {

        /// <summary>
        /// Converts an homogenous 2-tuple to a 2-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N2,T> ToVector<T>(this (T x1, T x2) x)
            => vector<N2,T>(x.x1, x.x2);

        /// <summary>
        /// Converts a 2-vector to a 2-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2) ToTuple<T>(this Vector<N2,T> v)
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
            => vector<N4,T>(x.x1, x.x2,x.x3,x.x4);


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
            => (v[0], v[1], v[2], v[3]);

    }
}