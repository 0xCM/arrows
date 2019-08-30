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

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BitVector128
    {
        [FieldOffset(0)]
        UInt128 data;

        [FieldOffset(0)]
        Vec128<ulong> xmm;

        [FieldOffset(0)]
        ulong x0;

        [FieldOffset(8)]
        ulong x1;

        public static readonly BitVector128 Zero = default;

        public static readonly BitVector128 One = (1,0);

        public static readonly BitSize BitSize = 128;

        public static readonly BitPos LastPos = BitSize - 1;

        /// <summary>
        /// Allocates a new empty vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 Alloc()
            => default;

        /// <summary>
        /// Creates a vector from two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromScalars(ulong lo, ulong hi)
            => new BitVector128(lo,hi);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 FromBitString(in BitString src)
        {
            var x0 = src.TakeUInt64(0);            
            var x1 = src.Length > 64 ? src.TakeUInt64(64) : 0ul;
            return FromScalars(x0, x1);
        }

        [MethodImpl(Inline)]    
        public static implicit operator BitVector128((ulong x0, ulong x1) src)
            => new BitVector128(src.x0, src.x1);

        [MethodImpl(Inline)]    
        public static implicit operator (ulong x0, ulong x1)(BitVector128 src)
            => (src.x0, src.x1);

        /// <summary>
        /// Implicitly converts a cpu vector to a bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(Vec128<ulong> src)
            => new BitVector128(src);

        /// <summary>
        /// Implicitly converts an unsigned 128-bit integer to a bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector128(UInt128 src)
            => new BitVector128(src);

        /// <summary>
        /// Implicitly converts a bitvector to a cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator Vec128<ulong>(BitVector128 src)
            => src.xmm;

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ^(BitVector128 lhs, BitVector128 rhs)
            => lhs.XOr(rhs);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator &(BitVector128 lhs, BitVector128 rhs)
            => lhs.And(rhs);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator |(BitVector128 lhs, BitVector128 rhs)
            => lhs.Or(rhs);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator <<(BitVector128 lhs, int offset)
            => lhs.Sll((byte)offset);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator >>(BitVector128 lhs, int offset)
            => lhs.Srl((byte)offset);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ~(BitVector128 src)
            => src.Flip();

        /// <summary>
        /// Negates the operand via two'2 complement
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator -(BitVector128 src)
            => src.Negate();

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator ++(BitVector128 src)
            => src.Inc();

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector128 operator --(BitVector128 src)
            => src.Dec();

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector128 lhs,BitVector128 rhs)
            => Mod<N2>.mod((lhs & rhs).Pop());              

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector128 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector128 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector128 lhs, in BitVector128 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector128 lhs, in BitVector128 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]    
        public BitVector128(ulong x0, ulong x1)
            : this()
        {
            this.x0 = x0; 
            this.x1 = x1;
        }

        [MethodImpl(Inline)]    
        public BitVector128(Vec128<ulong> src)
            : this()
        {
            this.xmm = src;
        }

        [MethodImpl(Inline)]    
        public BitVector128(UInt128 src)
            : this()
        {
            this.data = src;
        }

        /// <summary>
        /// The vector's 64 least significant bits
        /// </summary>
        public readonly BitVector64 Lo
        {
            [MethodImpl(Inline)]
            get => x0;
        }

        /// <summary>
        /// The vector's 64 most significant bits
        /// </summary>
        public readonly BitVector64 Hi
        {
            [MethodImpl(Inline)]
            get => x1;
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
        /// Computs the bitwise and of the vector and the operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector128 And(BitVector128 rhs)
        {
            xmm = Bits.and(xmm,rhs.xmm);
            return this;
        }

        /// <summary>
        /// Computs the bitwise or of the vector and the operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector128 Or(BitVector128 rhs)
        {
            xmm = Bits.or(xmm, rhs.xmm);
            return this;
        }

        /// <summary>
        /// Computs the bitwise xor of the vector and the operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public BitVector128 XOr(BitVector128 rhs)
        {
            xmm = Bits.xor(xmm,rhs.xmm);
            return this;
        }

        /// <summary>
        /// Negates the vector via two's complement
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector128 Negate()
        {
            xmm = dinx.negate(xmm);
            return this;
        }

        /// <summary>
        /// Applies the bitwise complement
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector128 Flip()
        {
            xmm = Bits.flip(xmm);
            return this;
        }

        /// <summary>
        /// Shifts the vector bits leftwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector128 Sll(byte offset)
        {
            xmm = Bits.sll(xmm,offset);
            return this;
        }

        /// <summary>
        /// Shifts the vector bits rightwards
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public BitVector128 Srl(byte offset)
        {
            xmm = Bits.srl(xmm,offset);
            return this;
        }

        /// <summary>
        /// Applies in-place rightward bit rotation by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector128 RotR(byte offset)
        {
            xmm = Bits.rotr(xmm, offset);
            return this;
        }

        /// <summary>
        /// Applies in-place leftward bit rotation by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector128 RotL(byte offset)
        {
            xmm = Bits.rotl(xmm, offset);
            return this;
        }

        /// <summary>
        /// Counts the number of enabled bits in the source
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop(x0) + Bits.pop(x1);

        /// <summary>
        /// Counts the number of leading zeros
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Nlz()
        {
            if(x1 == 0)
                return 64 + Bits.nlz(x0);
            else
                return Bits.nlz(x1);
        }

        /// <summary>
        /// Counts the number of trailing zeros
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Ntz()
        {
            if(x0 == 0)
                return Bits.ntz(x1) + 64;
            else
                return Bits.ntz(x0);
        }

        /// <summary>
        /// Computes the bitwise and of the vector the complement of the right operand
        /// </summary>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]        
        public BitVector128 AndNot(BitVector128 rhs)
        {
            xmm = Bits.andnot(xmm,rhs);
            return this;
        }

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector128 Inc()
        {
            xmm = ginx.inc(xmm);
            return this;
        }

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public BitVector128 Dec()
        {
            xmm = ginx.dec(xmm);
            return this;
        }

        /// <summary>
        /// Enables a position-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(BitPos pos)
            => xmm = Bits.or(xmm, One << pos);            

        /// <summary>
        /// Disables a position-identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Disable(BitPos pos)
            => xmm = Bits.andnot(xmm, One << pos);                        

        [MethodImpl(Inline)]
        public readonly bool Test(BitPos pos)
            => Bits.and(xmm,One << pos) != Vec128<ulong>.Zero;

        /// <summary>
        /// Reads a bit value
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public readonly Bit Get(BitPos pos)
            => Test(pos);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector128 Replicate()
            => new BitVector128(x0,x1);

        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public readonly string FormatBits(bool tlz = false, bool specifier = false, int? blockWidth = null)
            => ToBitString().Format(tlz, specifier, blockWidth);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector128 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => obj is BitVector64 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => FormatBits();
 
    }
}