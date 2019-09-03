//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    
    using static zfunc;
    
    public class t_histogram : UnitTest<t_histogram>
    {            
        void HistoTest<T>(Interval<T> domain, T? grain = null)
            where T : struct
        {            
            var width = gmath.sub(domain.Right, domain.Left);
            var data = Polyrand.Array<T>(Pow2.T14, domain);
            var histo = new Histogram<T>(domain, grain ?? (gmath.div(width,convert<T>(100))));
            histo.Deposit(data);  

            var buckets = histo.Buckets().ReadOnly();
            var total = (int)buckets.TotalCount();

            babble($"Histogram domain: {histo.Domain}");
            babble($"Histogram grain: {histo.BinWidth}");
            babble($"Histogram bucket count: {buckets.Length}");            
            babble($"Total number of samples: {data.Length}");
            babble($"Sum of bucket counts: {total}");
            Claim.eq(total, data.Length);

        }
    
    }

}