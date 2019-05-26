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

    partial class Benchmark : Context
    {

        public Benchmark()
            :base(Z0.Randomizer.define(RandSeeds.BenchSeed))
        {
            
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

        void MeasurePrimalGeneric()
        {
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: true);
            var comparison =  config.Compare(OpType.Define(OpKind.Add, PrimalKind.float64), true);
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

        void MeasureAtomicInX()
        {
            var blocks = Pow2.T12;
            var lhs = Randomizer.Span256<double>(blocks).ToReadOnlySpan();
            var rhs = Randomizer.Span256<double>(blocks).ToReadOnlySpan(); 
            while(true)
            {
                var baseline = InXVecBench.Add(lhs,rhs);
                var inxAtomic = InXVecBench.AddAtomic(lhs, rhs);
                var primFused = PrimalGBench.Add<double>(lhs,rhs);

                print(baseline.Compare(inxAtomic).ToRecord().FormatMessage());                
                //print(baseline.Compare(primFused).ToRecord().FormatMessage());                
                //print(primFused.Compare(inxAtomic).ToRecord().FormatMessage());                
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
                //comparisons.AddRange(MeasureInX256(ops));
                print(comparisons.FormatMessages());
            }
       }

         // Converts an array of bytes into a long.  
        public static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }

        public void RunSimpleBench()
        {
            var cycles = Pow2.T13;
            var lhs = Randomizer.Array<int>(Pow2.T15);
            var rhs = Randomizer.Array<int>(Pow2.T15);
            var dst = span<int>(Pow2.T15);

            while(true)
            {
                var sw3 = stopwatch();
                for(var i = 0; i< cycles; i++)
                    gmath.add(lhs, rhs, dst);
                
                print($"Generic Fused {snapshot(sw3)}");
            
                var sw1 = stopwatch();
                for(var i = 0; i< cycles; i++)
                for(var j = 0; j< dst.Length; j++)
                    dst[i] = lhs[i] + rhs[i];
                print($"Direct {snapshot(sw1)}");

                var sw2 = stopwatch();
                for(var i = 0; i< cycles; i++)
                for(var j = 0; j< dst.Length; j++)
                    dst[i] = gmath.add(lhs[i], rhs[j]);                
                print($"Generic Atomic {snapshot(sw2)}");
            
            
            
            }

            
        }

        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {
                gmath.one<byte>();
                //app.RunTests();
                //app.MeasurePrimalGeneric();
                //app.MeasureIntrinsics();
                //app.MeasureAtomicInX();
                app.RunSimpleBench();
                
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}