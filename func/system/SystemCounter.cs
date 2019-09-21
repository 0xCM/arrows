//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// A stopwatch-like type in the form of a struct rather than a class
    /// </summary>
    public struct SystemCounter
    {
        long total;

        long started;

        public static implicit operator long(SystemCounter counter)
            => counter.Count;

        public static implicit operator TimeSpan(SystemCounter counter)
            => TimeSpan.FromTicks(counter.Count);

        [MethodImpl(Inline)]
        public static SystemCounter New(bool start = false)
        {
            var counter = default(SystemCounter);
            if(start)
                counter.Start();
            return counter;
        }
        

        [MethodImpl(Inline)]
        public void Start()
        {
            OS.GetCount(ref started);
        }

        [MethodImpl(Inline)]
        public void Stop()
        {
            var stopped = 0L;
            OS.GetCount(ref stopped);
            total += (stopped - started);
        }

        /// <summary>
        /// Gets the total number of timer ticks
        /// </summary>
        public readonly long Count
        {
            [MethodImpl(Inline)]
            get => total;
        }

        /// <summary>
        /// Gets the elapsed time implied by the tick count
        /// </summary>
        public readonly TimeSpan Time
        {
            [MethodImpl(Inline)]
            get => TimeSpan.FromTicks(Count);
        }
         
    }


}