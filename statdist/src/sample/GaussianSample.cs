//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Encapsulates data sampled from a Gaussian distribution joined with
    /// the BRNG identifier and distribution parameters that were specified
    /// when the sample was taken
    /// </summary>
    public readonly struct GaussianSample<T>
        where T : struct
    {

        public GaussianSample(RngKind rng, GaussianSpec<T> spec, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Distribution = spec;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        /// <summary>
        /// The distribution spec that was used to draw the sample
        /// </summary>
        public readonly GaussianSpec<T> Distribution;

        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

    }
}