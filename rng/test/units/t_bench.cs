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
    using Mkl;

    using static zfunc;
    using static x86;
    
    public class t_bench : RngTest<t_bench>
    {

        public void bench_mrg32k3a_uniform_u32()
        {

            Benchmark(RNG.Mrg32k3a());
        }

        public void bench_mrg32k3a_uniform_f64()
        {
            Benchmark(RNG.Mrg32k3a() as IPointSource<double>);
        }

        public void bench_splitmix_uniform_u64()
        {

            Benchmark(RNG.SplitMix().PointSource<ulong>());
        }

        public void bench_splitmix_bitstring()
        {
            Benchmark((RNG.SplitMix().BitStringSource((Pow2.T03, Pow2.T08))));
        }

        void bench_splitmix_bitsource()
        {
            Benchmark(RNG.SplitMix().PointSource<ulong>().ToBitStream());
        }

        public void bench_splitmix_uniform_f64()
        {

            Benchmark(RNG.SplitMix().PointSource<double>());
        }

        public void bench_splitmix_bernoulli_u64()
        {

            var gen = RNG.SplitMix();
            var sampler = gen.Bernoulli<byte>(.35);
            Benchmark(sampler);
        }

        public void bench_xor1024_uniform_u64()
        {

            Benchmark(RNG.XOrShift1024().PointSource<ulong>());
        }

        public void bench_xor256_uniform_u64()
        {

            Benchmark(RNG.XOrStarStar256().PointSource<ulong>());
        }

        public void bench_wyhash_uniform_u64()
        {

            Benchmark(RNG.WyHash64().PointSource<ulong>());
        }

        public void bench_pcg64_uniform_u64()
        {
             Benchmark(RNG.Pcg64().PointSource<ulong>());
        }

        public void bench_pcg64_uniform_u32()
        {
             Benchmark(RNG.Pcg64().PointSource<int>());
        }

        public void bench_pcg_32()
        {
             Benchmark(RNG.Pcg32());
        }

        public void bench_mkl_sfmt19937_uniform_i32()
        {
            using var generator = rng.sfmt19937(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<int>();
            Benchmark(sampler);            
        }

        public void bench_mkl_sfmt19937_bernoulli_i32()
        {
            using var generator = rng.sfmt19937(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.BernoulliSampler(BernoulliSpec.Define<int>(.35));
            Benchmark(sampler);            
        }

        public void bench_mkl_r250_uniform_i32()
        {
            using var generator = rng.r250(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<int>();
            Benchmark(sampler);            
        }

        public void bench_mkl_r250_uniform_f32()
        {
            using var generator = rng.r250(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<float>();
            Benchmark(sampler);            
        }

        public void bench_mkl_r250_uniform_f64()
        {
            using var generator = rng.r250(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<double>();
            Benchmark(sampler);            
        }

        public void bench_mkl_mcg59_bits_u32()
        {
            using var generator = rng.mcg59(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformBitsSampler<uint>();
            Benchmark(sampler);            
        }

        public void bench_mkl_mcg59_bits_u64()
        {
            using var generator = rng.mcg59(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformBitsSampler<ulong>();
            Benchmark(sampler);            
        }

        public void bench_mkl_mcg59_gaussian_f64()
        {
            using var generator = rng.mcg59(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.GaussianSampler(GaussianSpec.Define(10.0, 50.0));
            Benchmark(sampler);            
        }

        public void bench_mkl_mrg32k3a_i32()
        {
            using var generator = rng.mrg32K31(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<int>();
            Benchmark(sampler);            
        }

        public void bench_mkl_mrg32k3a_f32()
        {
            using var generator = rng.mrg32K31(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<float>();
            Benchmark(sampler);            
        }

        public void bench_mkl_mrg32k3a_f64()
        {
            using var generator = rng.mrg32K31(RngSeed.TakeSingle<uint>(0));
            var sampler = generator.UniformSampler<double>();
            Benchmark(sampler);            
        }

        void bench_binomial()            
        {
            //Slow!!!
            var spec = BinomialSpec<int>.Define(10, .5);
            Benchmark(spec.Distribution(Random));
        }

        void mul_bench()
        {
            RunMultiply();

        }

        void Pcg32Simd()
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

        static Span<IStepwiseSource<uint>> CreatPcgSuite()
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
            return RNG.Pcg32Suite(seed, inc);
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