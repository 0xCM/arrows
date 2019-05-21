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
    using static mfunc;
    using static Bits;

    partial class BitX
    {
    
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in sbyte src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in byte src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in ushort src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in short src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in int src, in int pos)
            => test(src,pos);

       /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in uint src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in long src, in int pos)
            => test(src,pos);
 
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this in ulong src, in int pos)
            => test(src,pos);

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in sbyte src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in byte src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in short src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in ushort src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in int src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in uint src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in long src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);            
        
        [MethodImpl(Inline)]
        public static ref Bit TestBit(this in ulong src, in int pos, out Bit dst)
             => ref test(src, pos, out dst);    
    }

}