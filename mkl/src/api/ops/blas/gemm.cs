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
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> gemm<M,K,N,T>(BlockMatrix<M,K,T> A, BlockMatrix<K,N,T> B, ref BlockMatrix<M,N,T> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            if(typeof(T) == typeof(float))
            {
                var Z = X.As<float>();
                gemm(A.As<float>(), B.As<float>(), ref Z);
            }
            else if(typeof(T) == typeof(double))
            {
                var x = X.As<double>();
                gemm(A.As<double>(), B.As<double>(), ref x);
            }                            
            else if(typeof(T) == typeof(int)|| typeof(T) == typeof(uint) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();            
            }            
            else if(typeof(T) == typeof(long) || typeof(T) == typeof(ulong))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();
            }
            else if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte) )
            {
                var Z = X.Convert<float>();
                X = gemm(A.Convert<float>(), B.Convert<float>(), ref Z).Convert<T>();
            }
            return ref X;
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static ref BlockMatrix<N,T> gemm<N,T>(BlockMatrix<N,T> A, BlockMatrix<N,T> B, ref BlockMatrix<N,T> X)
            where N : ITypeNat, new()
            where T : struct
        {
            if(typeof(T) == typeof(float))
            {
                var Z = X.As<float>();
                gemm(A.As<float>(), B.As<float>(), ref Z);
            }
            else if(typeof(T) == typeof(double))
            {
                var x = X.As<double>();
                gemm(A.As<double>(), B.As<double>(), ref x);
            }                            
            else if(typeof(T) == typeof(int)|| typeof(T) == typeof(uint) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();            
            }            
            else if(typeof(T) == typeof(long) || typeof(T) == typeof(ulong))
            {
                var Z = X.Convert<double>();
                X = gemm(A.Convert<double>(), B.Convert<double>(), ref Z).Convert<T>();
            }
            else if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte) )
            {
                var Z = X.Convert<float>();
                X = gemm(A.Convert<float>(), B.Convert<float>(), ref Z).Convert<T>();
            }
            return ref X;
        }

        /// <summary>
        /// Allocates a target matrix and populates it with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static BlockMatrix<M,N,float> gemm<M,K,N>(BlockMatrix<M,K,float> A, BlockMatrix<K,N,float> B)
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
            var X = BlockMatrix.Alloc<M,N,float>();
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
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
        public static BlockMatrix<M,N,double> gemm<M,K,N>(BlockMatrix<M,K,double> A, BlockMatrix<K,N,double> B)
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
            var X = BlockMatrix.Alloc<M,N,double>();
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1.0f, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
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
        public static ref BlockMatrix<M,N,float> gemm<M,K,N>(BlockMatrix<M,K,float> A, BlockMatrix<K,N,float> B, ref BlockMatrix<M,N,float> X)
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
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1f, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
            return ref X;
        }

        /// <summary>
        /// Populates a target matrix with the product of the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
        public static ref BlockMatrix<M,N,double> gemm<M,K,N>(BlockMatrix<M,K,double> A, BlockMatrix<K,N,double> B, ref BlockMatrix<M,N,double> X)
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
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, m, n, k, 1d, ref head(A), lda, ref head(B), ldb, 0, ref head(X), ldx);
            return ref X;
        }

        /// <summary>
        /// Computes the product of square metrices X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">The target matrix</param>
		/// <param name="N">The number of columns in B and C</param>
        public static ref BlockMatrix<N,float> gemm<N>(BlockMatrix<N,float> A, BlockMatrix<N,float> B, ref BlockMatrix<N,float> X)
            where N : ITypeNat, new()
        {
            var n = nati<N>();
            var ld = n;
            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose, n, n, n, 1, ref head(A), ld, ref head(B), ld, 0, ref head(X), ld);
            return ref X;
        }

        /// <summary>
        /// Computes the product of square metrices X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">The target matrix</param>
		/// <param name="N">The number of columns in B and C</param>
        public static ref BlockMatrix<N,double> gemm<N>(BlockMatrix<N,double> A, BlockMatrix<N,double> B, ref BlockMatrix<N,double> X)
            where N : ITypeNat, new()
        {
            var n = nati<N>();
            var ld = n;
            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose, n, n, n, 1, ref head(A), ld, ref head(B), ld, 0, ref head(X), ld);
            return ref X;
        }
    }
}
