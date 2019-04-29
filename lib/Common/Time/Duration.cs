//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static zcore;

    public readonly struct Duration
    {
        public static Duration define(long ticks)
            => new Duration(ticks);

        public static Duration mark(Stopwatch sw)
            => new Duration(sw.ElapsedTicks);

        public static Duration operator +(Duration lhs, Duration rhs)
            => define(lhs.Ticks + rhs.Ticks);
            
        public Duration(long Ticks)
            => this.Ticks = Ticks;
        
        public readonly long Ticks;
        
        public readonly long Ms
            => ticksToMs(Ticks);

        public override string ToString()
            => $"{Ticks} (ticks)".PadRight(17) + " = " + $"{Ms} (ms)".PadRight(10);
    }
}