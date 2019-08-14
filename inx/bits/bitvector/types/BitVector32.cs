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

    public ref struct BitVector32
    {
        uint data;

        public const int ByteSize = 4;

        public const int BitSize = ByteSize * 8;

        /// <summary>
        /// Creates the canonical zero bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 Zero() 
            => new BitVector32(0u);

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 Alloc()
            => new BitVector32(0);

        [MethodImpl(Inline)]
        public static BitVector32 Load(in ReadOnlySpan<byte> src, int offset = 0)
            => FromParts(src[offset + 0], src[offset + 1], src[offset + 2], src[offset + 3]);
    
        [MethodImpl(Inline)]
        public static BitVector32 Load(in ReadOnlySpan<Bit> src)
            => Load(in pack(src, out uint data));


        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32,uint>(in BitVector32 src)
            => new BitVector<N32,uint>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(uint src)
            => new BitVector32(src);

        /// <summary>
        /// Loads a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 Load(in uint src)
            => new BitVector32(src);    

        [MethodImpl(Inline)]
        public static explicit operator uint(in BitVector32 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitVector32 operator +(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.data ^ rhs.data;

        /// <summary>
        /// Subtracts the second operand from the first. Note that this operator is equivalent to
        /// the composite operation of applying the XOR operator to the left operand and the
        /// complement of the second
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator - (BitVector32 lhs, BitVector32 rhs)
            => lhs + -rhs;

        /// <summary>
        /// Computes the product of the operands. Note that this operator is equivalent 
        /// to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator *(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.data & rhs.data;

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator -(in BitVector32 src)
            => ~src.data;

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator <<(BitVector32 lhs, int offset)
            => lhs.data << offset;

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator >>(BitVector32 lhs, int offset)
            => lhs.data >> offset;

        /// <summary>
        /// Computes the bitwise complement of the operand. Note that this operator
        /// is equivalent to the negation operator (-)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ~(in BitVector32 src)
            => ~src.data;

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector32(in uint src)
            => this.data = src;

        /// <summary>
        /// Initializes a vector with a sequence of bit values that is clamped to 32 bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector32(in Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(32, src.Length); i++)
                if(src[i])
                    BitMask.enable(ref data, i);
        }

        /// <summary>
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in data, pos);
            
            [MethodImpl(Inline)]
            set => BitMask.set(ref data, pos, value);
       }

        [MethodImpl(Inline)]
        public uint Extract(int first, int last)
        {
            var len = (byte)(last - first + 1);
            return Bits.extract(in data, (byte)first, len);
        }

        public uint this[Range range]
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
        /// The number of bits represented by the vector
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        /// <summary>
        /// Computes the scalar product of the source vector and another
        /// </summary>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public Bit Dot(BitVector32 rhs)
        {
             return Mod<N2>.mod((uint)Bits.pop(data & rhs.data));               
            // var result = Bit.Off;
            // for(var i=0; i<Length; i++)
            //     result ^= this[i] & rhs[i];
            // return result;

        }

        [MethodImpl(Inline)]
        public void EnableBit(byte pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => BitMask.test(in data, pos);


        public BitVector16 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }
        
        public BitVector16 Lo
        {
            [MethodImpl(Inline)]
            get => lo(data);    
        }

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector32 RotR(uint offset)
            => Bits.rotr(ref data, offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector32 RotL(uint offset)
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
        public BitVector32 AndNot(in BitVector32 rhs)
            => Bits.andnot((uint)this, (uint)rhs);

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt32.MaxValue & data) == UInt32.MaxValue;

        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;


        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        [MethodImpl(Inline)]
        public bool Eq(in BitVector32 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector32 rhs)
            => data != rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        [MethodImpl(Inline)]
        static BitVector32 FromParts(in byte x0, in byte x1, in byte x2, in byte x3)
            => BitConverter.ToUInt32(array(x0, x1, x2, x3), 0);

    }
}