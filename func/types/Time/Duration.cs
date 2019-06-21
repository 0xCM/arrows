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
        
        public static Duration Define(long ticks, double? ms = null)
            => new Duration(ticks, ms);

        public static Duration mark(Stopwatch sw)
            => Define(sw.ElapsedTicks);

        public static implicit operator Duration(long ticks)
            => Define(ticks);
            
        public static Duration operator +(Duration lhs, Duration rhs)
            => new Duration(lhs.Ticks + rhs.Ticks);

        public static Duration operator -(Duration lhs, Duration rhs)
            => new Duration(lhs.Ticks - rhs.Ticks);

        public static double operator /(Duration lhs, Duration rhs)        
            => Math.Round((double)lhs.Ticks / (double) rhs.Ticks, 4);
                    

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

            
        public Duration(long Ticks, double? ms = null)
        {
            this.Ticks = Ticks;
            this.Ms = ms ?? ticksToMs(Ticks);
        }
        
        public readonly long Ticks;
        
        public Duration Half()
            => new Duration(Ticks/2);

        public readonly double Ms;

        static readonly double TicksPerMs = (double)Stopwatch.Frequency/1000.0;

        public double FractionalMs
            => ((double)Ticks)/TicksPerMs;

        public override string ToString()
            => $"{FractionalMs} ms";

        // public override string ToString()
        //     => concat($"{Ticks}".PadRight(10), " ticks ", " ~ ", $"{Ms} ms");

        public bool Equals(Duration rhs)
            => this.Ticks == rhs.Ticks;

        public override int GetHashCode()
            => Ticks.GetHashCode();

        public override bool Equals(object obj)            
            => obj is Duration ? Equals((Duration)obj) : false;
    }
}