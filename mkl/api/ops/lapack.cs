//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static nfunc;

    public static partial class mkl
    {
        public static EigenResult<N,double> dgeev<N>(Span256<double> A)
            where N : ITypeNat, new()
        {
            var n = nati<N>();
            var lda = n;
            var ldvl = n;
            var ldvr = n;
            var wslen = n*n;
            var exitcode = 0;        
            var v = 'V';
            var ws = span<double>(wslen);
            var wr = NatSpan.alloc<N,double>();
            var wi = NatSpan.alloc<N,double>();
            var lVec = A.Replicate(true);
            var rVec = A.Replicate(true);             
                        
            LAPACK.DGEEV(
                ref v, ref v, ref n, 
                ref A[0], ref lda, 
                ref wr[0], ref wi[0], 
                ref lVec[0], ref ldvl, 
                ref rVec[0], ref ldvr, 
                ref ws[0], ref wslen, 
                ref exitcode);

            if(exitcode != 0)
                MklException.Throw(exitcode);

            return EigenResult.Define(ComplexNumber.FromPaired<N,double>(wr, wi), lVec, rVec);

        }

    }

}