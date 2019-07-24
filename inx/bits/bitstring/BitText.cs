//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    partial class Bits
    {
        /// <summary>
        /// Constructs an 8-character string, referred to as a bitstring, contains the character sequence 
        /// {ci} := [c0,...c7] according to whether the bit in the i'th position of the source is respecively disabled/enabled
        /// !Note the reversal of order
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static string bstext(byte src)
            => ByteIndex.BitText(src);

        /// <summary>
        /// Constructs an 8-character string, referred to as a bitstring, contains the character sequence 
        /// {ci} := [c0,...c7] according to whether the bit in the i'th position of the source is respecively disabled/enabled
        /// !Note the reversal of order
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static string bstext(sbyte src)
            => ByteIndex.BitText(src);

        [MethodImpl(Inline)]
        public static string bstext(ushort src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        [MethodImpl(Inline)]
        public static string bstext(short src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        [MethodImpl(Inline)]
        public static string bstext(uint src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        [MethodImpl(Inline)]
        public static string bstext(int src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        [MethodImpl(Inline)]
        public static string bstext(ulong src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        [MethodImpl(Inline)]
        public static string bstext(long src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }


    }

}