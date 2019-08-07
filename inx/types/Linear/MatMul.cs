//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;
    using Z0.Mkl;        

    using static zfunc;
    using static nfunc;

    public static class MatMulx
    {
        [MethodImpl(Inline)]
        public static Matrix<M,N,float> Mul<M,K,N>(this Matrix<M,K,float> lhs, Matrix<K,N,float> rhs)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
                => Matrix.Load<M,N,float>(mkl.gemm<M,K,N>(lhs.Unsized,rhs.Unsized));

        [MethodImpl(Inline)]
        public static Matrix<M,N,double> Mul<M,K,N>(this Matrix<M,K,double> lhs, Matrix<K,N,double> rhs)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
                => Matrix.Load<M,N,double>(mkl.gemm<M,K,N>(lhs.Unsized,rhs.Unsized));

        /// <summary>
        /// Computes the matrix product X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,float> Mul<M,K,N>(this Matrix<M,K,float> A, Matrix<K,N,float> B, ref Matrix<M,N, float> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            mkl.gemm<M,K,N>(A, B, X);
            return ref X;
        }

        /// <summary>
        /// Computes the matrix product X = AB
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,double> Mul<M,K,N>(this Matrix<M,K,double> A, Matrix<K,N,double> B, ref Matrix<M,N,double> X)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where K : ITypeNat, new()
        {
            mkl.gemm<M,K,N>(A, B, X);   
            return ref X;
        }

    }

    public static class MatMul
    {
        public static T DotSlow<N,T>(Span<N,T> X, Span<N,T> Y)
            where N : ITypeNat, new()
            where T : struct
        {
            var result = default(T);
            for(var i=0; i< nati<N>(); i++)
                result = gmath.add(gmath.mul(X[i],Y[i]), result);
            return result;
        }

        public static void MulSlow<M,K,N,T>(Matrix<M,K,T> A, Matrix<K,N,T> B, Matrix<M,N,T> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i = 0; i< m; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = DotSlow<K,T>(A.Row(i), B.Col(j));                    
        }

        public static Matrix<M,N,T> MulSlow<M,K,N,T>(Matrix<M,K,T> A, Matrix<K,N,T> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var X = Matrix.Alloc<M,N,T>();
            MulSlow(A,B, X);
            return X;
        }

        public static void MulSlow<M,K,N,T>(Span<M,K,T> A, Span<K,N,T> B, Span<M,N,T> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i = 0; i< m; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = DotSlow(A.Row(i), B.Col(j));                    
        }

    }

}