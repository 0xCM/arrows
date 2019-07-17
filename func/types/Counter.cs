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
    /// Provides a performance counter, similar to the Stopwatch type
    /// </summary>
    public ref struct Counter
    {

        /// <summary>
        /// Creates a counter
        /// </summary>
        [MethodImpl(Inline)]
        public static Counter Count()
            => new Counter(OS.Counter);

        /// <summary>
        /// The first count, denoting the start of a relative time period
        /// </summary>
        long FirstCount;

        /// <summary>
        /// The last count, denoting the end of a relative time period
        /// </summary>
        long LastCount;

        [MethodImpl(Inline)]
        Counter(in long FirstCount)
        {
            this.FirstCount = FirstCount;
            this.LastCount = 0;
        }

        /// <summary>
        /// Gets the time elapsed as determined by the magnitude of the difference 
        /// between the first and last counts
        /// </summary>
        /// <param name="reset">True if the counter should be reset</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public Duration Mark(bool reset = false)
        {
            LastCount = OS.Counter;
            var delta = Math.Abs(LastCount - FirstCount);
            if(reset)
                FirstCount = 0;
            return Duration.Define(delta);
        }
    }
}