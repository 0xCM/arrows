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
    /// Captures a sample from a Cauchy distribution 
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Cauchy_distribution</remarks>
    public readonly struct CauchySample<T> : ISample<T,CauchySpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public CauchySample(RngKind rng, T loc, T scale, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.Data = data;
            this.DistSpec = CauchySpec<T>.Define(loc,scale);
        }        

        [MethodImpl(Inline)]
        public CauchySample(RngKind rng, CauchySpec<T> spec, MemorySpan<T> data)
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
        public readonly CauchySpec<T> DistSpec {get;}
        
        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}

    }
}