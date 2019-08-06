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
    using static nfunc;

    public readonly struct LaplaceSample<T>
        where T : struct
    {
        public LaplaceSample(BRNG rng, T mean, T beta, Memory<T> data)
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

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Span.Format();
    }
}