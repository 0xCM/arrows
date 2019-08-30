//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Captures a sample from a Cauchy distribution 
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Cauchy_distribution</remarks>
    public readonly struct CauchySample<T>
        where T : struct
    {

        public CauchySample(RngKind rng, CauchySpec<T> spec, Memory<T> data)
        {
            this.SourceRng = rng;
            this.SampleData = data;
            this.Distribution = spec;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        /// <summary>
        /// The distribution spec that was used to draw the sample
        /// </summary>
        public readonly CauchySpec<T> Distribution;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

    }
}