//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class math
    {

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static uint srl(uint src, int offset)
            => srl32u(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static long srl(long src, int offset)
            => srl64i(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static ulong srl(ulong src, int offset)
            => srl64u(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static sbyte srl(sbyte src, int offset)
            => (sbyte)srl32i(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static byte srl(byte src, int offset)
            => (byte)srl32u(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static short srl(short src, int offset)
            => (short) srl32i(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static ushort srl(ushort src, int offset)
            => (ushort) srl32u(src,offset);

        /// <summary>
        /// Applies a logical right shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift rightwards</param>
        [MethodImpl(Inline)]
        public static int srl(int src, int offset)
            => srl32i(src,offset);

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref sbyte srl(ref sbyte src, int offset)
        {            
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref byte srl(ref byte src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref short srl(ref short src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref ushort srl(ref ushort src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref int srl(ref int src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref uint srl(ref uint src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref long srl(ref long src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref ulong srl(ref ulong src, int offset)
        {
            src = srl(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        static int srl32i(int src, int offset)
            => (int)((uint)src >> offset);

        [MethodImpl(Inline)]
        static uint srl32u(uint src, int offset)
            => src >> offset;

        [MethodImpl(Inline)]
        static long srl64i(long src, int offset)
            => (long)((ulong)src >> offset);

        [MethodImpl(Inline)]
        static ulong srl64u(ulong src, int offset)
            => src >> offset;

    }

}