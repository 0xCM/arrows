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

    public ref struct BitVector16
    {
        public const int ByteSize = 2;

        public const int BitSize = ByteSize * 8;

        ushort data;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 Alloc()
            => new BitVector16(0);    

        /// <summary>
        /// Loads a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 Load(in ushort src)
            => new BitVector16(src);    

        [MethodImpl(Inline)]
        public static BitVector16 Load(in ReadOnlySpan<Bit> src)
            => Load(in pack(src, out ushort dst));

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N16,ushort>(in BitVector16 src)
            => new BitVector<N16,ushort>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(in ushort src)
            => new BitVector16(src);

        /// <summary>
        /// Explicitly converts the source vector to the underlying value it represents
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator ushort(in BitVector16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static BitVector16 operator +(in BitVector16 lhs, in BitVector16 rhs)
            => Load((ushort)(lhs.data ^ rhs.data));

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator -(in BitVector16 src)
            => Load((ushort)~src.data);

        /// <summary>
        /// Subtracts the second operand from the first. Note that this operator is equivalent to
        /// the composite operation of applying the XOR operator to the left operand and the
        /// complement of the second
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator - (BitVector16 lhs, BitVector16 rhs)
            => lhs + -rhs;

        /// <summary>
        /// Computes the product of the operands. Note that this operator is equivalent 
        /// to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator *(in BitVector16 lhs, in BitVector16 rhs)
            => Load((ushort)(lhs.data & rhs.data));

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector16 lhs, in BitVector16 rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand. Note that this operator
        /// is equivalent to the negation operator (-)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ~(in BitVector16 src)
            => Load((ushort) ~ src.data);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator <<(BitVector16 lhs, int offset)
            => (ushort)(lhs.data << offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator >>(BitVector16 lhs, int offset)
            => (ushort)(lhs.data >> offset);

        /// <summary>
        /// Determines whether the operands represent identical values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector16 lhs, in BitVector16 rhs)
            => lhs.Eq(rhs);

        /// <summary>
        /// Determines whether the operands represent identical values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector16 lhs, in BitVector16 rhs)
            => !lhs.Eq(rhs);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector16(in ushort data)
            => this.data = data;

        [MethodImpl(Inline)]
        public void EnableBit(byte pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public void SetBit(byte pos, Bit value)
            => BitMask.set(ref data, pos, value);

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => BitMask.test(in data, pos);

        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(pos);
            
            [MethodImpl(Inline)]
            set => BitMask.set(ref data, pos, value);
        }

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => this[(byte)pos];
            [MethodImpl(Inline)]
            set => this[(byte)pos] = value;
        }
        
        [MethodImpl(Inline)]
        public ushort Extract(int first, int last)
        {
            var len = (byte)(last - first+ 1);
            return Bits.extract(in data, (byte)first, len);
        }

        public ushort this[Range range]
        {
            [MethodImpl(Inline)]
            get => Extract(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public Bit Dot(BitVector16 rhs)
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
        public int Length
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        public BitVector8 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        
        }
        
        public BitVector8 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

         [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector16 RotR(uint offset)
            => Bits.rotr(ref data, (ushort)offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector16 RotL(uint offset)
            => Bits.rotl(ref data, (ushort)offset);

        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
            => Bits.pop(data);

        [MethodImpl(Inline)]
        public BitSize Nlz()
            => Bits.nlz(data);

        [MethodImpl(Inline)]
        public BitSize Ntz()
            => Bits.ntz(data);

        [MethodImpl(Inline)]
        public BitVector16 AndNot(in BitVector16 rhs)
            => Bits.andnot((ushort)this, (ushort)rhs);

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt16.MaxValue & data) == UInt16.MaxValue;

        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public bool Eq(in BitVector16 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector16 rhs)
            => data != rhs.data;

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }

}