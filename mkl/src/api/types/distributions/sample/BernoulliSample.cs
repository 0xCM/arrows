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

    public readonly struct BernoulliSample<T>
        where T : struct
    {
        public BernoulliSample(BRNG rng, double p, Memory<T> data)
        {
            this.SourceRng = rng;
            this.P = p;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public readonly BRNG SourceRng;

        /// <summary>
        /// The probability of trial success
        /// </summary>
        public readonly double P;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public readonly Memory<T> SampleData;    

        public Span<Bit> GetBits()
        {
            Span<Bit> dst = new Bit[SampleData.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] =As.int32(SampleData.Span[i]);
            return dst;
        }

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Span.FormatList();

    }
}