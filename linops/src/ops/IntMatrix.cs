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

    using static zfunc;
    using static nfunc;

    public static class IntMatrix
    {
        [MethodImpl(Inline)]
        public static ref Matrix<N,T> add<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            gmath.add(A.Span, B.Span, C.Span);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<N,T> sub<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            gmath.sub(A.Span, B.Span, C.Span);
            return ref C;
        }

        public static ref Matrix<N,T> mul<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var tB = B.Transpose();
            for(var i=0; i<A.RowCount; i++)
            for(var j=0; j<B.ColCount; j++)
                C[i,j] = A[i] * tB[j];
            return ref C;
        }

        public static ref Matrix<M,N,T> mul<M,P,N,T>(Matrix<M,P,T> A, Matrix<P,N,T> B, ref Matrix<M,N,T> C)
            where M : ITypeNat, new()
            where P : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var tB = B.Transpose();
            for(var i=0; i<A.RowCount; i++)
            for(var j=0; j<B.ColCount; j++)
                C[i,j] = A[i] * tB[j];
            return ref C;
        }

    }

}