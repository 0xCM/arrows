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

    public class InXBench : BenchContext
    {   

        public static InXBench Create(BenchConfig Config, IRandomizer random)
            => new InXBench(Config, random);
        
        InXBench(BenchConfig Config, IRandomizer Randomizer)
            : base(Config, Randomizer)
        {

            gmath.init();

        }


        protected Interval<T> Domain<T>()
            where T : struct, IEquatable<T>
                => Defaults.get<T>().Domain;

        T[] Sample<T>()
            where T : struct, IEquatable<T>
                => Randomizer.Array(Domain<T>(), Config.SampleSize);
        
        BenchComparison BenchCompare<T>(string mode, OpKind op, long runtime, TimedPair timing)
            where T : struct, IEquatable<T>
        {
            var dSummary = new BenchSummary($"dinx/{mode}", op.OpId<T>(), 0, timing.Left, Duration.Define(runtime/2));
            var gSummary = new BenchSummary($"ginx/{mode}", op.OpId<T>(), 0, timing.Right, Duration.Define(runtime/2));
            return BenchComparison.Define(dSummary, gSummary);
        }

        BenchComparison RunArrays<T>(OpKind op)
            where T : struct, IEquatable<T>
        {
            var started = stopwatch();
            var lhs = Sample<T>();            
            var rhs = Sample<T>();            
            var timing = op switch {
                OpKind.Add => InXTiming.CompareAdd(Config.Cycles, lhs, rhs),
                _ => TimedPair.Zero
                
                };
            return BenchCompare<T>("array", op, elapsed(started), timing);
        }
        
        BenchComparison RunVectors<T>(OpKind op)
            where T : struct, IEquatable<T>
        {
            var started = stopwatch();
            var lhs = Vec128.load(Sample<T>());
            Claim.eq(lhs.Length, Config.Reps);

            var rhs = Vec128.load(Sample<T>());
            Claim.eq(rhs.Length, Config.Reps);

            var timing = op switch {
                OpKind.Add => InXTiming.CompareAdd(Config.Cycles, lhs, rhs),
                _ => TimedPair.Zero
                
                };
            return BenchCompare<T>("vec128", op, elapsed(started), timing);
        }

        public void Run()
        {            
            var comparisons = new List<BenchComparison>();        
            comparisons.Add(RunVectors<double>(OpKind.Add));
            GC.Collect();
            comparisons.Add(RunArrays<double>(OpKind.Add));

            iter(comparisons,print);
        }        
    }
}