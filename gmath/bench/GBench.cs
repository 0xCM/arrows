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

    public class GBench : BenchContext
    {   
        static BenchConfig Configure<T>(int cycles, int reps)
            where T : struct, IEquatable<T>
        {
            var vLen = Vec128<T>.Length;
            var primKind = PrimalKinds.kind<T>();
            var domain = Defaults.get<T>().Domain;
            var samples = vLen * reps;

            return new BenchConfig(cycles, reps, samples);

        }

        static void Main(params string[] args)
        {            
            var cycles = Pow2.T15;
            var reps = Pow2.T14;            
            var gbench = GBench.Create(Configure<double>(cycles,reps), 
                Z0.Randomizer.define(RandSeeds.BenchSeed));
            gbench.Run();

        }

        public static GBench Create(BenchConfig Config, IRandomizer random)
            => new GBench(Config, random);
        
        GBench(BenchConfig Config, IRandomizer Randomizer)
            : base(Config,Randomizer)
        {

            gmath.init();

        }

        void print(string title, Duration duration)
        {
            var message = AppMsg.Define($"{title}".PadLeft(15)  + $" Duration = {duration}", SeverityLevel.Perform);
            zcore.print(message);
        }

        void print(BenchComparison comparison)
        {
            zcore.print(comparison.LeftBench.Description);
            zcore.print(comparison.RightBench.Description);
            zcore.print(comparison.CalcDelta().Description);

        }

        protected static string DTitle(OpId opid)
            => $"dinx/{opid}";

        protected static string GTitle(OpId opid)
            => $"ginx/{opid}";

        protected static OpId OpId<T>(OpKind kind)
            where T : struct, IEquatable<T>
                => Z0.OpId.Define(OpKind.Add, PrimalKinds.kind<T>());

        protected Interval<T> Domain<T>()
            where T : struct, IEquatable<T>
                => Defaults.get<T>().Domain;

        protected string DCycleTitle(int cycle, OpId opid)
            => $"{DTitle(opid)} Cycle {cycle}";

        protected string GCycleTitle(int cycle, OpId opid)
            => $"{GTitle(opid)} Cycle {cycle}";

        void AddDirect(ref Duration total, int cycle, bool announce, Vec128<double>[] lhs, Vec128<double>[] rhs)
        {
            var opid = OpId<double>(OpKind.Add);
            var title = DCycleTitle(cycle,opid);
            var timing= Timing.begin(title, announce);                
            for(var rep = 0; rep < Config.Reps; rep++)
                dinx.add(lhs[rep], rhs[rep]);                
            Timing.end(ref total, timing, announce);

        }

        void AddDirect<T>(ref Duration total, int cycle, bool announce, Vec128<T>[] lhs, Vec128<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.float64)
            {
                var xLhs = As.float64(lhs);
                var xRhs = As.float64(lhs);
                AddDirect(ref total, cycle, announce, xLhs, xRhs);
            }
        }

        void AddGeneric<T>(ref Duration total, int cycle, bool announce, Vec128<T>[] lhs, Vec128<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var opid = OpId<T>(OpKind.Add);
            var title = GCycleTitle(cycle,opid);
            var timing = Timing.begin(title, announce);                
            for(var rep = 0; rep < Config.Reps; rep++)
                ginx.add(lhs[rep], rhs[rep]);                                    
            Timing.end(ref total, timing, announce);

        }

        void SummarizeRun(OpId opid, Duration dTotal, Duration gTotal)
        {
            inform($"{Config}");
            print($"{DTitle(opid)} Total", dTotal);
            print($"{GTitle(opid)} Total", gTotal);

        }

        Vec128<T>[] Sample<T>()
            where T : struct, IEquatable<T>
        {
            var data = Randomizer.Array(Domain<T>(), Config.SampleSize);
            var vectors = Vec128.load<T>(data);
            Claim.eq(vectors.Length, Config.Reps);
            return vectors;
        }

        void Run<T>(OpKind op)
            where T : struct, IEquatable<T>
        {
            var opid = OpId<T>(op);            
            var lhs = Sample<T>();
            var rhs = Sample<T>();
            var gTotal = Duration.Zero;
            var dTotal = Duration.Zero;
            var opcount = 0L;

            bool tell()
                => opcount % Config.AnnounceRate == 0;

            if(op == OpKind.Add)
            {

                for(var cycle = 1; cycle <= Config.Cycles; cycle++, opcount += 2*Config.Reps)
                {
                    var announce = tell();
                    AddGeneric(ref gTotal, cycle, announce, lhs,rhs);
                    AddDirect(ref dTotal, cycle, announce, lhs,rhs);
                }
            } 

            SummarizeRun(opid, dTotal, gTotal);

        }

        public void Run()
        {            
            Run<double>(OpKind.Add);
        }        
    }
}