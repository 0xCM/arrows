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


    public static class BitVector
    {
        /// <summary>
        /// Constructs a BitVector from an integer
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        public static BitVector<T> define<T>(intg<T> src)
            => new BitVector<T>(src);

        public static BitVector<T> parse<T>(string src)
        {
            var result = intg<T>.Zero;    
            var chars = reorient(remove(src.Trim(), "0b"));
            var start = min(chars.Length,(int)intg<T>.BitSize) - 1;
            for(var i = start; i >=0; i--)
            {                
                var c = chars[i];
                var b = bit.Parse(c).ToIntG<T>();
                result += Pow2.mul(i,b);
            }
            return result;
        }

        public static BitVector<byte> parse8(string src)
        {

            var result = 0ul;    
            var chars = reorient(remove(src.Trim(), "0b"));
            var start = min(chars.Length, (int)intg<byte>.BitSize) - 1;
            for(var i = (int)start; i>=0; i--)
            {
                var c = chars[i];
                var b = (ulong)bit.Parse(c);
                result += Pow2.mul(i,b);
            }
            return ((byte)result).ToIntG();

        }
    }

    public readonly partial struct BitVector<T> : Structures.Bitwise<BitVector<T>>, Lengthwise,  Formattable, Equatable<BitVector<T>>
    {
        static readonly intg<T> One = intg<T>.One;
        
        static readonly intg<T> Zero = intg<T>.Zero;

        static readonly intg<T> BitSize = intg<T>.BitSize;
        
        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(intg<T> src)
            => new BitVector<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (BitVector<T> lhs, BitVector<T> rhs) 
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BitVector<T> lhs, BitVector<T> rhs) 
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator | (BitVector<T> lhs, BitVector<T> rhs) 
            => lhs.or(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator ^ (BitVector<T> lhs, BitVector<T> rhs) 
            => lhs.xor(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator ~ (BitVector<T> x) 
            => x.flip();

        [MethodImpl(Inline)]
        public static BitVector<T> operator >> (BitVector<T> lhs, int rhs) 
            => lhs.rshift(rhs);

        [MethodImpl(Inline)]
        public static BitVector<T> operator << (BitVector<T> lhs, int rhs) 
            => lhs.lshift(rhs);

        readonly intg<T> data;

        public uint length 
            => data.bitstring().length;

        [MethodImpl(Inline)]
        public BitVector(intg<T> src)
            => data = src;

        // public BitVector(BitString src)
        // {
        //     src.            
        // }
        [MethodImpl(Inline)]
        public BitVector<T> and(BitVector<T> rhs)
            => data.and(rhs.data);

        [MethodImpl(Inline)]
        public BitVector<T> or(BitVector<T> rhs)
            => data.or(rhs.data);

        [MethodImpl(Inline)]
        public BitVector<T> xor(BitVector<T> rhs)
            => data.xor(rhs.data);

        [MethodImpl(Inline)]
        public BitVector<T> flip()
            => data.flip();

        [MethodImpl(Inline)]
        public BitVector<T> lshift(int rhs)
            => data.lshift(rhs);

        [MethodImpl(Inline)]
        public BitVector<T> rshift(int rhs)
            => data.rshift(rhs);


        [MethodImpl(Inline)]
        public BitString bitstring()
            => data.bitstring();

        [MethodImpl(Inline)]
        public Slice<bit> bits()
            => data.bitstring().bits;

        [MethodImpl(Inline)]
        public string format()
            => data.bitstring().format();

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public bool eq(BitVector<T> rhs)
            => data.eq(rhs.data);
 
        [MethodImpl(Inline)]
        public bool neq(BitVector<T> rhs)
            =>data.neq(rhs.data);

        [MethodImpl(Inline)]
        public bool eq(BitVector<T> lhs, BitVector<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(BitVector<T> lhs, BitVector<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitVector<T> rhs)
            => data.eq(rhs.data);

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is BitVector<T> ? Equals((BitVector<T>)rhs) : false;
    }
}