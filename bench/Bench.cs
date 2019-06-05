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

    using static zfunc;

    public static class BenchRunner
    {
        public static void Run()
        {
            MetricKind.BitG.Compare();

        }
        
        internal static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        static IReadOnlyList<MetricComparisonRecord> Compare(this MetricKind metric)
        {
            switch(metric)
            {
                case MetricKind.NumG:
                    return NumGBench.Run().Log(metric);
                case MetricKind.BitD:
                case MetricKind.BitG:
                    return BitBench.Run().Log(metric);
                case MetricKind.PrimalD:
                case MetricKind.PrimalG:
                    return PrimalBench.Run().Log(metric);
                case MetricKind.InX128DFused:
                case MetricKind.InX128GFused:
                    return InXBench.Run128Fused().Log(metric);
                case MetricKind.InX256DFused:
                case MetricKind.InX256GFused:
                    return InXBench.Run256Fused().Log(metric);
                case MetricKind.ConvertD:
                case MetricKind.ConvertG:
                    return ConversionBench.Run().Log(metric);
                case MetricKind.VecG:
                    return VecGBench.Run().Log(metric);                

                default:
                    throw unsupported(metric);
            }
        }

        static IReadOnlyList<MetricComparisonRecord> Log(this IReadOnlyList<MetricComparisonRecord> comparisons, MetricKind kind, bool silent = false)
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

    }
}