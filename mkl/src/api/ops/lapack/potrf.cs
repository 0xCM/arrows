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
       public static bool potrf<N>(BlockMatrix<N,float> A, TriangularKind tk = TriangularKind.Lower)
            where N : ITypeNat, new()
        {
            var n = nati<N>();
            var lda = n;
            var lu = tk == TriangularKind.Lower ? 'L' : 'U';

            var exitcode = LAPACK.LAPACKE_spotrf(RowMajor, lu, n, ref head(A), lda);

            if (exitcode > 0)
                return false;
            else if(exitcode == 0)
                return true;
            else            
                throw MklException.Define(exitcode);
        }

        /// <summary>
        /// Attempts to use the cholesky algorithm to factor a square matrix as either
        /// A = L*Transpose(L)  or A = Transpose(U)*U according to whether the tk parameter
        /// respectively specifies Lower or Upper triangulation.
        /// </summary>
        /// <param name="A">The matrix to factor and the matrix that receives the results</param>
        /// <param name="tk">The triangular classification</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        public static bool potrf<N>(BlockMatrix<N,double> A, TriangularKind tk = TriangularKind.Lower)
            where N : ITypeNat, new()
        {
            var n = nati<N>();
            var lda = n;
            var lu = tk == TriangularKind.Lower ? 'L' : 'U';
            
            var exitcode = LAPACK.LAPACKE_dpotrf(RowMajor, lu, n, ref head(A), lda);
            
            if (exitcode > 0)
                return false;
            else if(exitcode == 0)
                return true;
            else            
                throw MklException.Define(exitcode);
        }

        /// <summary>
        /// Returns true if the matrix is positive-definite, false otherwise
        /// </summary>
        /// <param name="A"></param>
        /// <typeparam name="N">The square dimenion type</typeparam>
        public static bool posdef<N>(BlockMatrix<N,float> A)
            where N : ITypeNat, new()
                => potrf<N>(A.Replicate());        

        /// <summary>
        /// Returns true if the matrix is positive-definite, false otherwise
        /// </summary>
        /// <param name="A"></param>
        /// <typeparam name="N">The square dimenion type</typeparam>
        public static bool posdef<N>(BlockMatrix<N,double> A)
            where N : ITypeNat, new()
                => potrf<N>(A.Replicate());        
 


    }


}