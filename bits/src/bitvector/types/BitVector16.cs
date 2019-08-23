//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;    
    using static Bits;
    using static Bytes;

    /// <summary>
    /// Defines a 16-bit bitvector
    /// </summary>
    public struct BitVector16 : IBitVector<short>
    {
        ushort data;

        public static readonly BitVector16 Zero = 0;

        public static readonly BitVector8 One = 1;

        public static readonly BitSize BitSize = 16;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;

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
        public static BitVector16 FromScalar(ushort src)
            => new BitVector16(src);    

        /// <summary>
        /// Loads a vector from a primal source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalar(uint src)
            => new BitVector16((ushort)src);    

        /// <summary>
        /// Loads a vector from a primal source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromScalar(int src)
            => new BitVector16((ushort)src);    

        [MethodImpl(Inline)]
        public static BitVector16 FromScalars(byte lo, byte hi)
            => FromScalar(hi << 8 | lo);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector16 FromBitString(in BitString src)
            => new BitVector16(src.TakeUInt16());    

        [MethodImpl(Inline)]
        public static BitVector16 Load(ReadOnlySpan<Bit> src)
            => FromScalar(pack(src, out ushort dst));

        /// <summary>
        /// Enumerates each and every 16-bit bitvector exactly once
        /// </summary>
        public static IEnumerable<BitVector16> All
        {
           get
           {
                var bv = BitVector16.Zero;
                do 
                    yield return bv;            
                while(++bv);
           }
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N16,ushort>(BitVector16 src)
            => new BitVector<N16,ushort>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(ushort src)
            => new BitVector16(src);

        /// <summary>
        /// Converts the source vector to the underlying value it represents
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(BitVector16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector16 src)
            => BitVector32.FromScalar(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector16 src)
            => BitVector64.FromScalar(src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector16 src)
            => BitVector8.FromScalar((byte)src.data);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ^(BitVector16 lhs, BitVector16 rhs)
            => (ushort)(lhs.data ^ rhs.data);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator &(BitVector16 lhs, BitVector16 rhs)
            => (ushort)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator |(BitVector16 lhs, BitVector16 rhs)
            => (ushort)(lhs.data | rhs.data);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// Note that this operator is closely related to the negation operator (-)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ~(BitVector16 src)
            => (ushort) ~ src.data;

        /// <summary>
        /// Computes the sum of the source operands
        /// Note that the addition operator is equivalent to the (^) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator +(BitVector16 lhs, BitVector16 rhs)
            => lhs ^ rhs;

        /// <summary>
        /// Computes the product of the operands. Note that this operator is equivalent 
        /// to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator *(BitVector16 lhs, BitVector16 rhs)
            => lhs & rhs;

        /// <summary>
        /// Negates the operand. 
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator -(in BitVector16 src)
            => (ushort)(~src.data + 1);

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
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %( BitVector16 lhs, BitVector16 rhs)
            => mod<N2>(Bits.pop(lhs.data & rhs.data));              

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
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector16 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector16 src)
            => !src.Nonempty;

        /// <summary>
        /// Determines whether the operands represent identical values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool operator ==(BitVector16 lhs, BitVector16 rhs)
            => lhs.Equals(rhs);

        /// <summary>
        /// Determines whether the operands represent identical values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool operator !=(BitVector16 lhs, BitVector16 rhs)
            => !lhs.Equals(rhs);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector16(in ushort src)
            => this.data = src;

        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(pos);
            
            [MethodImpl(Inline)]
            set => BitMask.set(ref data, pos, value);
        }
        
        public ushort this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public BitSize Length
        {
            [MethodImpl(Inline)]
            get => 16;
        }

        /// <summary>
        /// The vector's 8 most significant bits
        /// </summary>
        public BitVector8 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        
        }
        
        /// <summary>
        /// The vector's 8 least significant bits
        /// </summary>
        public BitVector8 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

        /// <summary>
        /// Zero-extends the vector to a vector that accomondates
        /// the next power of 2
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 Expand()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        /// <summary>
        /// Rotates vector bits rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector16 RotR(BitSize offset)
            => Bits.rotr(ref data, (ushort)offset);

        /// <summary>
        /// Rotates vector bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector16 RotL(BitSize offset)
            => Bits.rotl(ref data, (ushort)offset);

        [MethodImpl(Inline)]
        public BitVector16 AndNot(BitVector16 rhs)
            => Bits.andnot((ushort)this, (ushort)rhs);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public Bit Dot(BitVector16 rhs)
            => mod<N2>(Bits.pop(data & rhs.data));              

        [MethodImpl(Inline)]
        public ushort Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

        [MethodImpl(Inline)]
        public void EnableBit(BitPos pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(BitPos pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void SetBit(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        [MethodImpl(Inline)]
        public bool TestBit(BitPos pos)
            => BitMask.test(in data, pos);

        /// <summary>
        /// Counts vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the vector's leading zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the vector's trailing zero bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public BitSize Ntz()
            => Bits.ntz(data);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector16 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector16 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
        {
            data = Bits.rev(data);
        }

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        public void Permute(Perm spec)
        {
            var mask = Alloc();
            var n = math.min(spec.Length, Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            data = Bits.deposit(data,mask);
        }

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt16.MaxValue & data) == UInt16.MaxValue;

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public bool Nonempty
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 Replicate()
            => new BitVector16(data);

        /// <summary>
        /// Returns the vector's bitstring representation
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Extracts the scalar value enclosed by the vector
        /// </summary>
        [MethodImpl(Inline)]
        public ushort ToScalar()
            => data;

        [MethodImpl(Inline)]
        public bool Equals(BitVector16 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

         public override bool Equals(object obj)
            => obj is BitVector16 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();
   }

}