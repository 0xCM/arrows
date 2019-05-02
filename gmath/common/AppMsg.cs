//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    public enum SeverityLevel
    {   
        /// <summary>
        /// Boring
        /// </summary>
        Unspecified = ConsoleColor.White,
        
        /// <summary>
        /// Identifies chatty content
        /// </summary>
        Verbose = ConsoleColor.DarkGray,

        /// <summary>
        /// Identifies iformational content
        /// </summary>
        Info = ConsoleColor.Green,
        
        /// <summary>
        /// Identifies warning content
        /// </summary>
        Warning = ConsoleColor.Yellow,

        /// <summary>
        /// Identifies error content
        /// </summary>
        Error = ConsoleColor.Red,

        
        /// <summary>
        /// Identifies benchmark/timing result
        /// </summary>
        Perform = ConsoleColor.Magenta,

        /// <summary>
        /// Dark blue foreground 
        /// </summary>
        HiliteBD = ConsoleColor.DarkBlue,

        /// <summary>
        /// Light blue foreground 
        /// </summary>
        HiliteBL = ConsoleColor.Blue,

        /// <summary>
        /// Dark cyan foreground 
        /// </summary>
        HiliteCD = ConsoleColor.DarkCyan,

        /// <summary>
        /// Cyan foreground 
        /// </summary>
        HiliteCL = ConsoleColor.Cyan,

        /// <summary>
        /// Dark magenta foreground
        /// </summary>
        HiliteMD = ConsoleColor.DarkMagenta,

        /// <summary>
        /// Magenta foreground
        /// </summary>
        HiliteML = ConsoleColor.Magenta,


    }


    public class AppMsg
    {
        public static AppMsg Define(string Content, SeverityLevel Level)
            => new AppMsg(Content, Level , string.Empty);

        public static AppMsg Define(string Content, SeverityLevel? Level = null, [CallerMemberName] string Caller = null)
            => new AppMsg(Content, Level ?? SeverityLevel.Info, Caller ?? string.Empty);

        public static readonly AppMsg Empty
            = new AppMsg(string.Empty, SeverityLevel.Info, string.Empty);

        AppMsg(string Content, SeverityLevel Level, string Caller)
        {
            this.Content = Content;
            this.Level = Level;
            this.Caller = Caller;
        }

        public string Content {get;}

        public SeverityLevel Level {get;}

        public string Caller {get;}

        public bool IsEmpty
            => String.IsNullOrWhiteSpace(Content);

        public override string ToString()
            => String.IsNullOrWhiteSpace(Caller) ? Content : $"{Caller}: {Content}";
    }


    public static class BenchmarkMessages
    {
        static string Pipe = $" | ";
        
        static string Eq = $" = ";

        public static AppMsg PairCycleStatus(string title, OpId opid, int cycle, Duration leftDuration, Duration rightDuration)
            => AppMsg.Define(append(
                    $"{title}/{opid} running".PadRight(28), 
                     Pipe, "Cycle", Eq, $"{cycle}".PadRight(5), 
                     Pipe, "Direct Duration", Eq, $"{leftDuration}".PadRight(12),
                     Pipe, "Generic Duration", Eq, $"{rightDuration}".PadRight(28)
                     ), SeverityLevel.Perform);

        public static AppMsg CycleEnd(string title, OpId opid, int cycle, Duration cycleDuration, long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{title}/{opid} running".PadRight(28), 
                     Pipe, "Cycle", Eq, $"{cycle}".PadRight(5), 
                     Pipe, "Total Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Total Duration", Eq, $"{totalDuration}".PadRight(28),
                     Pipe, "Duration", Eq, $"{cycleDuration.Ticks}".PadLeft(8), " ticks "
                     ), SeverityLevel.Perform);
        
        public static AppMsg BenchmarkEnd(string title, OpId opid,  long totalOpCount, Duration totalDuration)
            => AppMsg.Define(append(
                    $"{title}/{opid} summary".PadRight(28), 
                     Pipe, "Total Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Total Duration", Eq, $"{totalDuration}"), 
                        SeverityLevel.HiliteCL);

    }

}