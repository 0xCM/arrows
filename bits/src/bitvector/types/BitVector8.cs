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

    public struct BitVector8 : IBitVector<byte>
    {
        public static readonly BitSize BitSize = 8;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;

        byte data;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        public static BitVector8 Alloc()
            => new BitVector8();

        /// <summary>
        /// Creates a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromBitString(in BitString src)
            => new BitVector8(src.TakeUInt8());    

        /// <summary>
        /// Loads a vector from a bitspan
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static BitVector8 Load(in ReadOnlySpan<Bit> src)
            => FromScalar(pack(src, out byte dst));

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N8,byte>(in BitVector8 src)
            => new BitVector<N8,byte>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector8(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Explicitly converts the source vector to the underlying value it represents
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator byte(in BitVector8 src)
            => src.data;

        /// <summary>
        /// Computes the component-wise sum of the source operands. Note that this operator
        /// is equivalent to the XOR operator (^)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator +(in BitVector8 lhs, in BitVector8 rhs)
            => FromScalar((byte)(lhs.data ^ rhs.data));

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator -(in BitVector8 src)
            => FromScalar((byte)~src.data);

        /// <summary>
        /// Subtracts the second operand from the first. Note that this operator is equivalent to
        /// the composite operation of applying the XOR operator to the left operand and the
        /// complement of the second
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator - (BitVector8 lhs, BitVector8 rhs)
            => lhs + -rhs;

        /// <summary>
        /// Computes the product of the operands. Note that this operator is equivalent 
        /// to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator *(in BitVector8 lhs, in BitVector8 rhs)
            => (byte) (lhs.data & rhs.data);

        /// <summary>
        /// Computes the component-wise AND of the operands. Note that his operator is
        /// equivalent to the multiplication operator (*)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator &(in BitVector8 lhs, in BitVector8 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the component-wise OR of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator |(in BitVector8 lhs, in BitVector8 rhs)
            => (byte)(lhs.data | rhs.data);

        /// <summary>
        /// Computes the XOR of the source operands. Note that this operator is equivalent to 
        /// the addition operator (+)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ^(in BitVector8 lhs, in BitVector8 rhs)
            => (byte)(lhs.data ^ rhs.data);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator <<(BitVector8 lhs, int offset)
            => (byte)(lhs.data << offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator >>(BitVector8 lhs, int offset)
            => (byte)(lhs.data >> offset);

        /// <summary>
        /// Computes the bitwise complement of the operand. Note that this operator is
        /// equivalent to the negation operator (-)
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ~(BitVector8 src)
            => FromScalar((byte) ~ src.data);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector8 lhs, BitVector8 rhs)
            => lhs.Dot(rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector8 lhs, BitVector8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector8 lhs, BitVector8 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitVector8(byte src)
            => this.data = src;

        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in data, pos);
            
            [MethodImpl(Inline)]
            set => BitMask.set(ref data, pos, value);
        }

        /// <summary>
        /// The vector's 4 most significant bits
        /// </summary>
        public BitVector4 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        
        }
        
        /// <summary>
        /// The vector's 4 least significant bits
        /// </summary>
        public BitVector4 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        public BitVector8 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        [MethodImpl(Inline)]
        public BitVector8 Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        public readonly Bit Dot(BitVector8 rhs)
              => Mod<N2>.mod((uint)Bits.pop(data & rhs.data));              

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => 8;
        }

        [MethodImpl(Inline)]
        public void EnableBit(BitPos pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(BitPos pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public readonly bool TestBit(BitPos pos)
            => BitMask.test(in data, pos);

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
        {
            data = Bits.rev(data);
        }


        /// <summary>
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void SetBit(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 RotR(BitSize offset)
            => Bits.rotr(ref data, (byte)offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 RotL(BitSize offset)
            => Bits.rotl(ref data, (byte)offset);

        /// <summary>
        /// Counts the number of enabled bits in the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(data);

        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

        [MethodImpl(Inline)]
        public readonly BitSize Ntz()
            => Bits.ntz(data);

        [MethodImpl(Inline)]
        public BitVector8 AndNot(in BitVector8 rhs)
            => Bits.andnot((byte)this, (byte)rhs);

        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (0xFF & data) == 0xFF;
 
        [MethodImpl(Inline)]
        public readonly bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        [MethodImpl(Inline)]
        public readonly bool Equals(in BitVector8 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => obj is BitVector8 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();
   
    }
}