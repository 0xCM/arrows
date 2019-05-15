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

    
    using static zfunc;

    public partial class Num128Bench : BenchContext
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T12, AnnounceRate: Pow2.T10);

        public static Num128Bench Create(IRandomizer random, BenchConfig config = null)
            => new Num128Bench(random, config ?? DefaultConfig);

        protected BinOpData<T> BinOpInit<T>(bool nonzero = false)                
            where T : struct
        {
            GC.Collect();
            return new BinOpData<T>(
                Sample<T>(Config.SampleSize, nonzero), 
                Sample<T>(Config.SampleSize, nonzero), 
                alloc<T>(Config.SampleSize),
                alloc<T>(Config.SampleSize)
            );
        }

        protected Cycle MeasureCycles(OpId op, long opsPerCycle, Action action)
        {
            OpStats repeat(int cycles)
            {
                var timer = stopwatch(false);
                var opcount = 0L;

                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    timer.Start();
                    
                    action();
                    
                    timer.Stop();
                    opcount += opsPerCycle;
                                        
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(op, cycle, opcount, elapsed(timer)));                    
                }
                
                return  OpStats.Define(op, elapsed(timer), cycles, opcount);
            }
            
            return repeat;

        }

        protected Cycle Measure(OpId op, Func<long> action)
        {
            OpStats repeat(int cycles)
            {
                var timer = stopwatch(false);
                var opcount = 0L;

                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    timer.Start();
                    
                    opcount += action();
                    
                    timer.Stop();
                                        
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(op, cycle, opcount, elapsed(timer)));                    
                }
                
                return  OpStats.Define(op, elapsed(timer), cycles, opcount);
            }
            
            return repeat;
        }

        Num128Bench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {



        }

        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.Num128OpId<T>();

    }

}
