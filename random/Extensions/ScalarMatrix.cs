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
        /// Creates a random matrix of natural dimensions
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The column Type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static Matrix<M,N,T> Matrix<M,N,T>(this IRandomSource random)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
          {
                var fullblocks = Z0.Span256.blocks<T>(nati<M>()*nati<N>(), out int remainder);
                var blocks = remainder == 0 ? fullblocks : fullblocks + 1;
                return Z0.Matrix.Load<M,N,T>(random.Span256<T>(blocks));                    
          }                

        /// <summary>
        /// Creates a square matrix of natural dimension
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static Matrix<N,N,T> Matrix<N,T>(this IRandomSource random)
            where N : ITypeNat, new()
            where T : struct    
                => Z0.Matrix.Load<N,N,T>(random.Span256<T>(Z0.Span256.minblocks<N,N,T>()));                    

    }

}