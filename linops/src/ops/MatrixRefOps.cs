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

        public static ref BlockMatrix<N,T> Mul<N,T>(BlockMatrix<N,T> A, BlockMatrix<N,T> B, ref BlockMatrix<N,T> X)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var n = nati<N>();
            for(var i = 0; i< n; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = dot(A.Row(i), B.Col(j));                    
            return ref X;
        }


        public static ref BlockMatrix<M,N,T> Mul<M,K,N,T>(BlockMatrix<M,K,T> A, BlockMatrix<K,N,T> B, ref BlockMatrix<M,N,T> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i = 0; i< m; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = dot(A.GetRow(i), B.GetCol(j));         
            return ref X;           
        }

        public static BlockMatrix<M,N,T> Mul<M,K,N,T>(BlockMatrix<M,K,T> A, BlockMatrix<K,N,T> B)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var X = BlockMatrix.Alloc<M,N,T>();
            Mul(A,B, ref X);
            return X;
        }

        /// <summary>
        /// Commputes the canonical scalar product btween two vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        static T dot<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => gmath.dot<T>(lhs.Unsized,rhs.Unsized);

        public static void Mul<M,N,T>(BlockMatrix<M,N,T> A, BlockVector<N,T> B, BlockVector<M,T> X)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var m = nati<M>();
            for(var i = 0; i< m; i++)
                X[i] = dot(A.GetRow(i), B);                    
        }

    }

}