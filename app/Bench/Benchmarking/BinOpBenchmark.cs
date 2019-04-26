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
        public static BinOpBenchmark<T> Runner<T>(string opname, BenchConfig config = null)
            where T : struct, IEquatable<T>
                => new BinOpBenchmark<T>(opname, config);
    }


    public class BinOpBenchmark<T> : Benchmark<T>,  IBenchMark<TimedIndexBinOp<T>>, IBenchMark<Func<T,T,T>>
        where T : struct, IEquatable<T>
    {
        public BinOpBenchmark(string OpName,  BenchConfig config = null)
            :base(OpName, config ?? BenchConfig.Default)
        {

        }        

        protected BenchResult RunCycle(BenchResult current, Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker)
        {
            var ticks = 0L;
            LogCycleStart(current.CycleCount + 1);
            iter(Config.Reps, _ => ticks += worker(lhs,rhs));            
            var result = current.AppendCycle(Config.Reps, ticks);
            LogCycleFinish(result);
            return result;
        }

        BenchResult Run(Index<T> lhs, Index<T> rhs, Func<Index<T>, Index<T>, long> worker)
        {
            var result = BenchResult.Init(OpId);

            LogStart();
            for(var i = 0; i< Config.Cycles; i++)
                result += RunCycle(result, lhs, rhs, worker);
            LogFinish(result);

            return result;
        }

        static unsafe long TimedOp(Index<T> lhs, Index<T> rhs, out Index<T> dst, Func<T,T,T> Op)
        {
            var target = new T[lhs.Length];
            var sw = stopwatch();
            for(var i = 0; i< lhs.Length; i++)
                target[i] = Op(lhs[i],rhs[i]);
            dst = target;
            return sw.ElapsedTicks;
        }

        static unsafe long TimedOp(Index<T> lhs, Index<T> rhs, out Index<T> dst, Vec128BinOp<T> Op)
        {
            var sw = stopwatch();

            var target = new T[lhs.Length];
            var lArray = lhs.ToArray();
            var rArray = rhs.ToArray();
            var load = Vec128OpCache.Load<T>.Op;
            var store = Vec128OpCache.StoreP<T>.Op;

            for(var i = 0; i < lhs.Length; i += Vec128<T>.Length)                
            {
                var pLhs = pointer(ref lArray[i]);
                var pRhs = pointer(ref rArray[i]);
                var pDst = pointer(ref target[i]);

                load(pLhs, out Vec128<T> vLeft);
                load(pRhs, out Vec128<T> vRight);
                store(Op(vLeft,vRight), pDst);                
            }

            dst = target;
            return elapsed(sw);
        }

        public BenchResult Run(Func<T,T,T> Op)
        {
            TimedIndexBinOp<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<T> dst) 
                => TimedOp(lhs,rhs,out dst,Op);
            return Run(_TimedOp);
        }

        public BenchResult Run(Vec128BinOp<T> Op)
        {
            TimedIndexBinOp<T> _TimedOp = (Index<T> lhs, Index<T> rhs, out Index<T> dst)
                => TimedOp(lhs,rhs, out dst, Op);
            return Run(_TimedOp);             
        }
        
        public BenchResult Run(TimedIndexBinOp<T> Op)
            => Run(RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize),
                        (x,y) => Op(x, y, out Index<T> z));
    }
}