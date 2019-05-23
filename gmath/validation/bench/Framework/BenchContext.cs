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
    

    public abstract class BenchContext<K> : Context
        where K : Enum
    {
        public BenchContext(K BenchKind, IRandomizer Randomizer, BenchConfig Config)
            : base(Randomizer)
        {
            this.BenchKind = BenchKind;
            this.Config = Config;
        }

        public K BenchKind {get;}

        protected void print(MetricComparisonRecord src)
        {
            zfunc.print(src, SeverityLevel.Perform);
        }

        protected void print(IReadOnlyList<MetricComparisonRecord> src, char delimiter = ',')
        {
            if(src.Count == 0)
                return;


            zfunc.print(AppMsg.Define(src[0].HeaderText(delimiter), SeverityLevel.HiliteCL));
            foreach(var record in src)
                zfunc.print(record, SeverityLevel.Perform);
        }

        public void Run(Func<string,bool> filter = null)
        {
            filter = filter ?? (s => true);
            
            var comparisons = new List<IMetricComparison>();
            foreach(var runner in Runners().Where(r => filter(r.name)).Select(r => r.runner))
                comparisons.Add(runner());

            var logTarget = LogTarget.Define(LogArea.Bench, BenchKind);
            var records = map(comparisons, c => c.ToRecord());
            log(records, logTarget, ext: FileExtension.Define("csv"));
                    
            zfunc.print(AppMsg.Define(string.Join(',', MetricComparisonRecord.GetHeaders()), SeverityLevel.Info));
            foreach(var c in comparisons)            
                 print(c.ToRecord());
        }

        public IEnumerable<(string name, OpRunner runner)> Runners()
        {
            var methods = GetType().Methods().Where(
                    m => !m.IsStatic && !m.IsAbstract  
                    && m.DeclaringType == this.GetType()
                    && m.GetParameters().Length == 0 
                    && m.ReturnType == type<IMetricComparison>());            
            return methods.Select(m => (m.Name, (OpRunner)Delegate.CreateDelegate(typeof(OpRunner),this,m))).OrderBy(x => x.Name);
        }

        public BenchConfig Config {get;}
    
        
        // protected IBenchComparison Compare(OpMeasurer left, OpMeasurer right)
        // {
        //     var leftMeasure = left(Config.Cycles, Config.Reps);
        //     var rightMeasure = right(Config.Cycles, Config.Reps);            
        //     var lBench = leftMeasure.Summarize();            
        //     var rBench = rightMeasure.Summarize();
        //     return BenchComparison.Define(lBench,rBench);
        // }

        protected MetricComparison Run<T>(OpId<T> opid, Cycle left, Cycle right)
            where T : struct
        {
            var lMetrics = left(Config.Cycles);
            var rMetrics = right(Config.Cycles);

            Claim.eq(lMetrics.OpCount, rMetrics.OpCount);
            var lBench = lMetrics.Summarize();
            var rBench = rMetrics.Summarize();
            return MetricComparison.Define(lBench, rBench);
        }

        protected Cycle Measure<T>(OpId<T> opid, Func<IMetrics> run)
            where T : struct
        {
            IMetrics repeat(int cycles)
            {
                var totalOps = 0L;
                var totalTime = Duration.Zero;
                var lastCycle = default(IMetrics);

                for(var cycle = 1; cycle <= cycles; cycle++)
                {                    
                    lastCycle = run();
                    totalOps += lastCycle.OpCount;
                    totalTime += lastCycle.WorkTime;
                                                                                
                    if(cycle % Config.AnnounceRate == 0)
                        zfunc.print(BenchmarkMessages.CycleStatus(opid, cycle, totalOps, totalTime));                    
                }                
                return Metrics.Define<T>(opid, totalOps, totalTime, lastCycle.Results<T>());
            }
            
            return repeat;
        }

        protected IMetricComparison Finish(IMetricComparison compared)
        {
            GC.Collect();
            return compared;
        }
 
        protected static T head<T>(T[] src)
            => src.FirstOrDefault();

        protected (T[] Left,T[] Right) ArrayTargets<T>(T specimen = default(T))
            where T : struct
                => (alloc<T>(Config.SampleSize),
                    alloc<T>(Config.SampleSize));                
    }
}