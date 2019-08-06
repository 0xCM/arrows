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

    public readonly ref struct UniformBitsSample<T>
        where T : struct
    {
        public UniformBitsSample(BRNG rng,  Span<T> data)
        {
            this.SourceRng = rng;
            this.SampleData = data;
        }

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly BRNG SourceRng;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Span<T> SampleData;                

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Format();
    }

}