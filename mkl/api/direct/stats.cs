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

    using static zfunc;
    using static nfunc;

    partial class mkl
    {            

        [MethodImpl(Inline)]
        public static IVslSSTask<float> sstask(int dim, float[] samples)        
            => VslSSTaskF32.Define(dim, samples);

        [MethodImpl(Inline)]
        public static IVslSSTask<double> sstask(int dim, double[] samples)        
            => VslSSTaskF64.Define(dim, samples);



    }

}