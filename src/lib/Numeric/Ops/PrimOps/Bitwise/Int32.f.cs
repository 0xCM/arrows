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
    using target = System.Int32;

    public static partial class Bits
    {

        /// <summary>
        /// int => (short, .)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static short hi(int src)
            => (short)(src >> 16);

        /// <summary>
        /// int => (., short)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static short lo(int src)
            => (short)src;

        /// <summary>
        /// Extracts the least order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k1
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo8(int src)
            => lo(lo(src));

        /// <summary>
        /// Extracts the third order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k3
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hilo(int src)
            => lo(hi(src));

        /// <summary>
        /// Extracts the second order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k2
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lohi(int src)
            => hi(lo(src));


        /// <summary>
        /// Extracts the highest order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k4
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi8(int src)
            => hi(hi(src));

        /// <summary>
        /// Constructs a long value from two int values
        /// </summary>
        /// <param name="x1">The high-order bits</param>
        /// <param name="x0">The low-order bits</param>
        [MethodImpl(Inline)]
        public static long pack(target x0, target x1)
            => (long)x1 << 32 | (long)(uint)x0;

        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (short x0, short x1) unpack(target src)
            => (lo(src), hi(src));



    }

}