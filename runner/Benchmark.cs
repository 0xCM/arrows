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

        IReadOnlyList<MetricComparisonRecord> Measure(MetricKind metric)
        {
            switch(metric)
            {
                case MetricKind.NumG:
                    return MeasureNumG();
                case MetricKind.BitD:
                case MetricKind.BitG:
                    return MeasureBitsG();
                case MetricKind.PrimalD:
                case MetricKind.PrimalG:
                    return MeasurePrimalG();
                case MetricKind.InX128DFused:
                case MetricKind.InX128GFused:
                    return MeasureInX128Fused();
                case MetricKind.InX256DFused:
                case MetricKind.InX256GFused:
                    return MeasureInX256Fused();
                // case MetricKind.InX256D:
                // case MetricKind.InX256G:
                //     return MeasureInX256Atomic();

                default:
                    throw unsupported(metric);
            }
        }
        
        IReadOnlyList<MetricComparisonRecord> MeasureNumG()
        {
            var ops = items(OpKind.Add, OpKind.Mul, OpKind.Sub);
            var prims = items(PrimalKind.float32, PrimalKind.float64, PrimalKind.int64);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = MetricConfig.Define(MetricKind.NumG,runs: Pow2.T04, cycles: Pow2.T14, samples: Pow2.T13, dops: false);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunNumGComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            LogComparisons(comparisons, MetricKind.NumG);
            PrintComparisons(comparisons);
            return comparisons;
            
        }

        IReadOnlyList<MetricComparisonRecord> MeasureBitsG()
        {
            var ops = items(OpKind.ToggleBit, OpKind.Pop);
            var prims = PrimalKinds.Integral;
            var optypes =from o in ops from p in prims select OpType.Define(o,p);
            var config = MetricConfig.Define(MetricKind.BitG, runs: Pow2.T04, cycles: Pow2.T13, samples: Pow2.T12, dops: true);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunBitGComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            LogComparisons(comparisons, MetricKind.BitG);
            PrintComparisons(comparisons);
            return comparisons;

        }
        IReadOnlyList<MetricComparisonRecord> MeasurePrimalG()
        {
            var ops = items(OpKind.Sub, OpKind.Mul,  OpKind.Add, OpKind.GtEq, OpKind.LtEq, OpKind.Eq);
            var prims = items(PrimalKinds.All);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = MetricConfig.Define(MetricKind.PrimalG, runs: Pow2.T04, cycles: Pow2.T13, samples: Pow2.T12, dops: false);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            LogComparisons(comparisons, MetricKind.PrimalG);
            PrintComparisons(comparisons);
            return comparisons;

        }

        // IReadOnlyList<MetricComparisonRecord> MeasureInX256Atomic()
        // {
        //     var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
        //     var ops = items(OpKind.Add, OpKind.Sub);
        //     var specs = from p in primitives
        //                 from o in ops
        //                 select o.WithType(p);
        //     var blocks = Pow2.T12;
        //     var lhs = Randomizer.Span256<double>(blocks).ToReadOnlySpan();
        //     var rhs = Randomizer.Span256<double>(blocks).ToReadOnlySpan(); 
        //     var baseline = InXBench.Add(lhs,rhs);
        //     var inxAtomic = InXVecBench.AddAtomic(lhs, rhs);
        //     var primFused = PrimalGBench.Run<double>(OpKind.Add,lhs,rhs);
        //     var comparison = baseline.Compare(inxAtomic).ToRecord();
        //     print(comparison.FormatMessage());                
        //     return items(comparison).ToList();
        // }
        
        IReadOnlyList<MetricComparisonRecord> MeasureInX256Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
            var ops = items(OpKind.Add, OpKind.Sub);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXMetricConfig256.Define(MetricKind.InX256GFused, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);
            var comparisons = config.RunComparisons(specs);
            print(comparisons.FormatMessages());
            return comparisons;

       }
        
        IReadOnlyList<MetricComparisonRecord> MeasureInX128Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
            var ops = items(OpKind.Add, OpKind.Sub);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXMetricConfig128.Define(MetricKind.InX128GFused, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T10);
            var comparisons = config.RunComparisons(specs);
            print(comparisons.FormatMessages());
            return comparisons;
       }

         // Converts an array of bytes into a long.  
        public static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }

        Duration TestEq<T>(N128 bits, int blocks)
            where T : struct
        {
            var src = Randomizer.Span128<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
            {
                var v1 = src.Vector(block);
                var v2 = src.Vector(block);                                
                var eq = ginx.eq(v1,v2);
                for(var i =0; i< eq.Length; i++)
                    Claim.@true(eq[i]);
            }           
            return snapshot(sw);
        }
        Duration TestEq<T>(N256 bits, int blocks)
            where T : struct
        {
            var src = Randomizer.Span256<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
            {
                var v1 = src.Vector(block);
                var v2 = src.Vector(block);                                
                var eq = ginx.eq(v1,v2);
                for(var i =0; i< eq.Length; i++)
                    Claim.@true(eq[i]);
            }           
            return snapshot(sw);

        }

        void TestEq()
        {
            var blocks = Pow2.T08;
            var n128 = N128.Rep;
            var n256 = N256.Rep;
            var time = Duration.Zero;
            time += TestEq<byte>(n128, blocks);
            time += TestEq<sbyte>(n128, blocks);
            time += TestEq<short>(n128, blocks);
            time += TestEq<ushort>(n128, blocks);
            time += TestEq<int>(n128, blocks);
            time += TestEq<uint>(n128, blocks);
            time += TestEq<long>(n128, blocks);
            time += TestEq<ulong>(n128, blocks);
            time += TestEq<float>(n128, blocks);
            time += TestEq<double>(n128, blocks);
            time += TestEq<byte>(n256, blocks);
            time += TestEq<sbyte>(n256, blocks);
            time += TestEq<short>(n256, blocks);
            time += TestEq<ushort>(n256, blocks);
            time += TestEq<int>(n256, blocks);
            time += TestEq<uint>(n256, blocks);
            time += TestEq<long>(n256, blocks);
            time += TestEq<ulong>(n256, blocks);
            inform($"Tests succeded after {time.Ms} ms");

            // var ix = (byte)2;
            // var ixVal = (byte)119;
            // var v1 = Randomizer.Vec128<byte>();            
            // var v2 = ginx.insert(ixVal,v1,ix);
            // var cmp = dinx.eq(v1,v2);
            // for(var i=0; i<cmp.Length; i++)
            // {
            //     if(i != ix)
            //         Claim.@true(cmp[i]);
            //     else
            //         Claim.@false(cmp[i]);
            // }                        
        }

        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {
                gmath.one<byte>();
                //app.RunTests();
                //app.Measure(MetricKind.PrimalG);
                //app.MeasureAtomicInX();
                app.TestEq();
                
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}