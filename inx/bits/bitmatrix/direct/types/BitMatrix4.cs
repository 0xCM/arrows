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

    public ref struct BitMatrix4
    {        
        internal Span<byte> bits;

        public static readonly N4 N = default;

        public static BitMatrix4 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity4x4);
        }

        public static BitMatrix4 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(0,0);
        }

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(params byte[] src)        
            => src.Length == 0 ? new BitMatrix4(0,0)  : new BitMatrix4(src);

        public static BitMatrix4 Define(ushort src)
            => Define(BitConverter.GetBytes(src));

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(Span<byte> src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static explicit operator ushort(BitMatrix4 src)
            => BitConverter.ToUInt16(src.bits);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix4(ushort src)
            => Define(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix4 lhs, BitMatrix4 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix4 lhs, BitMatrix4 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator & (BitMatrix4 lhs, BitMatrix4 rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator | (BitMatrix4 lhs, BitMatrix4 rhs)
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator ^ (BitMatrix4 lhs, BitMatrix4 rhs)
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator ~ (BitMatrix4 src)
            => src.Flip();
            
        [MethodImpl(Inline)]
        BitMatrix4(params byte[] src)
        {                    
            require(src.Length == Pow2.T01);
            this.bits = src;
        }

        [MethodImpl(Inline)]
        BitMatrix4(ReadOnlySpan<byte> src)
        {                    
            require(src.Length == Pow2.T01);
            this.bits = src.Replicate();
        }

        [MethodImpl(Inline)]
        BitMatrix4(Span<byte> src)
        {
            require(src.Length == Pow2.T01);
            this.bits = src;
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => this.GetBit(row,col);

            [MethodImpl(Inline)]
            set => this.SetBit(row,col,value);
        }            
 
         [MethodImpl(Inline)]
        public bool Eq(in BitMatrix4 rhs)
            => BitConverter.ToUInt16(bits) == BitConverter.ToUInt16(rhs.bits);

        [MethodImpl(Inline)]
        public bool NEq(in BitMatrix4 rhs)
            => BitConverter.ToUInt16(bits) != BitConverter.ToUInt16(rhs.bits);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}