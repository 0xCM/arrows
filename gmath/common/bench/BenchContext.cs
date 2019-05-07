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

    using static zcore;
    using static zfunc;
    using static mfunc;
    
    public delegate BenchComparison OpRunner();

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
            
            var comparisons = new List<BenchComparison>();
            foreach(var runner in Runners().Where(r => filter(r.Key)).Select(r => r.Value))
                comparisons.Add(runner());
            iter(comparisons,print);
        }

        public IReadOnlyDictionary<string,OpRunner> Runners()
        {
            var methods = GetType().GetMethods().Where(
                    m => m.IsPublic && !m.IsStatic && !m.IsAbstract  
                    && m.DeclaringType == this.GetType()
                    && m.GetParameters().Length == 0 
                    && m.ReturnType == typeof(BenchComparison));
            
            var runners = map(methods, m => (m.Name, (OpRunner) Delegate.CreateDelegate(typeof(OpRunner),this,m))).ToDictionary();
            return runners;            
        }


        public BenchConfig Config {get;}
    
        protected AppMsg ConfigStats
            => AppMsg.Define($"Cycles = {Config.Cycles}, Reps = {Config.Reps}, Ops = {Config.Cycles * Config.Reps}", SeverityLevel.Info);


        protected void print(BenchComparison comparison)
        {
            zcore.print(comparison.LeftBench.Description);
            zcore.print(comparison.RightBench.Description);
            zcore.print(comparison.CalcDelta().Description);
        }        
        
        protected BenchComparison Compare(OpId op, Repeat left, Repeat right, int? cycles, int? reps, int? samples)
        {
            var _cycles = cycles ?? Config.Cycles;
            var _reps = reps ?? Config.Reps;
            var dTime = left(_cycles , _reps);
            var gTime = right(_cycles, _reps);            
            var dBench = BenchSummary.Define(op, _cycles, 0, dTime);
            var gBench = new BenchSummary(~op, _cycles, 0, gTime);
            return BenchComparison.Define(dBench,gBench);
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
                        zcore.print(BenchmarkMessages.CycleStatus(op, cycle, opcount, elapsed(timer)));                    
                }
                
                return  OpStats.Define(op, elapsed(timer), cycles, opcount);
            }
            
            return repeat;

        }

        protected Cycle Measure(OpId op, Func<OpMeasure> action)
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
                        zcore.print(BenchmarkMessages.CycleStatus(op, cycle, totalOps, totalTime));                    
                }
                
                return  OpStats.Define(op, totalTime, cycles, totalOps);
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
                        zcore.print(BenchmarkMessages.CycleStatus(op, cycle, opcount, elapsed(timer)));                    
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
                        zcore.print(BenchmarkMessages.CycleStatus(title, cycle, opcount, elapsed(timer)));                    
                }
                
                return elapsed(timer);
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
                 
        protected T[] Init<T>(int? samples, bool nonzero = false)
            where T : struct, IEquatable<T>
        {
            GC.Collect();
            return Sample<T>(samples,nonzero);
        }

        protected BinOpData<T> BinOpInit<T>(int? samples, bool nonzero = false)                
            where T : struct, IEquatable<T>
        {
            GC.Collect();
            return new BinOpData<T>(
                Sample<T>(samples ?? Config.SampleSize, nonzero), 
                Sample<T>(samples ?? Config.SampleSize, nonzero), 
                alloc<T>(samples ?? Config.SampleSize),
                alloc<T>(samples ?? Config.SampleSize)
            );
        }
        
        protected UnaryOpData<T> UnaryOpInit<T>(int? samples, bool nonzero = false)                
            where T : struct, IEquatable<T>
        {
            GC.Collect();
            return new UnaryOpData<T>(
                Sample<T>(samples ?? Config.SampleSize, nonzero), 
                alloc<T>(samples ?? Config.SampleSize),
                alloc<T>(samples ?? Config.SampleSize)
            );
        }

        protected BenchComparison Finish(BenchComparison compared)
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
    }
}