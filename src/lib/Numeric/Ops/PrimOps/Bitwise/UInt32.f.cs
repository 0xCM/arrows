//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using target = System.UInt32;

    public static partial class Bits
    {

        /// <summary>
        /// Extracts the upper half of the bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort hi(target src)
            => (ushort)(src >> 16);

        /// <summary>
        /// Extracts the most significant byte from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi8(target src)
            => hi(hi(src));


        /// <summary>
        /// Extracts the lower half of the bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort lo(target src)
            => (ushort)src;

        /// <summary>
        /// Extracts the least significant byte from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo8(target src)
            => lo(lo(src));

        /// <summary>
        /// (uint,uint) => ulong
        /// </summary>
        /// <param name="x1">The high-order bits</param>
        /// <param name="x0">The low-order bits</param>
        [MethodImpl(Inline)]
        public static ulong pack(target x0, target x1)
            => (ulong)x1 << 32 | (ulong)x0;

        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (ushort hi, ushort lo) unpack(target src)
            => (hi(src),lo(src));

 
        [MethodImpl(Inline)]
        public static target andnot(target lhs, target rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static target leastOnBit(target src)
            => Bmi1.ExtractLowestSetBit(src);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static target msbOffCount(target src)
            => Lzcnt.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static target lsbOffCount(target src)
            => Bmi1.TrailingZeroCount(src);

        [MethodImpl(Inline)]
        public static target deposit(target src, target mask)        
            => Bmi2.ParallelBitDeposit(src,mask);
            
        /// <summary>
        /// Extract bits from a source interger at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static target extract(target src, target mask)        
            => Bmi2.ParallelBitExtract(src,mask);

        [MethodImpl(Inline)]
        public static target extract(target value, int start, int length)
            => Bmi1.BitFieldExtract(value,(byte)start,(byte)length);

    }

}