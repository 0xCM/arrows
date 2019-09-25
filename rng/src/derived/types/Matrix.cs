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
    using static As;
    using static nfunc;

    partial class RngD
    {

        /// <summary>
        /// Allocates and fills a matrix of natural dimensions with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The range of potiential random values</param>
        /// <param name="m">The natural number of rows</param>
        /// <param name="n">The natural number of columns</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> Matrix<M,N,T>(this IPolyrand random, Interval<T>? domain = null, M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
                => Z0.Matrix.Load<M,N,T>(random.Array<T>(Z0.Matrix<M,N,T>.CellCount, domain));                    

        /// <summary>
        /// Allocates and fills a matrix of natural dimensions with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The range of potiential random values</param>
        /// <param name="m">The natural number of rows</param>
        /// <param name="n">The natural number of columns</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> Matrix<M,N,T>(this IPolyrand random, Interval<T> domain, M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
                => Z0.Matrix.Load<M,N,T>(random.Array<T>(Z0.Matrix<M,N,T>.CellCount, domain));                    
               
        /// <summary>
        /// Samples a square matrix of natural order
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The min random value</param>
        /// <param name="max">The max random value</param>
        /// <param name="transformer">The max random value</param>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N,T> Matrix<N,T>(this IPolyrand random, N n, T min, T max)
            where N : ITypeNat, new()
            where T : unmanaged   
                => Z0.Matrix.Load<N,T>(random.Array<T>(Z0.Matrix<N,T>.CellCount, (min,max)));                    

         /// <summary>
         /// Samples values over an S-domain, transforms the sample into a T-domain and from this transformed
         /// sample constructs a matrix of natural dimensions
         /// </summary>
         /// <param name="random">The random source</param>
         /// <param name="domain">The sample domain</param>
         /// <param name="m">The row count</param>
         /// <param name="n">The column count</param>
         /// <param name="rep">A scalar representative</param>
         /// <typeparam name="M">The row type</typeparam>
         /// <typeparam name="N">The column type</typeparam>
         /// <typeparam name="S">The sample type</typeparam>
         /// <typeparam name="T">The matrix element type</typeparam>
         [MethodImpl(Inline)]
         static Matrix<M,N,T> Matrix<M,N,S,T>(this IPolyrand random, Interval<S>? domain = null, M m = default, N n = default,  T rep = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
            where S : unmanaged
                => random.Matrix<M,N,S>(domain).Convert<T>();
 
         /// <summary>
         /// Samples values over an S-domain, transforms the sample into a T-domain and from this transformed
         /// sample constructs a square matrix of natural order
         /// </summary>
         /// <param name="random">The random source</param>
         /// <param name="domain">The sample domain</param>
         /// <param name="m">The row count</param>
         /// <param name="n">The column count</param>
         /// <param name="rep">A scalar representative</param>
         /// <typeparam name="N">The order type type</typeparam>
         /// <typeparam name="S">The sample type</typeparam>
         /// <typeparam name="T">The matrix element type</typeparam>
         [MethodImpl(Inline)]
         static Matrix<N,T> Matrix<N,S,T>(this IPolyrand random, Interval<S> domain, N n = default,  T rep = default)
            where N : ITypeNat, new()
            where T : unmanaged    
            where S : unmanaged
                => random.Matrix<N,S>(new N(), domain.Left, domain.Right).Convert<T>();

         /// <summary>
         /// Samples 32-bit integers that are converted to 32-bit floats to populate a square matrix
         /// </summary>
         /// <param name="random">The random source</param>
         /// <param name="n">The matrix order</param>
         /// <param name="min">The minimum entry value</param>
         /// <param name="min">The maximum entry value</param>
         /// <typeparam name="N">The matrix order type</typeparam>
         /// <typeparam name="S">The sample type</typeparam>
         /// <typeparam name="T">The matrix element type</typeparam>
         [MethodImpl(Inline)]
         public static Matrix<N,float> MatrixF32<N,S>(this IPolyrand random, S? min = null, S? max = null, N n = default)
            where S : unmanaged
            where N : ITypeNat, new()
                => random.Matrix<N,S, float>(closed(min ?? TypeMin<S>(), max ?? TypeMax<S>()));

        /// <summary>
        /// Samples source values of type S to populate a matrix of natural dimensions with 64-bit floating point entries
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="min">The maximum entry value</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        [MethodImpl(Inline)]
        public static  Matrix<N,double> MatrixF64<N,S>(this IPolyrand random, S? min = null, S? max = null, N n = default)
            where S : unmanaged
            where N : ITypeNat, new()
                => random.Matrix<N,S, double>(closed(min ?? TypeMin<S>(), max ?? TypeMax<S>()));

        /// <summary>
        /// Samples source values of type S to populate a matrix of natural dimensions with 32-bit floating point entries
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="max">The maximum entry value</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="M">The col count type</typeparam>
        /// <typeparam name="N">The row count type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,float> MatrixF32<M,N,S>(this IPolyrand random, S? min = null, S? max = null, M m = default,  N n = default)
            where S : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => random.Matrix<M,N,S, float>(closed(min ?? TypeMin<S>(), max ?? TypeMax<S>()));

        /// <summary>
        /// Samples source values of type S to populate a matrix of natural dimensions with 64-bit floating point entries
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="max">The maximum entry value</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="M">The col count type</typeparam>
        /// <typeparam name="N">The row count type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,double> MatrixF64<M,N,S>(this IPolyrand random, S? min = null, S? max = null, M m = default,  N n = default)
            where S : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => random.Matrix<M,N,S, double>(closed(min ?? TypeMin<S>(), max ?? TypeMax<S>()));
    }
}