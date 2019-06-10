//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;


    /// <summary>
    /// Characterizes a Gaussian (normal) distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Normal_distribution</remarks>
    public class GaussianSpec : IDistributionSpec
    {
        public GaussianSpec(double Mean, double StdDev)
        {
            this.Mean = Mean;
            this.StdDev = StdDev;
        }

        /// <summary>
        /// The mean of the distribtion that serves as the location parameter
        /// </summary>

        [Symbol(GreekSym.mu)]
        public double Mean {get;}

        /// <summary>
        /// The standard deviation
        /// </summary>

        [Symbol(GreekSym.sigma)]
        public double StdDev {get;}

        public double Variance 
            => StdDev * StdDev;


        [Symbol(GreekSym.tau)]
        public double Precision 
             => 1.0/Variance;
            
    }


    /// <summary>
    /// Realizes a Gaussian distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GaussianDist<T> : Distribution<GaussianSpec,T>
        where T : struct
    {    
        public GaussianDist(GaussianSpec spec)
        {
            this.Spec = spec;
        }

        public GaussianSpec Spec {get;}

        public override IEnumerable<T> Sample(IRandomizer random)
        {
            return new T[]{};
        }
            
    }

}