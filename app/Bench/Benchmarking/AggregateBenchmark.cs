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

    public static class AggregateBenchmark
    {
        public static IBenchMark<TimedAggregateOp<T>> Runner<T>(string opname, BenchConfig config = null)
            where T : struct, IEquatable<T>
                => new AggregateBenchmark<T>(opname, config);

    }

    public class AggregateBenchmark<T> : Benchmark<T>,  IBenchMark<TimedAggregateOp<T>>
        where T : struct, IEquatable<T>
    {
        public AggregateBenchmark(string OpName,  BenchConfig config = null)
            :base(OpName, config ?? BenchConfig.Default)
        {

        }

        protected long TimeReps(Index<T> src, Func<Index<T>, long> worker)
        {
            var ticks = 0L;
            iter(Config.Reps, _ => ticks += worker(src));
            return ticks;
        }

        protected BenchResult RunCycle(Index<T> src, Func<Index<T>, long> worker, int cycle)
        {
            var result = BenchResult.Init(OpId);

            LogCycleStart(cycle);
            result = result.AppendRepTicks(TimeReps(src,worker));
            LogCycleFinish(cycle, result);

            return result;
        }


        BenchResult Run(Index<T> src, Func<Index<T>, long> worker)
        {
            var result = BenchResult.Init(OpId);
            
            LogStart();
            iter(Config.Cycles, i => result = result.AppendCycle(RunCycle(src, worker,i)));
            LogFinish(result);

            return result;
        }

        public BenchResult Run(TimedAggregateOp<T> Op)
            => Run(RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),                        
                        x => Op(x,  out T z)
                        );
    }
}