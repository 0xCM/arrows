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

    /// <summary>
    /// Defines reference operations related to matrix/vector multiplication
    /// </summary>
    public static class MatrixRefOps
    {
        public static Span<M,P,double> Mul<M,N,P>(Span<M,N,double> lhs, Span<N,P,double> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var p = nati<P>();
            var dst = NatSpan.Alloc<M,P,double>();
            for(var r = 0; r< m; r++)
                for(var c = 0; c < p; c++)
                    for(var i=0; i<nati<N>(); i++)
                        dst[r,c] += lhs[r,i] * rhs[i,c];
                                    
            return dst;
        }

        public static ref Matrix<N,T> Mul<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> X)
            where N : ITypeNat, new()
            where T : struct
        {
            var n = nati<N>();
            for(var i = 0; i< n; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = Linear.dot(A.Row(i), B.Col(j));                    
            return ref X;
        }


        public static ref Matrix<M,N,T> Mul<M,K,N,T>(Matrix<M,K,T> A, Matrix<K,N,T> B, ref Matrix<M,N,T> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i = 0; i< m; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = Linear.dot(A.GetRow(i), B.GetCol(j));         
            return ref X;           
        }

        public static Matrix<M,N,T> Mul<M,K,N,T>(Matrix<M,K,T> A, Matrix<K,N,T> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var X = Matrix.Alloc<M,N,T>();
            Mul(A,B, ref X);
            return X;
        }

        public static void Mul<M,N,T>(Matrix<M,N,T> A, Vector<N,T> B, Vector<M,T> X)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var m = nati<M>();
            for(var i = 0; i< m; i++)
                X[i] = Linear.dot(A.GetRow(i), B);                    
        }

    }

}