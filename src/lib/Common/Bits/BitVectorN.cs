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

    /// <summary>
    /// Defines an integrally and naturally typed bitvector
    /// </summary>
    public readonly struct BitVector<N> : Structures.Bitwise<BitVector<N>>, Lengthwise,  Formattable, Equatable<BitVector<N>>
        where N : TypeNat, new()
    {
        public static readonly uint Length = (uint)natval<N>();        
        

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

        public Slice<N,bit> bits {get;}

        public uint length 
            => Length;

        [MethodImpl(Inline)]
        public BitVector<N> and(BitVector<N> rhs)
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitVector<N> or(BitVector<N> rhs)
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitVector<N> xor(BitVector<N> rhs)
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitVector<N> flip()
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitVector<N> lshift(int rhs)
            => throw new Exception();

        [MethodImpl(Inline)]
        public BitVector<N> rshift(int rhs)
            => throw new Exception();


        [MethodImpl(Inline)]
        public BitString bitstring()
            => throw new Exception();


        [MethodImpl(Inline)]
        public string format()
            => bits.format();

        [MethodImpl(Inline)]
        public int hash()
            => bits.GetHashCode();

        [MethodImpl(Inline)]
        public bool eq(BitVector<N> rhs)
            => bits.eq(rhs.bits);
 
        [MethodImpl(Inline)]
        public bool neq(BitVector<N> rhs)
            =>bits.neq(rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitVector<N> lhs, BitVector<N> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(BitVector<N> lhs, BitVector<N> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitVector<N> rhs)
            => bits.eq(rhs.bits);

 
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

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is BitVector<N> ? Equals((BitVector<N>)rhs) : false;

        public byte[] bytes()
        {
            var len = (bits.length / 8) + 1;            
            var dst = new byte[]{};
            foreach(var part in bits.Partition(8))
            {
                var segment = part.ToArray();
                if(segment.Length != 8)
                {
                    var padding = repeat(bit.Zero, 8 - part.Count);                    
                    segment = concat(padding,segment.ToArray());
                }                                    
            }
            throw new NotImplementedException();

        }
    }

    partial class xcore
    {

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
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N32,int> ToBitVector(this float src)
            => bitvector(BitConverter.SingleToInt32Bits(src));

        /// <summary>
        /// Constructs a bitvector from a number
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static BitVector<N64,long> ToBitVector(this double src)
            => bitvector(BitConverter.DoubleToInt64Bits(src));

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
                    )), primops.bitsize<double>());
 
    }    
}