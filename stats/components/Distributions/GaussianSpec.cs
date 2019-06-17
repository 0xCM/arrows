//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Characterizes a Gaussian (normal) distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Normal_distribution</remarks>
    public class GaussianSpec : IDistributionSpec
    {
        public GaussianSpec(double mean, double stddev)
        {
            this.Mean = mean;
            this.StdDev = stddev;
        }

        /// <summary>
        /// The mean of the distribtion that serves as the location parameter
        /// </summary>

        [Symbol(Greek.mu)]
        public double Mean {get;}

        /// <summary>
        /// The standard deviation
        /// </summary>

        [Symbol(Greek.sigma)]
        public double StdDev {get;}

        public double Variance 
            => StdDev * StdDev;

        [Symbol(Greek.tau)]
        public double Precision 
             => 1.0/Variance;            
    }

}