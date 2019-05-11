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
    
        protected void print(BenchComparisonRecord src)
        {
            zfunc.print(src, SeverityLevel.Perform);
        }
        
        protected IBenchComparison Compare(OpId opid, OpMeasurer left, OpMeasurer right)
        {
            var leftMeasure = left(Config.Cycles, Config.Reps);
            var rightMeasure = right(Config.Cycles, Config.Reps);            
            var lBench = BenchSummary.Define(opid, Config.Cycles, leftMeasure);
            var rBench = BenchSummary.Define(~opid, Config.Cycles, rightMeasure);
            return BenchComparison.Define(lBench,rBench);
        }

        protected BenchComparison Run<T>(OpId<T> opid, Cycle left, Cycle right)
            where T : struct, IEquatable<T>
        {
            var lStats = left(Config.Cycles);
            var rStats = right(Config.Cycles);
            Claim.eq(lStats.OpCount, rStats.OpCount);
            Claim.eq(lStats.Cycles, rStats.Cycles);
            var lBench = BenchSummary.Define(lStats.Op, Config.Cycles, lStats.OpCount, lStats.ExecTime);
            var rBench = new BenchSummary(rStats.Op, Config.Cycles,  rStats.OpCount, rStats.ExecTime);
            return BenchComparison.Define(lBench, rBench);
        }

        protected Cycle Measure(OpId opid, Func<OpMetrics> action)
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
                        zfunc.print(BenchmarkMessages.CycleStatus(opid, cycle, totalOps, totalTime));                    
                }
                
                return  OpStats.Define(opid, totalTime, cycles, totalOps);
            }
            
            return repeat;
        }

        protected Cycle Measure<T>(OpId<T> opid, Func<OpMetrics<T>> run)
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
                        zfunc.print(BenchmarkMessages.CycleStatus(opid, cycle, totalOps, totalTime));                    
                }
                
                return OpStats.Define(opid, totalTime, cycles, totalOps);
            }
            
            return repeat;
        }

        protected OpMeasurer Measure<T>(OpId<T> opid, Action action, int? OpCountPerRep = null)
            where T : struct, IEquatable<T>
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
                    
                    opcount += (OpCountPerRep ?? Config.SampleSize);
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(opid, cycle, opcount, elapsed(timer)));                    
                }
                
                return (opcount, elapsed(timer));
            }
            
            return  repeat;
        }

        protected T[] Sample<T>(int? samples = null, bool nonzero = false)
            where T : struct, IEquatable<T>
        {
            var zero = gmath.zero<T>();
            Func<T,bool> filter = nonzero  ? x => !x.Equals(zero)  : (Func<T,bool>)null;    
            return Randomizer.Array<T>(samples ?? Config.SampleSize, filter);
        }
        
        protected IBenchComparison Finish(IBenchComparison compared)
        {
            GC.Collect();
            return compared;
        }
 
        protected static T head<T>(T[] src)
            => src.FirstOrDefault();

        protected (T[] Left,T[] Right) ArrayTargets<T>(T specimen = default(T))
            where T : struct, IEquatable<T>
                => (alloc<T>(Config.SampleSize),
                    alloc<T>(Config.SampleSize));                
    }
}