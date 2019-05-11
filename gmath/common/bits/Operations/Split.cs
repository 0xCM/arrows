//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (short x0, short x1) split(int src)
            => (lo(src), hi(src));

        /// <summary>
        /// ushort => (byte,byte)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) split(ushort src)
            => (lo(src), hi(src));

        /// <summary>
        /// Splits a short into two sbytes
        /// </summary>
        /// <param name="x0">The source bits [0 .. 7]</param>
        /// <param name="x1">The source bits [8 .. 15]</param>
        [MethodImpl(Inline)]
        public static (sbyte x0, sbyte x1) split(short src)
            => (lo(src),hi(src));

        /// <summary>
        /// long => (int,int)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1) split(long src)
            => (lo(src), hi(src));

        /// <summary>
        /// ulong => (uint,uint)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (uint x0, uint x1) split(ulong src)
            => (lo(src), hi(src));

        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (ushort hi, ushort lo) split(uint src)
            => (hi(src),lo(src));

        /// <summary>
        /// Partitions the bits of a decimal as a sequence of four integers
        /// </summary>
        /// <param name="x0">The source bits [0 .. 31]</param>
        /// <param name="x1">The source bits [32 .. 63]</param>
        /// <param name="x2">The source bits [64 .. 97]</param>
        /// <param name="x3">The source bits [98 .. 127]</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1, int x2, int x3) split(decimal src)
            => apply(Decimal.GetBits(src), x => (x[0],x[1],x[2],x[3]));
    

    }

}