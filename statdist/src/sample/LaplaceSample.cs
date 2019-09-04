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
    /// Captures a sample from an Laplace distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Laplace_distribution</remarks>
    public readonly struct LaplaceSample<T>  : ISample<T,LaplaceSpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]    
        public LaplaceSample(RngKind rng, T loc, T scale, MemorySpan<T> data)
        {
            this.Rng = rng;
            this.DistSpec = LaplaceSpec<T>.Define(loc,scale);
            this.Data = data;
        }

        [MethodImpl(Inline)]    
        public LaplaceSample(RngKind rng, LaplaceSpec<T> spec, MemorySpan<T> data)
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
        /// Characterizes the specified sample distribution
        /// </summary>
        public LaplaceSpec<T> DistSpec {get;}

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