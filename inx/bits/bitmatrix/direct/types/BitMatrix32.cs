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

    public ref struct BitMatrix32
    {        
        internal Span<uint> bits;

        public const uint Size = 1024;

        public const uint RowSize = 32;

        public static readonly N32 N = default;

        public static BitMatrix32 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity32x32);
        }

        public static BitMatrix32 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(new uint[N]);
        }
        
        [MethodImpl(Inline)]
        public static BitMatrix32 Define(params uint[] src)        
            => src.Length == 0 ? Zero : new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix32(src.As<byte,uint>());

        [MethodImpl(Inline)]
        public static BitMatrix32 Define(Span<uint> src)        
            => new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 Define(ReadOnlySpan<uint> src)        
            => new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix32 lhs, BitMatrix32 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix32 lhs, BitMatrix32 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        BitMatrix32(Span<uint> src)
        {                        
            require(src.Length == Pow2.T05);
            this.bits = src;
        }

        [MethodImpl(Inline)]
        BitMatrix32(ReadOnlySpan<uint> src)
        {                        
            require(src.Length == Pow2.T05);
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
        public bool Eq(in BitMatrix32 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public bool NEq(in BitMatrix32 rhs)
            => !this.AndNot(rhs).IsZero();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}