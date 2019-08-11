//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct CauchySample<T>
        where T : struct
    {
        public CauchySample(BRNG rng, T mean, T beta, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Mean = mean;
            this.Beta = beta;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly BRNG SourceRng;

        /// <summary>
        /// The distribution mean
        /// </summary>
        public readonly T Mean;

        /// <summary>
        /// The scale factor
        /// </summary>
        public readonly T Beta;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

    }
}