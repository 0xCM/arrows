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


    public ref struct GaussianSample<T>
        where T : struct
    {
        public GaussianSample(BRNG rng, double mu, double sigma, Span<T> data)
        {
            this.SourceRng = rng;
            this.Mu = mu;
            this.Sigma = sigma;
            this.SampleData = data;
        }        

        /// <summary>
        /// The generator used during sample generation
        /// </summary>
        public BRNG SourceRng;

        /// <summary>
        /// The mean
        /// </summary>
        public double Mu;

        /// <summary>
        /// The standard deviation
        /// </summary>
        public double Sigma;
        
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

    public static class GaussianSample
    {
        public static GaussianSample<T> GaussianSampled<T>(this BRNG rng, double mu, double sigma, Span<T> data)
            where T : struct
                => new GaussianSample<T>(rng, mu, sigma, data);
    }


}