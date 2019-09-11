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

    /// <summary>
    /// Defines matrix multiplication reference operations
    /// </summary>
    public static class MatMulRef
    {
        public static ref BlockMatrix<M,N,T> Mul<M,K,N,T>(BlockMatrix<M,K,T> A, BlockMatrix<K,N,T> B, ref BlockMatrix<M,N,T> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var m = nati<M>();
            var n = nati<N>();
            var tB = B.Transpose();

            for(var i=0; i< m; i++)
            {
                var r = A.GetRow(i);
                for(var j = 0; j< n; j++)
                {
                    var c = tB.GetRow(j);
                    X[i,j] = r * c;
                }
            }
            return ref X;
        }

    }

}