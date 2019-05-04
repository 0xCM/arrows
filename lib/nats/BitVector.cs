//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static nats;

    /// <summary>
    /// Defines primary bitvector api
    /// </summary>
    public static class BitVector
    {

        /// <summary>
        /// Constructs a BitVector from an array of bits
        /// </summary>
        /// <param name="src">The source bits</param>
        public static BitVector<N> define<N>(params bit[] src)
            where N : TypeNat, new()
                => new BitVector<N>(src);

        /// <summary>
        /// Constructs a BitVector from an array of binary digits
        /// </summary>
        /// <param name="src">The source bits</param>
        public static BitVector<N> define<N>(params BinaryDigit[] src)
            where N : TypeNat, new()
                => new BitVector<N>(src.ToBits());
   
        public static BitVector<N> Parse<N>(string src)
            where N : TypeNat, new()
        {
            var len = Nat.require<N>(src.Length);
            var bits = alloc<bit>(src.Length);
            for(var i=0; i< len; i++)
                bits[i] = bit.Parse(src[i]);
            return define<N>(bits);

        }
    }  
    /// <summary>
    /// Defines an integrally and naturally typed bitvector
    /// </summary>
    public readonly struct BitVector<N> : Structures.Bitwise<BitVector<N>>, Lengthwise,  Formattable, Equatable<BitVector<N>>
        where N : TypeNat, new()
    {
        public static readonly uint Length = (uint)natu<N>();        
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
        
        [MethodImpl(Inline)]
        public static bool operator == (BitVector<N> lhs, BitVector<N> rhs) 
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BitVector<N> lhs, BitVector<N> rhs) 
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator | (BitVector<N> lhs, BitVector<N> rhs) 
            => lhs.or(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator ^ (BitVector<N> lhs, BitVector<N> rhs) 
            => lhs.xor(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator ~ (BitVector<N> x) 
            => x.flip();

        [MethodImpl(Inline)]
        public static BitVector<N> operator >> (BitVector<N> lhs, int rhs) 
            => lhs.rshift(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N> operator << (BitVector<N> lhs, int rhs) 
            => lhs.lshift(rhs);

        static Exception error(int len)
            => new Exception($"The source has length {len} which differs from the required length {Length}" );
        
        public BitVector(params bit[] src)
            => bits = src.Length == Length ? src : throw error(src.Length);

        public BitVector(Index<bit> src)
            => bits = src.Count == Length ? src : throw error(src.Count);

        public Index<bit> bits {get;}
        
        public uint length 
            => Length;

        [MethodImpl(Inline)]
        public BitVector<N> and(BitVector<N> rhs)
            => new BitVector<N>(fuse(bits,rhs.bits, (x,y) => x & y));

        [MethodImpl(Inline)]
        public BitVector<N> or(BitVector<N> rhs)
            => new BitVector<N>(fuse(bits,rhs.bits, (x,y) => x | y));

        [MethodImpl(Inline)]
        public BitVector<N> xor(BitVector<N> rhs)
            => new BitVector<N>((fuse(bits, rhs.bits, (x,y) => x ^ y)));

        [MethodImpl(Inline)]
        public BitVector<N> flip()
            => new BitVector<N>(map(bits,x => ~x));

        [MethodImpl(Inline)]
        public BitVector<N> lshift(int rhs)
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitVector<N> rshift(int rhs)
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitString bitstring()
            => BitString.define(bits);

        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public bool testbit(int pos)            
            => bits[pos];

        [MethodImpl(Inline)]
        public string format()
            => string.Join("", map(bits, b => b.format()));

        [MethodImpl(Inline)]
        public int hash()
            => bits.GetHashCode();

        [MethodImpl(Inline)]
        public bool eq(BitVector<N> rhs)
        {
            for(var i = 0; i< length; i++)
                if(bits[i] != rhs.bits[i])
                    return false;
            return true;
        } 
 
        [MethodImpl(Inline)]
        public bool neq(BitVector<N> rhs)
            => not(eq(rhs));

        [MethodImpl(Inline)]
        public bool eq(BitVector<N> lhs, BitVector<N> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(BitVector<N> lhs, BitVector<N> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitVector<N> rhs)
            => eq(rhs);
 
        /// <summary>
        /// Turns off the rightmost nonzero bit, e.g.,
        /// 01110110 => 01110100
        /// </summary>
        public BitVector<N> rightmostOnToOff()
            => throw new Exception();

        /// <summary>
        /// Turns on the rightmost zero bit, e.g.,
        /// 01110111 => 01111111
        /// </summary>
        public BitVector<N> rightmostOffToOn()
            => throw new Exception();

        /// <summary>
        /// Turns off trailing nonzero bits, e.g.,
        /// 01110111 => 01110000
        /// </summary>
        public BitVector<N> trailingOnToOff()
            => throw new Exception();

        /// <summary>
        /// Turns on trailing zero bits, e.g.,
        /// 01111000 => 01111111
        /// </summary>
        public BitVector<N> trailingOffToOn()
            => throw new Exception();


        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is BitVector<N> ? Equals((BitVector<N>)rhs) : false;

        static byte turnBitOff(byte src, int pos)
            => (byte)(src & ~ (1 << pos));
        
        
        public byte[] bytes()
            => throw new NotImplementedException();
    }

 
}