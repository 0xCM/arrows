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

    /// <summary>
    /// Captures the length of a time period predicated on timer ticks
    /// </summary>
    public readonly struct Duration
    {
        /// <summary>
        /// The number of elapsed timer ticks that determines the period length
        /// </summary>
        public readonly long Ticks;


        public static readonly Duration Zero = new Duration(0);
        
        public static Duration Define(long timerTicks)
            => new Duration(timerTicks);

        public static implicit operator Duration(TimeSpan src)
            => new Duration(src.Ticks);

        public static implicit operator Duration(long timerTicks)
            => Define(timerTicks);
            
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
        public Duration(long TimerTicks)
        {
            this.Ticks = TimerTicks;
        }

        static readonly ulong TicksPerSecond = (ulong)Stopwatch.Frequency;

        /// <summary>
        /// The number of nanoseconds that elapse during a timer tick
        /// </summary>
        static ulong NsPerTick = 1_000_000_000/TicksPerSecond;

        static readonly double TicksPerMs  = (double)TicksPerSecond/1000.0;

        /// <summary>
        /// The duration expressed in nanoseconds
        /// </summary>
        public ulong Ns
        {
            [MethodImpl(Inline)]
            get => NsPerTick * (ulong)Ticks;
        }

        public ulong TimerTicks
        {
            [MethodImpl(Inline)]
            get => (ulong)Ticks;
        }

        public double Ms
            => ((double)Ticks)/TicksPerMs;

        public override string ToString()
            => $"{Ns} ns ~ ".PadLeft(16) + $"{Ms} ms";

        public bool Equals(Duration rhs)
            => this.Ticks == rhs.Ticks;

        public override int GetHashCode()
            => Ticks.GetHashCode();

        public override bool Equals(object obj)            
            => obj is Duration ? Equals((Duration)obj) : false;
    }
}