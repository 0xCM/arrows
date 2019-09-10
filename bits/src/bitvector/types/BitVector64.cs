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

    /// <summary>
    /// Defines a 64-bit bitvector
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BitVector64 : IFixedBits<BitVector64,ulong>
    {
        
        [FieldOffset(0)]
        internal BitVector4 bv4;

        [FieldOffset(0)]
        internal BitVector8 bv8;

        [FieldOffset(0)]
        internal BitVector16 bv16;

        [FieldOffset(0)]
        internal BitVector32 bv32;

        [FieldOffset(0)]
        ulong data;

        [FieldOffset(0)]
        uint x00;

        [FieldOffset(4)]
        uint x01;

        [FieldOffset(0)]
        ushort x000;

        [FieldOffset(2)]
        ushort x001;

        [FieldOffset(4)]
        ushort x010;

        [FieldOffset(6)]
        ushort x011;

        [FieldOffset(0)]        
        byte x0000;
        
        [FieldOffset(1)]
        byte x0001;
        
        [FieldOffset(2)]
        byte x0010;
        
        [FieldOffset(3)]
        byte x0011;

        [FieldOffset(4)]
        byte x0100;
        
        [FieldOffset(5)]
        byte x0101;
        
        [FieldOffset(6)]
        byte x0110;
        
        [FieldOffset(7)]
        byte x0111;

        public static readonly BitVector64 Zero = default;

        public static readonly BitSize BitSize = 64;

        public static readonly BitPos LastPos = BitSize - 1;

        /// <summary>
        /// Allocates a new empty vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 Alloc()
            => new BitVector64(0);

        /// <summary>
        /// Creates a permutation-defined mask
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static BitVector64 Mask(Perm spec)
        {
            var mask = Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return mask;
        }

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(byte src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(ushort src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(uint src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalar(ulong src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromScalars(uint lo, uint hi)
            => FromScalar((ulong)hi << 32 | (ulong)lo);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 FromBitString(in BitString src)
            => src.TakeUInt64();

        /// <summary>
        /// Enumerates all 32-bit bitvectors whose width is less than or equal to a specified maximum
        /// </summary>
        public static IEnumerable<BitVector64> All(int maxwidth)
        {
            var maxval = Pow2.pow(maxwidth);
            var bv = BitVector64.Zero;
            while(bv < maxval)
                yield return bv++;            
        }

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N64,ulong>(in BitVector64 src)
            => new BitVector<N64,ulong>(src.data);

        /// <summary>
        /// Implicitly converts an unsigned 64-bit integer to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source integer</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector64(in ulong src)
            => new BitVector64(src);

        /// <summary>
        /// Implicitly converts a bitvector to a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(BitVector64 src)
            => src.data;        

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(byte src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(ushort src)
            => FromScalar(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(uint src)
            => FromScalar(src);

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
        /// Negates the operand via two'2 complement
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
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator <<(BitVector64 lhs, int offset)
            => lhs.data << offset;

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator >>(BitVector64 lhs, int offset)
            => lhs.data >> offset;

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ++(in BitVector64 src)
            => src.Inc();

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator --(in BitVector64 src)
            => src.Dec();

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector64 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector64 src)
            => !src.Nonempty;

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
            : this()
                => this.data = data;

        /// <summary>
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
       }

        /// <summary>
        /// Selects a range of bits
        /// </summary>
        public BitVector64 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        public BitVector64 this[BitPos lpos, BitPos rpos]
        {
            [MethodImpl(Inline)]
            get => Between(lpos, rpos);
        }

        /// <summary>
        /// The vector's 32 least significant bits
        /// </summary>
        public BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => bv32;

            [MethodImpl(Inline)]
            set => bv32 = value;
        }

        /// <summary>
        /// The vector's 32 most significant bits
        /// </summary>
        public BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => x01;
            [MethodImpl(Inline)]
            set => x01 = value;
        }        

        /// <summary>
        /// The actual number of bits represented by the vector
        /// </summary>
        public readonly BitSize Length
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        /// <summary>
        /// The maximum number of bits that can be represented
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl(Inline)]
            get => Length;
        }

        /// <summary>
        /// Computes the least number of bits required to represent vector content
        /// </summary>
        public int MinWidth
        {
            [MethodImpl(Inline)]
            get => Bits.width(in data);
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
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public readonly bool Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => !Empty;
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public readonly Bit Dot(BitVector64 rhs)
            => mod<N2>(Bits.pop(data & rhs.data));              

        /// <summary>
        /// Selects an index-identified byte where index = 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];

        /// <summary>
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector64 ShiftL(byte offset)
        {
            data <<= offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector64 ShiftR(byte offset)
        {
            data >>= offset;
            return this;
        }

        /// <summary>
        /// Applies in-place rightward bit rotation by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 RotR(byte offset)
            => Bits.rotr(ref data, offset);

        /// <summary>
        /// Applies in-place leftward bit rotation by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 RotL(byte offset)
            => Bits.rotl(ref data, offset);

        /// <summary>
        /// Enables a bit in-place
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit in-place
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector64 Inc()
        {
            ++data;
            return this;
        }

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector64 Dec()
        {
            --data;
            return this;
        }

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()
            => data = Bits.rev(data);

        /// <summary>
        /// Computes the vector src = src & ~ rhs in-place
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector64 AndNot(in BitVector64 rhs)
        {
            data = Bits.andn((ulong)this, (ulong)rhs);            
            return this;
        }

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public void Permute(Perm spec)
            => data = Bits.scatter(data,Mask(spec));

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly bool Test(BitPos pos)
            => BitMask.test(in data, pos);

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(BitPos pos)
            => Test(pos);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Msb(int n)                
            => Between(LastPos - n, LastPos);                
        
        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(data);
        
        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Ntz()
            => Bits.ntz(data);

        /// <summary>
        /// Counts the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public readonly uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Extract(BitMask64 spec)
            => Bits.gather(in data, spec);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Extract(ulong spec)
            => Bits.gather(in data, spec);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector32 Extract(BitMask32 spec)
            => (uint)Bits.gather(in data, (uint)spec);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector16 Extract(BitMask16 spec)        
            => (ushort)Bits.gather(in data, (ushort)spec);
        
        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 Extract(BitMask8 spec)
            => (byte)Bits.gather(in data, (byte)spec);

        /// <summary>
        /// Tests whether all bits are on
        /// </summary>
        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (UInt64.MaxValue & data) == UInt64.MaxValue;
        
        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public readonly ulong Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }
            
        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 ToBitVector8()
            => BitVector8.FromScalar(data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Applies the identity conversion Bv64 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(data);

        /// <summary>
        /// Applies a widening conversion Bv64 -> Bv128
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector128 ToBitVector128()
            => BitVector128.FromScalar(data);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector64 Replicate()
            => new BitVector64(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public readonly string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector64 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => obj is BitVector64 x && Equals(x); 
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();
 
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

    }
}