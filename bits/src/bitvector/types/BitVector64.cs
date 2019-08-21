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

    using static Bits;
    using static Bytes;

    using static zfunc;    

    /// <summary>
    /// Defines a 64-bit bitvector
    /// </summary>
    public struct BitVector64
    {
        ulong data;

        public static readonly BitVector64 Zero = default;

        public static readonly BitSize BitSize = 64;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;

        [MethodImpl(Inline)]
        public static BitVector64 Alloc()
            => new BitVector64(0);

        /// <summary>
        /// Creates a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(ulong src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromBitString(in BitString src)
            => new BitVector64(src.TakeUInt64());    

        [MethodImpl(Inline)]
        public static BitVector64 Load(in ReadOnlySpan<Bit> src)
            => FromScalar(pack(src, out ulong data));

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N64,ulong>(in BitVector64 src)
            => new BitVector<N64,ulong>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(in ulong src)
            => new BitVector64(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitVector64 src)
            => src.data;        


        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ^(BitVector64 lhs, BitVector64 rhs)
            => lhs.data ^ rhs.data;

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator &(BitVector64 lhs, BitVector64 rhs)
            => lhs.data & rhs.data;

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator |(BitVector64 lhs, BitVector64 rhs)
            => lhs.data | rhs.data;

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector64 lhs, in BitVector64 rhs)
            => Mod<N2>.mod(Bits.pop(lhs.data & rhs.data));              

        /// <summary>
        /// Computes the sum of the source operands
        /// Note that the AND operator is equivalent to the (^) operator
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator +(BitVector64 lhs, BitVector64 rhs)
            => lhs ^ rhs;

        /// <summary>
        /// Computes the product of the operands. 
        /// Note that this operator is equivalent to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator *(BitVector64 lhs, BitVector64 rhs)
            => lhs & rhs;

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ~(BitVector64 src)
            => ~src.data;

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator -(BitVector64 src)
            => ~src.data + 1ul;

        /// <summary>
        /// Subtracts the second operand from the first. Note that this operator is equivalent to
        /// the composite operation of applying the XOR operator to the left operand and the
        /// complement of the second
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator - (BitVector64 lhs, BitVector64 rhs)
            => lhs + -rhs;    

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator <<(BitVector64 lhs, int offset)
            => lhs.data << offset;

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator >>(BitVector64 lhs, int offset)
            => lhs.data >> offset;


        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector64 lhs, in BitVector64 rhs)
            => !lhs.Equals(rhs);

        /// <summary>
        /// Initializes a vector with the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector64(in ulong data)
            => this.data = data;

        /// <summary>
        /// Initializes a vector with a sequence of bit values that is clamped to 64 bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector64(in Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(BitSize, src.Length); i++)
                if(src[i])
                    BitMask.enable(ref data, i);
        }

        /// <summary>
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(pos);
            
            [MethodImpl(Inline)]
            set => SetBit(pos,value);
       }

        public ulong this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// The vector's 32 most significant bits
        /// </summary>
        public BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => (uint)hi(data);        
        }
        
        /// <summary>
        /// The vector's 32 least significant bits
        /// </summary>
        public BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => (uint)lo(data);    
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public BitSize Length
        {
            [MethodImpl(Inline)]
            get => 64;
        }

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        Bit DotRef(BitVector64 rhs)
        {
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;
        }

        /// <summary>
        /// Enables a bit
        /// </summary>
        /// <param name="pos">The position of the bit to manipulate</param>
        [MethodImpl(Inline)]
        public void EnableBit(BitPos pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit
        /// </summary>
        /// <param name="pos">The position of the bit to manipulate</param>
        [MethodImpl(Inline)]
        public void DisableBit(BitPos pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to manipulate</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void SetBit(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public bool TestBit(BitPos pos)
            => BitMask.test(in data, pos);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector64 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector64 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 RotR(BitSize offset)
            => Bits.rotr(ref data, offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 RotL(BitSize offset)
            => Bits.rotl(ref data, offset);
        
        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
            => pop(data);
        
        [MethodImpl(Inline)]
        public BitSize Nlz()
            => nlz(data);

        [MethodImpl(Inline)]
        public BitSize Ntz()
            => ntz(data);

        [MethodImpl(Inline)]
        public BitVector64 AndNot(in BitVector64 rhs)
            => Bits.andnot((ulong)this, (ulong)rhs);

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
        {
            data = Bits.rev(data);
        }

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt64.MaxValue & data) == UInt64.MaxValue;

        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public bool Equals(in BitVector64 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public ulong Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        public override bool Equals(object obj)
            => obj is BitVector64 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();
 
    }
}