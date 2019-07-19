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

    public ref struct BitMatrix16
    {   
        public const uint Size = 256;
        
        public const uint RowSize = 16;        

        internal Span<ushort> bits;

        public static readonly N16 N = default;
        

        public static BitMatrix16 Identity 
        {
            [MethodImpl(Inline)]
            get => BitMatrix16.Define(BitMatrixStore.Identity16x16);
        }

        public static BitMatrix16 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(new ushort[N]);
        }
        
        [MethodImpl(Inline)]
        public static BitMatrix16 Define(params ushort[] src)        
            => src.Length == 0 ? Zero : new BitMatrix16(src);


        [MethodImpl(Inline)]
        public static BitMatrix16 Define(Span<ushort> src)        
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix16(src.As<byte,ushort>());

        [MethodImpl(Inline)]
        public static BitMatrix16 Define(ReadOnlySpan<ushort> src)        
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator & (BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator | (BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ^ (BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ~ (BitMatrix16 src)
            => src.Flip();

        [MethodImpl(Inline)]
        BitMatrix16(Span<ushort> src)
        {                        
            require(src.Length == Pow2.T04);
            this.bits = src;
        }

        [MethodImpl(Inline)]
        BitMatrix16(ReadOnlySpan<ushort> src)
        {                        
            require(src.Length == Pow2.T04);
            this.bits = src.Replicate();
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => this.GetBit(row,col);

            [MethodImpl(Inline)]
            set => this.SetBit(row,col,value);
        }            

        public int RowDim
            => N;

        public int ColDim
            => N;

        [MethodImpl(Inline)]
        public BitVector16 Row(int index)
            => bits[index];

        [MethodImpl(Inline)]
        public bool Eq(in BitMatrix16 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public bool NEq(in BitMatrix16 rhs)
            => !this.AndNot(rhs).IsZero();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
   }
}