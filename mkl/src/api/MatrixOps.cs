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
        public static BlockMatrix<M,N,float> Mul<M,K,N>(this BlockMatrix<M,K,float> A, BlockMatrix<K,N,float> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
                => BlockMatrix.Load<M,N,float>(mkl.gemm<M,K,N>(A.Unsized, B.Unsized));

        /// <summary>
        /// Allocates and computes a matrix X = AB of natural dimension MxN 
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="M">The A row count type</typeparam>
        /// <typeparam name="K">The A colum count / B row count type</typeparam>
        /// <typeparam name="N">The B column count type</typeparam>
        [MethodImpl(Inline)]
        public static BlockMatrix<M,N,double> Mul<M,K,N>(this BlockMatrix<M,K,double> A, BlockMatrix<K,N,double> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
                => BlockMatrix.Load<M,N,double>(mkl.gemm<M,K,N>(A.Unsized, B.Unsized));

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
        public static ref BlockMatrix<M,N,float> Mul<M,K,N>(this BlockMatrix<M,K,float> A, BlockMatrix<K,N,float> B, ref BlockMatrix<M,N, float> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            mkl.gemm<M,K,N>(A, B, ref X);
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
        public static ref BlockMatrix<M,N,double> Mul<M,K,N>(this BlockMatrix<M,K,double> A, BlockMatrix<K,N,double> B, ref BlockMatrix<M,N,double> X)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where K : ITypeNat, new()
        {
            mkl.gemm(A, B, ref X);   
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
        public static ref BlockMatrix<N,float> Mul<N>(this BlockMatrix<N,float> A, BlockMatrix<N,float> B, ref BlockMatrix<N, float> X)
            where N : ITypeNat, new()
        {
            mkl.gemm(A, B, ref X);
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
        public static ref BlockMatrix<N,double> Mul<N>(this BlockMatrix<N,double> A, BlockMatrix<N,double> B, ref BlockMatrix<N, double> X)
            where N : ITypeNat, new()
        {
            mkl.gemm(A, B, ref X);
            return ref X;
        }
        
        [MethodImpl(Inline)]
        public static BlockMatrix<N,T> Map<N,S,T>(this BlockMatrix<N,S> A, Func<S,T> f)
            where N : ITypeNat, new()
            where T : struct
            where S : struct
        {
            var src = A.Unblocked;
            var dstM = BlockMatrix.Alloc<N,T>();
            var dst = dstM.Unblocked;
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(src[i]);
            return dstM;
        }

        public static BlockMatrix<N,double> Pow<N>(this BlockMatrix<N,double> A, int exp)
            where N : ITypeNat, new()
        {
            if(exp == 1)
                return A;

            var B = A.Replicate();
            var X = BlockMatrix.Alloc<N,double>();
            mkl.gemm(A,B,ref X);
            if(exp == 2)
                return X;

            var i = exp;
            while(--i > 2)
                mkl.gemm(X,X,ref X);    
            
            return X;                        
        }

    }


}