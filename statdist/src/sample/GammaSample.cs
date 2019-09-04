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
    /// Captures a sample from a Gamma distribution
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Gamma_distribution</remarks>
    public readonly struct GammaSample<T> : ISample<T,GammaSpec<T>>
        where T : unmanaged
    {
        public GammaSample(RngKind rng, T alpa, T dx, T beta, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = GammaSpec<T>.Define(alpa,dx,beta);
            this.Data = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}

        /// <summary>
        /// Characterizes the specified sample distribution
        /// </summary>
        public readonly GammaSpec<T> DistSpec {get;}

        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}        

    }

}