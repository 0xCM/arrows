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
    
    using static zfunc;


    public readonly struct Duration
    {
        public static readonly Duration Zero = new Duration(0);
        
        public static Duration Define(long ticks)
            => new Duration(ticks);

        public static Duration mark(Stopwatch sw)
            => Define(sw.ElapsedTicks);

        public static implicit operator Duration(long ticks)
            => Define(ticks);
            
        public static Duration operator +(Duration lhs, Duration rhs)
            => new Duration(lhs.Ticks + rhs.Ticks);

        public static Duration operator -(Duration lhs, Duration rhs)
            => new Duration(lhs.Ticks - rhs.Ticks);

        public static bool operator !=(Duration lhs, Duration rhs)
            => lhs.Ticks != rhs.Ticks;

        public static bool operator ==(Duration lhs, Duration rhs)
            => lhs.Ticks == rhs.Ticks;


        public static bool operator >(Duration lhs, Duration rhs)
            => lhs.Ticks > rhs.Ticks;

        public static bool operator <(Duration lhs, Duration rhs)
            => lhs.Ticks < rhs.Ticks;

        public static bool operator >=(Duration lhs, Duration rhs)
            => lhs.Ticks >= rhs.Ticks;

        public static bool operator <=(Duration lhs, Duration rhs)
            => lhs.Ticks <= rhs.Ticks;

            
        public Duration(long Ticks)
            => this.Ticks = Ticks;
        
        public readonly long Ticks;
        
        public Duration Half()
            => new Duration(Ticks/2);

        public long Ms
            => ticksToMs(Ticks);

        public override string ToString()
            => append($"{Ticks}".PadRight(10), " ticks ", " ~ ", $"{Ms} ms");

        public bool Equals(Duration rhs)
            => this.Ticks == rhs.Ticks;

        public override int GetHashCode()
            => Ticks.GetHashCode();

        public override bool Equals(object obj)            
            => obj is Duration ? Equals((Duration)obj) : false;
    }
}