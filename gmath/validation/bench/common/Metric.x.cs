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

        public static MetricComparison Compare(this IMetrics lhs, IMetrics rhs)        
            => MetricComparison.Define(lhs.Summarize(), rhs.Summarize());

        public static Metrics<T> DefineMetrics<T>(this OpId<T> OpId, long OpCount, Duration WorkTime, num<T>[] Results)
            where T : struct
                => Metrics.Capture(OpId, OpCount, WorkTime, Results);
        
        public static Metrics<T> DefineMetrics<T>(this OpId<T> OpId, long OpCount, Duration WorkTime, T[] Results)
            where T : struct
                => Metrics.Capture(OpId, OpCount, WorkTime, Results);

       public static MetricDelta CalcDelta(this IMetricComparison comparison)
            => MetricDelta.Calc(comparison);

        public static bool NonZeroRight(this OpKind op)
            => op == OpKind.Div || op == OpKind.Mod;

        public static MetricSummary<T> Summarize<T>(this Metrics<T> metrics)        
            where T : struct
            => MetricSummary.Define(metrics);

        public static MetricSummary Summarize(this IMetrics metrics)        
            => MetricSummary.Define(metrics);

        public static MetricComparison<T> Compare<T>(this Metrics<T> lhs, Metrics<T> rhs)
            where T : struct
                => MetricComparison.Define(lhs.Summarize(), rhs.Summarize());

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

        public static Metrics<T> Run<T>(this MetricKind metric, OpKind op, MetricConfig config = null, IRandomizer random = null)
            where T : struct
        {
            switch(metric)
            {
                case MetricKind.Number:
                    return NumGBench.Run<T>(op, config, random);
                case MetricKind.PrimalDirect:
                    return PrimalDBench.Run<T>(op, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGBench.Run<T>(op, config, random);
            }
            throw unsupported(metric);
        }

        public static IMetrics Run(this MetricKind metric, OpKind op, PrimalKind primal, 
            InXMetricConfig config = null, Genericity genericity = Genericity.Default, 
            IRandomizer random = null)
        {
            switch(genericity)
            {
                case Genericity.Direct:
                    switch(metric)
                    {
                        case MetricKind.Vec128:
                            return InXVecBench.Run(op, primal, (InXMetricConfig128)config, random);
                        case MetricKind.Vec256:
                            return InXVecBench.Run(op, primal, (InXMetricConfig256)config, random);
                    }
                    break;
                case Genericity.Generic:
                    switch(metric)
                    {
                        case MetricKind.Vec128:
                            return InXGBench.Run(op, primal, (InXMetricConfig128)config, random);
                        case MetricKind.Vec256:
                            return InXGBench.Run(op, primal, (InXMetricConfig256)config, random);
                    }
                break;
            }

            throw unsupported(metric);
        }

        public static IMetrics Run(this MetricKind metric, OpKind op, PrimalKind primal, 
            MetricConfig config = null, IRandomizer random = null)
        {
            switch(metric)
            {
                case MetricKind.Number:
                    return NumGBench.Run(op, primal, config, random);
                case MetricKind.PrimalDirect:
                    return PrimalDBench.Run(op, primal, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGBench.Run(op, primal, config, random);
            }
            throw unsupported(metric);
        }

        public static IMetrics Run(this MetricId metric, MetricConfig config = null, IRandomizer random = null)
        {
            (var @class, var prim, var op) = metric;
            
            random = Random(random);

            switch(@class)
            {
                case MetricKind.PrimalDirect:
                    return PrimalDBench.Run(op, prim, config, random);
                case MetricKind.Number:
                    return NumGBench.Run(op, prim, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGBench.Run(op, prim, config, random);
                default:
                    throw unsupported(metric.Classifier);
            }
        }

        public static AppMsg FormatMessage(this MetricComparisonRecord src, char delimiter = ',', bool digitcommas = false)        
            => AppMsg.Define(src.Delimited(delimiter,digitcommas), SeverityLevel.Perform);
        
        public static IReadOnlyList<AppMsg> FormatMessages(this IEnumerable<MetricComparisonRecord> src, char delimiter = ',', bool digitcommas = false)
        {
            var records = src.ToList();
            if(records.Count == 0)
                return new AppMsg[]{};

            var messages = new List<AppMsg>(records.Count + 1);
            messages.Add(AppMsg.Define(records[0].HeaderText(delimiter), SeverityLevel.HiliteCL));
            foreach(var record in src)
                messages.Add(record.FormatMessage(delimiter, digitcommas));
            return messages;

        }
    }

}