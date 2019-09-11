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
        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref sbyte bitmap(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
        {
             dst |= (sbyte)((Bits.extract(src, srcOffset, len) << dstOffset));
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref byte bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
        {
            dst |= (byte)((Bits.extract(src, srcOffset, len) << dstOffset));
            return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref short bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
        {
             dst |= (short)((Bits.extract(src, srcOffset, len) << dstOffset));
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref ushort bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
        {
             dst |= (ushort)((Bits.extract(src, srcOffset, len) << dstOffset));
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref int bitmap(in int src, byte srcOffset, byte len,  byte dstOffset, ref int dst)
        {
             dst |= (Bits.extract(in src, srcOffset, len) << dstOffset);
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref uint bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
        {
             dst |= (Bits.extract(in src, srcOffset, len) << dstOffset);
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value to a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref long bitmap(in long src, byte srcOffset, byte len,  byte dstOffset, ref long dst)
        {
             dst |= (Bits.extract(in src, srcOffset, len) << dstOffset);
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value into a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref ulong bitmap(in ulong src, byte srcOffset, byte len,  byte dstOffset, ref ulong dst)
        {
             dst |= (Bits.extract(in src, srcOffset, len) << dstOffset);
             return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value into a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref float bitmap(in float src, byte srcOffset, byte len,  byte dstOffset, ref float dst)
        {
              math.or(ref dst, extract(src.ToBits(), srcOffset, len) << dstOffset);
              return ref dst;
        }

        /// <summary>
        /// Projects a contiguous sequence of bits from a source value into a target value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="srcOffset">The source offset index</param>
        /// <param name="len">The number of bits in the sequence</param>
        /// <param name="dstOffset">The target offset index</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static ref double bitmap(in double src, byte srcOffset, byte len,  byte dstOffset, ref double dst)
        {
             math.or(ref dst, extract(src.ToBits(), srcOffset, len) << dstOffset);
             return ref dst;
        }

    }

}