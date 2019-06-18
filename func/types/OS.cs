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

    public ref struct Counter
    {
        long FirstCount;

        long LastCount;

        [MethodImpl(Inline)]
        Counter(in long FirstCount)
        {
            this.FirstCount = FirstCount;
            this.LastCount = 0;
        }


        [MethodImpl(Inline)]
        public static Counter Count()
            => new Counter(OS.Counter);

        [MethodImpl(Inline)]
        public Duration Mark(bool reset = false)
        {
            LastCount = OS.Counter;
            var delta = LastCount - FirstCount;
            if(reset)
                FirstCount = 0;
            return Duration.Define(delta, OS.CounterMs(delta));
        }
    }

    public static class OS
    {
        const string kernel = "kernel32.dll";

        public static readonly long CounterFrequency;
        
        static OS()
        {
            QueryPerformanceFrequency(ref CounterFrequency);
        }

        [MethodImpl(Inline)]
        public static long CounterDelta(in long prior)
            => Counter - prior;

        [MethodImpl(Inline)]
        public static double CounterMs(in long count)
            => ((double)count)/((double) CounterFrequency);

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


        [MethodImpl(Inline)]
        static long PerformanceCounter()
        {
            var count = 0L;
            QueryPerformanceCounter(ref count);
            return count;
        }
        
        [DllImport(kernel)]
        static extern int QueryPerformanceCounter(ref long count);
        
        /// <summary>
        /// Retrieves the number of performance counter counts per second.
        /// </summary>
        /// <remarks>This is determined by the OS at boot time and is invariant until the next reboot</remarks>
        [DllImport(kernel)]
        static extern int QueryPerformanceFrequency(ref long frequency);


    }
}