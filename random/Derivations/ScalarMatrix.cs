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
        /// Samples a random matrix of natural order
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

    }

}