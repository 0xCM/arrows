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
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the low-order bits from a ushort to produce a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(ushort src)
            => (byte)src;

        /// <summary>
        /// Produces a byte by extracting bits [0 .. 7] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte lo(short src)
            => (sbyte)src;

        /// <summary>
        /// Produces a byte by extracting bits [8 .. 15] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(short src)
            => (sbyte)(src >> 8);

        [MethodImpl(Inline)]
        public static short lo(int src)
            => (short)src;

        [MethodImpl(Inline)]
        public static short hi(int src)
            => (short)(src >> 16);

        [MethodImpl(Inline)]
        public static ushort lo(uint src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort hi(uint src)
            => (ushort)(src >> 16);

        [MethodImpl(Inline)]
        public static int hi(long src)
            => (int)(src >> 32);

        [MethodImpl(Inline)]
        public static int lo(long src)
            => (int)src;

        [MethodImpl(Inline)]
        public static uint hi(ulong src)
            => (uint)(src >> 32);

        [MethodImpl(Inline)]
        public static uint lo(ulong src)
            => (uint)src;
 
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

        [MethodImpl(Inline)]
        public static uint extract(uint value, int start, int length)
            => Bmi1.BitFieldExtract(value,(byte)start,(byte)length);

        /// <summary>
        /// Extracts a run of bits from the source beginning at a specified offset
        /// </summary>
        /// <param name="value">The source value</param>
        /// <param name="offset">The offset value</param>
        /// <param name="length">The length of the run</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong extract(ulong value, int offset, int length)
            => Bmi1.X64.BitFieldExtract(value,(byte)offset,(byte)length);

        /// <summary>
        /// Extracts mask-identified bits from the source 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong extract(ulong src, ulong mask)        
            => Bmi2.X64.ParallelBitExtract(src,mask);
    }
}