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
    using static As;
    using static AsIn;

    partial class gbits
    {        
        /// <summary>
        /// Constructs a string bs of n := bitsize[T] characters, referred to as a *bitstring*, that
        /// consists of a sequence of n characters, bs = [c0,..., c_i, ..., c_n-1],
        /// where bs[i] = '1' if the bit at position in the source is enabled and '0' otherwise.
        /// !Note the reversal of order
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static string bstext<T>(in T src)
        {
            if(typeof(T) == typeof(byte))
                return bstext(uint8(in src));
            else if(typeof(T) == typeof(sbyte))
                return bstext(int8(in src));
            else if(typeof(T) == typeof(ushort))
                return bstext(uint16(in src));
            else if(typeof(T) == typeof(short))
                return bstext(int16(in src));
            else if(typeof(T) == typeof(uint))
                return bstext(uint32(in src));
            else if(typeof(T) == typeof(int))
                return bstext(int32(in src));
            else if(typeof(T) == typeof(ulong))
                return bstext(uint64(in src));
            else if(typeof(T) == typeof(long))
                return bstext(int64(in src));
            else            
                throw unsupported<T>();            
        }

        /// <summary>
        /// Constructs the bitstring for an 8-bit unsigned integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static string bstext(byte src)
            => BitStore.BitText(src);

        /// <summary>
        /// Constructs the bitstring for an 8-bit signed integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static string bstext(sbyte src)
            => BitStore.BitText(src);

        /// <summary>
        /// Constructs the bitstring for a 16-bit unsigned integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static string bstext(ushort src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        /// <summary>
        /// Constructs the bitstring for a 16-bit signed integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static string bstext(short src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        [MethodImpl(Inline)]
        static string bstext(uint src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        /// <summary>
        /// Constructs the bitstring for a 32-bit signed integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static string bstext(int src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        /// <summary>
        /// Constructs the bitstring for a 64-bit unsigned integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static string bstext(ulong src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }

        /// <summary>
        /// Constructs the bitstring for a 64-bit signed integer
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static string bstext(long src)
        {
            (var lo, var hi) = Bits.split(src);            
            return bstext(hi) + bstext(lo);
        }
 

    }

}