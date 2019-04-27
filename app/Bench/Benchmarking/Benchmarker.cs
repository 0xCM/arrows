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
    using Specs = System.Collections.Generic.IEnumerable<BenchSpec>;


    using static zcore;


    public static class Benchmarker
    {
        public static BenchResult Run(Specs specs, BenchConfig config = null)
        {
            var sw = stopwatch();       
            var pll = false;     
            config = config ?? BenchConfig.Default;
            var results =  pll 
                ? specs.AsParallel().Select(s => s(config)).OrderBy(x => x.OpId).ToList() 
                : specs.Select(s => s(config)).OrderBy(x => x.OpId).ToList();
                            
            iter(results, r => inform(r,string.Empty));
            var ticks = results.Select(x => x.TickCount).Sum();
            inform($"Total Bench Time = {ticksToMs(ticks)}",string.Empty);
            inform($"Total Runtime = {sw.ElapsedMilliseconds}",string.Empty);
            return results.Merge();
        }

    }



    public class Benchmarker<T> : Benchmark<T>
        where T : struct, IEquatable<T>
    {
        TimedOpConvert<T> OpConvert {get;}
        
        public Benchmarker(string OpName,  BenchConfig config = null)
            : base(OpName, config ?? BenchConfig.Default)
        {
            OpConvert = new TimedOpConvert<T>();
        }        

        protected BenchResult RunCycle(int cycle, Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker)
        {
            var ticks = 0L;
            var result = BenchResult.Init(cycle,OpId,Config.Reps);
            LogCycleStart(cycle);
            iter(Config.Reps, _ => ticks += worker(lhs,rhs));            
            result = result.AppendTicks(ticks);
            LogCycleFinish(result);
            return result;
        }

        BenchResult Run(Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker)
        {
            var result = BenchResult.Init(0,OpId,Config.Reps);

            LogStart();
            for(var i = 0; i< Config.Cycles; i++)
                result += RunCycle(i,lhs, rhs, worker);
            LogFinish(result);

            return result;
        }

        BenchResult Run(TimedFusedPred<T> Op)
            => Run(
                RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize), 
                RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),                        
                        (x,y) => Op(x, y,  out Index<bool> z));
                            
        BenchResult Run(TimedAggOp<T> Op)
            => Run(RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),                        
                        x => Op(x,  out T z));
                        
        protected BenchResult RunCycle(Index<T> src, Func<Index<T>, long> worker, int cycle)
        {
            var result = BenchResult.Init(cycle,OpId,Config.Reps);
            LogCycleStart(cycle);
            var ticks = 0L;
            iter(Config.Reps, _ => ticks += worker(src));
            result = result.AppendTicks(ticks);
            LogCycleFinish(result);
            return result;
        }

        BenchResult Run(Index<T> src, Func<Index<T>, long> worker)
        {
            var result = BenchResult.Init(0, OpId,Config.Reps);
            LogStart();
            iter(Config.Cycles, i => result = result.Merge(RunCycle(src, worker,i)));
            LogFinish(result);
            return result;
        }

        BenchResult Run(TimedFusedUnaryOp<T> Op)
            => Run(
                RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        x => Op(x, out Index<T> z));

       BenchResult Run(TimedFusedBinOp<T> Op)
            => Run(
                RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        (x,y) => Op(x, y, out Index<T> z)
                        );
 
        public BenchResult Run(PrimalFusedPred<T> Op)
        {
            TimedFusedPred<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<bool> dst) 
                => OpConvert.TimedOp(lhs,rhs,out dst,Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(PrimalFusedUnaryOp<T> Op)
        {
            TimedFusedUnaryOp<T> _TimedOp = (Index<T> src, out Index<T> dst) 
                => OpConvert.TimedOp(src,out dst,Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(PrimalFusedBinOp<T> Op)
        {
            TimedFusedBinOp<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<T> dst) 
                => OpConvert.TimedOp(lhs,rhs,out dst,Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(PrimalAggOp<T> Op)
        {
            TimedAggOp<T> _TimedOp = (Index<T> src, out T dst)  
                => OpConvert.TimedOp(src,out dst,Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(PrimalBinOp<T> Op)
        {
            TimedFusedBinOp<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<T> dst) 
                => OpConvert.TimedOp(lhs,rhs,out dst, Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(PrimalUnaryOp<T> Op)
        {
            TimedFusedUnaryOp<T> _TimedOp = (Index<T> src, out Index<T> dst) 
                => OpConvert.TimedOp(src, out dst, Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(Func<T,T,T> Op)
        {
            TimedFusedBinOp<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<T> dst) 
                => OpConvert.TimedOp(lhs,rhs,out dst,Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(Vec128BinOp<T> Op)
        {
            TimedFusedBinOp<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<T> dst)
                => OpConvert.TimedOp(lhs,rhs, out dst, Op);
            return Run(_TimedOp);             
        }

    }
}