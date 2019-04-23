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
    
    public interface IBenchmarkRunner
    {
        long Run();
    }

    public class BinOpRunner<T> : Benchmark<T>,  IBenchmarkRunner
        where T : struct, IEquatable<T>
    {

        public BinOpRunner(TimedIndexBinOp<T> BinOp, string OpName,  BenchConfig config = null)
            :base(config ?? BenchConfig.Default)
        {
            this.BinOp = BinOp;
            this.OpName = OpName;
        }


        TimedIndexBinOp<T> BinOp {get;}

        public string OpName {get;}

        static readonly long TicksPerMs = Stopwatch.Frequency/1000L;
        
        static long TicksToMs(long ticks)
            => ticks/TicksPerMs;

        public override long Run()
        {
            var totalTicks = 0L;
            var lhs = RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize);
            var rhs = RandomIndex<T>(Settings.Domain<T>(), Config.SampleSize);

            var kind = PrimKinds.kind<T>();
            var opinfo = $"{OpName}/{kind}";

            zcore.hilite($"{opinfo} Executing {Config.Cycles} cycles", SeverityLevel.HiliteCL);
            for(var i = 0; i < Config.Cycles; i ++)
            {
                var cycleTicks = 0L;

                var statsMsg = $"Cycle = {i} | Samples = {Config.SampleSize} | Reps = {Config.Reps}";
                zcore.hilite($"{opinfo} Start  {statsMsg}", SeverityLevel.HiliteCL);

                for(var j = 0; j < Config.Reps; j++)                    
                   cycleTicks += BinOp(lhs,rhs,out Index<T> dst);

                zcore.hilite($"{opinfo} Finish {statsMsg} | Duration = {TicksToMs(cycleTicks)}ms", SeverityLevel.Perform);                        

                totalTicks += cycleTicks;

            }
            
            var msTotal = TicksToMs(totalTicks);
            zcore.hilite($"{opinfo} Summary: Cycles = {Config.Cycles}, Reps = {Config.Reps} | Duration = {msTotal}ms", SeverityLevel.HiliteCL);
            return msTotal;
        }
    }
}