//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Z0.Mkl;

    using static zfunc;
    
    public class t_bitvectors : UnitTest<t_bitvectors>
    {
        protected override int SampleSize
            => Pow2.T12;

        public void bv16width()
        {
            var limit = 12;
            var set1 = BitVector16.All(limit).Select(x => x.Scalar).ToArray();
            Claim.eq(mathspan.max(set1.ToSpan()), (ushort)0b111111111111);

            var set2 = Random.BitVectors(n16, limit).TakeArray((int)Pow2.pow(limit*2));
            Span<int> dist = stackalloc int[limit + 1];
            for(var i=0; i<set2.Length; i++)
            {
                var v = set2[i];
                Claim.lteq(v.MinWidth, limit);
                ++dist[v.MinWidth];
            }

            //should approach 2^(limit - 1)
            double idealRatio = Pow2.pow(limit - 1);
            Span<double> ratios = stackalloc double[dist.Length];
            for(var i=1; i<dist.Length; i++)
                ratios[i] = ((double)dist[i]/Pow2.pow(i));
            
            var delta = mathspan.sub(ratios.Slice(1), idealRatio);
            Claim.yea(math.lt(math.abs(delta.Last()), 3.0));
            
        }

        public void bvGeneric()
        {
            var trace = false;
            var lenRange = closed(3,68);
            var lenStats = Collector.Create();
            var bitStats = Collector.Create();
            for(var i=0; i<SampleSize; i++)
            {
                var v = Random.BitVector<int>(lenRange);
                Claim.between(v.Length, lenRange);
                
                lenStats.Collect(v.Length);
                bitStats.Collect(v.Pop());
            }
            var lenMeanIdeal = ((double)lenRange.Width() * .50).Round(Scale);
            var lenMeanActual = lenStats.Mean.Round(Scale);
            var popIdeal = (long)(lenMeanIdeal)*(double)SampleSize;

            if(trace)
            {
                Trace("samples", $"{SampleSize}");
                Trace("cell type", type<int>().DisplayName());
                Trace($"len range", $"{lenRange}");
                Trace($"len mean ideal", $"{lenMeanIdeal}");
                Trace($"len mean actual", $"{lenMeanActual}");
                Trace($"pop ideal", $"{popIdeal}");
            }
        }
    }
}

