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

    ref struct MatrixProducInfo<M,K,N>
        where M : ITypeNat, new()
        where K : ITypeNat, new()
        where N : ITypeNat, new()
    {

        public int m;

        public int k;

        public int n;

        public int lda;

        public int ldb;

        public int ldx;
    }

    static class MatrixProductInfo
    {
        public static MatrixProducInfo<M,K,N> mpi<M,K,N>()
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var info = new MatrixProducInfo<M,K,N>();
            info.m = nati<M>();
            info.k = nati<K>();
            info.n = nati<N>();
            info.lda = info.k;
            info.ldb = info.n;
            info.ldx = info.n;
            return info;
        }
    }


    public static partial class mkl
    {
        const CBLAS_TRANSPOSE NoTranspose = CBLAS_TRANSPOSE.CblasNoTrans;
        
        const CBLAS_LAYOUT RowMajor = CBLAS_LAYOUT.CblasRowMajor;

        /// <summary>
        /// Allocates a target matrix and populates it with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static Span<M,N,float> gemm<M,K,N>(Span<M,K,float> A, Span<K,N,float> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            var X = NatSpan.alloc<M,N,float>();
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref A[0], lda, ref B[0], ldb, 0, ref X[0], ldx);
            return X;
        }    

        /// <summary>
        /// Allocates a target matrix and populates it with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static Span<M,N,double> gemm<M,K,N>(Span<M,K,double> A, Span<K,N,double> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            var X = NatSpan.alloc<M,N,double>();
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0, ref A[0], lda, ref B[0], ldb, 0, ref X[0], ldx);
            return X;
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static void gemm<M,K,N>(Span<M,K,float> A, Span<K,N,float> B, Span<M,N,float> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1f, ref A[0], lda, ref B[0], ldb, 0, ref X[0], ldx);
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static void gemm<M,K,N>(Span<M,K,double> A, Span<K,N,double> B, Span<M,N,double> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldx = n;
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1d, ref A[0], lda, ref B[0], ldb, 0, ref X[0], ldx);
        }

        /// <summary>
        /// Allocates and computes an matrix X = AB of dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix of dimension MxK</param>
        /// <param name="B">The right matrix of dimension KxN</param>
        /// <typeparam name="M">The natural dimension type that specifies the number of rows in A</typeparam>
        /// <typeparam name="K">The natural dimension type that specifies the number of columns in A and rows in B</typeparam>
        /// <typeparam name="N">The natural dimension type that specifies the number of columns in B</typeparam>
        public static Span256<float> gemm<M,K,N>(Span256<float> A, Span256<float> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldc = n;
            var dst = Span256.alloc<float>(Span256.blocks<float>(m*n));
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref A[0], lda, ref B[0], ldb, 0, ref dst[0], ldc);
            return dst;
        }

        /// <summary>
        /// Allocates and computes an matrix X = AB  of dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix of dimension MxK</param>
        /// <param name="B">The right matrix of dimension KxN</param>
        /// <typeparam name="M">The natural dimension type that specifies the number of rows in A</typeparam>
        /// <typeparam name="K">The natural dimension type that specifies the number of columns in A and rows in B</typeparam>
        /// <typeparam name="N">The natural dimension type that specifies the number of columns in B</typeparam>
        public static Span256<double> gemm<M,K,N>(Span256<double> A, Span256<double> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldc = n;
            var dst = Span256.alloc<double>(Span256.blocks<double>(m*n));
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0, ref A[0], lda, ref B[0], ldb, 0, ref dst[0], ldc);
            return dst;
        }

        /// <summary>
        /// Computes a matrix X = AB of dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix of dimension MxK</param>
        /// <param name="B">The right matrix of dimension KxN</param>
        /// <typeparam name="M">The natural dimension type that specifies the number of rows in A</typeparam>
        /// <typeparam name="K">The natural dimension type that specifies the number of columns in A and rows in B</typeparam>
        /// <typeparam name="N">The natural dimension type that specifies the number of columns in B</typeparam>
        public static void gemm<M,K,N>(Span256<float> A, Span256<float> B, Span256<float> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldc = n;
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref A[0], lda, ref B[0], ldb, 0, ref X[0], ldc);
        }

        public static void gemm<M,K,N>(Span256<double> a, Span256<double> b, Span256<double> dst)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var k = nati<K>();
            var n = nati<N>();
            var lda = k;
            var ldb = n;
            var ldc = n;
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0, ref a[0], lda, ref b[0], ldb, 0, ref dst[0], ldc);
        }

    }
}
