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
    /// Captures a sample from a Binomial distribution 
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Binomial_distribution</remarks>
    public readonly struct BinomialSample<T> : ISample<T,BinomialSpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinomialSample(RngKind rng, T n, double p, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.Data = data;
            this.DistSpec = BinomialSpec<T>.Define(n,p);
        }        

        [MethodImpl(Inline)]
        public BinomialSample(RngKind rng, BinomialSpec<T> spec, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.Data = data;
            this.DistSpec = spec;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}

        /// <summary>
        /// The distribution spec that was used to draw the sample
        /// </summary>
        public readonly BinomialSpec<T> DistSpec {get;}
        
        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}

    }
}