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
    using static nfunc;

    /// <summary>
    /// Captures a sample from a Gemetric distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Geometric_distribution</remarks>
    public readonly struct GeometricSample<T> : ISample<T>
        where T : unmanaged
    {
        public GeometricSample(RngKind rng, double p, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.P = p;
            this.Data = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public RngKind Rng {get;}

        /// <summary>
        /// The probability of trial success
        /// </summary>
        public double P {get;}
        
        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public MemorySpan<T> Data {get;} 

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => Data.Span.FormatList();


    }
}