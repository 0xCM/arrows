//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct Duration
    {
        public readonly long Ticks;

        public readonly double Ms;

        public static readonly Duration Zero = new Duration(0);
        
        public static Duration Define(long ticks, double? ms = null)
            => new Duration(ticks, ms);

        public static implicit operator Duration(TimeSpan src)
            => new Duration(src.Ticks);

        public static implicit operator Duration(long ticks)
            => Define(ticks);

        public static Duration Mark(Stopwatch sw)
            => Define(sw.ElapsedTicks);
            
        [MethodImpl(Inline)]
        public static Duration operator +(Duration lhs, Duration rhs)
            => new Duration(lhs.Ticks + rhs.Ticks);

        [MethodImpl(Inline)]
        public static Duration operator +(Duration lhs, TimeSpan rhs)
            => new Duration(lhs.Ticks + rhs.Ticks);

        [MethodImpl(Inline)]
        public static Duration operator -(Duration lhs, Duration rhs)
            => new Duration(lhs.Ticks - rhs.Ticks);

        [MethodImpl(Inline)]
        public static Duration operator -(Duration lhs, TimeSpan rhs)
            => new Duration(lhs.Ticks - rhs.Ticks);

        [MethodImpl(Inline)]
        public static double operator /(Duration lhs, Duration rhs)        
            => Math.Round((double)lhs.Ticks / (double) rhs.Ticks, 4);

        [MethodImpl(Inline)]
        public static double operator /(Duration lhs, TimeSpan rhs)        
            => Math.Round((double)lhs.Ticks / (double) rhs.Ticks, 4);

        [MethodImpl(Inline)]
        public static bool operator !=(Duration lhs, Duration rhs)
            => lhs.Ticks != rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator ==(Duration lhs, Duration rhs)
            => lhs.Ticks == rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >(Duration lhs, Duration rhs)
            => lhs.Ticks > rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >(Duration lhs, TimeSpan rhs)
            => lhs.Ticks > rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <(Duration lhs, Duration rhs)
            => lhs.Ticks < rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <(Duration lhs, TimeSpan rhs)
            => lhs.Ticks < rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >=(Duration lhs, Duration rhs)
            => lhs.Ticks >= rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >=(Duration lhs, TimeSpan rhs)
            => lhs.Ticks >= rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <=(Duration lhs, Duration rhs)
            => lhs.Ticks <= rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <=(Duration lhs, TimeSpan rhs)
            => lhs.Ticks <= rhs.Ticks;
            
        [MethodImpl(Inline)]
        public Duration(long Ticks, double? ms = null)
        {
            this.Ticks = Ticks;
            this.Ms = ms ?? ticksToMs(Ticks);
        }

        [MethodImpl(Inline)]
        public Duration(TimeSpan ts)
        {
            this.Ticks = ts.Ticks;
            this.Ms = ticksToMs(Ticks);
        }

        public Duration Half()
            => new Duration(Ticks/2);

        static readonly double TicksPerMs 
            = (double)Stopwatch.Frequency/1000.0;

        public double FractionalMs
            => ((double)Ticks)/TicksPerMs;

        public override string ToString()
            => $"{FractionalMs} ms";

        public bool Equals(Duration rhs)
            => this.Ticks == rhs.Ticks;

        public override int GetHashCode()
            => Ticks.GetHashCode();

        public override bool Equals(object obj)            
            => obj is Duration ? Equals((Duration)obj) : false;
    }
}