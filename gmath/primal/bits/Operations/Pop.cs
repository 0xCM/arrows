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
        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(sbyte src)
            => (int)Popcnt.PopCount((byte)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(byte src)
            => (int)Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(short src)
            => (int)Popcnt.PopCount((ushort)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(ushort src)
            => (int)Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(int src)
            => (int)Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(uint src)
            => (int)Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(long src)
            => (int)Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(ulong src)
            => (int)Popcnt.X64.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in each value within a specified range
        /// </summary>
        [MethodImpl(NotInline)]
        public static int[] pops(byte min, byte max)
        {
            var current = min;
            var i = 0;
            var dst = new int[max - min + 1];
            while(current <= max)
                dst[i++] = pop(current++);
            return dst;
        }

        [MethodImpl(Inline)]
        public static int[] pops(sbyte min, sbyte max)
            => pops((byte)min, (byte)max);

        /// <summary>
        /// Counts the enabled bits in each value within a specified range
        /// </summary>
        [MethodImpl(NotInline)]
        public static int[] pops(ushort min, ushort max)
        {
            var current = min;
            var i = 0;
            var dst = new int[max - min + 1];
            while(current <= max)
                dst[i++] = pop(current++);
            return dst;
        }

        /// <summary>
        /// Counts the enabled bits in each value within a specified range
        /// </summary>
        [MethodImpl(NotInline)]
        public static int[] pops(uint min, uint max)
        {
            var current = min;
            var i = 0;
            var dst = new int[max - min + 1];
            while(current <= max)
                dst[i++] = pop(current++);
            return dst;
        }

        /// <summary>
        /// Counts the enabled bits in each value within a specified range
        /// </summary>
        [MethodImpl(NotInline)]
        public static int[] pops(ulong min, ulong max)
        {
            var current = min;
            var i = 0;
            var dst = new int[max - min + 1];
            while(current <= max)
                dst[i++] = pop(current++);
            return dst;
        }

    }

}