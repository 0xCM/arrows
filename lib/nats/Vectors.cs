//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;


    using static zfunc;
    using static nats;
    using static zcore;

    public static class natvec
    {
        /// <summary>
        /// Converts a 3-vector to a 3-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x4">The fourth coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2, T x3, T x4) tuple<T>(Vector<N4,T> v)
            where T : struct, IEquatable<T>
                => (v[0], v[1], v[2], v[3]);

        /// <summary>
        /// Converts an homogenous 4-tuple to a 4-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <param name="x3">The third coordinate</param>
        /// <param name="x4">The fourth coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N4,T> vector<T>((T x1, T x2, T x3, T x4) x)
            where T : struct, IEquatable<T>
                => vector<N4,T>(x.x1, x.x2,x.x3,x.x4);

        /// <summary>
        /// Converts an homogenous 2-tuple to a 2-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N2,T> vector<T>((T x1, T x2) x)
            where T : struct, IEquatable<T>
                => vector<N2,T>(x.x1, x.x2);

        /// <summary>
        /// Replicates a given value a specified number of times
        /// </summary>
        /// <param name="value">The value to replicate</param>
        /// <typeparam name="N">The natural count type</typeparam>
        /// <typeparam name="T">The replicant type</typeparam>
        [MethodImpl(Inline)]   
        public static T[] repeat<N,T>(T value)
            where N : ITypeNat, new()
            => zfunc.repeat(value, natu<N>());

    }

}