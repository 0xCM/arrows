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
    /// Realizes a Gaussian distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GaussianDist<T> : Distribution<GaussianSpec,T>
        where T : struct
    {    
        public GaussianDist(IRandomSource random, GaussianSpec spec)
            : base(random, spec)
        {

        }

        /// <summary>
        /// Samples a gaussian distribution
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="mean"></param>
        /// <param name="stdDev"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Marsaglia_polar_method</remarks>
        static IEnumerable<double> Gaussian(IRandomSource rng, double mean, double stdDev) 
        {            
            while(true)
            {
                double u, v, s;
                do 
                {
                    u = rng.NextDouble() * 2 - 1;
                    v = rng.NextDouble() * 2 - 1;
                    s = u * u + v * v;                
                } while (s >= 1 || s == 0);
                var x = math.sqrt(-2.0 * math.ln(s) / s);
                yield return v * x;
                yield return mean + stdDev * u * x;
           }
        }

        public override IEnumerable<T> Sample()
        {
            while(true)
            {
                foreach(var next in Gaussian(Random, Spec.Mean, Spec.StdDev))
                    yield return convert<double,T>(next, out T x);
            }                
        }            
    }


}