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

        [MethodImpl(Inline)]
        public BitVector16(in ushort data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N16,ushort>(in BitVector16 src)
            => new BitVector<N16,ushort>(src.data);

        [MethodImpl(Inline)]
        public static BitVector16 Define(in ushort src)
            => new BitVector16(src);    

        [MethodImpl(Inline)]
        public static BitVector16 Define(in ReadOnlySpan<Bit> src)
            => Define(in pack(src, out ushort dst));

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(in ushort src)
            => new BitVector16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(in BitVector16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector16 lhs, in BitVector16 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector16 lhs, in BitVector16 rhs)
            => !lhs.Eq(rhs);


        [MethodImpl(Inline)]
        public static BitVector16 operator +(in BitVector16 lhs, in BitVector16 rhs)
            => Define((ushort)(lhs.data ^ rhs.data));

        /// <summary>
        /// Computes the componentwise AND of the source vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator *(in BitVector16 lhs, in BitVector16 rhs)
            => Define((ushort)(lhs.data & rhs.data));

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Bit operator %(in BitVector16 lhs, in BitVector16 rhs)
            => lhs.Dot(rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ~(in BitVector16 src)
            => Define((ushort) ~ src.data);

        [MethodImpl(Inline)]
        public void EnableBit(byte pos)
            => BitMask.enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
            => BitMask.disable(ref data, pos);

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => BitMask.test(in data, pos);

        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    BitMask.enable(ref data, pos);
                else
                    BitMask.disable(ref data, pos);                    
            }            
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

        public Bit Dot(BitVector16 rhs)
        {
            var result = Bit.Off;
            for(var i=0; i<Length; i++)
                result ^= this[i] & rhs[i];
            return result;

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

        [MethodImpl(Inline)]
        public ulong PopCount()
            => pop(data);

        [MethodImpl(Inline)]
        public ulong Nlz()
            => nlz(data);

        [MethodImpl(Inline)]
        public ulong Ntz()
            => ntz(data);

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