//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Diagnostics;    
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Runtime.InteropServices;
    using static zfunc;


	[SuppressUnmanagedCodeSecurity]
    public static partial class LAPACK
    {
        const string MklDll = "z0-lapack-clib.dll";


        /*
            void SGETRF( const MKL_INT* m, const MKL_INT* n, float* a, const MKL_INT* lda,
                        MKL_INT* ipiv, MKL_INT* info );

            void DGETRF( const MKL_INT* m, const MKL_INT* n, double* a, const MKL_INT* lda,
                        MKL_INT* ipiv, MKL_INT* info );
        
        
         */
    }

}
