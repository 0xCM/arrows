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
    /// Captures a sample from a Poisson distribution 
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Poisson_distribution</remarks>
    public readonly struct PoissonSample<T> : ISample<T, PoissonSpec<double>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]    
        public PoissonSample(RngKind rng, double lambda, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = PoissonSpec<double>.Define(lambda);
            this.Data = data;
        }

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}
        
        /// <summary>
        /// Characterizes the specified sample distribution
        /// </summary>
        public PoissonSpec<double> DistSpec {get;}

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