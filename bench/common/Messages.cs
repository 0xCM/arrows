//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public static class BenchmarkMessages
    {
        static string Pipe = $" | ";
        
        static string Eq = $" = ";

        public static AppMsg CycleStatus(OpId opid, int cycle, long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{opid} running".PadRight(40), 
                     Pipe, "Cycle", Eq, $"{cycle}".PadRight(8), 
                     Pipe, "Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Duration", Eq, $"{totalDuration}"
                     ), SeverityLevel.Perform);

        public static AppMsg Describe(this IMetricComparison comparison)
        {
            var title = $"{comparison.LeftTitle} / {comparison.RightTitle}";
            var delta = comparison.LeftMetrics.WorkTime - comparison.RightMetrics.WorkTime;
            var width = Math.Abs(delta.Ms);
            var leftDuration = comparison.LeftMetrics.WorkTime;
            var rightDuration = comparison.RightMetrics.WorkTime;
            var ratio = Math.Round((double)leftDuration.Ticks / (double)rightDuration.Ticks, 4);
            var description = append(
                $"{title}", 
                $" | Left Time  = {leftDuration.Ms} ms",
                $" | Right Time = {rightDuration.Ms} ms",
                $" | Difference = {delta.Ms} ms",
                $" | Performance Ratio = {ratio}"
                );
            return AppMsg.Define(description,  SeverityLevel.Perform);
        }
 
        public static AppMsg BenchmarkEnd(OpId opid,  long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{opid} summary".PadRight(28), 
                     Pipe, "Total Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Total Duration", Eq, $"{totalDuration}"), 
                        SeverityLevel.HiliteCL);

        public static AppMsg BenchmarkEnd(IMetrics metrics)
            => BenchmarkEnd(metrics.OpId, metrics.OpCount, metrics.WorkTime);

    }
}