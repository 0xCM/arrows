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

        

         // Converts an array of bytes into a long.  
        public static long ToInt64(byte[] value, int startIndex)
        {

            return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
        }

        // IReadOnlyList<MetricComparisonRecord> Measure(MetricKind metric)
        // {
        //     switch(metric)
        //     {
        //         case MetricKind.NumG:
        //             return NumGBench.Run().Emit(metric);
        //         case MetricKind.BitD:
        //         case MetricKind.BitG:
        //             return BitBench.Run().Emit(metric);
        //         case MetricKind.PrimalD:
        //         case MetricKind.PrimalG:
        //             return PrimalGBench.Run().Emit(metric);
        //         case MetricKind.InX128DFused:
        //         case MetricKind.InX128GFused:
        //             return InXBench.Run128Fused().Emit( metric);
        //         case MetricKind.InX256DFused:
        //         case MetricKind.InX256GFused:
        //             return InXBench.Run256Fused().Emit(metric);
        //         case MetricKind.ConvertD:
        //         case MetricKind.ConvertG:
        //             return ConversionBench.Run().Emit(metric);

        //         default:
        //             throw unsupported(metric);
        //     }
        // }

        public void Measure(MetricKind metric)
        {
            metric.Run();
        }
        public void BenchBitVector()
        {
            var n = N8192.Rep;
            var lhsData = Randomizer.Span<int>((int)n.value);            
            var rhsData = Randomizer.Span<int>((int)n.value);
            var lhs = BitVector.Load(ref lhsData[0], n);
            var rhs = BitVector.Load(ref rhsData[0], n);
            var opcount = 0L;
            var time = Duration.Zero;
            var opsPerCycle = (long)n.value * 5L;
            while(true)
            {
                var sw = stopwatch();            
                for(var cycle = 1; cycle <= Pow2.T16; cycle++)
                {
                    lhs &= rhs;
                    lhs ^= rhs;
                    lhs |= rhs;
                    lhs >>= 4;
                    lhs <<= 4;
                    opcount += opsPerCycle;
                }
                time += snapshot(sw);
                print(AppMsg.Define($"Total Ops = {opcount} |".PadRight(30) + $"Total Time = {time.Ms} ms", SeverityLevel.Perform));
            }

        }

        static void Main(params string[] args)
        {            
            var app = new Benchmark();
            try
            {
                gmath.init();

                //app.RunTests();                
                app.Measure(MetricKind.VecG);
                //app.Measure(MetricKind.InX128GFused);
                //app.Measure(MetricKind.InX256GFused);
                //app.Measure(MetricKind.NumG);
                //app.Measure(MetricKind.BitG);
                
                //app.BenchBitVector();                
                
                
            }
            catch(Exception e)
            {
                app.NotifyError(e);
            }
        }

    }

}