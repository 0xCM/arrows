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
    using Z0.Mkl;

    using static Nats;
    using static zfunc;
    
    public class RandomBitVectors : UnitTest<RandomBitVectors>
    {
        protected override int SampleSize
            => Pow2.T12;

        public void SampleGeneric()
        {
            var lenRange = closed(3,68);
            var src = Random.BitVecStream<int>(lenRange);
            var lenStats = Accumulator.Create();
            var bitStats = Accumulator.Create(true);
            for(var i=0; i<SampleSize; i++)
            {
                var v = src.First();
                Claim.between(v.Length, lenRange);
                
                lenStats.Accumulate(v.Length);
                bitStats.Accumulate(v.Pop());
            }
            var lenMeanIdeal = ((double)lenRange.Width() * .50).Round(Scale);
            var lenMeanActual = lenStats.Mean.Round(Scale);
            var popIdeal = (long)(lenMeanIdeal)*(double)SampleSize;
            var popActual = (long)bitStats.Sum;
            Trace("samples", $"{SampleSize}");
            Trace("cell type", type<int>().DisplayName());
            Trace($"len range", $"{lenRange}");
            Trace($"len mean ideal", $"{lenMeanIdeal}");
            Trace($"len mean actual", $"{lenMeanActual}");
            Trace($"pop ideal", $"{popIdeal}");
            Trace($"pop actual", $"{popActual}");

        }

    }

}

