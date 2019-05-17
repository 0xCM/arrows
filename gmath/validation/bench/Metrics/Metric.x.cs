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
    
    using static zfunc;
    using static mfunc;

    public static class MetricX
    {
        static IRandomizer Random(IRandomizer random = null)
            => random ?? Z0.Randomizer.define(RandSeeds.BenchSeed);

        public static MetricId Identify(this MetricKind metric, PrimalKind primitive, OpKind op)
            => MetricId.Define(metric, primitive, op);

        public static MetricId Identify<T>(this MetricKind metric, OpKind op)
            where T : struct
                => MetricId.Define(metric, PrimalKinds.kind<T>(), op);

        public static void Deconstruct(this MetricId metric, out MetricKind Classifier, out PrimalKind Primitive, out OpKind Operator)
        {
            Classifier = metric.Classifier;
            Primitive = metric.Primitive;
            Operator = metric.Operator;
        }

        public static MetricComparisonSpec DefineComparison(this MetricKind Baseline, MetricKind Bench, PrimalKind Primitive, OpKind Operator)
            => MetricComparisonSpec.Define(Baseline, Bench, Primitive, Operator);

        public static MetricComparisonSpec DefineComparison<T>(this MetricKind Baseline, MetricKind Bench, OpKind Operator)
            where T : struct
                => MetricComparisonSpec.Define(Baseline, Bench, PrimalKinds.kind<T>(), Operator);

        public static OpMetrics<T> Run<T>(this MetricKind metric, OpKind op, MetricConfig config = null, IRandomizer random = null)
            where T : struct
        {
            switch(metric)
            {
                case MetricKind.Number:
                    return NumGMetrics.Run<T>(op, config, random);
                case MetricKind.PrimalDirect:
                    return PrimalDMetrics.Run<T>(op, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGMetrics.Run<T>(op, config, random);
            }
            throw unsupported(metric);
        }

        public static IOpMetrics Run(this MetricKind metric, OpKind op, PrimalKind primal, MetricConfig config = null, IRandomizer random = null)
        {
            switch(metric)
            {
                case MetricKind.Number:
                    return NumGMetrics.Run(op, primal, config, random);
                case MetricKind.PrimalDirect:
                    return PrimalDMetrics.Run(op, primal, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGMetrics.Run(op, primal, config, random);
            }
            throw unsupported(metric);
        }



        public static IOpMetrics Run(this MetricId metric, bool baseline = true, MetricConfig config = null, IRandomizer random = null)
        {
            (var @class, var prim, var op) = metric;
            
            random = Random(random);

            if(!baseline)
                op = ~op;
            switch(@class)
            {
                case MetricKind.PrimalDirect:
                    return PrimalDMetrics.Run(op, prim, config, random);
                case MetricKind.Number:
                    return NumGMetrics.Run(op, prim, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGMetrics.Run(op, prim, config, random);
                default:
                    throw unsupported(metric.Classifier);
            }
        }

        

        public static IReadOnlyList<AppMsg> FormatMessages(this IEnumerable<BenchComparisonRecord> src, char delimiter = ',')
        {
            var records = src.ToList();
            if(records.Count == 0)
                return new AppMsg[]{};

            var messages = new List<AppMsg>(records.Count + 1);
            messages.Add(AppMsg.Define(records[0].HeaderText(delimiter), SeverityLevel.HiliteCL));
            foreach(var record in src)
                messages.Add(AppMsg.Define(record.Delimited(delimiter), SeverityLevel.Perform));
            return messages;

        }

    }

}