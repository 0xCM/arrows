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

    public ref struct BitVector8
    {
        byte data;

        public const int ByteSize = 1;

        public const int BitSize = ByteSize * 8;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        public static BitVector8 Alloc()
            => new BitVector8();

        /// <summary>
        /// Loads a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 Load(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Loads a vector from a bitspan
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static BitVector8 Load(in ReadOnlySpan<Bit> src)
            => Load(pack(src, out byte dst));

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
            => Load((byte)(lhs.data ^ rhs.data));

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator -(in BitVector8 src)
            => Load((byte)~src.data);

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
        public static BitVector8 operator ~(in BitVector8 src)
            => Load((byte) ~ src.data);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector8 lhs, in BitVector8 rhs)
            => lhs.Dot(rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector8 lhs, in BitVector8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector8 lhs, in BitVector8 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitVector8(in byte data)
            => this.data = data;

        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in data, pos);
            
            [MethodImpl(Inline)]
            set => BitMask.set(ref data, pos, value);
        }

        [MethodImpl(Inline)]
        public byte Extract(int first, int last)
        {
            var len = (byte)(last - first+ 1);
            return Bits.extract(in data, (byte)first, len);
        }

        public byte this[Range range]
        {
            [MethodImpl(Inline)]
            get => Extract(range.Start.Value, range.End.Value);
        }

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => this[(byte)pos];
            [MethodImpl(Inline)]
            set => this[(byte)pos] = value;
        }

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        public readonly Bit Dot(BitVector8 rhs)
        {
              return Mod<N2>.mod((uint)Bits.pop(data & rhs.data));              

            // var result = Bit.Off;
            // for(var i=0; i<Length; i++)
            //     result ^= this[i] & rhs[i];
            // return result;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        [MethodImpl(Inline)]
        public void EnableBit(byte pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public readonly bool TestBit(byte pos)
            => BitMask.test(in data, pos);

        [MethodImpl(Inline)]
        public void SetBit(byte pos, Bit value)
            => BitMask.set(ref data, pos, value);

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 RotR(uint offset)
            => Bits.rotr(ref data, (byte)offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 RotL(uint offset)
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
        public readonly bool Equals(in BitVector8 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (0xFF & data) == 0xFF;
 
        [MethodImpl(Inline)]
        public readonly bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            =>  bytes(in data);

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);
        
        public override bool Equals(object obj)
            => throw new NotSupportedException();
       
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}