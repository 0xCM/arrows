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
    using static mfunc;
    
    public delegate IBenchComparison OpRunner();

    public abstract class BenchContext : Context
    {
        public BenchContext(IRandomizer Randomizer, BenchConfig Config)
            : base(Randomizer)
        {
            this.Config = Config;
        }

        public void Run(Func<string,bool> filter = null)
        {
            filter = filter ?? (s => true);
            
            var comparisons = new List<IBenchComparison>();
            foreach(var runner in Runners().Where(r => filter(r.name)).Select(r => r.runner))
                comparisons.Add(runner());

            zfunc.print(AppMsg.Define(string.Join(',', BenchComparisonRecord.Headers()), SeverityLevel.Info));
            foreach(var c in comparisons)
                print(c.ToRecord());
        }

        public IEnumerable<(string name, OpRunner runner)> Runners()
        {
            var methods = GetType().GetMethods().Where(
                    m => m.IsPublic && !m.IsStatic && !m.IsAbstract  
                    && m.DeclaringType == this.GetType()
                    && m.GetParameters().Length == 0 
                    && m.ReturnType == type<IBenchComparison>());            
            return methods.Select(m => (m.Name, (OpRunner)Delegate.CreateDelegate(typeof(OpRunner),this,m))).OrderBy(x => x.Name);
        }

        public BenchConfig Config {get;}
    
        protected AppMsg ConfigStats
            => AppMsg.Define($"Cycles = {Config.Cycles}, Reps = {Config.Reps}, Ops = {Config.Cycles * Config.Reps}", SeverityLevel.Info);

        protected void print(BenchComparisonRecord src)
        {
            zfunc.print(src, SeverityLevel.Perform);
        }

        protected void print(IBenchComparison comparison)
        {
            zfunc.print(comparison.LeftMsg);
            zfunc.print(comparison.RightMsg);
            zfunc.print(comparison.CalcDelta().Description);
        }        
        
        protected IBenchComparison Compare(OpId op, OpMeasurer left, OpMeasurer right)
        {
            var leftMeasure = left(Config.Cycles, Config.Reps);
            var rightMeasure = right(Config.Cycles, Config.Reps);            
            var lBench = BenchSummary.Define(op, Config.Cycles, leftMeasure);
            var rBench = BenchSummary.Define(~op, Config.Cycles, rightMeasure);
            return BenchComparison.Define(lBench,rBench);
        }

        protected BenchComparison Compare(OpId op, Repeat left, Repeat right)
        {
            var lTime = left(Config.Cycles, Config.Reps);
            var rTime = right(Config.Cycles, Config.Reps);            
            var lBench = BenchSummary.Define(op, Config.Cycles, 0, lTime);
            var rBench = new BenchSummary(~op, Config.Cycles, 0, rTime);
            return BenchComparison.Define(lBench,rBench);
        }

        protected BenchComparison<OpId<T>> Measure<T>(OpMeasurer<T> left, OpMeasurer<T> right)
            where T : struct, IEquatable<T>
        {
            var lhs = left(Config.Cycles , Config.Reps);
            var rhs = right(Config.Cycles, Config.Reps);            
            return BenchComparison.Define(
                BenchSummary.Define(lhs.OpId, Config.Cycles, lhs), 
                BenchSummary.Define(rhs.OpId, Config.Cycles, rhs));                    
        }

        protected BenchComparison Run<T>(T title, Cycle left, Cycle right, int? cycles = null)
        {
            var lStats = left(Config.Cycles);
            var rStats = right(Config.Cycles);
            Claim.eq(lStats.OpCount, rStats.OpCount);
            Claim.eq(lStats.Cycles, rStats.Cycles);
            var lBench = BenchSummary.Define(lStats.Op, Config.Cycles, lStats.OpCount, lStats.ExecTime);
            var rBench = new BenchSummary(rStats.Op, Config.Cycles,  rStats.OpCount, rStats.ExecTime);
            return BenchComparison.Define(lBench, rBench);
        }


        BenchComparison<OpId<T>> Compare<T>(OpMetrics<T> lhs, OpMetrics<T> rhs)
            where T : struct, IEquatable<T>
        {
            return BenchComparison.Define(
                BenchSummary.Define(lhs.OpId, Config.Cycles, lhs), 
                BenchSummary.Define(rhs.OpId, Config.Cycles, rhs));                    
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

        protected Cycle Measure(OpId op, Func<OpMetrics> action)
        {
            OpStats repeat(int cycles)
            {
                var totalOps = 0L;
                var totalTime = Duration.Zero;

                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    
                    var cycleResult = action();
                    totalOps += cycleResult.OpCount;
                    totalTime += cycleResult.WorkTime;
                                        
                                        
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(op, cycle, totalOps, totalTime));                    
                }
                
                return  OpStats.Define(op, totalTime, cycles, totalOps);
            }
            
            return repeat;
        }

        protected Cycle Measure<T>(OpId<T> op, Func<OpMetrics<T>> run)
            where T : struct, IEquatable<T>
        {
            OpStats repeat(int cycles)
            {
                var totalOps = 0L;
                var totalTime = Duration.Zero;

                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    
                    var result = run();
                    totalOps += result.OpCount;
                    totalTime += result.WorkTime;
                                                                                
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(op, cycle, totalOps, totalTime));                    
                }
                

                return OpStats.Define(op, totalTime, cycles, totalOps);
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

        /// <summary>
        /// Measures the time required to iterate an action over a specified number
        /// of cycles, each of which iterate the action over a specified number of
        /// repetitions
        /// </summary>
        /// <param name="action">The action for which a cyclic measure is to be obtained</param>
        /// <param name="cycles">The number of cycles to iterate</param>
        /// <param name="reps">The number of reps to iterate</param>
        protected Repeat Measure<T>(T title, int? samples, Action action)
        {
            Duration repeat(int cycles, int reps)
            {
                var timer = stopwatch(false);
                var opcount = 0L;

                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    timer.Start();
                    
                    for(var rep = 1; rep <= reps; rep++)
                        action();
                    
                    timer.Stop();
                    
                    opcount += ((long)reps *  (long)(samples ?? Config.SampleSize));
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(title, cycle, opcount, elapsed(timer)));                    
                }
                
                return elapsed(timer);
            }
            
            return  repeat;
        }

        protected OpMeasurer Measure<T>(T title, Action action, int OpCountPerRep = 1)
        {
            OpMetrics repeat(int cycles, int reps)
            {
                var timer = stopwatch(false);
                var opcount = 0L;

                for(var cycle = 1; cycle <= cycles; cycle++)
                {
                    timer.Start();
                    
                    for(var rep = 1; rep <= reps; rep++)
                        action();
                    
                    timer.Stop();
                    
                    opcount += OpCountPerRep;
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(title, cycle, opcount, elapsed(timer)));                    
                }
                
                return (opcount, elapsed(timer));
            }
            
            return  repeat;
        }

        // protected OpMeasurer<T> RunMeasure<T>(OpId<T> op, OpMeasurer<T> measurer)
        //     where T : struct, IEquatable<T>
        // {
        //     OpMeasure<T> repeat(int cycles, int reps)
        //     {
        //         var timer = stopwatch(false);
        //         var opcount = 0L;

        //         for(var cycle = 1; cycle <= cycles; cycle++)
        //         {
        //             timer.Start();
                    
        //             for(var rep = 1; rep <= reps; rep++)
        //                 opcount += action();
                    
        //             timer.Stop();
                    
        //             if(cycle % Config.AnnounceRate == 0)
        //                 zfunc.print(BenchmarkMessages.CycleStatus(op, cycle, opcount, elapsed(timer)));                    
        //         }
                
        //         return (opcount, elapsed(timer));
        //     }
            
        //     return  repeat;
        // }

        protected T[] Sample<T>(int? samples = null, bool nonzero = false)
            where T : struct, IEquatable<T>
        {
            var zero = gmath.zero<T>();
            Func<T,bool> filter = nonzero  ? x => !x.Equals(zero)  : (Func<T,bool>)null;    
            return Randomizer.Array<T>(samples ?? Config.SampleSize, filter);
        }
                 
        protected T[] Init<T>(bool nonzero = false)
            where T : struct, IEquatable<T>
        {
            GC.Collect();
            return Sample<T>(Config.SampleSize,nonzero);
        }

        protected BinOpData<T> BinOpInit<T>(bool nonzero = false)                
            where T : struct, IEquatable<T>
        {
            GC.Collect();
            return new BinOpData<T>(
                Sample<T>(Config.SampleSize, nonzero), 
                Sample<T>(Config.SampleSize, nonzero), 
                alloc<T>(Config.SampleSize),
                alloc<T>(Config.SampleSize)
            );
        }
        
        protected UnaryOpData<T> UnaryOpInit<T>(bool nonzero = false)                
            where T : struct, IEquatable<T>
        {
            GC.Collect();
            return new UnaryOpData<T>(
                Sample<T>(Config.SampleSize, nonzero), 
                alloc<T>(Config.SampleSize),
                alloc<T>(Config.SampleSize)
            );
        }

        protected IBenchComparison Finish(IBenchComparison compared)
        {
            GC.Collect();
            return compared;
        }


        protected unsafe void SampleTo<T>(void* pDst, int? samples = null, bool nonzero = false)
            where T : struct, IEquatable<T>
        {
            var domain = Defaults.get<T>().Domain;
            Randomizer.StreamTo<T>(domain, samples ?? Config.SampleSize, pDst);             
        }
 
       protected static T head<T>(T[] src)
            => src.FirstOrDefault();

        protected (T[] Left,T[] Right) ArrayTargets<T>(T specimen = default(T))
            where T : struct, IEquatable<T>
                => (alloc<T>(Config.SampleSize),
                    alloc<T>(Config.SampleSize));                

    }
}