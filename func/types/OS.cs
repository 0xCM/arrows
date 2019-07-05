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

    public static class OS
    {
        const string kernel = "kernel32.dll";

        public static readonly long CounterFrequency;
        
        /// <summary>
        /// Gets the OS thread ID, not the "ManagedThreadId" which is useless
        /// </summary>
        public static uint CurrentThreadId
        {
            [MethodImpl(Inline)]
            get => GetCurrentThreadId();
        }

        /// <summary>
        /// Returns the difference between the current Counter value and a prior counter value
        /// </summary>
        [MethodImpl(Inline)]
        public static long CounterDelta(in long prior)
            => Counter - prior;

        /// <summary>
        /// Converts a counter value to milliseconds
        /// </summary>
        /// <param name="count">The count value to convert</param>
        [MethodImpl(Inline)]
        public static double CounterMs(in long count)
            => ((double)count)/((double) CounterFrequency);

        /// <summary>
        /// Gets the current value of the counter
        /// </summary>
        public static long Counter
        {
            
            [MethodImpl(Inline)]
            get
            {
                var count = 0L;
                QueryPerformanceCounter(ref count);
                return count;
            }
        }

        static OS()
        {
            QueryPerformanceFrequency(ref CounterFrequency);
        }

        
        [DllImport(kernel)]
        static extern int QueryPerformanceCounter(ref long count);
        
        /// <summary>
        /// Retrieves the number of performance counter counts per second.
        /// </summary>
        /// <remarks>This is determined by the OS at boot time and is invariant until the next reboot</remarks>
        [DllImport(kernel)]
        static extern int QueryPerformanceFrequency(ref long frequency);

        /// <summary>
        /// Get the OS ID of the current thread
        /// </summary>
        [DllImport(kernel)]
        static extern uint GetCurrentThreadId();


    }
}