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

    using static zfunc;
    using static nfunc;


    public static class VectorX
    {
        /// <summary>
        /// Converts an homogenous 2-tuple to a 2-vector
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N2,T> ToVector<T>(this (T x1, T x2) x)
            where T : struct
            => vector(x);

        /// <summary>
        /// Converts a 2-vector to a 2-tuple
        /// </summary>
        /// <param name="x1">The first coorinate</param>
        /// <param name="x2">The second coordinate</param>
        /// <typeparam name="T">The coordinate type</typeparam>
        [MethodImpl(Inline)]
        public static (T x1, T x2) ToTuple<T>(this Vector<N2,T> v)
            where T : struct
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
            where T : struct
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
            where T : struct
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
            where T : struct
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
            where T : struct
                => tuple(v);

        /// <summary>
        /// Constructs a vector whose length descends from the type natural under extension
        /// </summary>
        /// <param name="n">The natural number representative</param>
        /// <param name="components">The source components</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,T>(this Z0.ITypeNat<N> n, IEnumerable<T> components)
            where N : ITypeNat, new()
            where T :struct
                => new Vector<N, T>(components);

        /// <summary>
        /// Counts the number of components that are false
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int CountFalse<N>(this Vector<N,bool> src)
            where N : ITypeNat, new()    
                => src.cells(x => x == false).Count();

        /// <summary>
        /// Counts the number of components that are true
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int CountTrue<N>(this Vector<N,bool> src)
            where N : ITypeNat, new()    
                => src.cells(x => x == true).Count();


    }

}