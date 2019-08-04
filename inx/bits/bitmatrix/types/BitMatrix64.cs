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
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator | (BitMatrix64 lhs, BitMatrix64 rhs)
            => Or(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ^ (BitMatrix64 lhs, BitMatrix64 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ~ (BitMatrix64 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix64 lhs, BitMatrix64 rhs)
            => !lhs.Equals(rhs);

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
            get => BitMask.test(in bits[row], col);

            [MethodImpl(Inline)]
            set => BitMask.set(ref bits[row], (byte)col, value);
        }            

        public int RowDim
            => N;

        public int ColDim
            => N;

        [MethodImpl(Inline)]
        public BitVector64 Row(int row)
            => bits[row];

        public BitVector64 Col(int col)
        {
            var dst = 0ul;
            for(var row = 0; row < RowDim; row++)
                gbits.set(ref dst, (byte)row, this[row,col]);
            return dst;
        }


        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => bits.AsBytes();

        [MethodImpl(Inline)]
        public bool Equals(in BitMatrix64 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public string Format()
            => MemoryMarshal.AsBytes(bits).FormatMatrixBits(64);

        public bool IsZero()
        {
            const int rowstep = 4;
            for(var i=0; i< RowDim; i += rowstep)
            {
                this.LoadVector(out Vec256<ulong> vSrc, i);
                if(!vSrc.TestZ(vSrc))
                    return false;
            }
            return true;
        }

        public BitVector64 Diagonal()
        {
            var dst = (ulong)0;
            for(byte i=0; i < N; i++)
                if(this[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public BitMatrix64 AndNot(in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< RowDim; i += rowstep)
            {
                this.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.AndNot(vRhs, ref bits[i]);                
            }
            return this;

        }

        [MethodImpl(Inline)] 
        public BitMatrix64 Replicate()
            => Define(bits.ReadOnly()); 

        static ref BitMatrix64 And(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.And(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix64 XOr(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.XOr(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix64 Flip(ref BitMatrix64 src)
        {
            const int rowstep = 4;
            for(var i=0; i< src.RowDim; i += rowstep)
            {
                src.LoadVector(out Vec256<ulong> vSrc, i);
                vSrc.Flip(ref src.bits[i]);
            }
            return ref src;
        }

        static ref BitMatrix64 Or(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.Or(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }
        

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }

}