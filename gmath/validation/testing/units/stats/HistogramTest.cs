//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static mfunc;
    using static zfunc;
    
    public class HistogramTest : UnitTest<HistogramTest>
    {
            
        void HistoTest<T>(Interval<T> domain, T? grain = null)
            where T : struct
        {            
            var width = gmath.sub(domain.Right, domain.Left);
            var data = Randomizer.Array(domain, Pow2.T14);
            var histo = new Histogram<T>(domain, grain ?? (gmath.div(width,convert<T>(100))));
            histo.Deposit(data);  

            var buckets = histo.Buckets().Freeze();
            var total = (int)buckets.TotalCount();

            babble($"Histogram domain: {histo.Domain}");
            babble($"Histogram grain: {histo.Grain}");
            babble($"Histogram bucket count: {buckets.Length}");            
            babble($"Total number of samples: {data.Length}");
            babble($"Sum of bucket counts: {total}");
            Claim.eq(total, data.Length);

        }
    
    }

}