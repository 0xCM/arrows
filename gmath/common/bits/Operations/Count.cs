//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static uint popcount(uint src)
            => Popcnt.PopCount(src);

        [MethodImpl(Inline)]
        public static ulong popcount(ulong src)
            => Popcnt.X64.PopCount(src);

        [MethodImpl(Inline)]
        public static uint[] popcounts(uint min, uint max)
        {
            var current = min;
            var i = 0;
            var dst = new uint[max - min + 1];
            while(current <= max)
                dst[i++] = popcount(current++);
            return dst;
        }

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint msbOffCount(uint src)
            => Lzcnt.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static uint lsbOffCount(uint src)
            => Bmi1.TrailingZeroCount(src);
 
         [MethodImpl(Inline)]
        public static int countTrailingOff(long src)
            => BitOperations.TrailingZeroCount(src);

        // /// <summary>
        // /// Counts the number of trailing zero bits in the source
        // /// </summary>
        // /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countTrailingOff(sbyte src)
            => countTrailingOff((int)src);

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countLeadingOff(byte src)
            => countLeadingOff((ushort)src) - 8;

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countTrailingOff(byte src)
            => countTrailingOff((uint)src);

        [MethodImpl(Inline)]
        public static int countLeadingOff(ushort src)
            => countLeadingOff((uint)src) - 16;

        [MethodImpl(Inline)]
        public static int countTrailingOff(ushort src)
            => countTrailingOff((uint)src);

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countLeadingOff(uint src)
            => BitOperations.LeadingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countTrailingOff(uint src)
            => BitOperations.TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong msbOffCount(ulong src)
            => Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static ulong lsbOffCount(ulong src)
            => Bmi1.X64.TrailingZeroCount(src);

    }
}