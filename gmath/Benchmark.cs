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

    static class Benchmark
    {
        static readonly PrimalKind[] Primitives = new PrimalKind[]{
                //PrimalKind.int16, PrimalKind.uint16,
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

        static void RunIntrinsicBench(IRandomizer randomizer)
        {
            var cycles = Pow2.T16;
            var reps = Pow2.T14;            
            var gbench = InXBench.Create(ConfigureVec128<double>(cycles,reps), randomizer);
            gbench.Run();

        }

        static BenchConfig ConfigurePrimal(int? cycles = null, int? reps = null)
        {
            return new BenchConfig(cycles ?? 1400, reps ?? Pow2.T18, reps ?? Pow2.T18, primitives: Primitives);            
        }
        static PrimalBench Primal(IRandomizer randomizer)
            => PrimalBench.Create(PrimalBench.DefaultConfig, randomizer);
        
        static void RunPrimalBench(IRandomizer randomizer, BenchConfig config = null)
        {
            PrimalBench.Create(config ?? ConfigurePrimal(), randomizer).Run();            
        }


        static void Main(params string[] args)
        {            
            var randomizer = Z0.Randomizer.define(RandSeeds.BenchSeed);
            var config = ConfigurePrimal()
                            .WithPrimitives(PrimalKind.float32,PrimalKind.float64)
                            .WithActiveOperators();
            RunPrimalBench(randomizer, config);
        }

    }



}