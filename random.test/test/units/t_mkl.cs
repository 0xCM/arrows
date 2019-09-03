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
    
    public class t_mkl : UnitTest<t_mkl>
    {

        const uint Seed = 0x78941u;

        const double MinF64 = -350000;

        const double MaxF64 = 350000;

        const float MinF32 = -350000;

        const float MaxF32 = 350000;

        static readonly Interval<float> RangeF32 = (MinF32, MaxF32);

        static readonly Interval<double> RangeF64 = (MinF64, MaxF64);

        public void DefaultRngTest()
        {
            DefaultRngTest(Pow2.T08, Pow2.T17);
        }

        public void mcg31()
        {
            using var rng = mkl.gMcg31(Seed);
            MklRngTest(rng, Pow2.T08, Pow2.T17);
        }

        public void mt2203()
        {
            using var rng = mkl.gMt2203(Seed);
            MklRngTest(rng, Pow2.T08, Pow2.T17);
        }

        public void r250()
        {
            using var rng = mkl.gR250(Seed);
            MklRngTest(rng, Pow2.T08, Pow2.T17);
        }

        void MklRngTest(VslStream vsls, int segment, int total)
        {
            var src = vsls.Uniform(RangeF64);
            var sum = 0.0;
            for(var i=0; i< total; i+= segment)
            {
                var sample = src.Take(segment).ToArray();                
                for(var j=0; j< segment; j++)
                    sum += sample[j];
            }
            var avg = sum/((double)total);
            //Trace(avg.ToString());            

        }

        void DefaultRngTest(int segment, int total)
        {
            var src = RNG.XOrShift1024().ToPolyrand().Stream(RangeF64);
            var sum = 0.0;
            for(var i=0; i< total; i+= segment)
            {
                var sample = src.Take(segment).ToArray();                
                for(var j=0; j< segment; j++)
                    sum += sample[j];
            }
            var avg = sum/((double)total);
            //Trace(avg.ToString());            

        }

    }
}