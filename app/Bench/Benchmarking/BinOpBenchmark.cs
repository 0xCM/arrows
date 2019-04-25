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

    public unsafe delegate long TimedIndexUnaryOp<T>(Index<T> src, out Index<T> dst)
        where T : struct, IEquatable<T>;

    public unsafe delegate long TimedAggregateOp<T>(Index<T> src, out T dst)
        where T : struct, IEquatable<T>;

    public static class BinOpBenchmark
    {
        public static IBenchMark<TimedIndexBinOp<T>> Runner<T>(string opname, BenchConfig config = null)
            where T : struct, IEquatable<T>
                => new BinOpBenchmark<T>(opname, config);


    }


    public class BinOpBenchmark<T> : Benchmark<T>,  IBenchMark<TimedIndexBinOp<T>>
        where T : struct, IEquatable<T>
    {

        public BinOpBenchmark(string OpName,  BenchConfig config = null)
            :base(OpName, config ?? BenchConfig.Default)
        {

        }        

        protected long TimeReps(Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker)
        {
            var ticks = 0L;
            iter(Config.Reps, _ => ticks += worker(lhs,rhs));
            return ticks;
        }

        protected BenchResult RunCycle(Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker, int cycle)
        {
            var result = BenchResult.Init(OpId);

            LogCycleStart(cycle);
            result = result.AppendRepTicks(TimeReps(lhs,rhs,worker));
            LogCycleFinish(cycle, result);

            return result;
        }

        BenchResult Run(Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker)
        {
            var result = BenchResult.Init(OpId);

            LogStart();
            iter(Config.Cycles, i => result = result.AppendCycle(RunCycle(lhs,rhs, worker,i)));
            LogFinish(result);

            return result;
        }


        public BenchResult Run(TimedIndexBinOp<T> Op)
            => Run(RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        (x,y) => Op(x, y, out Index<T> z));
    }
}