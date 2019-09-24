//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {         


        /// <summary>
        /// Populates a target span with 8 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<byte> unpack(byte src, Span<byte> dst)
        {
            BitParts.unpack8x1(src, dst);
            return dst;
        }    

        /// <summary>
        /// Populates a target span with 8 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> unpack(byte src)
            => unpack(src, new byte[Pow2.T03]);

        /// <summary>
        /// Populates a target span with 16 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<byte> unpack(ushort src, Span<byte> dst)
        {
            BitParts.unpack16x1(src, dst);
            return dst;
        }

        /// <summary>
        /// Populates a target span with 16 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> unpack(ushort src)
            => unpack(src, new byte[Pow2.T04]);


        /// <summary>
        /// Populates a target span with 32 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<byte> unpack(uint src, Span<byte> dst)
        {
            BitParts.unpack32x1(src, dst);
            return dst;
        }

        /// <summary>
        /// Populates a target span with 32 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> unpack(uint src)
            => unpack(src, new byte[Pow2.T05]);

        /// <summary>
        /// Populates a target span with 64 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        public static Span<byte> unpack(ulong src, Span<byte> dst)
        {
            BitParts.unpack64x1(src, dst);
            return dst;
        } 

        /// <summary>
        /// Populates a target span with 64 bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> unpack(ulong src)
            => unpack(src, new byte[Pow2.T06]);


    }
}