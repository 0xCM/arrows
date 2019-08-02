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

        public static BitMatrix8 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity8x8);
        }

        public static BitMatrix8 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(new byte[N]);
        }        

        [MethodImpl(Inline)]
        public static BitMatrix8 Define(ulong src)        
            => new BitMatrix8(BitConverter.GetBytes(src));

        [MethodImpl(Inline)]
        public static BitMatrix8 Define(params byte[] src)        
            => src.Length == 0 ? Zero : new BitMatrix8(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 Define(Span<byte> src)        
            => new BitMatrix8(src);

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