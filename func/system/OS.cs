//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Security;
    using static zfunc;
    using static As;


    /// <summary>
    /// Defines API for directly accessing OS resources
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public static unsafe class OS
    {
        const string kernel = "kernel32.dll";

        public static readonly long CounterFrequency;

        /// <summary>
        /// The handle for the current process
        /// </summary>
        public static readonly IntPtr CurrentProcess = System.Diagnostics.Process.GetCurrentProcess().Handle;

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

        [MethodImpl(Inline)]
        public static ref long GetCount(ref long count)
        {
            QueryPerformanceCounter(ref count);
            return ref count;
        }

        /// <summary>
        /// Gets the CPU cycles consumed by the calling thread
        /// </summary>
        public static ulong ThreadCpuCycles 
        {
            [MethodImpl(Inline)]
            get
            {
                var cycles = 0ul;
                if (!QueryThreadCycleTime((IntPtr)(-2), ref cycles))
                    return 0ul;
                return cycles;
            }
        }

        static void ThrowLiberationError(IntPtr pCode, ReadOnlySpan<byte> src)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)src.Length;            
            throw new Exception($"Attempting to liberate the memory range [{start.FormatHex(false)},{end.FormatHex(false)}] ({src.Length} bytes) for execution failed");     
        }

        [MethodImpl(Inline)]
        public static IntPtr Liberate(ReadOnlySpan<byte> src)
        {
            var pCode = (IntPtr)refptr(ref asRef(in src[0]));
            if (!OS.VirtualProtectEx(CurrentProcess, pCode, (UIntPtr)src.Length, 0x40, out uint _))
                ThrowLiberationError(pCode, src);
            return pCode;
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

        /// <summary>
        /// Gets the handle of the current thread
        /// </summary>
        [DllImport(kernel)]
        static extern IntPtr GetCurrentThread();

        /// <summary>
        /// Retrieves the cyle time for a specified thread
        /// </summary>
        /// <param name="hThread">The handle to the thread</param>
        /// <param name="cycles">The number of cpu clock cycles used by the thread</param>
        [DllImport(kernel)]
        static extern bool QueryThreadCycleTime(IntPtr hThread, ref ulong cycles);

        /// <summary>
        /// Retrieves the sum of the cycle time of all threads of the specified process.
        /// </summary>
        /// <param name="hProc">The handle to the process</param>
        /// <param name="cycles">The number of cpu clock cycles used by the threads of the process</param>
        [DllImport(kernel)]
        static extern bool QueryProcessCycleTime(IntPtr hProc, ref ulong cycles);

        [DllImport(kernel)]
        static extern void QueryInterruptTime(ref ulong time);


        [DllImport(kernel)]
        static extern void QueryInterruptTimePrecise(ref ulong time);

         /// <summary>
        /// Windows API that applies memory protection attributes
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, uint flags, out uint oldFlags); 
               
    }
}