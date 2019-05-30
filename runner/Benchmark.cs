//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0.Metrics;

    using static zfunc;    
    using static math;
    using static ansi;

    class Benchmark : Context
    {

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }

        IReadOnlyList<MetricComparisonRecord> Emit(IReadOnlyList<MetricComparisonRecord> comparisons, MetricKind kind, bool silent = false)
        {
            var target = LogTarget.Define(LogArea.Bench, kind);
            log(comparisons, target, ext: FileExtension.Define("csv"));
            if(!silent)
            {
                print(AppMsg.Define(MetricComparisonRecord.GetHeaderText(), SeverityLevel.Perform));
                foreach(var record in comparisons)
                    print(record.FormatMessage());
            }
            return comparisons;
        }
        
        IReadOnlyList<MetricComparisonRecord> MeasureNumG()
        {
            var ops = items(OpKind.Add, OpKind.Mul, OpKind.Sub);
            var prims = items(PrimalKind.float32, PrimalKind.float64, PrimalKind.int64);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = NumGConfig.Define(MetricKind.NumG,runs: Pow2.T03, cycles: Pow2.T13, samples: Pow2.T11, dops: false);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;            
        }

        IReadOnlyList<MetricComparisonRecord> MeasureBitsG()
        {
            var ops = items(OpKind.ToggleBit, OpKind.Pop);
            var prims = PrimalKinds.Integral;
            var optypes =from o in ops from p in prims select OpType.Define(o,p);
            var config = BitGConfig.Define(MetricKind.BitG, runs: Pow2.T03, cycles: Pow2.T12, samples: Pow2.T11, dops: true);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;
        }
        IReadOnlyList<MetricComparisonRecord> MeasurePrimalG()
        {
            var ops = items(OpKind.Sub, OpKind.Mul, OpKind.Add, OpKind.GtEq, OpKind.LtEq, OpKind.Eq);
            var prims = items(PrimalKinds.All);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = PrimalGConfig.Define(MetricKind.PrimalG, runs: Pow2.T03, cycles: Pow2.T12, samples: Pow2.T11, dops: false);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;

        }

        IReadOnlyList<MetricComparisonRecord> MeasureInX256Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int32, PrimalKind.int64, PrimalKind.float32, PrimalKind.float64);
            var ops = items(OpKind.And, OpKind.Add, OpKind.Sub, OpKind.XOr);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXConfig256.Define(MetricKind.InX256GFused, runs: Pow2.T03, cycles: Pow2.T13, blocks: Pow2.T11);
            return config.RunComparisons(specs);

       }
        
        IReadOnlyList<MetricComparisonRecord> MeasureInX128Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
            var ops = items(OpKind.Add, OpKind.Sub);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXConfig128.Define(MetricKind.InX128GFused, runs: Pow2.T03, cycles: Pow2.T12, blocks: Pow2.T11);
            return config.RunComparisons(specs);
       }

         // Converts an array of bytes into a long.  
        public static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }

        IReadOnlyList<MetricComparisonRecord> MeasureConversions()
        {
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var comparison in ConversionBench.Run())
                comparisons.Add(comparison);
            return comparisons;
        }

        IReadOnlyList<MetricComparisonRecord> Measure(MetricKind metric)
        {
            switch(metric)
            {
                case MetricKind.NumG:
                    return Emit(MeasureNumG(),metric);
                case MetricKind.BitD:
                case MetricKind.BitG:
                    return Emit(MeasureBitsG(),metric);
                case MetricKind.PrimalD:
                case MetricKind.PrimalG:
                    return Emit(MeasurePrimalG(),metric);
                case MetricKind.InX128DFused:
                case MetricKind.InX128GFused:
                    return Emit(MeasureInX128Fused(), metric);
                case MetricKind.InX256DFused:
                case MetricKind.InX256GFused:
                    return Emit(MeasureInX256Fused(), metric);
                case MetricKind.ConvertD:
                case MetricKind.ConvertG:
                    return Emit(MeasureConversions(),metric);

                default:
                    throw unsupported(metric);
            }
        }

        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {
                gmath.init();

                //app.RunTests();
                //app.Measure(MetricKind.PrimalG);
                //app.Measure(MetricKind.InX128GFused);
                app.Measure(MetricKind.InX256GFused);
                //app.Measure(MetricKind.NumG);
                app.Measure(MetricKind.BitG);
                
                
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}