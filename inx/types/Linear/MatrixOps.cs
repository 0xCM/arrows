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
    using System.Runtime.InteropServices;    
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
                => Matrix.Load<M,N,double>(mkl.gemm<M,K,N>(A.Unsized, B.Unsized));

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

        /// <summary>
        /// Computes the product of square matrices of natural dimension
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="N">The common order of all matrices</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N,float> Mul<N>(this Matrix<N,float> A, Matrix<N,float> B, ref Matrix<N, float> X)
            where N : ITypeNat, new()
        {
            mkl.gemm<N,N,N>(A, B, X);
            return ref X;
        }

        /// <summary>
        /// Computes the product of square matrices of natural dimension
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="X">Tht target matrix</param>
        /// <typeparam name="N">The common order of all matrices</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N,double> Mul<N>(this Matrix<N,double> A, Matrix<N,double> B, ref Matrix<N, double> X)
            where N : ITypeNat, new()
        {
            mkl.gemm<N,N,N>(A, B, X);
            return ref X;
        }
        
        [MethodImpl(Inline)]
        public static Matrix<N,T> Map<N,S,T>(this Matrix<N,S> A, Func<S,T> f)
            where N : ITypeNat, new()
            where T : struct
            where S : struct
        {
            var src = A.Unblocked;
            var dstM = Matrix.Alloc<N,T>();
            var dst = dstM.Unblocked;
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(src[i]);
            return dstM;
        }

        public static Matrix<N,double> Pow<N>(this Matrix<N,double> A, int exp)
            where N : ITypeNat, new()
        {
            if(exp == 1)
                return A;

            var B = A.Replicate();
            var X = Matrix.Alloc<N,double>();
            mkl.gemm<N,N,N>(A,B,X);
            if(exp == 2)
                return X;

            var i = exp;
            while(--i > 2)
                mkl.gemm<N,N,N>(X,X,X);    
            
            return X;                        
        }

    }


}