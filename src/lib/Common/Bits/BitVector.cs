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

    partial class Operative
    {

        public interface BitVectored<N,T>
            where N : TypeNat, new()
        {
            BitVector<N,T> bitvector(T src);
        }
    }

    /// <summary>
    /// Defines an integrally and naturally typed bitvector
    /// </summary>
    public readonly struct BitVector<N,T> : Wrapped<intg<T>>, Structures.Bitwise<BitVector<N,T>>, Lengthwise,  Formattable, Equatable<BitVector<N,T>>
        where N : TypeNat, new()
    {
        static readonly intg<T> One = intg<T>.One;
        
        static readonly intg<T> Zero = intg<T>.Zero;

        static readonly intg<T> BitSize = intg<T>.BitSize;
                
        public static readonly uint Length = (uint)natval<N>();        
        
        [MethodImpl(Inline)]
        public static implicit operator BitVector<N,T>(intg<T> src)
            => new BitVector<N,T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (BitVector<N,T> lhs, BitVector<N,T> rhs) 
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BitVector<N,T> lhs, BitVector<N,T> rhs) 
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator | (BitVector<N,T> lhs, BitVector<N,T> rhs) 
            => lhs.or(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^ (BitVector<N,T> lhs, BitVector<N,T> rhs) 
            => lhs.xor(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~ (BitVector<N,T> x) 
            => x.flip();

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator >> (BitVector<N,T> lhs, int rhs) 
            => lhs.rshift(rhs);

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator << (BitVector<N,T> lhs, int rhs) 
            => lhs.lshift(rhs);

        readonly intg<T> data;


        [MethodImpl(Inline)]
        public BitVector(intg<T> src)
        {
            this.data = src;
            this.bits = slice<N,bit>(src.bitstring().bits);
        }

        readonly Slice<N,bit> bits;

        public uint length 
            => Length;

        [MethodImpl(Inline)]
        public BitVector<N,T> and(BitVector<N,T> rhs)
            => data.and(rhs.data);

        [MethodImpl(Inline)]
        public BitVector<N,T> or(BitVector<N,T> rhs)
            => data.or(rhs.data);

        [MethodImpl(Inline)]
        public BitVector<N,T> xor(BitVector<N,T> rhs)
            => data.xor(rhs.data);

        [MethodImpl(Inline)]
        public BitVector<N,T> flip()
            => data.flip();

        [MethodImpl(Inline)]
        public BitVector<N,T> lshift(int rhs)
            => data.lshift(rhs);

        [MethodImpl(Inline)]
        public BitVector<N,T> rshift(int rhs)
            => data.rshift(rhs);

        [MethodImpl(Inline)]
        public BitString bitstring()
            => data.bitstring();

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public bool eq(BitVector<N,T> rhs)
            => data.eq(rhs.data);
 
        [MethodImpl(Inline)]
        public bool neq(BitVector<N,T> rhs)
            =>data.neq(rhs.data);

        [MethodImpl(Inline)]
        public bool eq(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(BitVector<N,T> lhs, BitVector<N,T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitVector<N,T> rhs)
            => data.eq(rhs.data);

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => bits[pos];
        }
 
        /// <summary>
        /// Turns off the rightmost nonzero bit, e.g.,
        /// 01110110 => 01110100
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector<N,T> rightmostOnToOff()
            => data & (data - One);

        /// <summary>
        /// Turns on the rightmost zero bit, e.g.,
        /// 01110111 => 01111111
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector<N,T> rightmostOffToOn()
            => data | (data + One);

        /// <summary>
        /// Turns off trailing nonzero bits, e.g.,
        /// 01110111 => 01110000
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector<N,T> trailingOnToOff()
            => data & (data + One);

        /// <summary>
        /// Turns on trailing zero bits, e.g.,
        /// 01111000 => 01111111
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector<N,T> trailingOffToOn()
            => data & (data + One);

        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public bool test(int pos)            
            => (data & (One << pos)) != Zero;

        [MethodImpl(Inline)]
        public intg<T> unwrap()
            => data;

        [MethodImpl(Inline)]
        public string format()
            => data.bitstring().format();

        /// <summary>
        /// Returns the position of the highest on-bit
        /// </summary>
        [MethodImpl(Inline)]
        public int hipos()
        {
            var start = (int)length - 1;
            for(var i = start; i>= 0; i--)
                if(bits[i])
                    return start - i;
            return 0;
        }            

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is BitVector<N,T> ? Equals((BitVector<N,T>)rhs) : false;
    }
}