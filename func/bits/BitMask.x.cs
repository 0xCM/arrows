//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class BitMaskX
    {
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this sbyte src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this byte src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ushort src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this short src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this int src, byte pos)
            => BitMask.test(src,pos);

       /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this uint src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this long src, byte pos)
            => BitMask.test(src,pos);
 
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ulong src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this float src, byte pos)
            => BitMask.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this double src, byte pos)
            => BitMask.test(src,pos);
 
        [MethodImpl(Inline)]
        public static ref byte ToggleBit(this ref byte src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref sbyte ToggleBit(this ref sbyte src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short ToggleBit(this ref short src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort ToggleBit(this ref ushort src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int ToggleBit(this ref int src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint ToggleBit(this ref uint src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long ToggleBit(this ref long src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong ToggleBit(this ref ulong src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float ToggleBit(this ref float src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double ToggleBit(this ref double src, int pos)
        {
            BitMask.toggle(ref src, pos);
            return ref src;
        }
 
    }
}