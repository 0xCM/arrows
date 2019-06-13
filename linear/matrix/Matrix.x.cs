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
        
    using static zfunc;
    using static nfunc;

    public static class MatrixX
    {

        public static bool Eq<M,N,T>(this Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => Matrix.eq(lhs,rhs);

        public static bool NEq<M,N,T>(this Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => Matrix.neq(lhs,rhs);

        public static Matrix<M,N,T> Random<M,N,T>(this IRandomSource random)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                =>  random.Span<M,N,T>();

    }
}