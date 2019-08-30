//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
     using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Captures a sample from a Poisson distribution 
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Poisson_distribution</remarks>
    public readonly struct PoissonSample<T>
        where T : struct
    {
        public PoissonSample(RngKind rng, double lambda, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Lambda = lambda;
            this.SampleData = data;
        }

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;
        
        public readonly double Lambda;

        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Span.FormatList();
    }

}