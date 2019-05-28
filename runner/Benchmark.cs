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
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static math;
    using static ansi;

    class Benchmark : Context
    {

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }

        void LogComparisons(IReadOnlyList<MetricComparisonRecord> comparisons, MetricKind kind)
        {
            var target = LogTarget.Define(LogArea.Bench, kind);
            log(comparisons, target, ext: FileExtension.Define("csv"));
        }

        void PrintComparisons(IReadOnlyList<MetricComparisonRecord> comparisons)
        {
            print(AppMsg.Define(MetricComparisonRecord.GetHeaderText(), SeverityLevel.Perform));
            foreach(var record in comparisons)
                print(record.FormatMessage());

        }

        void MeasureNumG()
        {
            var ops = items(OpKind.Add, OpKind.Mul, OpKind.Sub);
            var prims = items(PrimalKind.float32, PrimalKind.float64, PrimalKind.int64);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunNumGComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            LogComparisons(comparisons, MetricKind.PrimalGeneric);
            PrintComparisons(comparisons);
            
        }
        void MeasurePrimalGeneric()
        {
            var ops = items(OpKind.Sub,OpKind.Mul);
            var prims = items(PrimalKinds.All);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: true);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            LogComparisons(comparisons, MetricKind.PrimalGeneric);
            PrintComparisons(comparisons);

        }

        static IReadOnlyList<MetricComparisonRecord> MeasureInX128(IEnumerable<OpType> ops)
        {
            var config = InXMetricConfig128.Define(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T10);
            return config.RunComparisons(ops, true);
        }

        static IReadOnlyList<MetricComparisonRecord> MeasureInX256(IEnumerable<OpType> ops)
        {
            var config = InXMetricConfig256.Define(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);
            return config.RunComparisons(ops, true);
        }

        void MeasureAtomicInX()
        {
            var blocks = Pow2.T12;
            var lhs = Randomizer.Span256<double>(blocks).ToReadOnlySpan();
            var rhs = Randomizer.Span256<double>(blocks).ToReadOnlySpan(); 
            while(true)
            {
                var baseline = InXVecBench.Add(lhs,rhs);
                var inxAtomic = InXVecBench.AddAtomic(lhs, rhs);
                var primFused = PrimalGBench.Run<double>(OpKind.Add,lhs,rhs);

                print(baseline.Compare(inxAtomic).ToRecord().FormatMessage());                
            }
        }
        
      void MeasureIntrinsics()
       {            
            var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
            var ops = items(OpKind.Add, OpKind.Sub);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var comparisons = new List<MetricComparisonRecord>();            
            while(true)
            {
                comparisons.AddRange(MeasureInX128(specs));
                comparisons.AddRange(MeasureInX256(specs));
                print(comparisons.FormatMessages());
            }
       }

         // Converts an array of bytes into a long.  
        public static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }


        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {
                gmath.one<byte>();
                //app.RunTests();
                //app.MeasurePrimalGeneric();
                app.MeasureNumG();
                //app.MeasureIntrinsics();
                //app.MeasureAtomicInX();
                //app.RunSimpleBench();
                
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}