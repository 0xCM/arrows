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

    using static zfunc;
    
    public class t_rngfactory : UnitTest<t_rngfactory>
    {

        const uint Seed = 0x78941u;

        const double MinF64 = -350000;

        const double MaxF64 = 350000;

        const float MinF32 = -350000;

        const float MaxF32 = 350000;

        static readonly Interval<float> RangeF32 = (MinF32, MaxF32);

        static readonly Interval<double> RangeF64 = (MinF64, MaxF64);

        protected override int SampleSize => Pow2.T14;

        protected override int CycleCount => Pow2.T08;

        public void DefaultRngTests()
        {
            PolyRng(RNG.Pcg64(Seed));
        }

        public void mcg31()
        {
            using var src = rng.mcg31(Seed);
            MklRng(src);
        }

        public void mcg59()
        {
            using var src = rng.mcg31(Seed);
            MklRng(src);
        }

        public void sfmt19937()
        {
            
            using var src = rng.sfmt19937(Seed);
            MklRng(src);
        }

        public void mt2203()
        {
            using var src = rng.mt2203(Seed);
            MklRng(src);
        }

        public void r250()
        {
            using var src = rng.r250(Seed);
            MklRng(src);
        }

        OpTime MklRng(RngStream src)
        {
            var segment = Pow2.T08;
            var total = Pow2.T17;
            var stats = Accumulator.Create();
            var samples =  samplers.uniform(src, (RangeF64));
            var sw = stopwatch(false);
            for(var i=0; i< total; i+= segment)
            {
                sw.Start();
                var sample = samples.TakeArray(segment);
                sw.Stop();
                for(var j=0; j< segment; j++)
                    stats.Accumulate(sample[j]);
            }
            
            return (total, sw, $"{src.RngKind}");

        }

        OpTime PolyRng(IPolyrand random)
        {
            var segment = Pow2.T08;
            var total = Pow2.T17;
            var src = random.Stream(RangeF64);
            var stats = Accumulator.Create();
            var sw = stopwatch(false);
            for(var i=0; i< total; i+= segment)
            {
                sw.Start();
                var sample = src.TakeArray(segment);
                sw.Stop();
                for(var j=0; j< segment; j++)
                    stats.Accumulate(sample[j]);
            }
            
            return (total, sw, $"polyrand");

        }

    }
}