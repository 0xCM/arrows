//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static nfunc;

    partial class mkl
    {

        /// <summary>
        /// Computes the scalar product between two vectors of natural length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static float dot<N>(BlockVector<N,float> x, BlockVector<N,float> y)
            where N : ITypeNat, new()
                => dot(x.Unsized, y.Unsized);

        /// <summary>
        /// Computes the scalar product between two vectors of natural length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot<N>(BlockVector<N,double> x, BlockVector<N,double> y)
            where N : ITypeNat, new()
                => dot(x.Unsized, y.Unsized);

        /// <summary>
        /// Computes the scalar product between two vectors that are hopefully of the same length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static float dot(BlockVector<float> x, BlockVector<float> y)
            => dot(x.Unblocked, y.Unblocked);

        /// <summary>
        /// Computes the scalar product between two vectors that are hopefully of the same length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot(BlockVector<double> x, BlockVector<double> y)
            => dot(x.Unblocked, y.Unblocked);

        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        static float dot(Span<float> X, Span<float> Y)        
            => CBLAS.cblas_sdot(length(X,Y), ref head(X), 1, ref head(Y), 1);

        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        static double dot(Span<double> X, Span<double> Y)        
            => CBLAS.cblas_ddot(length(X,Y), ref head(X), 1, ref head(Y), 1);

    }

}