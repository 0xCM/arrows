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

    using static zcore;

    class Benchmark : Context
    {
        static BenchConfig ConfigureGInX(int? cycles = null, int? samples = null)
            => new BenchConfig(cycles ?? Pow2.T18, 1, samples ?? Pow2.T10 * Pow2.T04, AnnounceRate: Pow2.T15);
        
        static BenchConfig ConfigureGMath(int? cycles = null, int? reps = null)        
            => new BenchConfig(cycles ?? Pow2.T11, reps ?? Pow2.T18, reps ?? Pow2.T18, primitives: Primitives);            

        protected void print(BenchComparison c)
        {
            zcore.print(c.LeftBench.Description);
            zcore.print(c.RightBench.Description);
            zcore.print(c.CalcDelta().Description);
        }

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }

        static readonly PrimalKind[] Primitives = new PrimalKind[]{
                PrimalKind.int32, PrimalKind.uint32,
                PrimalKind.int64, PrimalKind.uint64,
                PrimalKind.float32, PrimalKind.float64,
        };

        static BenchConfig ConfigureVec128<T>(int cycles, int reps)
            where T : struct, IEquatable<T>
        {
            var vLen = Vec128<T>.Length;
            var primKind = PrimalKinds.kind<T>();
            var domain = Defaults.get<T>().Domain;
            var samples = vLen * reps;
            return new BenchConfig(cycles, reps, samples);
        }

        void RunAdHocInXBench()
        {
            
            var comparisons = new List<BenchComparison>();
            var bench = GInXBench.Create(ConfigureGInX(), Randomizer);
            comparisons.Add(bench.MulF32());
            comparisons.Add(bench.MulF64());
            iter(comparisons,print);

        }
        
        void RunInXBench()
        {
            var bench = GInXBench.Create(ConfigureGInX(), Randomizer);
            var comparisons = new List<BenchComparison>();
            foreach(var runner in bench.OpRunners().Select(r => r.Value))
                comparisons.Add(runner());
            iter(comparisons,print);

        }

        void RunGMathBench()
        {
            var bench = GMathBench.Create(Randomizer);
            var comparisons = new List<BenchComparison>();
            foreach(var runner in bench.OpRunners().Select(r => r.Value))
                comparisons.Add(runner());
            iter(comparisons,print);
        }
        void RunAdHocBench()
        {
            var bench = GMathBench.Create(Randomizer);
            var comparisons = new List<BenchComparison>();
            comparisons.Add(bench.MulF32());
            comparisons.Add(bench.MulF64());
            iter(comparisons,print);
        }

        static void Main(params string[] args)
        {            
            
            var bench = new Benchmark();
            bench.RunAdHocInXBench();
        }

    }

}