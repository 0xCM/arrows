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
    /// Captures a sample from a Bernoulli distribution 
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Bernoulli_distribution</remarks>
    public readonly struct BernoulliSample<T>
        where T : struct
    {
        public BernoulliSample(RngKind rng, BernoulliSpec<T> spec, Memory<T> data)
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
        public readonly BernoulliSpec<T> Distribution;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;    

        public Span<Bit> GetBits()
        {
            Span<Bit> dst = new Bit[SampleData.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] =As.int32(SampleData.Span[i]);
            return dst;
        }

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Span.FormatList();

    }
}