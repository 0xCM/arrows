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
    using static x86;
    
    public class RandBench : UnitTest<RandBench>
    {
        public void Multiply()
        {
            RunMultiply();

        }

        public void Pcg32Simd()
        {
            RunPcg32Simd();

        }

        
        void RunMultiply(int opcount = Pow2.T16)
        {
            var lhsSrc = Random.Stream<ulong>();
            var rhsSrc = Random.Stream<ulong>();
            var len = Vec256<ulong>.Length;

            var sw = stopwatch(false);
            for(var i=0; i <opcount; i++)
            {
                var v1 = Vec256.Load(lhsSrc.TakeSpan(len));
                var v2 = Vec256.Load(rhsSrc.TakeSpan(len));
                sw.Start();
                dinx.mul(v1,v2);
                sw.Stop();
            }
            Collect((opcount, snapshot(sw), "direct"));
            
            sw.Reset();            

            for(var i=0; i <opcount; i++)
            {
                var v1 = Vec256.Load(lhsSrc.TakeSpan(len));
                var v2 = Vec256.Load(rhsSrc.TakeSpan(len));
                sw.Start();
                _mm256_mul_epi32(v1, v2);
                sw.Stop();
            }            
            Collect((opcount, snapshot(sw), "dsl"));


        }

        static PcgAvx32Rng CreatPcgAvx()
        {
            var seed = Vec256.FromParts(Seed64.Seed00, Seed64.Seed01, Seed64.Seed02, Seed64.Seed03);
            var inc =  Vec256.FromParts(0xFFFFul, 0xFFFFul + 128, 0xFFFFul + 256, 0xFFFFul + 512);
            return PcgAvx32Rng.Create(seed,inc);
        }

        static Span<Pcg32> CreatPcgSuite()
        {
            Span<ulong> seed = new ulong[]
            {
                Seed64.Seed00, Seed64.Seed01, Seed64.Seed02, Seed64.Seed03, 
                Seed64.Seed04, Seed64.Seed05, Seed64.Seed06, Seed64.Seed07
            };

            Span<ulong> inc = new ulong[]
            {
                0xFFFFul, 0xFFFFul + Pow2.T07, 0xFFFFul + Pow2.T08, 0xFFFFul + Pow2.T09,
                0xFFFFul + Pow2.T10, 0xFFFFul + Pow2.T11, 0xFFFFul + Pow2.T12, 0xFFFFul + Pow2.T13,
            };
            return Pcg32.Suite(seed, inc);
        }


        void RunPcg32Simd(int opcount = Pow2.T16)
        {
            var pcgSuite = CreatPcgSuite();
            var pcgAvx = CreatPcgAvx();

            var sw = stopwatch(false);

            sw.Start();
            for(var i=0; i<opcount; i++)
                pcgSuite.Next();
            sw.Stop(); 

            Collect((opcount, snapshot(sw), "pcg32"));
           
            sw.Reset();
            sw.Start();
            for(var i=0; i<opcount; i++)
                pcgAvx.Next();
            sw.Stop();

            Collect((opcount, snapshot(sw), "pcg32-avx"));
            
        }
    }

}