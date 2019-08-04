//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    using Z0.Mkl;

    public static class CovectorX
    {

        [MethodImpl(Inline)]
        public static Matrix<M,P,double> Mul<M,N,P>(this Matrix<M,N,double> lhs, Matrix<N,P,double> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
                => Matrix.Load<M,P,double>(mkl.gemm<M,N,P>(lhs.Data,rhs.Data));

    }
}