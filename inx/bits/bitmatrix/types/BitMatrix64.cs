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
    /// Defines a 64x64 matrix of bits
    /// </summary>
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
        public static BitMatrix64 Alloc()        
            => Define(new ulong[N]);

        [MethodImpl(Inline)]
        public static BitMatrix64 Define(params ulong[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix64(src);

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
        public static BitMatrix64 operator + (BitMatrix64 lhs, BitMatrix64 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator * (BitMatrix64 lhs, BitMatrix64 rhs)
            => Mul(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator & (BitMatrix64 lhs, BitMatrix64 rhs)
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator - (BitMatrix64 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator | (BitMatrix64 lhs, BitMatrix64 rhs)
            => Or(ref lhs,rhs);


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

        /// <summary>
        /// Specifies the number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Specifies the number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Creates a bitvector from the content of an index-identified row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 RowVector(int row)
            => bits[row];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref ulong RowData(int row)
            => ref bits[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref ulong this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 64
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => bits.Swap(i,j);

        /// <summary>
        /// Returns the data for an index-identified column
        /// </summary>
        public readonly ulong ColData(int index)
        {
            ulong col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in bits[r], index, ref col, r);
            return  col;
        }
        
        /// <summary>
        /// Creates a bitvector from the content of an index-identified column
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 ColVector(int col)
            =>  ColData(col);

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public readonly Span<Bit> Unpack()
            => bits.Unpack(out Span<Bit> dst);

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

        [MethodImpl(Inline)]
        public BitMatrix64 Compare(BitMatrix64 rhs)
            => this.AndNot(rhs);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        public bool IsZero()
        {
            const int rowstep = 4;
            for(var i=0; i< RowCount; i += rowstep)
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
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.AndNot(vRhs, ref bits[i]);                
            }
            return this;
        }

        public readonly BitMatrix64 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.bits[i] = ColData(i);
            return dst;
        }

        [MethodImpl(Inline)] 
        public readonly BitMatrix64 Replicate()
            => Define(bits.ReadOnly()); 

        static ref BitMatrix64 And(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowCount; i += rowstep)
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
            for(var i=0; i< lhs.RowCount; i += rowstep)
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
            for(var i=0; i< src.RowCount; i += rowstep)
            {
                src.LoadVector(out Vec256<ulong> vSrc, i);
                vSrc.Flip(ref src.bits[i]);
            }
            return ref src;
        }

        static ref BitMatrix64 Or(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.Or(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }
        
        static ref BitMatrix64 Mul(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            var x = lhs;
            var y = rhs.Transpose();
            ref var dst = ref lhs;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< N; j++)
                {
                    var c = y.RowVector(j);
                    z[j] = r % c;
                }
                dst[i] = z;
            }
            return ref dst;
        }

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}