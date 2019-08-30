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
    public readonly struct ChiSquareSample<T>
        where T : struct
    {
        public ChiSquareSample(RngKind rng, int freedom, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Freedom = freedom;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind SourceRng;

        /// <summary>
        /// The degrees of freedom
        /// </summary>
        public readonly int Freedom;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

    }

}