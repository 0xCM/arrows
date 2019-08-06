//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Captures a sample from a uniform distribution 
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Uniform_distribution_(continuous)</remarks>
    public readonly struct UniformRangeSample<T>
        where T : struct
    {
        public UniformRangeSample(BRNG rng, Interval<T> range, Memory<T> data)
        {
            this.SourceRng = rng;
            this.Range = range;
            this.SampleData = data;
        }

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly BRNG SourceRng;

        /// <summary>
        /// The range of values over which the sample was taken
        /// </summary>
        public readonly Interval<T> Range;

        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;        

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Span.Format();
    }
}