//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class SystemTime
    {
        static readonly ulong TimerTicksPerSecond = (ulong)Stopwatch.Frequency;

        static ulong NsPerTimerTick = 1_000_000_000/TimerTicksPerSecond;

        static readonly DateTime TimeOrigin = new DateTime(2019,01,01);
        
        [MethodImpl(Inline)]
        public static ulong Timestamp(uint ServerId = 0)        
            => (ulong)(now().Ticks - TimeOrigin.Ticks);                
    }
}