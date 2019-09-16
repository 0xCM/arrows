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
        /// Applies an logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref sbyte srl(ref sbyte src, int offset)
        {            
            math.abs(ref src) >>= offset;
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
            src >>= offset;
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
            math.abs(ref src) >>= offset;
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
            src >>= offset;
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
            math.abs(ref src) >>= offset;
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
            src >>= offset;
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
            math.abs(ref src) >>= offset;
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
            src >>= offset;
            return ref src;
        }

    }

}