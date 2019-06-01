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
    using static Bits;

    public static partial class BitX
    {

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in sbyte src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in byte src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in ushort src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in short src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in int src, in int pos)
            => test(src,pos);

       /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in uint src, in int pos)
            => test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in long src, in int pos)
            => test(src,pos);
 
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool Test(this in ulong src, in int pos)
            => test(src,pos);

        [MethodImpl(Inline)]
        public static ref Bit Test(this in sbyte src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit Test(this in byte src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit Test(this in short src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit Test(this in ushort src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit Test(this in int src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit Test(this in uint src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            

        [MethodImpl(Inline)]
        public static ref Bit Test(this in long src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);            
        
        [MethodImpl(Inline)]
        public static ref Bit Test(this in ulong src, in int pos, out Bit dst)
             => ref tbit(src, pos, out dst);    
    }

}