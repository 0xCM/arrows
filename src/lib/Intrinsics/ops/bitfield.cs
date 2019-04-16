//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static x86;


    partial class InX
    {

        [MethodImpl(Inline)]
        public static uint andnot(uint lhs, uint rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static ulong andnot(ulong lhs, ulong rhs)
            => Bmi1.X64.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint leastOnBit(uint src)
            => Bmi1.ExtractLowestSetBit(src);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint leadingOffCount(uint src)
            => Lzcnt.LeadingZeroCount(src);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong leadingOffCount(ulong src)
            => Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static uint traingOffCount(uint src)
            => Bmi1.TrailingZeroCount(src);

        [MethodImpl(Inline)]
        public static ulong traingOffCount(ulong src)
            => Bmi1.X64.TrailingZeroCount(src);


        [MethodImpl(Inline)]
        public static ulong leastOnBit(ulong src)
            => Bmi1.X64.ExtractLowestSetBit(src);

        [MethodImpl(Inline)]
        public static uint deposit(uint src, uint mask)        
            => Bmi2.ParallelBitDeposit(src,mask);

        [MethodImpl(Inline)]
        public static ulong deposit(ulong src, ulong mask)        
            => Bmi2.X64.ParallelBitDeposit(src,mask);
            
        /// <summary>
        /// Extract bits from a source interger at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint extract(uint src, uint mask)        
            => Bmi2.ParallelBitExtract(src,mask);

        /// <summary>
        /// Extract bits from a source interger at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong extract(ulong src, ulong mask)        
            => Bmi2.X64.ParallelBitExtract(src,mask);

        [MethodImpl(Inline)]
        public static uint extract(uint value, byte start, byte length)
            => Bmi1.BitFieldExtract(value,start,length);

        [MethodImpl(Inline)]
        public static ulong extract(ulong value, byte start, byte length)
            => Bmi1.X64.BitFieldExtract(value,start,length);

    }

}