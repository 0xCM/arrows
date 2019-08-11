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
         public static Matrix<M,N,T> Matrix<M,N,T>(this IRandomSource random, Interval<T>? domain = null)
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
         public static Matrix<N,T> Matrix<N,T>(this IRandomSource random, Interval<T>? domain = null, Func<T,T> transformer = null)
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
          public static Matrix<M,N,T> Matrix<M,N,S,T>(this IRandomSource random, Interval<S>? domain = null, M m = default, N n = default,  T rep = default)
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
          public static Matrix<N,T> Matrix<N,S,T>(this IRandomSource random, Interval<S>? domain = null, N n = default,  T rep = default)
            where N : ITypeNat, new()
            where T : struct    
            where S : struct
                => random.Matrix<N,S>(domain).Convert<T>();
 
    }

}