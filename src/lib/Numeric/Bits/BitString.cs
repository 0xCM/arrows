//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;


    partial class Structures
    {
        public interface BitString :  Formattable, Lengthwise
        {
            

        }
        
        public interface BitString<S> : BitString, FreeMonoid<S>
            where S : BitString<S>, new()
        {


        }

        public interface BitString<S,N> : BitString<S>
            where S : BitString<S,N>, new()
            where N : TypeNat, new()
        {


        }

    }

    public readonly struct BitString : Structures.BitString<BitString>
    {

        public static BitString define(IReadOnlyList<bit> src)
            => new BitString(src.ToArray());

        public static BitString define(params bit[] src)
            => new BitString(src);

        public static BitString define(IEnumerable<bit> src)
            => new BitString(src.ToArray());

        public static readonly BitString Empty = default;


        [MethodImpl(Inline)]
        public static BitString operator + (BitString lhs, BitString rhs) 
            => lhs.concat(rhs);

        public bit[] bits {get;}

        public BitString zero 
            => Empty;


        [MethodImpl(Inline)]
        public bool nonzero()
            => bits.Length != 0;


        [MethodImpl(Inline)]
        public BitString(params bit[] src)
            => this.bits = src;


        [MethodImpl(Inline)]
        public BitString concat(BitString rhs)
            => new BitString(Arr.concat(bits, rhs.bits));

        [MethodImpl(Inline)]
        public bool eq(BitString rhs)
            => Arr.equals(bits,rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitString lhs, BitString rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitString rhs)
            => Arr.equals(bits,rhs.bits);

        [MethodImpl(Inline)]
        public bool neq(BitString rhs)
            =>  not(Equals(rhs));

        [MethodImpl(Inline)]
        public bool neq(BitString lhs, BitString rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public string format()
            => string.Concat(map(bits,b =>  b.format()));

        [MethodImpl(Inline)]
        public int hash()
            => bits.HashCode();

        public uint length
            => (uint)bits.Length;

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();


    }

 
    partial class xcore
    {
        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this byte src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this sbyte src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this short src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ushort src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this int src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this uint src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this long src)
            => primops.bitstring(src);

        /// <summary>
        /// Constructs a bitstring from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ulong src)
            => primops.bitstring(src);


    }
}