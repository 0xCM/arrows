//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;    
    using static Bits;
    using static Bytes;

    /// <summary>
    /// Defines a 4-bit bitvector
    /// </summary>
    public struct BitVector4 : IBitVector<UInt4>
    {
        UInt4 data;

        public static readonly BitVector4 Zero = default;

        public static readonly BitSize BitSize = 4;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;

        [MethodImpl(Inline)]
        public static BitVector4 FromParts(Bit? x0 = null, Bit? x1 = null, Bit? x2 = null, Bit? x3 = null)
            => UInt4.FromBits(x0,x1,x2,x3);

        /// <summary>
        /// Creates a vector from the lower 4 bits of a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromScalar(byte src)
            => new BitVector4(src);            

        /// <summary>
        /// Creates a vector from the primal source value with which it aligns
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromScalar(UInt4 src)
            => new BitVector4(src);            

        /// <summary>
        /// Creates a vector from the primal source value with which it aligns
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector4 FromBitString(BitString src)
            => new BitVector4(src.IsEmpty ? (byte)0 : src.PackedBits()[0]);            

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N4,byte>(in BitVector4 src)
            => new BitVector<N4,byte>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector4(in byte src)
            => new BitVector4(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(in BitVector4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector4(UInt4 src)
            => new BitVector4(src);

        /// <summary>
        /// Computes the XOR of the source operands. 
        /// Note that this operator is equivalent to the addition operator (+)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator ^(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data ^ rhs.data);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator &(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator |(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static BitVector4 operator ~(BitVector4 src)
            => new BitVector4(~src.data);

        /// <summary>
        /// Computes the component-wise sum of the source operands. 
        /// Note that this operator is equivalent to the XOR operator (^)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator +(in BitVector4 lhs, in BitVector4 rhs)
            => lhs ^ rhs;

        /// <summary>
        /// Computes the product of the operands. 
        /// Note that this operator is equivalent to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator *(in BitVector4 lhs, in BitVector4 rhs)
            => lhs & rhs;

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Dot(rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator -(in BitVector4 src)
            => (byte)(~src.data + 1);

        [MethodImpl(Inline)]
        public static BitVector4 operator >>(BitVector4 lhs, int rhs)
            => new BitVector4(lhs.data >> rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator <<(BitVector4 lhs, int rhs)
            => new BitVector4(lhs.data << rhs);


        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector4 lhs, in BitVector4 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitVector4(byte data)
        {
            this.data = (UInt4)data;
        }

        [MethodImpl(Inline)]
        public BitVector4(UInt4 data)
        {
            this.data = data;
        }

        [MethodImpl(Inline)]
        public void EnableBit(BitPos pos)
            => data[pos] = Bit.On;

        [MethodImpl(Inline)]
        public void DisableBit(BitPos pos)
            => data[pos] = Bit.Off;

        [MethodImpl(Inline)]
        public bool TestBit(BitPos pos)
            => data[pos];

        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => data[pos];
            
            [MethodImpl(Inline)]
            set => data[pos] = value;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public BitSize Length
        {
            [MethodImpl(Inline)]
            get => 4;
        }

        public Bit Dot(BitVector4 rhs)
        {
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;
        }

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => new byte[]{data};
        }

        /// <summary>
        /// Counts the number of enabled bits in the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Nlz()
            => Bits.nlz((byte)(data << 4));

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Ntz()
            => Bits.ntz(data);

        [MethodImpl(Inline)]
        public bool Equals(in BitVector4 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (0xF & data) == 0xF;
 
        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public BitVector4 Between(BitPos first, BitPos last)
            => Bits.between(data, first, last);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector4 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector4 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Extracts the scalar value enclosed by the vector
        /// </summary>
        [MethodImpl(Inline)]
        public UInt4 ToScalar()
            => data;

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

         public override bool Equals(object obj)
            => obj is BitVector4 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();
    }
}