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
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs.NEq(rhs);

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
            get => this.GetBit(row,col);

            [MethodImpl(Inline)]
            set => this.SetBit(row,col,value);
        }            
    
        public int RowDim
            => N;

        public int ColDim
            => N;
 
        [MethodImpl(Inline)]
        public bool Eq(in BitMatrix8 rhs)
            => BitConverter.ToUInt64(bits) == BitConverter.ToUInt64(rhs.bits);

        [MethodImpl(Inline)]
        public bool NEq(in BitMatrix8 rhs)
            => BitConverter.ToUInt64(bits) != BitConverter.ToUInt64(rhs.bits);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}