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
    /// Captures a sample from a uniform distribution 
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Uniform_distribution_(continuous)</remarks>
    public readonly struct UniformSample<T> : ISample<T, UniformSpec<T>>
        where T : unmanaged
    {
        public UniformSample(RngKind rng, Interval<T> range, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = range;
            this.Data = data;
        }

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}

        /// <summary>
        /// Characterizes the specified sample distribution
        /// </summary>
        public readonly UniformSpec<T> DistSpec {get;}

        /// <summary>
        /// The data sampled according to the distribution spec
        /// </summary>
        public readonly MemorySpan<T> Data {get;}        

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => Data.Span.FormatList();
    }
}