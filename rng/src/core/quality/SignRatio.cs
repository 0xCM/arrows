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
        /// Calulates the ratio of the count of positive to negative values.
        /// The test succeeds if the ratio approaches unity as the sample size approaches infinity
        /// </summary>
        /// <param name="samples">The sample count</param>
        public static double SignRatio(this IPolyrand random, long samples, long radius)
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