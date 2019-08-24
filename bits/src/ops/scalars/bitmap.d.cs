//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static void bitmap(sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
             => dst |= (sbyte)((Bits.extract(src, srcOffset, len) << dstOffset));

        [MethodImpl(Inline)]
        public static void bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
             => dst |= (byte)((Bits.extract(src, srcOffset, len) << dstOffset));

        [MethodImpl(Inline)]
        public static void bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
             => dst |= (short)((Bits.extract(src, srcOffset, len) << dstOffset));

        [MethodImpl(Inline)]
        public static void bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
             => dst |= (ushort)((Bits.extract(src, srcOffset, len) << dstOffset));

        [MethodImpl(Inline)]
        public static void bitmap(int src, byte srcOffset, byte len,  byte dstOffset, ref int dst)
             => dst |= (Bits.extract(src, srcOffset, len) << dstOffset);

        [MethodImpl(Inline)]
        public static void bitmap(uint src, byte srcOffset, byte len,  byte dstOffset, ref uint dst)
             => dst |= (Bits.extract(src, srcOffset, len) << dstOffset);

        [MethodImpl(Inline)]
        public static void bitmap(long src, byte srcOffset, byte len,  byte dstOffset, ref long dst)
             => dst |= (Bits.extract(src, srcOffset, len) << dstOffset);

        /// <summary>
        /// Projects a contiguous sequence of bits from a source to a target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static void bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref ulong dst)
             => dst |= (Bits.extract(src, srcOffset, len) << dstOffset);

        [MethodImpl(Inline)]
        public static byte shufflespec(byte x3, byte x2, byte x1, byte x0)
            => (byte)((x3 << 6) | (x2 << 4) | (x1 << 2) | x0);
    }

}