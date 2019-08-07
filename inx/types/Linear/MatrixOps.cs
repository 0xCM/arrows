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

    public static class MatrixOps
    {
        /// <summary>
        /// Allocates and computes a matrix X = AB of natural dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,float> Mul<M,K,N>(this Matrix<M,K,float> A, Matrix<K,N,float> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
                => Matrix.Load<M,N,float>(mkl.gemm<M,K,N>(A.Unsized, B.Unsized));

        /// <summary>
        /// Allocates and computes a matrix X = AB of natural dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,double> Mul<M,K,N>(this Matrix<M,K,double> A, Matrix<K,N,double> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
                => Matrix.Load<M,N,double>(mkl.gemm<M,K,N>(A.Unsized,B.Unsized));

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

}