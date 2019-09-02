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

    partial class RngX
    {
        /// <summary>
        /// Samples a random matrix of natural dimensions
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static Matrix<M,N,T> Matrix<M,N,T>(this IPolyrand random, Interval<T>? domain = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => Z0.Matrix.Load<M,N,T>(random.Span256<T>(Z0.Span256.MinBlocks<M,N,T>(), domain));                    

         public static Matrix<M,N,T> Matrix<M,N,T>(this IPolyrand random, Interval<T> domain, M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => Z0.Matrix.Load<M,N,T>(random.Span256<T>(Z0.Span256.MinBlocks<M,N,T>(), domain));                    
               
        /// <summary>
        /// Samples a square matrix of natural order
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static Matrix<N,T> Matrix<N,T>(this IPolyrand random, Interval<T>? domain = null, Func<T,T> transformer = null)
            where N : ITypeNat, new()
            where T : struct   
        {                 
            var data = random.Span256<T>(Z0.Span256.MinBlocks<N,N,T>(), domain);
            if(transformer != null)
                for(var i=0; i<data.Length; i++)
                    data[i] = transformer(data[i]);
            return Z0.Matrix.Load<N,T>(data);                    
        }

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
          public static Matrix<M,N,T> Matrix<M,N,S,T>(this IPolyrand random, Interval<S>? domain = null, M m = default, N n = default,  T rep = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
            where S : struct
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
          public static Matrix<N,T> Matrix<N,S,T>(this IPolyrand random, Interval<S>? domain = null, N n = default,  T rep = default)
            where N : ITypeNat, new()
            where T : struct    
            where S : struct
                => random.Matrix<N,S>(domain).Convert<T>();

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
         public static Matrix<N,float> MatrixF32<N,S,T>(this IPolyrand random, int? min = null, int? max = null, N n = default)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => random.Matrix<N,int, float>(closed(min ?? -25, max ?? 25));

        /// <summary>
        /// Samples 64-bit integers that are converted to 64-bit floats to populate a square matrix
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="min">The maximum entry value</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        /// <typeparam name="T">The matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static  Matrix<N,double> MatrixF64<N,S,T>(this IPolyrand random, long? min = null, long? max = null, N n = default)
            where T : struct
            where S : struct
            where N : ITypeNat, new()
                => random.Matrix<N,long, double>(closed(min ?? -25L, max ?? 25L));

        /// <summary>
        /// Samples 32-bit integers that are converted to 32-bit floats to populate a matrix of natural dimensions
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="max">The maximum entry value</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="N">The row count type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        /// <typeparam name="T">The matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,float> MatrixF32<M,N,S,T>(this IPolyrand random, int? min = null, int? max = null, M m = default, N n = default)
            where T : struct
            where S : struct
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => random.Matrix<M,N,int, float>(closed(min ?? -25, max ?? 25));

        /// <summary>
        /// Samples 64-bit integers that are converted to 64-bit floats to populate a matrix of natural dimensions
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum entry value</param>
        /// <param name="max">The maximum entry value</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="N">The row count type</typeparam>
        /// <typeparam name="S">The sample type</typeparam>
        /// <typeparam name="T">The matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,double> MatrixF64<M,N,S,T>(this IPolyrand random, long? min = null, long? max = null, M m = default,  N n = default)
            where T : struct
            where S : struct
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => random.Matrix<M,N,long, double>(closed(min ?? -25L, max ?? 25L));

    }

}