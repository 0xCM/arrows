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

    using Z0.Test;

    
    using static zfunc;    
    using static mfunc;    
    using static math;
    using static ansi;


    partial class Benchmark : Context
    {

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
        }


        void RunTests()
        {
            TestRunner.RunTests(string.Empty, false);
        }


        public static IEnumerable<IMetrics> Run(IEnumerable<MetricKind> metrics, IEnumerable<OpKind> ops, 
            IEnumerable<PrimalKind> primitives, MetricConfig config = null, IRandomizer random = null)
        {
            var query = from m in metrics
                        from o in ops
                        from p in primitives
                        select m.Run(o,p, config, random);
            return query;
        }

       MetricComparisonRecord MeasurePrimalGeneric(MetricConfig config, OpType op)
        => config.Compare(op, true);

        void MeasurePrimalGeneric()
        {
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            var comparison = MeasurePrimalGeneric(config, OpType.Define(OpKind.Mul, PrimalKind.float64));
            print(comparison.FormatMessage());

        }


        IReadOnlyList<MetricComparisonRecord> MeasureInX128(IEnumerable<OpType> ops)
        {
            var config = InXMetricConfig128.Define(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T10);
            var comparisons = new List<MetricComparisonRecord>();            
            comparisons.AddRange(config.CollectComparisons(ops, true));
            return comparisons;
        }

        IReadOnlyList<MetricComparisonRecord> MeasureInX256(IEnumerable<OpType> ops)
        {
            var config = InXMetricConfig256.Define(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);
            var comparisons = new List<MetricComparisonRecord>();            
            comparisons.AddRange(config.CollectComparisons(ops, true));
            return comparisons;
        }

       void MeasureIntrinsics()
       {            
            var ops = items(PrimalKind.float32, PrimalKind.float64, PrimalKind.int64).Map(primal => OpKind.Add.WithType(primal));            
            var comparisons = new List<MetricComparisonRecord>();            
            //comparisons.AddRange(MeasureInX128(ops));
            comparisons.AddRange(MeasureInX256(ops));
            print(comparisons.FormatMessages());

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
                app.MeasureIntrinsics();
                
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}