//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class MetricX
    {
        public static MetricId Identify(this MetricKind metric, PrimalKind primitive, OpKind op)
            => MetricId.Define(metric, primitive, op);

        public static MetricId Identify<T>(this MetricKind metric, OpKind op)
            where T : struct
                => MetricId.Define(metric, PrimalKinds.kind<T>(), op);

        public static MetricDelta CalcDelta(this IMetricComparison comparison)
            => MetricDelta.Calc(comparison);
    
        public static MetricSummary<T> Summarize<T>(this Metrics<T> metrics)        
            where T : struct
            => MetricSummary.Define(metrics);

        public static MetricSummary Summarize(this IMetrics metrics)        
            => MetricSummary.Define(metrics);

        public static MetricComparison<T> Compare<T>(this Metrics<T> lhs, Metrics<T> rhs)
            where T : struct
                => MetricComparison.Define(lhs.Summarize(), rhs.Summarize());
        
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
    
        public static MetricComparison Compare(this IMetrics lhs, IMetrics rhs)        
            => MetricComparison.Define(lhs.Summarize(), rhs.Summarize());

        public static AppMsg FormatMessage(this MetricComparisonRecord src, char delimiter = ',', bool digitcommas = false)        
            => AppMsg.Define(src.Delimited(delimiter,digitcommas), SeverityLevel.Perform);
        
        public static IReadOnlyList<AppMsg> FormatMessages(this IEnumerable<MetricComparisonRecord> src, char delimiter = ',', bool digitcommas = false)
        {
            var records = src.ToList();
            if(records.Count == 0)
                return new AppMsg[]{};

            var messages = new List<AppMsg>(records.Count + 1);
            messages.Add(AppMsg.Define(MetricComparisonRecord.GetHeaderText(delimiter), SeverityLevel.HiliteCL));
            foreach(var record in src)
                messages.Add(record.FormatMessage(delimiter, digitcommas));
            return messages;

        }

        public static Metrics<T> CaptureMetrics<T>(this OpId<T> OpId, long OpCount, Duration WorkTime, T[] results)
            where T : struct
                => (OpId, OpCount, WorkTime, results);

        public static Metrics<T> CaptureMetrics<T>(this OpId OpId, long OpCount, Duration WorkTime, Span<T> results)
            where T : struct
                => new Metrics<T>(OpId, OpCount, WorkTime, results);


    }
}