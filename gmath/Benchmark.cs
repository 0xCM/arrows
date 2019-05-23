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

       IReadOnlyList<MetricComparisonRecord> CompareMetrics(int runs = Pow2.T04, int cycles = Pow2.T13, int samples = Pow2.T13)
       {
            var config = MetricConfig.Define(runs: runs, cycles: cycles, samples: samples, dops: true);
            var prim = PrimalKind.float32;
            var baseline = MetricKind.PrimalDirect;
            var benchmark = MetricKind.PrimalGeneric;
            var operators = items(OpKind.Add, OpKind.Mul);
            var specs =  operators.Select(op => baseline.DefineComparison(benchmark, prim, op));
            return specs.Run(config).ToReadOnlyList();
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
            var config = MetricConfig.Define(runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            
            var m1 = MetricKind.PrimalDirect.Run(OpKind.Add, PrimalKind.float32, config);
            print(m1.Describe());

            var m2 = MetricKind.PrimalGeneric.Run(OpKind.Add, PrimalKind.float32, config);
            print(m2.Describe());

            print(items(m1.Compare(m2).ToRecord()).FormatMessages());

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
                while(true)
                    app.CompareMetrics();
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}