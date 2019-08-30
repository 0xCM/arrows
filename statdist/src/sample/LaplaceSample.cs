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
    using static nfunc;

    /// <summary>
    /// Captures a sample from an Laplace distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Laplace_distribution</remarks>
    public readonly struct LaplaceSample<T>
        where T : struct
    {
        public LaplaceSample(RngKind rng, LaplaceSpec<T> spec, Memory<T> data)
        {
            this.SourceRng = rng;
            this.SampleData = data;
            this.Distribution = spec;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        public readonly LaplaceSpec<T> Distribution;

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