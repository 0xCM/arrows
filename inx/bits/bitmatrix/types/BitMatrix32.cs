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

    /// <summary>
    /// Defines a 32x32 matrix of bits
    /// </summary>
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
        public static BitMatrix32 Alloc()        
            => Define(new uint[N]);


        [MethodImpl(Inline)]
        public static BitMatrix32 Define(params uint[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix32(src);

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
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix32 lhs, BitMatrix32 rhs)
            => !(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public static BitMatrix32 operator + (BitMatrix32 lhs, BitMatrix32 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator * (BitMatrix32 lhs, BitMatrix32 rhs)
            => Mul(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator & (BitMatrix32 lhs, BitMatrix32 rhs)
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (BitMatrix32 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator | (BitMatrix32 lhs, BitMatrix32 rhs)
            => Or(ref lhs, rhs);

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
            get => BitMask.test(in bits[row], col);

            [MethodImpl(Inline)]
            set => BitMask.set(ref bits[row], (byte)col, value);
        }            

        public BitVector32 Diagonal()
        {
            var dst = (uint)0;
            for(byte i=0; i < BitMatrix32.N; i++)
                if(this[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        [MethodImpl(Inline)] 
        public BitMatrix32 Replicate()
            => Define(bits.ReadOnly()); 

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<Bit> Unpack()
            => bits.Unpack(out Span<Bit> dst);

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }
 
        [MethodImpl(Inline)]
        public BitVector32 RowVector(int index)
            => bits[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref uint RowData(int row)
            => ref bits[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref uint this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => bits.Swap(i,j);


        public uint ColData(int index)
        {
            uint col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in bits[r], index, ref col, r);
            return col;

        }
        
        [MethodImpl(Inline)]
        public BitVector32 ColVector(int index)
            => ColData(index);

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => bits.AsBytes();

        [MethodImpl(Inline)]
        public bool Equals(in BitMatrix32 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public bool IsZero()
        {
            const int rowstep = 8;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadVector(out Vec256<uint> vSrc, i);
                if(!vSrc.TestZ(vSrc))
                    return false;
            }
            return true;
        }

        public BitMatrix32 AndNot(in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.AndNot(vRhs, ref bits[i]);                
            }
            return this;
        }

        public BitMatrix32 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.bits[i] = ColData(i);
            return dst;
        }

        static ref BitMatrix32 And(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.And(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix32 Or(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.Or(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix32 XOr(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.XOr(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix32 Flip(ref BitMatrix32 src)
        {
            const int rowstep = 8;
            for(var i=0; i< src.RowCount; i += rowstep)
            {
                src.LoadVector(out Vec256<uint> vSrc, i);
                vSrc.Flip(ref src.bits[i]);
            }
            return ref src;
        }

        static ref BitMatrix32 Mul(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            var x = lhs.Replicate();
            var y = rhs.Transpose();

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                for(var j = 0; j< N; j++)
                    lhs[i,j] = y.RowVector(j).Dot(r);
            }
            return ref lhs;

        }

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}