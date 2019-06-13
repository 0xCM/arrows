//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    public static class RNGx
    {                

        /// <summary>
        /// Samples a gaussian distribution
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="mean"></param>
        /// <param name="stdDev"></param>
        /// <remarks>See https://en.wikipedia.org/wiki/Marsaglia_polar_method</remarks>
        public static IEnumerable<double> Gaussian(this IRandomSource rng, double mean, double stdDev) 
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
        
        public static System.Random SystemRandom(this IRandomSource rng)
            => new SysRand(rng);
    }   
}