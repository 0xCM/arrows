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
        public static int pop(in sbyte src)
            => (int)Popcnt.PopCount((byte)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in byte src)
            => (int)Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in short src)
            => (int)Popcnt.PopCount((ushort)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in ushort src)
            => (int)Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in int src)
            => (int)Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in uint src)
            => (int)Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in long src)
            => (int)Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static int pop(in ulong src)
            => (int)Popcnt.X64.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in each value within a specified range
        /// </summary>
        [MethodImpl(NotInline)]
        public static int[] pops(in byte min, in byte max)
        {
            var current = min;
            var i = 0;
            var dst = new int[max - min + 1];
            while(current <= max)
                dst[i++] = pop(current++);
            return dst;
        }

        [MethodImpl(Inline)]
        public static int[] pops(in sbyte min, in sbyte max)
            => pops((byte)min, (byte)max);

        /// <summary>
        /// Counts the enabled bits in each value within a specified range
        /// </summary>
        [MethodImpl(NotInline)]
        public static int[] pops(in ushort min, in ushort max)
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
        public static int[] pops(in uint min, in uint max)
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
        public static int[] pops(in ulong min, in ulong max)
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