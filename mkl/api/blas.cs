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

        [MethodImpl(Inline)]
        public static double dot(Span<float> x, Span<float> y)        
            => CBLAS.cblas_sdot(length(x,y), ref x[0], 1, ref y[0], 1);

        [MethodImpl(Inline)]
        public static double dot(Span<double> x, Span<double> y)        
            => CBLAS.cblas_ddot(length(x,y), ref x[0], 1, ref y[0], 1);
        
        [MethodImpl(Inline)]
        public static double asum(Span<float> x)        
            => CBLAS.cblas_sasum(x.Length, ref x[0], 1);

        [MethodImpl(Inline)]
        public static double asum(Span<double> x)        
            => CBLAS.cblas_dasum(x.Length, ref x[0], 1);

        [MethodImpl(Inline)]
        public static float asum(Span<ComplexF32> x)        
            => CBLAS.cblas_scasum(x.Length, ref x[0], 1);

        [MethodImpl(Inline)]
        public static double asum(Span<ComplexF64> x)        
            => CBLAS.cblas_dzasum(x.Length, ref x[0], 1);
                
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

        

    }

}
