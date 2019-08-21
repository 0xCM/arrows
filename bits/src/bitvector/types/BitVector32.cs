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

    /// <summary>
    /// Defines a 32-bit bitvector
    /// </summary>
    public struct BitVector32 : IBitVector<uint>
    {
        uint data;

        public static readonly BitVector32 Zero = default;
        
        public static readonly BitSize BitSize = 32;

        public static readonly BitPos FirstPos = 0;

        public static readonly BitPos LastPos = BitSize - 1;

        /// <summary>
        /// Allocates a zero-filled vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 Alloc()
            => new BitVector32(0);

        /// <summary>
        /// Loads a vector from the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromScalar(in uint src)
            => new BitVector32(src);    

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 FromBitString(in BitString src)
            => new BitVector32(src.TakeUInt32());    

        [MethodImpl(Inline)]
        public static BitVector32 Load(in ReadOnlySpan<byte> src, int offset = 0)
            => FromParts(src[offset + 0], src[offset + 1], src[offset + 2], src[offset + 3]);
    
        [MethodImpl(Inline)]
        public static BitVector32 Load(in ReadOnlySpan<Bit> src)
            => FromScalar(in Bits.pack(src, out uint data));

        [MethodImpl(Inline)]
        public static BitVector32 FromBits(params Bit[] src)
            => new BitVector32(src);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32,uint>(in BitVector32 src)
            => new BitVector<N32,uint>(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(uint src)
            => new BitVector32(src);

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector32 src)
            => BitVector64.FromScalar(src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector32 src)
            => BitVector8.FromScalar((byte)src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector32 src)
            => BitVector16.FromScalar((ushort)src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint(in BitVector32 src)
            => src.data;        

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ^(BitVector32 lhs, BitVector32 rhs)
            => lhs.data ^ rhs.data;

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator &(BitVector32 lhs, BitVector32 rhs)
            => lhs.data & rhs.data;

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(BitVector32 lhs, BitVector32 rhs)
            => Mod<N2>.mod(Bits.pop(lhs.data & rhs.data));

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator |(BitVector32 lhs, BitVector32 rhs)
            => lhs.data | rhs.data;

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ~(BitVector32 src)
            => ~src.data;

        /// <summary>
        /// Computes the sum of the source operands
        /// Note that the addition operator is equivalent to the (^) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator +(BitVector32 lhs, BitVector32 rhs)
            => lhs ^ rhs;

        /// <summary>
        /// Computes the product of the operands. 
        /// Note that this operator is equivalent to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator *(BitVector32 lhs, BitVector32 rhs)
            => lhs & rhs;

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
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator -(BitVector32 src)
            => ~src.data + 1u;

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

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector32 lhs, in BitVector32 rhs)
            => !lhs.Equals(rhs);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector32(uint src)
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
        public Bit this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => TestBit(pos);
            
            [MethodImpl(Inline)]
            set => SetBit(pos, value);
       }

        public uint this[Range range]
        {
            [MethodImpl(Inline)]
            get => Between(range.Start.Value, range.End.Value);
        }

        public BitVector16 Hi
        {
            [MethodImpl(Inline)]
            get => Bits.hi(data);        
        }
        
        public BitVector16 Lo
        {
            [MethodImpl(Inline)]
            get => Bits.lo(data);    
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
        /// The number of bits represented by the vector
        /// </summary>
        public BitSize Length
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        /// <summary>
        /// Sets a bit to a specified value
        /// </summary>
        /// <param name="pos">The position of the bit to set</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void SetBit(BitPos pos, Bit value)
            => BitMask.set(ref data, pos, value);

        [MethodImpl(Inline)]
        public uint Between(BitPos first, BitPos last)
            => Bits.between(in data, first,last);

        [MethodImpl(Inline)]
        public void EnableBit(BitPos pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(BitPos pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public bool TestBit(BitPos pos)
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
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public BitVector32 Lsb(int n)                
            => Between(0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public BitVector32 Msb(int n)                
            => Between(LastPos - n, LastPos);                

        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector32 RotR(BitSize offset)
            => Bits.rotr(ref data, offset);

        /// <summary>
        /// Rotates bits in the source leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public BitVector32 RotL(BitSize offset)
            => Bits.rotl(ref data, offset);

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
        public bool Equals(BitVector32 rhs)
            => data == rhs.data;

        public override bool Equals(object obj)
            => obj is BitVector32 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => Format();
 

        [MethodImpl(Inline)]
        static BitVector32 FromParts(in byte x0, in byte x1, in byte x2, in byte x3)
            => BitConverter.ToUInt32(array(x0, x1, x2, x3), 0);

        [MethodImpl(Inline)]
        Bit DotRef(BitVector32 rhs)
        {
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;
        }

    }
}