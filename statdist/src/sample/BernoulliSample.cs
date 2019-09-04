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
    public readonly struct BernoulliSample<T> : ISample<T,BernoulliSpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BernoulliSample(RngKind rng, BernoulliSpec<T> spec, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = spec;
            this.Data = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}

        /// <summary>
        /// The distribution spec that was used to draw the sample
        /// </summary>
        public readonly BernoulliSpec<T> DistSpec {get;}
        
        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}    

        /// <summary>
        /// Renders the sample data as text
        /// </summary>
        public string Format()
            => Data.Span.FormatList();

    }
}