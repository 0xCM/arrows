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
        where T : unmanaged
    {    
        public GaussianDist(IPolyrand random, GaussianSpec<T> spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
        {
            if(typeof(T) == typeof(float))
            {
                var spec = Spec.ToFloat32();
                foreach(var next in Gaussian(Polyrand, spec))
                    yield return As.generic<T>(next);
            }
            else if (typeof(T) == typeof(double))
            {
                var spec = Spec.ToFloat64();
                foreach(var next in Gaussian(Polyrand, spec))
                    yield return As.generic<T>(next);
            }
            else
                foreach(var next in Gaussian(Polyrand, Spec.ToFloat64()))
                    yield return convert<double,T>(next, out T x);
        }            

        /// <summary>
        /// Samples a gaussian distribution
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="mean"></param>
        /// <param name="stdDev"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Marsaglia_polar_method</remarks>
        static IEnumerable<double> Gaussian(IPolyrand rng, GaussianSpec<double> spec) 
        {            
            while(true)
            {
                double u, v, s;
                do 
                {
                    u = rng.Next<double>() * 2 - 1;
                    v = rng.Next<double>() * 2 - 1;
                    s = u * u + v * v;                
                } 
                while (s >= 1 || s == 0);
                
                var x = fmath.sqrt(-2.0 * math.ln(s) / s);                
                yield return v * x;                
                yield return spec.Mean + spec.StdDev * u * x;
           }
        }

        static IEnumerable<float> Gaussian(IPolyrand rng, GaussianSpec<float> spec) 
        {            
            while(true)
            {
                float u, v, s;
                do 
                {
                    u = rng.Next<float>() * 2 - 1;
                    v = rng.Next<float>() * 2 - 1;
                    s = u * u + v * v;                
                } 
                while (s >= 1 || s == 0);
                
                var x = fmath.sqrt(-2.0f * math.ln(s) / s);
                yield return v * x;
                yield return spec.Mean + spec.StdDev * u * x;
           }
        }

    }
}