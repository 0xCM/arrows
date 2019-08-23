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

    public struct BitVector8 : IBitVector<byte>
    {
        byte data;
        
        public static readonly BitVector8 Zero = 0;

        public static readonly BitVector8 One = 1;

        public static readonly BitVector8 Max = 0xFF;
        
        public static readonly BitSize BitSize = 8;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        public static BitVector8 Alloc()
            => new BitVector8();

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


        /// <summary>
        /// Enumerates each and every 8-bit bitvector exactly once
        /// </summary>
        /// <value></value>
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
            => src.Expand();

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector8 src)
            => BitVector32.FromScalar(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector8 src)
            => BitVector64.FromScalar(src.data);

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
        /// Constructs a new bitvector from a specified segment
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        [MethodImpl(Inline)]
        public BitVector8 Between(BitPos first, BitPos last)
            => Bits.between(in data, first, last);

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
        /// Enables a bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void EnableBit(BitPos pos)
            => BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void DisableBit(BitPos pos)
            => BitMask.disable(ref data, pos);

        /// <summary>
        /// Determines whether a bit is enabled
        /// </summary>
        /// <param name="pos">The position of the bit to check</param>
        [MethodImpl(Inline)]
        public readonly bool TestBit(BitPos pos)
            => BitMask.test(in data, pos);

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

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
            => Bits.nlz(data);

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
            => Bits.andnot((byte)this, (byte)rhs);

        [MethodImpl(Inline)]
        public readonly bool AllOnes()
            => (0xFF & data) == 0xFF;

        /// <summary>
        /// Zero-extends the vector to a vector that accomondates
        /// the next power of 2
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 Expand()
            => BitVector16.FromScalar(data);

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
            get => !Empty;
        }

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector8 Replicate()
            => new BitVector8(data);

        [MethodImpl(Inline)]
        public BitVector16 Concat(BitVector8 tail)
            => BitVector16.FromScalars(tail.data, data);

        /// <summary>
        /// Extracts the scalar value enclosed by the vector
        /// </summary>
        [MethodImpl(Inline)]
        public byte ToScalar()
            => data;

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