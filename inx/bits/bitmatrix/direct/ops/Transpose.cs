//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrixOps
    {    
        public static BitMatrix<N,M,T> Transpose<M,N,T>(this BitMatrix<M,N,T> src)
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = BitMatrix.Define<N,M,T>();
            for(var row = 0; row < src.RowCount; row++)
                dst.ReplaceCol(row, src.Row(row));            
            return dst;
        }

    }
}