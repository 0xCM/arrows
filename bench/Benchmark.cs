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


        void MeasurePrimalGeneric()
        {
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: true);
            var comparison =  config.RunComparison(OpType.Define(OpKind.Add, PrimalKind.float64), true);
            print(comparison.FormatMessage());
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
            var cycles = Pow2.T15;
            var samples = Pow2.T14;
            var lhs = Randomizer.Array<int>(samples);
            var rhs = Randomizer.Array<int>(samples);
            var dst = span<int>(samples);
            gmath.init();

            while(true)
            {
                var sw1 = stopwatch();
                for(var i = 0; i< cycles; i++)
                    math.add(lhs, rhs, dst);
                print($"Direct Fused".PadRight(16) +  $"{snapshot(sw1).Ms} ms");

                var sw2 = stopwatch();
                for(var i = 0; i< cycles; i++)
                for(var j = 0; j< dst.Length; j++)
                    dst[j] = lhs[j] + rhs[j];                
                print($"Local Direct".PadRight(16) + $"{snapshot(sw2).Ms} ms");

                var sw3 = stopwatch();
                for(var i = 0; i< cycles; i++)
                    gmath.add(lhs, rhs, dst);                
                print($"Generic Fused".PadRight(16) +  $"{snapshot(sw3).Ms} ms");
                                    
                var sw4 = stopwatch();
                for(var i = 0; i< cycles; i++)
                for(var j = 0; j< dst.Length; j++)
                    dst[j] = gmath.add(lhs[j],  rhs[j]);                
                print($"Generic Atomic".PadRight(16) + $"{snapshot(sw4).Ms} ms");

                var sw5 = stopwatch();
                for(var i = 0; i< cycles; i++)
                for(var j = 0; j< dst.Length; j++)
                    dst[j] = math.add(lhs[j], rhs[j]);                
                print($"Direct Atomic".PadRight(16) + $"{snapshot(sw5).Ms} ms");
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