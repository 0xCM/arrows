//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zcore;
    
    public readonly struct Timing
    {

        public static Timing begin(string title, bool announce = true)
        {
            if(announce)
                print(AppMsg.Define($"{title} begin".PadRight(25), SeverityLevel.HiliteCL, string.Empty));            
            return Timing.Start(title);
        }

        [MethodImpl(Inline)]
        public static Duration end(Timing timing, bool announce = true)
        {
            var duration = Duration.define(elapsed(timing.Stopwatch));
            if(announce)
                print(AppMsg.Define($"{timing.Title} end".PadRight(25) + $"| Duration = {duration}", SeverityLevel.HiliteML, string.Empty));
            return duration;
        }

        [MethodImpl(Inline)]
        public static void end(ref Duration runningTotal, Timing timing, bool announce = true)
        {
            var current = Duration.define(elapsed(timing.Stopwatch));
            runningTotal = current + runningTotal;
            if(announce)
                print(AppMsg.Define($"{timing.Title} end".PadRight(25) 
                    + $" Elapsed = {current.Ticks} (ticks) | Total Epapsed = {runningTotal}", 
                        SeverityLevel.HiliteML, string.Empty));            
        }

        [MethodImpl(Inline)]
        public static Timing Start(string Title)
            => new Timing(Title);
        
        [MethodImpl(Inline)]
        public Timing(string Title)
        {
            this.Title = Title;
            this.Stopwatch = stopwatch();
        }
        
        public readonly string Title;

        public readonly Stopwatch Stopwatch;
    }
   
}