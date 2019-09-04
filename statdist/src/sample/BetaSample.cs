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
    /// Captures a sample from a Beta distribution 
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Beta_distribution</remarks>
    public readonly struct BetaSample<T> : ISample<T,BetaSpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BetaSample(RngKind rng, T alpha, T beta, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.Data = data;
            this.DistSpec = BetaSpec<T>.Define(alpha,beta);
        }        

        [MethodImpl(Inline)]
        public BetaSample(RngKind rng, BetaSpec<T> spec, MemorySpan<T> data)
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
        public readonly BetaSpec<T> DistSpec {get;}
        
        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}

    }
}