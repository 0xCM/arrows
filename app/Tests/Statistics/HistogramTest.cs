namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    using static BitVectorPatterns;
    using static BitPatterns;
    
    using P = Paths;


    [DisplayName(Path)]
    public class HistogramTest : UnitTest<HistogramTest>
    {
        const string Path = P.stats;
    
        void HistoTest<T>(Interval<T> domain, T? grain = null)
            where T : struct, IEquatable<T>
        {            
            //CheckRandomBounds(domain);

            var width = primops.sub(domain.right, domain.left);
            var data = RandomIndex(domain, Pow2.T14);
            var histo = new Histogram<T>(domain, grain ?? (primops.div(width,convert<T>(100))));
            histo.Deposit(data);  

            var buckets = histo.Buckets().Freeze();
            var total = (int)buckets.TotalCount();

            babble($"Histogram domain: {histo.Domain}");
            babble($"Histogram grain: {histo.Grain}");
            babble($"Histogram bucket count: {buckets.Count}");            
            babble($"Total number of samples: {data.Length}");
            babble($"Sum of bucket counts: {total}");
            Claim.eq(total, data.Length);

        }
    
    }

}