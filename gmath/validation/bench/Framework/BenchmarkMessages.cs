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

        public static AppMsg CycleStatus<T>(T title, int cycle, long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{title} running".PadRight(40), 
                     Pipe, "Cycle", Eq, $"{cycle}".PadRight(8), 
                     Pipe, "Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Duration", Eq, $"{totalDuration}"
                     ), SeverityLevel.Perform);

        public static AppMsg CycleEnd(OpId opid, int cycle, Duration cycleDuration, long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{opid} running".PadRight(28), 
                     Pipe, "Cycle", Eq, $"{cycle}".PadRight(5), 
                     Pipe, "Total Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Total Duration", Eq, $"{totalDuration}".PadRight(28),
                     Pipe, "Duration", Eq, $"{cycleDuration.Ticks}".PadLeft(8), " ticks "
                     ), SeverityLevel.Perform);


        static string deltaTitle(BenchComparison c)               
            => $"{c.LeftBench.Title} vs {c.RightBench.Title}";

        static Duration deltaTiming(BenchComparison c)               
            => c.LeftBench.ExecTime - c.RightBench.ExecTime;

        public static AppMsg Describe(this IBenchComparison comparison)
        {
            var title = $"{comparison.LeftTitle} / {comparison.RightTitle}";
            var delta = comparison.LeftMeasure.WorkTime - comparison.RightMeasure.WorkTime;
            var width = Math.Abs(delta.Ms);
            var leftDuration = comparison.LeftMeasure.WorkTime;
            var rightDuration = comparison.RightMeasure.WorkTime;
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

       public static AppMsg BenchmarkEnd<T>(T title,  long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{title} summary".PadRight(28), 
                     Pipe, "Total Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Total Duration", Eq, $"{totalDuration}"), 
                        SeverityLevel.HiliteCL);
 
        public static AppMsg BenchmarkEnd(OpId opid,  long totalOpCount, Duration totalDuration)
            => BenchmarkEnd<OpId>(opid, totalOpCount, totalDuration);
    }
}