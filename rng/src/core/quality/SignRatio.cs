//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public static partial class RngQuality
    {
        /// <summary>
        /// Counts the number of sample points that lie within a specified interval
        /// </summary>
        /// <param name="random">The distribution to analyze</param>
        /// <param name="domain">The interval within which points will be counted</param>
        /// <param name="count">The number of sample points to use</param>
        /// <typeparam name="T">The distribution point type</typeparam>
        public static Ratio<double> SamplesWithin<T>(IPolyrand random, Interval<T> domain, int count)
            where T : unmanaged
        {
            var src = random.Stream(domain).Take((uint)count);
            var counter = 0;
            foreach(var sample in src)
                if(domain.Contains(sample))
                    counter++;
            return new Ratio<double>(counter, count);

        }    

        /// <summary>
        /// Calulates the ratio of the count of positive to negative values.
        /// The test succeeds if the ratio approaches unity as the sample size approaches infinity
        /// </summary>
        /// <param name="samples">The sample count</param>
        public static double SignRatio(IPolyrand random, long samples, long radius)
        {
            var domain = closed(0 - math.abs(radius), 0 + math.abs(radius));
            var pos = 0L;
            var neg = 0L;
            var zed = 0L;
            for(var i=0; i<samples; i++)
            {
                var next = random.Next(domain);
                if(next > 0)
                    pos++;
                else if(next < 0)
                    neg++;
                else
                    zed++;
            }

            var ratio = (neg != 0 ?  (double)pos/(double)neg : 0d);
            
            // Should be zero or extremly close so combining it with the ratio should have 
            // negligible impact. Otherwise, something is wrong and willb reflected in the
            // metric
            var eps = (double)zed / (double)samples;
            var metric = ratio + eps;

            return metric.Round(6);
        }

    }

}