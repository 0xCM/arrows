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
    /// Captures a sample from a Chi^2 distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Chi-squared_distribution</remarks>
    public readonly struct ChiSquareSample<T> : ISample<T,Chi2Spec<T>>
        where T : unmanaged
    {
        public ChiSquareSample(RngKind rng, int freedom, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = freedom;
            this.Data = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}

        /// <summary>
        /// The degrees of freedom
        /// </summary>
        public readonly Chi2Spec<T> DistSpec {get;}
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly MemorySpan<T> Data {get;}

    }

}