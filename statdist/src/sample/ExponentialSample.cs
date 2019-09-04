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

    /// <summary>
    /// Captures a sample from an exponential distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Exponential_distribution</remarks>
    public readonly struct ExponentialSample<T> : ISample<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ExponentialSample(RngKind rng, T dx, T beta, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.Dx = dx;
            this.Beta = beta;
            this.Data = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}

        /// <summary>
        /// The displacement
        /// </summary>
        public readonly T Dx; 

        public readonly T Beta;

        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}        

    }

}