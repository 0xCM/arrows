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
        /// Computes an LU factorization of a general M-by-N matrix A using partial pivoting with row interchanges.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="X"></param>
        /// <param name="P"></param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static ref Matrix<M,N,double> getrf<M,N>(Matrix<M,N,double> A, Span<int> P, ref Matrix<M,N,double> X)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var lda = n;
            
            A.CopyTo(ref X);
            var exit = LAPACK.LAPACKE_dgetrf(RowMajor, m, n, ref head(X), lda, ref head(P));
            ThrowOnError(exit);
            
            return ref X;
        }

        /// <summary>
        /// Computes an LU factorization of an N-square matrix A using partial pivoting with row interchanges.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="X"></param>
        /// <param name="P"></param>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static ref Matrix<N,double> getrf<N>(Matrix<N,double> A, Span<int> P, ref Matrix<N,double> X)
            where N : ITypeNat, new()
        {
            var n = nati<N>();
            var lda = n;
            
            A.CopyTo(ref X);
            var exit = LAPACK.LAPACKE_dgetrf(RowMajor, n, n, ref head(X), lda, ref head(P));
            ThrowOnError(exit);
            
            return ref X;
        }


    }

}