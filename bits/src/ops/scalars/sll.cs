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
    
    partial class Bits
    {
        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static sbyte sll(sbyte src, int offset)
            => (sbyte)(math.abs(ref src) << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static byte sll(byte src, int offset)
            => (byte)(src << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static short sll(short src, int offset)
            => (short)(math.abs(ref src) << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static ushort sll(ushort src, int offset)
            => (ushort)(src << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static int sll(int src, int offset)
            => math.abs(ref src) << offset;

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static uint sll(uint src, int offset)
            => src << offset;

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static long sll(long src, int offset)
            => math.abs(ref src) << offset;

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static ulong sll(ulong src, int offset)
            => src << offset;

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref sbyte sll(ref sbyte src, int offset)
        {            
            math.abs(ref src) <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref byte sll(ref byte src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref short sll(ref short src, int offset)
        {
            math.abs(ref src) <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref ushort sll(ref ushort src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref int sll(ref int src, int offset)
        {
            math.abs(ref src) <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref uint sll(ref uint src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref long sll(ref long src, int offset)
        {
            math.abs(ref src) <<= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref ulong sll(ref ulong src, int offset)
        {
            src <<= offset;
            return ref src;
        }

    }

}