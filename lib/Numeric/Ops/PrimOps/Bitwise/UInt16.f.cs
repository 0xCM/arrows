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
    using target = System.UInt16;

    public static partial class Bits
    {

        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static byte hi(target src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the low-order bits from a ushort to produce a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(target src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static uint pack(target x0, target x1)
            => (uint)x1 << 16 | (uint)x0;

        [MethodImpl(Inline)]
        public static ulong pack(target x0, target x1, target x2, target x3)
            => pack(pack(x0,x1), pack(x2,x3));

        /// <summary>
        /// ushort => (byte,byte)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) unpack(target src)
            => (lo(src), hi(src));


    }

}