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
        public static Matrix<M,P,float> Mul<M,N,P>(this Matrix<M,N,float> lhs, Matrix<N,P,float> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
                => Matrix.Load<M,P,float>(mkl.gemm<M,N,P>(lhs.Data,rhs.Data));

        [MethodImpl(Inline)]
        public static Matrix<M,P,double> Mul<M,N,P>(this Matrix<M,N,double> lhs, Matrix<N,P,double> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
                => Matrix.Load<M,P,double>(mkl.gemm<M,N,P>(lhs.Data,rhs.Data));


        [MethodImpl(Inline)]
        public static ref Matrix<M,P,double> Mul<M,N,P>(this Matrix<M,N,double> lhs, Matrix<N,P,double> rhs, ref Matrix<M,P, double> dst)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
        {
            mkl.gemm<M,N,P>(lhs.Data,rhs.Data, dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<M,P,float> Mul<M,N,P>(this Matrix<M,N,float> lhs, Matrix<N,P,float> rhs, ref Matrix<M,P, float> dst)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
        {
            mkl.gemm<M,N,P>(lhs.Data,rhs.Data, dst.Data);
            return ref dst;
        }

    }

}