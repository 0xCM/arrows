//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;
    using Z0;

    using static zcore;

    partial class xcore
    {
        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this byte src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this sbyte src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this short src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ushort src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this int src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this uint src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this long src)
            => bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ulong src)
            => bitstring(src);


        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N8,byte> ToBitVector(this byte src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N8,sbyte> ToBitVector(this sbyte src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N16,short> ToBitVector(this short src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N16,ushort> ToBitVector(this ushort src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N32,int> ToBitVector(this int src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N32,uint>  ToBitVector(this uint src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N64,long> ToBitVector(this long src)
            => bitvector(src);

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N64,ulong> ToBitVector(this ulong src)
            => bitvector(src);

        /// <summary>
        /// Constructs an IEE bitstring from a double
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => lpadZ(apply(Bits.split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            ieee.exponent.ToBitString().format(),
                            ieee.mantissa.ToBitString().format()                        
                    )), (int)Float64Ops.BitSize);
 

        /// <summary>
        /// Converts a bool to a bit
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static bit ToBit(this bool src)
            => src;

        /// <summary>
        /// Converts a bit to a bool
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static bit ToBool(this bit src)
            => src;

        /// <summary>
        /// Consructs a bit sream from a stream of bools
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static IEnumerable<bit> ToBits(this IEnumerable<bool> src)
            => map(src,x => x.ToBit());

        /// <summary>
        /// Consructs a bitstring from a stream of bool
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this IEnumerable<bool> src)
            => BitString.define(src.ToBits());

        /// <summary>
        /// Consructs a bitstring from bitslice
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this Slice<bit> src)
            => BitString.define(src);

    }
}