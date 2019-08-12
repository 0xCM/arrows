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
    public class GaussianDist<T> : Distribution<GaussianSpec<T>,T>
        where T : struct
    {    
        public GaussianDist(IRandomSource random, GaussianSpec<T> spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
        {
            if(typeof(T) == typeof(double))
                foreach(var next in Gaussian(Random, Spec.ToFloat32()))
                    yield return As.generic<T>(next);
            else if (typeof(T) == typeof(float))
                foreach(var next in Gaussian(Random, Spec.ToFloat64()))
                    yield return As.generic<T>(next);
            else
                foreach(var next in Gaussian(Random, Spec.ToFloat64()))
                    yield return convert<double,T>(next, out T x);
        }            

        /// <summary>
        /// Samples a gaussian distribution
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="mean"></param>
        /// <param name="stdDev"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Marsaglia_polar_method</remarks>
        static IEnumerable<double> Gaussian(IRandomSource rng, GaussianSpec<double> spec) 
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
                yield return spec.Mean + spec.StdDev * u * x;
           }
        }

        static IEnumerable<float> Gaussian(IRandomSource rng, GaussianSpec<float> spec) 
        {            
            while(true)
            {
                float u, v, s;
                do 
                {
                    u = (float)(rng.NextDouble()) * 2 - 1;
                    v = (float)(rng.NextDouble()) * 2 - 1;
                    s = u * u + v * v;                
                } while (s >= 1 || s == 0);
                var x = math.sqrt(-2.0f * math.ln(s) / s);
                yield return v * x;
                yield return spec.Mean + spec.StdDev * u * x;
           }
        }

    }
}