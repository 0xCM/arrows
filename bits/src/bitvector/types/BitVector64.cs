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

    public ref struct BitVector64
    {
        ulong data;

        public const int ByteSize = 8;

        public const int BitSize = 8*ByteSize;

        [MethodImpl(Inline)]
        public static BitVector64 Alloc()
            => new BitVector64(0);

        /// <summary>
        /// Loads a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 Load(ulong src)
            => new BitVector64(src);    

        [MethodImpl(Inline)]
        public static BitVector64 Load(in ReadOnlySpan<Bit> src)
            => Load(pack(src, out ulong data));

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N64,ulong>(in BitVector64 src)
            => new BitVector<N64,ulong>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(in ulong src)
            => new BitVector64(src);

        [MethodImpl(Inline)]
        public static explicit operator ulong(in BitVector64 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static BitVector64 operator +(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.data ^ rhs.data;

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator -(in BitVector64 src)
            => ~src.data;

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
        /// Computes the product of the operands. Note that this operator is equivalent 
        /// to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator *(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.data & rhs.data;

        /// <summary>
        /// Computes the XOR of the source operands. Note that this operator is equivalent 
        /// to the addition operator (+)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ^(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.data ^ rhs.data;

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

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ~(in BitVector64 src)
            => ~src.data;

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.Dot(rhs);

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
        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(pos);
            
            [MethodImpl(Inline)]
            set => SetBit(pos,value);
       }


        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public Bit Dot(BitVector64 rhs)
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

        [MethodImpl(Inline)]
        public bool TestBit(int pos)
            => BitMask.test(in data, pos);

        public BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => (uint)hi(data);        
        }
        
        public BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => (uint)lo(data);    
        }

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);
        
        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 RotR(uint offset)
            => Bits.rotr(ref data, offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector64 RotL(uint offset)
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
        public ulong Extract(int first, int last)
        {
            var len = (byte)(last - first + 1);
            return Bits.extract(in data, (byte)first, len);
        }

        public ulong this[Range range]
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

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}