//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using target = System.Int16;

    public static partial class Bits
    {

        /// <summary>
        /// Produces a byte by extracting bits [0 .. 7] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(target src)
            => (byte)src;

        /// <summary>
        /// Produces a byte by extracting bits [8 .. 15] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(target src)
            => (byte)(src >> 8);

        /// <summary>
        /// Constructs a int value from two short values
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static int pack(short x0, short x1)
            => (int)x1 << 16 | (int)(ushort)x0;

        /// <summary>
        /// Concatenates the bits of four short values to produce a long value
        /// </summary>
        /// <param name="x0">The least significant bits [0..15] of the result</param>
        /// <param name="x1">Bits [16..31] of the result</param>
        /// <param name="x2">Bits [32..47] of the result</param>
        /// <param name="x3">The most significant bits [32..63] of the result</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static long pack(short x0, short x1, short x2, short x3)
            => pack(pack(x0,x1), pack(x2,x3));

        /// <summary>
        /// Splits a short into two bytes
        /// </summary>
        /// <param name="x0">The source bits [0 .. 7]</param>
        /// <param name="x1">The source bits [8 .. 15]</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) unpack(target src)
            => (lo(src),hi(src));

    }

}