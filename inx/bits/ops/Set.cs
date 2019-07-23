//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    
    partial class Bits
    {                

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref byte set(ref byte src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref sbyte set(ref sbyte src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref short set(ref short src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref ushort set(ref ushort src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref int set(ref int src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref uint set(ref uint src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref long set(ref long src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref ulong set(ref ulong src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref float set(ref float src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref double set(ref double src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

    }

}