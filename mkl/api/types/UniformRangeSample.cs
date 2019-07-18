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

    public ref struct UniformRangeSample<T>
        where T : struct
    {
        public UniformRangeSample(BRNG rng, Interval<T> range, Span<T> data)
        {
            this.SourceRng = rng;
            this.Range = range;
            this.SampleData = data;
        }


        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public BRNG SourceRng;

        /// <summary>
        /// The range of values over which the sample was taken
        /// </summary>
        public Interval<T> Range;

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

    public static class UniformRangeSample
    {
        public static UniformRangeSample<T> UniformRangeSampled<T>(this BRNG rng, Interval<T> range, Span<T> data)
            where T : struct
                => new UniformRangeSample<T>(rng, range, data);
    }

}