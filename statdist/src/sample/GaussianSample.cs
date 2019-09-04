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
    /// Captures a sample from a Gaussian (normal) distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Normal_distribution</remarks>
    public readonly struct GaussianSample<T> : ISample<T, GaussianSpec<T>>
        where T : unmanaged
    {
        public GaussianSample(RngKind rng, T mu, T sigma, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = GaussianSpec<T>.Define(mu,sigma);
            this.Data = data;
        }        

        
        public GaussianSample(RngKind rng, GaussianSpec<T> spec, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = spec;
            this.Data = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public RngKind Rng {get;}

        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public GaussianSpec<T> DistSpec {get;}

        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public MemorySpan<T> Data {get;}      

    }
}