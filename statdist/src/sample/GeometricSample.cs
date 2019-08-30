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
    /// Captures a sample from a Gemetric distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Geometric_distribution</remarks>
    public readonly struct GeometricSample<T>
        where T : struct
    {
        public GeometricSample(RngKind rng, double p, Memory<T> data)
        {
            this.SourceRng = rng;
            this.P = p;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        /// <summary>
        /// The probability of trial success
        /// </summary>
        public readonly double P;
        
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