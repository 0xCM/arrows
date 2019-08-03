//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;


    public ref struct BitMatrix8
    {        
        internal Span<byte> bits;

        public const uint Size = 64;

        public const uint RowSize = 8;
        
        public static readonly N8 N = default;

        /// <summary>
        /// Creates a copy of the 8x8 identity matrix
        /// </summary>
        public static BitMatrix8 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity8x8);
        }

        /// <summary>
        /// Creates a copy of the 8x8 zero matrix
        /// </summary>
        public static BitMatrix8 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(new byte[N]);
        }        

        /// <summary>
        /// Creates an 8x8 bitmatrix from the 8 bytes of data present in an unsigned long
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Define(ulong src)        
            => new BitMatrix8(BitConverter.GetBytes(src));

        /// <summary>
        /// Creates an 8x8 bitmatrix from 8 bytes
        /// </summary>
        /// <param name="row0">Specifies the bits in row0</param>
        /// <param name="row1">Specifies the bits in row1</param>
        /// <param name="row2">Specifies the bits in row2</param>
        /// <param name="row3">Specifies the bits in row3</param>
        /// <param name="row4">Specifies the bits in row4</param>
        /// <param name="row5">Specifies the bits in row5</param>
        /// <param name="row6">Specifies the bits in row6</param>
        /// <param name="row7">Specifies the bits in row7</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Define(byte row0, byte row1, byte row2, byte row3, byte row4, byte row5, byte row6, byte row7)        
            => new BitMatrix8(new byte[]{row0,row1,row2,row3,row4,row5,row6,row7});

        /// <summary>
        /// Creates an 8x8 bitmatrix from a parameter array which may either be empty
        /// or contain exactly 8 values
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        static BitMatrix8 Define(params byte[] src)        
            => src.Length == 0 ? Zero : new BitMatrix8(src);

        /// <summary>
        /// Creates an 8x8 bitmatrix from a span that contains exactly 8 entries
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Define(Span<byte> src)        
            => new BitMatrix8(src);

        /// <summary>
        /// Creates an 8x8 bitmatrix from a readonly span that contains exactly 8 entries
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix8(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix8 lhs, BitMatrix8 rhs)
            => !(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public static BitMatrix8 operator & (BitMatrix8 lhs, BitMatrix8 rhs)
            => And(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator | (BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ^ (BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ~ (BitMatrix8 src)
            => src.Flip();

        [MethodImpl(Inline)]
        public static explicit operator ulong(BitMatrix8 src)
            => BitConverter.ToUInt64(src.bits);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix8(ulong src)
            => Define(src);

        [MethodImpl(Inline)]
        BitMatrix8(ReadOnlySpan<byte> src)
        {                    
            require(src.Length == Pow2.T03);
            this.bits = src.Replicate();
        }

        [MethodImpl(Inline)]
        BitMatrix8(Span<byte> src)
        {
            require(src.Length == Pow2.T03);
            this.bits = src;
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in bits[row], col);

            [MethodImpl(Inline)]
            set => BitMask.set(ref bits[row], (byte)col, value);
        }            
    
        public int RowDim
            => N;

        public int ColDim
            => N;
 
        [MethodImpl(Inline)]
        public BitVector8 Row(int index)
            => bits[index];

        [MethodImpl(Inline)]
        public bool Equals(in BitMatrix8 rhs)
            => BitConverter.ToUInt64(bits) == BitConverter.ToUInt64(rhs.bits);

        [MethodImpl(Inline)]
        public BitMatrix8 AndNot(in BitMatrix8 rhs)
        {
             bits = ((ulong)this &~ (ulong)rhs).ToBytes();
             return this;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix8 And(ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits =((ulong)lhs & (ulong)rhs).ToBytes();
             return ref lhs;
        }

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => bits;

        [MethodImpl(Inline)]
        public string Format()
            => bits.FormatMatrixBits(8);


        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}