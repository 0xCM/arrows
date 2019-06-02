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
    using Z0.Metrics;

    using static zfunc;

    public static class BenchTools
    {
        internal static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        public static IReadOnlyList<MetricComparisonRecord> Emit(this IReadOnlyList<MetricComparisonRecord> comparisons, MetricKind kind, bool silent = false)
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


        public static IReadOnlyList<MetricComparisonRecord> Measure(this MetricKind metric)
        {
            switch(metric)
            {
                case MetricKind.NumG:
                    return NumGBench.Run().Emit(metric);
                case MetricKind.BitD:
                case MetricKind.BitG:
                    return BitBench.Run().Emit(metric);
                case MetricKind.PrimalD:
                case MetricKind.PrimalG:
                    return PrimalGBench.Run().Emit(metric);
                case MetricKind.InX128DFused:
                case MetricKind.InX128GFused:
                    return InXBench.Run128Fused().Emit( metric);
                case MetricKind.InX256DFused:
                case MetricKind.InX256GFused:
                    return InXBench.Run256Fused().Emit(metric);
                case MetricKind.ConvertD:
                case MetricKind.ConvertG:
                    return ConversionBench.Run().Emit(metric);
                case MetricKind.VecG:
                    return VecGBench.Run().Emit(metric);                

                default:
                    throw unsupported(metric);
            }
        }

    }

}