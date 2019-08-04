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

        const CBLAS_TRANSPOSE NoTranspose = CBLAS_TRANSPOSE.CblasNoTrans;
        
        const CBLAS_LAYOUT RowMajor = CBLAS_LAYOUT.CblasRowMajor;

        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static double dot(Span<float> x, Span<float> y)        
            => CBLAS.cblas_sdot(length(x,y), ref x[0], 1, ref y[0], 1);

        [MethodImpl(Inline)]
        public static double dot(Span<double> lhs, Span<double> rhs)        
            => CBLAS.cblas_ddot(length(lhs,rhs), ref lhs[0], 1, ref rhs[0], 1);
        
        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="src">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(Span<float> src)        
            => CBLAS.cblas_sasum(src.Length, ref src[0], 1);
        
        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="src">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(Span<double> src)        
            => CBLAS.cblas_dasum(src.Length, ref src[0], 1);

        [MethodImpl(Inline)]
        public static float asum(Span<ComplexF32> x)        
            => CBLAS.cblas_scasum(x.Length, ref x[0], 1);

        [MethodImpl(Inline)]
        public static double asum(Span<ComplexF64> x)        
            => CBLAS.cblas_dzasum(x.Length, ref x[0], 1);
                
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
            var ldc = n;
            var dst = NatSpan.alloc<M,N,float>();

            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose,            
                m, n, k, 1.0f, ref A[0], lda, ref B[0], ldb, 0, ref dst[0], ldc);
            return dst;
        }    

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
            var dst = Span256.alloc<float>(Span256.blocks<float>(nati<M>()*nati<N>()));

            CBLAS.cblas_sgemm(RowMajor, NoTranspose, NoTranspose,            
                m, n, k, 1.0f, ref A[0], lda, ref B[0], ldb, 0, ref dst[0], ldc);
            return dst;
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
            var ldc = n;
            var dst = NatSpan.alloc<M,N,double>();

            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose,            
                m, n, k, 1.0, ref A[0], lda, ref B[0], ldb, 0, ref dst[0], ldc);
            return dst;
        }

        
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
            var dst = Span256.alloc<double>(Span256.blocks<double>(nati<M>()*nati<N>()));

            CBLAS.cblas_dgemm(RowMajor, NoTranspose, NoTranspose,            
                m, n, k, 1.0, ref A[0], lda, ref B[0], ldb, 0, ref dst[0], ldc);
            return dst;
        }

    }
}
