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
        const CBLAS_TRANSPOSE NoTranspose = CBLAS_TRANSPOSE.CblasNoTrans;
        
        const MatrixLayout RowMajor = MatrixLayout.RowMajor;

        [MethodImpl(Inline)]
        static int ThrowOnError(int exit)
        {
            if(exit < 0)
                throw MklException.Define(exit);
            return exit;
        }

    }

}