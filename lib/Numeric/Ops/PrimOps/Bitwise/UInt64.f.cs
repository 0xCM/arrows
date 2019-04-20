//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using target = System.UInt64;

    public static partial class Bits
    {
        /// <summary>
        /// Extracts the high-order bits from a ulong to produce a uint
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static uint hi(ulong src)
            => (uint)(src >> 32);

        /// <summary>
        /// Extracts the low-order bits from a ulong to produce a uint
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint lo(ulong src)
            => (uint)src;
                
        /// <summary>
        /// ulong => (uint,uint)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (uint x0, uint x1) unpack(ulong src)
            => (lo(src), hi(src));

        [MethodImpl(Inline)]
        public static target rotate(target src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static target andnot(target lhs, target rhs)
            => Bmi1.X64.AndNot(lhs,rhs);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static target msbOffCount(target src)
            => Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static target lsbOffCount(target src)
            => Bmi1.X64.TrailingZeroCount(src);

        /// <summary>
        /// Extracts a run of bits from the source beginning at a specified offset
        /// </summary>
        /// <param name="value">The source value</param>
        /// <param name="offset">The offset value</param>
        /// <param name="length">The length of the run</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static target extract(target value, int offset, int length)
            => Bmi1.X64.BitFieldExtract(value,(byte)offset,(byte)length);

        /// <summary>
        /// Extracts mask-identified bits from the source 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static target extract(target src, target mask)        
            => Bmi2.X64.ParallelBitExtract(src,mask);

        /// <summary>
        /// Sets mask-identified bits in the soruce
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static target deposit(target src, target mask)        
            => Bmi2.X64.ParallelBitDeposit(src,mask);

        [MethodImpl(Inline)]
        public static target leastOnBit(target src)
            => Bmi1.X64.ExtractLowestSetBit(src);

    }

}