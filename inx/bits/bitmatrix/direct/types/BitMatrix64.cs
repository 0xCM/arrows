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

    public ref struct BitMatrix64
    {                
        public const uint Size = 4096;
        
        public const uint RowSize = 64;
        

        internal Span<ulong> bits;

        public static readonly N64 N = default;

        public static BitMatrix64 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity64x64);
        }

        public static BitMatrix64 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(new ulong[N]);
        }
        
        [MethodImpl(Inline)]
        public static BitMatrix64 Define(params ulong[] src)        
            => src.Length == 0 ? Zero : new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix64(src.As<byte,ulong>());

        [MethodImpl(Inline)]
        public static BitMatrix64 Define(Span<ulong> src)        
            => new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 Define(ReadOnlySpan<ulong> src)        
            => new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator & (BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator | (BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ^ (BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ~ (BitMatrix64 src)
            => src.Flip();

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        BitMatrix64(Span<ulong> src)
        {                        
            require(src.Length == Pow2.T06);
            this.bits = src;
        }

        [MethodImpl(Inline)]
        BitMatrix64(ReadOnlySpan<ulong> src)
        {                        
            require(src.Length == Pow2.T06);
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
        public bool Eq(in BitMatrix64 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public bool NEq(in BitMatrix64 rhs)
            => !this.AndNot(rhs).IsZero();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }

}