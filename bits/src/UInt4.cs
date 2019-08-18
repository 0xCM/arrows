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

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct UInt4 : IEquatable<UInt4>
    {
        [FieldOffset(0)]
        byte data;

        const byte MinValue = 0;

        const byte MaxValue = 0xF;

        const byte Modulus = MaxValue + 1;

        const byte BitCount = 4;        

        /// <summary>
        /// Defines a mapping from possible UInt4 values to their hex code representations
        /// </summary>
        static readonly char[] HexMap 
            = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

        static readonly byte[] ReverseMap
            = new byte[]{
                0b0000, 0b1000, 0b0100, 0b1100, 
                0b0010, 0b1010, 0b0110, 0b1110, 
                0b0001, 0b1001, 0b0101, 0b1101, 
                0b0011, 0b1011, 0b0111, 0b1111, 
                };

        /// <summary>
        /// Constructs a <see cref='UInt4'/> from a byte value in the range [0, 15]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        UInt4(byte src)
        {
            require(src <= MaxValue);
            this.data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator byte(UInt4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(UInt4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint(UInt4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(UInt4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator UInt4(byte src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator UInt4(sbyte src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator UInt4(ushort src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator UInt4(uint src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator UInt4(int src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator UInt4(ulong src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static implicit operator UInt4(ReadOnlySpan<Bit> src)
            => FromBitSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator UInt4(Span<Bit> src)
            => FromBitSpan(src);

        /// <summary>
        /// Constructs a <see cref='UInt4'/> from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline)]
        public static UInt4 FromBits(Bit? x0 = null, Bit? x1 = null, Bit? x2 = null, Bit? x3 = null)
        {
            var data = (byte)0;
            if(x0 == 1) data |= (1 << 0);
            if(x1 == 1) data |= (1 << 1);
            if(x2 == 1) data |= (1 << 2);
            if(x3 == 1) data |= (1 << 3);
            return new UInt4(data);
        }

        /// <summary>
        /// Constructs a <see cref='UInt4'/> from a sequence of bits presented in a bitspan
        /// </summary>
        /// <param name="src">The source bits, from lo to high, from which at most 4 will be consumed</param>
        /// <param name="offset">The index in the span at which consumption should begin</param>
        [MethodImpl(Inline)]
        public static UInt4 FromBitSpan(ReadOnlySpan<Bit> src, int offset = 0)
        {
            var available = src.Length - offset;
            if(available <= 0)
                return FromByte(0);

            return FromBits(
                available > 0 ? src[offset + 0] : (Bit?)null,
                available > 1 ? src[offset + 1] : (Bit?)null,
                available > 2 ? src[offset + 2] : (Bit?)null,
                available > 3 ? src[offset + 3] : (Bit?)null);
        }

        [MethodImpl(Inline)]
        public static UInt4 FromBitSeq(ReadOnlySpan<byte> src, int offset = 0)
        {
            var available = src.Length - offset;
            var dst = default(UInt4);
            
            if(available > 0 && src[0] != 0)
                dst.data |= (1 << 0);
            if(available > 1 && src[1] != 0)
                dst.data |= (1 << 1);
            if(available > 2 && src[2] != 0)
                dst.data |= (1 << 2);
            if(available > 3 && src[3] != 0)
                dst.data |= (1 << 3);
            return dst;
        }

        [MethodImpl(Inline)]
        public static UInt4 FromByte(byte src)
            => new UInt4(src);

        [MethodImpl(Inline)]
        public static UInt4 operator + (UInt4 lhs, UInt4 rhs)
        {
            var sum = (byte)(lhs.data + rhs.data);
            return (sum >= Modulus) 
                ? new UInt4((byte)(sum - Modulus))
                : new UInt4(sum);                    
        }

        [MethodImpl(Inline)]
        public static UInt4 operator - (UInt4 lhs, UInt4 rhs)
        {
            var diff = lhs.data - rhs.data;
            return diff < 0 
                ? new UInt4((byte)(diff + Modulus)) 
                : new UInt4((byte)diff);            
        }

        [MethodImpl(Inline)]
        public static UInt4 operator * (UInt4 lhs, UInt4 rhs)
            => FromByte(MulMod16(lhs.data, rhs.data));

        [MethodImpl(Inline)]
        public static bool operator ==(UInt4 lhs, UInt4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in UInt4 lhs, in UInt4 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static UInt4 operator |(UInt4 lhs, UInt4 rhs)
            => FromByte((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static UInt4 operator &(UInt4 lhs, UInt4 rhs)
            => FromByte((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static UInt4 operator ^(UInt4 lhs, UInt4 rhs)
            => FromHi((byte) ((byte)(lhs.data ^ rhs.data) << BitCount));

        [MethodImpl(Inline)]
        public static UInt4 operator >>(UInt4 lhs, int rhs)
            => new UInt4((byte)(lhs.data >> rhs));

        [MethodImpl(Inline)]
        public static UInt4 operator <<(UInt4 lhs, int rhs)
            => new UInt4((byte)(lhs.data << rhs));

        [MethodImpl(Inline)]
        public static UInt4 operator ~(UInt4 src)
            => FromHi((byte)((byte)(~src.data) << BitCount ));

        [MethodImpl(Inline)]
        public static UInt4 operator ++(UInt4 src)
        {
            if(src.data != MaxValue)
                src.data++;
            else
                src.data = MinValue;
            return src;
        }

        [MethodImpl(Inline)]
        public static UInt4 operator --(UInt4 src)
        {
            if(src.data != MinValue)
                src.data--;
            else
                src.data = MaxValue;
            return src;
        }

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(byte src)        
            => new UInt4((byte)(src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(sbyte src)        
            => new UInt4((byte)((byte)src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(short src)        
            => new UInt4((byte)((byte)src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(int src)        
            => new UInt4((byte)((byte)src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(uint src)        
            => new UInt4((byte)((byte)src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(long src)        
            => new UInt4((byte)((byte)src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromLo(ulong src)        
            => new UInt4((byte)((byte)src & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 most significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromHi(byte src)        
            => new UInt4((byte)((src >> 4) & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 most significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromHi(sbyte src)        
            => new UInt4((byte)((src >> 4) & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 most significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromHi(short src)        
            => new UInt4((byte)((src >> 12) & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 most significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromHi(int src)        
            => new UInt4((byte)((src >> 28) & MaxValue));

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 most significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 FromHi(long src)        
            => new UInt4((byte)((src >> 60) & MaxValue));

        [MethodImpl(Inline)]
        public bool AllOnes()
            => data == MaxValue;
 
        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == MinValue;

        /// <summary>
        /// Returns true if an index-identified bit is enabled; false otherwise
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => pos < BitCount ? BitMask.test(in data, pos) : false;

        [MethodImpl(Inline)]
        public static UInt4 Mul(UInt4 lhs, UInt4 rhs)
            => UInt4.FromByte(MulMod16(lhs,rhs));

        [MethodImpl(Inline)]
        UInt4 RotL(byte offset)
            => (this << offset) | (this >> BitCount - offset);

        /// <summary>
        /// Multiplies the current value by a source value
        /// </summary>
        /// <param name="rhs">The source value</param>
        [MethodImpl(Inline)]
        public UInt4 MulBy(UInt4 rhs)
        {
            data = MulMod16(data, rhs.data);
            return this;
        }

        /// <summary>
        /// Enables an index-identified bit if its not already enabled
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public void Enable(byte pos)
        {
            if(pos < BitCount)
                data |= (byte)(1 << pos);
        }

        /// <summary>
        /// Disables an index-identified bit if its not already disabled
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
        {
            if(pos < BitCount)
                BitMask.disable(ref data, pos);
        }

        /// <summary>
        /// Specifies the status an index-identified bit
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(byte pos, Bit bit)
        {
            if(pos < BitCount)
                BitMask.set(ref data, pos, bit);
        }

        /// <summary>
        /// Queries and manipulates a bit identified by its 0-based index
        /// </summary>
        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => TestBit((byte)pos);
            
            [MethodImpl(Inline)]
            set => SetBit((byte)pos, value);
        }


        /// <summary>
        /// Queries and manipulates the lower two bits
        /// </summary>
        public UInt4 Lo
        {
            [MethodImpl]
            get => FromByte(Bits.between(in data,0, 1));
            
            [MethodImpl(Inline)]
            set 
            {
                var src = value.Lo;
                SetBit(0, src[0]);
                SetBit(1, src[1]);

            }
        }

        /// <summary>
        /// Queries and manipulates the upper two bits
        /// </summary>
        public UInt4 Hi
        {
            [MethodImpl]
            get => FromByte(Bits.between(in data,2, 3));

            [MethodImpl]
            set
            {
                var src = value.Lo;
                SetBit(2, src[0]);
                SetBit(3, src[1]);
            }

        }

        /// <summary>
        /// Renders the value as as hexadecimal string
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => HexMap[data].ToString();

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromBitSeq(gbits.bitseq(data).Slice(0,BitCount));

        [MethodImpl(Inline)]
        public bool Equals(UInt4 rhs)
            => data == rhs.data;


        public override bool Equals(object rhs)
            => rhs is UInt4 x ? Equals(x) : false;
       
        public override int GetHashCode()
            => data;

        /// <summary>
        /// Multiplies two bytes modulo 4
        /// </summary>
        /// <param name="lhs">The first byte</param>
        /// <param name="rhs">The second byte</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        static byte MulMod16(byte lhs, byte rhs)
            => (byte)Mod<N16>.mod((uint)(lhs * rhs));

    }

}