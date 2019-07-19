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
    /// Encapsulates data sampled from a Chi^2 distribution joined with
    /// the BRNG identifier and distribution parameters that were specified
    /// when the sample was taken
    /// </summary>
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

}