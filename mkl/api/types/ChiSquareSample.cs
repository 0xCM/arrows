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

    public ref struct ChiSquareSample<T>
        where T : struct
    {
        public ChiSquareSample(BRNG rng, int freedom, Span<T> data)
        {
            this.SourceRng = rng;
            this.Freedom = freedom;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public BRNG SourceRng;

        /// <summary>
        /// The degrees of freedom
        /// </summary>
        public int Freedom;
        
        /// <summary>
        /// The data that has been sampled according to the attendant parameters
        /// </summary>
        public Span<T> SampleData;        

        /// <summary>
        /// Rnders the sample data as text
        /// </summary>
        public string Format()
            => SampleData.Format();
    }

    public static class ChiSquareSample
    {
        public static ChiSquareSample<T> ChiSquareSampled<T>(this BRNG rng, int freedom, Span<T> data)
            where T : struct
                => new ChiSquareSample<T>(rng, freedom, data);
    }


}