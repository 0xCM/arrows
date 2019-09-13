//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;    
    using static Bits;

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct BitVector8 : IFixedBits<BitVector8,byte>
    {
        [FieldOffset(0)]
        BitVector4 bv4;

        [FieldOffset(0)]
        byte data;

        public static readonly BitVector8 Zero = 0;

        public static readonly BitVector8 One = 1;

        public static readonly BitVector8 Ones = byte.MinValue;
        
        public static readonly BitSize BitSize = 8;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;
        
        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        public static BitVector8 Alloc()
            => new BitVector8();

        /// <summary>
        /// Creates a permutation-defined mask
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static BitVector8 Mask(Perm spec)
        {
            var mask = Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return mask;
        }

        [MethodImpl(Inline)]
        public static BitVector8 Parse(string src)
            =>  FromBitString(BitString.Parse(src));

        /// <summary>
        /// Creates a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(int src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(uint src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromScalar(ulong src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 FromBitString(in BitString src)
            => src.TakeUInt8();    

        /// <summary>
        /// Enumerates each and every 8-bit bitvector exactly once
        /// </summary>
        public static IEnumerable<BitVector8> All
        {
           get
           {
                var bv = BitVector8.Zero;
                do            
                    yield return bv;            
                while(++bv);
           }
        }
         
        [MethodImpl(Inline)]
        public static implicit operator BitVector<N8,byte>(in BitVector8 src)
            => new BitVector<N8,byte>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector8(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Converts the source vector to the underlying value it represents
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(BitVector8 src)
            => src.ToBitVector16();

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector8 src)
            => src.ToBitVector32();

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector8 src)
            => src.ToBitVector64();

        /// <summary>
        /// Computes the XOR of the source operands. 
        /// Note that this operator is equivalent to the addition operator (+)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ^(BitVector8 lhs, BitVector8 rhs)
            => (byte)(lhs.data ^ rhs.data);

        /// <summary>
        /// Raises a vector b to a power n where n >= 0
        /// </summary>
        /// <param name="b">The base vector</param>
        /// <param name="n">The power</param>
        [MethodImpl(Inline)]        
        public static BitVector8 operator ^(BitVector8 b, int n)
            => b.Pow(n);
            
        /// <summary>
        /// Computes the component-wise AND of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator &(BitVector8 lhs, BitVector8 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator |(BitVector8 lhs, BitVector8 rhs)
            => (byte)(lhs.data | rhs.data);

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
        /// Computes the bitwise complement of the operand. 
        /// Note that this operator is closely related to the negation operator (-)
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ~(BitVector8 src)
            => (byte) ~ src.data;

        /// <summary>
        /// Computes the component-wise sum of the source operands. 
        /// Note that this operator is equivalent to the XOR operator (^)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator +(BitVector8 lhs, BitVector8 rhs)
            => lhs ^ rhs;

        /// <summary>
        /// Computes the product of the operands. 
        /// Note that this operator is equivalent to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator *(BitVector8 lhs, BitVector8 rhs)
            => Gf256.mul(lhs,rhs);

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator -(in BitVector8 src)
            => (byte)(~src.data + 1);

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
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector8 lhs, BitVector8 rhs)
            => lhs.Dot(rhs);

        [MethodImpl(Inline)]
        public static BitVector8 operator ++(BitVector8 src)
        {
             ref var dst = ref As.asRef(in src);
             dst.data = (byte)(dst.data + (byte)1);
             return dst;
        }

        [MethodImpl(Inline)]
        public static BitVector8 operator --(in BitVector8 src)
        {
             ref var dst = ref As.asRef(in src);
             dst.data = (byte)(dst.data - (byte)1);
             return dst;
        }

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector8 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector8 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector8 lhs, BitVector8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector8 lhs, BitVector8 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static Bit operator <(BitVector8 lhs, BitVector8 rhs)
            => lhs.data < rhs.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public static Bit operator >(BitVector8 lhs, BitVector8 rhs)
            => lhs.data > rhs.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public static Bit operator <=(BitVector8 lhs, BitVector8 rhs)
            => lhs.data <= rhs.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public static Bit operator >=(BitVector8 lhs, BitVector8 rhs)
            => lhs.data >= rhs.data ? Bit.On : Bit.Off;

        [MethodImpl(Inline)]
        public BitVector8(byte src)
            : this()
            => this.data = src;        

        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos,value);
        }

        /// <summary>
        /// The vector's 4 least significant bits
        /// </summary>
        public BitVector4 Lo
        {
            [MethodImpl(Inline)]
            get => bv4;
            
            [MethodImpl(Inline)]
            set => bv4 = value;
        }

        /// <summary>
        /// The vector's 4 most significant bits
        /// </summary>
        public readonly BitVector4 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        

        }        

        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        [MethodImpl(Inline)]
        public ref byte Byte(int index)
            => ref Bytes[0];

        [MethodImpl(Inline)]
        public static ref byte AsBytes(ref BitVector8 src)
            => ref src.data;

        public BitVector8 this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector8 this[BitPos first, BitPos last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }

        /// <summary>
        /// Specifies the parity of the vector: 1 if the population count is odd, otherwise 0
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Parity_function</remarks>
        public Bit Parity
        {
            [MethodImpl(Inline)]
            get => odd(Pop());
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public BitVector8 Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

        /// <summary>
        /// Populates a target vector with mask-identified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public BitVector8 Gather(BitVector8 spec)
            => Bits.gather(in data, spec);

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
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

        /// <summary>
        /// The maximum number of bits that can be represented
        /// </summary>
        public readonly BitSize Capacity
        {
            [MethodImpl]
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
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Disables the high bits that follow a specified bit
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void DisableAfter(BitPos pos)
            => Bits.trunc(ref data, ++pos);

        /// <summary>
        /// Sets a bit value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

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
        /// Shifts the bits in the vector leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector8 Sll(uint offset)
        {
            data <<= (int)offset;
            return this;
        }

        /// <summary>
        /// Shifts the bits in the vector rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector8 Srl(uint offset)
        {
            data >>= (int)offset;
            return this;
        }

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 Ror(uint offset)
            => Bits.rotr(ref data, (byte)offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector8 Rol(uint offset)
            => Bits.rotl(ref data, (byte)offset);

        /// <summary>
        /// Counts the number of enabled bits in the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

        /// <summary>
        /// Counts the number of trailing zero bits
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
        public uint Rank(BitPos pos)
            => Bits.rank(data,pos);

        /// <summary>
        /// Raises the vector to a power
        /// </summary>
        /// <param name="n">The power</param>
        public BitVector8 Pow(int n)
        {
            if(n == 0)                
                return Zero;
            else if(n==1)
                return this;
            else
            {                
                var dst = Replicate();
                for(var i=2; i<=n; i++)
                    dst *= this;
                return dst;
            }
        }

        /// <summary>
        /// Computes the smallest integer n > 1 such that v^n = identity
        /// </summary>
        public int Order()
        {
            var dst = Replicate();
            for(var i=2; i<256; i++)
            {
                dst *= this;
                if(dst == One)
                    return i;

            }
            return 0;
        }

        [MethodImpl(Inline)]
        BitVector8 Mul(in BitVector8 rhs)
        {
            Gf256.mul(data, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public BitVector8 AndNot(in BitVector8 rhs)
            => Bits.andn((byte)this, (byte)rhs);

        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (0xFF & data) == 0xFF;


        [MethodImpl(Inline)]
        public readonly BitString ToBitString(int? maxlen = null)
            => maxlen == null ? data.ToBitString() : data.ToBitString().Truncate(maxlen.Value);

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

        /// <summary>
        /// Reverses the vector's bits
        /// </summary>
        [MethodImpl(Inline)]
        public void Reverse()        
            => data = Bits.rev(data);

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public void Permute(Perm spec)
        {
            var src = Replicate();
            for(var i=0; i<Length; i++)
                this[i] = src[spec[i]];
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
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 Replicate()
            => new BitVector8(data);

        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public BitVector8 Replicate(Perm p)
        {
            var dst = Replicate();
            dst.Permute(p);
            return dst;
        }

        /// <summary>
        /// Creates a new vector via concatenation
        /// </summary>
        /// <param name="tail">The lower bits of the new vector</param>
        [MethodImpl(Inline)]
        public BitVector16 Concat(BitVector8 tail)
            => BitVector16.FromScalars(tail.data, data);

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public byte Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Returns the vector's bitstring representation
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        /// <summary>
        /// Converts the source to a 32-bit vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector16()
            => BitVector16.FromScalar(data);

        /// <summary>
        /// Converts the source to a 32-bit vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector32 ToBitVector32()
            => BitVector32.FromScalar(data);

        /// <summary>
        /// Converts the source to a 64-bit vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector64 ToBitVector64()
            => BitVector64.FromScalar(data);

         /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
       [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector8 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => obj is BitVector8 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => Format();   
    
    }
}