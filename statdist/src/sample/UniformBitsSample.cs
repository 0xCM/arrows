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
    /// Captures a sample of uniformly distributed bits
    /// </summary>
    public readonly struct UniformBitsSample<T> : ISample<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]    
        public UniformBitsSample(RngKind rng,  MemorySpan<T> data)
        {
            this.Rng = rng;
            this.Data = data;
        }

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly RngKind Rng {get;}
        
        /// <summary>
        /// The sampled data
        /// </summary>
        public readonly MemorySpan<T> Data {get;}       

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => Data.Span.FormatList();
    }

}