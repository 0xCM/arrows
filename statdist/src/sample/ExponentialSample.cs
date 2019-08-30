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
    public readonly struct ExponentialSample<T>
        where T : struct
    {
        public ExponentialSample(RngKind rng, T Dx, T Beta, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Dx = Dx;
            this.Beta = Beta;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        /// <summary>
        /// The displacement
        /// </summary>
        public readonly T Dx; 

        public readonly T Beta;

        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

    }

}