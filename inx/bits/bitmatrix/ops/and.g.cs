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


        public static ref BitMatrix<M,N,T> And<M,N,T>(this ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
        {
            return ref lhs;
        }


    }

}