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

    public delegate BenchComparison OpRunner(int? cycles = null, int? samples = null);

    public abstract class BenchContext : Context
    {
        public BenchContext(BenchConfig Config, IRandomizer Randomizer)
            : base(Randomizer)
        {
            this.Config = Config;
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
        
        protected BenchComparison Compare(OpId op, Cycle direct, Cycle generic, int? cycles, int? reps, int? samples)
        {
            var running = stopwatch();
            var _cycles = cycles ?? Config.Cycles;
            var _reps = reps ?? Config.Reps;
            var _samples = samples ?? Config.SampleSize;
            var opcount = (long)((long)_reps * (long)_cycles * (long)(_samples));
            var dTime = direct(cycles ?? Config.Cycles,reps ?? Config.Reps);
            var gTime = generic(cycles ?? Config.Cycles, reps ?? Config.Reps);            
            var runtime = snapshot(running);
            var dBench = BenchDetail.Define(op, _cycles, _reps, _samples, opcount, dTime, runtime.Half());
            var gBench = new BenchSummary(~op, opcount, gTime, runtime.Half());
            var comparison = BenchComparison.Define(dBench,gBench);
            return comparison;
        }

        /// <summary>
        /// Measures the time required to iterate an action over a specified number
        /// of cycles, each of which iterate the action over a specified number of
        /// repetitions
        /// </summary>
        /// <param name="action">The action for which a cyclic measure is to be obtained</param>
        /// <param name="cycles">The number of cycles to iterate</param>
        /// <param name="reps">The number of reps to iterate</param>
        protected Cycle Measure<T>(T title, int? samples, Action action)
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

        public IReadOnlyDictionary<string,OpRunner> OpRunners()
        {
            var methods = GetType().GetMethods().Where(
                    m => m.IsPublic && !m.IsStatic && !m.IsAbstract  
                    && m.DeclaringType == this.GetType()
                    && m.GetParameters().Length == 2 
                    && m.ReturnType == typeof(BenchComparison));
            
            var runners = map(methods, m => (m.Name, (OpRunner) Delegate.CreateDelegate(typeof(OpRunner),this,m))).ToDictionary();
            return runners;            
        }

    }
}