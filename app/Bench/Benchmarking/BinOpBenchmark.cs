//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;


    using static zcore;
    

    public unsafe delegate long TimedIndexBinOp<T>(Index<T> lhs, Index<T> rhs, out Index<T> dst)
        where T : struct, IEquatable<T>;

    public class BinOpBenchmark<T> : Benchmark<T>,  IBenchMark<TimedIndexBinOp<T>>
        where T : struct, IEquatable<T>
    {

        public BinOpBenchmark(string OpName,  BenchConfig config = null)
            :base(config ?? BenchConfig.Default)
        {
            this.OpName = OpName;
        }

        public string OpName {get;}

        static readonly long TicksPerMs = Stopwatch.Frequency/1000L;
        
        static long TicksToMs(long ticks)
            => ticks/TicksPerMs;

        BenchResult TimeWork(Index<T> lhs, Index<T> rhs, string OpName, Func<Index<T>, Index<T>, long> worker)
        {
            var kind = PrimKinds.kind<T>();
            var opid = $"{OpName}/{kind}";
            var totalResult = BenchResult.Init(opid);

            zcore.hilite($"{totalResult.OpId} Executing {Config.Cycles} cycles", SeverityLevel.HiliteCL);
            for(var i = 0; i < Config.Cycles; i ++)
            {
                var cycleResult = BenchResult.Init(opid);

                var statsMsg = $"Cycle = {i} | Samples = {Config.SampleSize} | Reps = {Config.Reps}";
                zcore.hilite($"{totalResult.OpId} Start  {statsMsg}", SeverityLevel.HiliteCL);

                
                for(var j = 0; j < Config.Reps; j++)                    
                    cycleResult = cycleResult.AppendRepTicks(worker(lhs,rhs));
                
                totalResult = totalResult.AppendCycle(cycleResult);                
                zcore.hilite($"{totalResult.OpId} Finish {statsMsg} | Duration = {cycleResult.Duration}ms", SeverityLevel.Perform);                        

            }
            
            zcore.hilite($"{totalResult}", SeverityLevel.HiliteCL);
            return totalResult;

        }


        public BenchResult Run(TimedIndexBinOp<T> Op)
            => TimeWork(RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        OpName,
                        (x,y) => Op(x, y, out Index<T> z)
                        );
    }
}