//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
 
    using static zfunc;
    using static As;

    partial class Bits
    {                
        /// <summary>
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static byte truncate(byte src, byte len)
            => (byte)ZeroHighBits(src, len);

        /// <summary>
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static ushort truncate(ushort src, byte len)
            => (ushort)ZeroHighBits(src, len);

        /// <summary>
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static uint truncate(uint src, byte len)
            => ZeroHighBits(src, len);

        /// <summary>
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static ulong truncate(ulong src, byte len)
            => ZeroHighBits(src, len);


        [MethodImpl(Inline)]
        public static byte mulx(byte a, byte b)
            => (byte)MultiplyNoFlags(a,b);

        [MethodImpl(Inline)]
        public static ushort mulx(ushort a, ushort b)
            => (ushort)MultiplyNoFlags(a,b);

        [MethodImpl(Inline)]
        public static uint mulx(uint a, uint b)
            => MultiplyNoFlags(a,b);

        [MethodImpl(Inline)]
        public static ulong mulx(ulong a, ulong b)
            => MultiplyNoFlags(a,b);

        [MethodImpl(Inline)]
        public static unsafe void mulx(uint a, uint b, ref uint lo, ref uint hi)
            => hi = MultiplyNoFlags(a, b, refptr(ref lo));

        [MethodImpl(Inline)]
        public static unsafe void mulx(ulong a, ulong b, ref ulong lo,ref ulong hi)
            => hi = MultiplyNoFlags(a, b, refptr(ref lo));


    }

}