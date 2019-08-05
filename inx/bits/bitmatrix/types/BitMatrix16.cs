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
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator | (BitMatrix16 lhs, BitMatrix16 rhs)
            => Or(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ^ (BitMatrix16 lhs, BitMatrix16 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ~ (BitMatrix16 src)
            =>Flip(ref src);

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
            get => BitMask.test(in bits[row], col);

            [MethodImpl(Inline)]
            set => BitMask.set(ref bits[row], (byte)col, value);

        }            

        public int RowDim
            => N;

        public int ColDim
            => N;

        [MethodImpl(Inline)]
        public BitVector16 Row(int index)
            => bits[index];

        [MethodImpl(Inline)]
        public BitMatrix16 AndNot(in BitMatrix16 rhs)
        {
            this.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.AndNot(vRhs, ref bits[0]);
            return this;
        }

        public BitVector16 Diagonal()
        {
            var dst = (ushort)0;
            for(byte i=0; i < BitMatrix16.N; i++)
                if(this[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public BitVector16 Col(int index)
        {
            ushort col = 0;
            for(var r = 0; r < N; r++)
                if(BitMask.test(in bits[r], index))
                    BitMask.enable(ref col, r);
            return col;
        }

        [MethodImpl(Inline)] 
        public BitMatrix16 Replicate()
            => Define(bits.ReadOnly());


        [MethodImpl(Inline)]
        static ref BitMatrix16 And(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.And(vRhs, ref lhs.bits[0]);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 Or(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.Or(vRhs, ref lhs.bits[0]);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 XOr(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.XOr(vRhs, ref lhs.bits[0]);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 Flip(ref BitMatrix16 src)
        {
            src.LoadVector(out Vec256<ushort> vSrc);
            vSrc.Flip(ref src.bits[0]);
            return ref src;
        }

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => bits.AsBytes();

        [MethodImpl(Inline)]
        public bool IsZero()
        {
            this.LoadVector(out Vec256<ushort> vSrc);
            return vSrc.TestZ(vSrc);            
        }

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