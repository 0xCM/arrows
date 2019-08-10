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

    /// <summary>
    /// Defines reference operations related to matrix/vector multiplication
    /// </summary>
    public static class MatrixRefOps
    {
        public static T Dot<N,T>(Vector<N,T> X, Vector<N,T> Y)
            where T : struct
            where N : ITypeNat, new()
        {
            var result = default(T);
            var len = nati<N>();
            for(var i=0; i< len; i++)
                result = gmath.add(gmath.mul(X[i],Y[i]), result);
            return result;
        }

        public static T Dot<T>(Span<T> X, Span<T> Y)
            where T : struct
        {
            var result = default(T);
            var len = length(X,Y);
            for(var i=0; i< len; i++)
                result = gmath.add(gmath.mul(X[i],Y[i]), result);
            return result;
        }

        public static ref Matrix<N,T> Mul<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> X)
            where N : ITypeNat, new()
            where T : struct
        {
            var n = nati<N>();
            for(var i = 0; i< n; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = Dot(A.Row(i), B.Col(j));                    
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
                X[i,j] = Dot(A.Row(i), B.Col(j));         
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
                X[i] = Dot(A.Row(i), B);                    
        }

    }

}