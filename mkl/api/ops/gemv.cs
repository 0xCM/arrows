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


    public static partial class mkl
    {

        /// <summary>
        /// Computes the matrix-vector product y = A*x;
        /// </summary>
        /// <param name="A">A source matrix of dimension MxN</param>
        /// <param name="x">A source vector of length N</param>
        /// <param name="y">A target vector of length M</param>
        /// <typeparam name="M">The row dimension type of A</typeparam>
        /// <typeparam name="N">The column dimension type of A</typeparam>
        public static ref Vector<M,double> gemv<M,N>(Matrix<M,N,double> A, Vector<N,double> x, ref Vector<M,double> y)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var lda = n;
            CBLAS.cblas_dgemv(RowMajor, NoTranspose, m, n, alpha: 1.0, ref head(A), lda, ref head(x), incX: 1, beta: 0, ref head(y), incY: 1);
            return ref y;
        }

        /// <summary>
        /// Computes the matrix-vector product y = A*x;
        /// </summary>
        /// <param name="A">A source matrix of dimension MxN</param>
        /// <param name="x">A source vector of length N</param>
        /// <param name="y">A target vector of length M</param>
        /// <typeparam name="M">The row dimension type of A</typeparam>
        /// <typeparam name="N">The column dimension type of A</typeparam>
        public static ref Vector<M,float> gemv<M,N>(Matrix<M,N,float> A, Vector<N,float> x, ref Vector<M,float> y)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var lda = n;
            CBLAS.cblas_sgemv(RowMajor, NoTranspose, m, n, alpha: 1f, ref head(A), lda, ref head(x), incX: 1, beta: 0, ref head(y), incY: 1);
            return ref y;
        }
    }

}