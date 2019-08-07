//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines bitmatrix of natural dimensions over a primal type
    /// </summary>
    public ref struct BitMatrix<M,N,T>
        where M : ITypeNat, new()        
        where N : ITypeNat, new()
        where T : struct
    {        
        Span<T> bits;

        /// <summary>
        /// Specifies the MxN matrix dimension
        /// </summary>
        static readonly Dim<M,N> Dim = default;

        static readonly BitGridSpec<T> GridSpec = (SizeOf<T>.BitSize, (int)Dim.I, (int)Dim.J);
        
        public static readonly BitLayout<T> GridLayout = GridSpec.CalcLayout();

        /// <summary>
        /// Allocates a Zero-filled mxn matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Zeros()
            => new BitMatrix<M, N, T>(new T[GridLayout.TotalSegments]);

        /// <summary>
        /// Allocates a One-filled mxn matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Ones()
        {
            Span<T> data = new T[GridLayout.TotalSegments];
            var length = BitSize.Size<T>();
            for(var i=0; i<data.Length; i++)
                for(var j = 0; j< length; j++)
                    gbits.enable(ref data[i], j);
            return new BitMatrix<M, N, T>(data);
        }

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> operator &(BitMatrix<M,N,T> lhs, BitMatrix<M,N,T> rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> operator *(BitMatrix<M,N,T> lhs, BitMatrix<M,N,T> rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public BitMatrix(Span<T> src)
        {
            require(src.Length == GridLayout.TotalSegments, 
                $"A span of length {src.Length} was provided which differs from the required segment count of {GridLayout.TotalSegments}");
            this.bits = src;
        }

        [MethodImpl(Inline)]
        public BitMatrix(ReadOnlySpan<T> src)
        {
            require(src.Length == GridLayout.TotalSegments, 
                $"A span of length {src.Length} was provided which differs from the required segment count of {GridLayout.TotalSegments}");
            this.bits = src.Replicate();
        }

        [MethodImpl(Inline)]
        Bit GetBit(int row, int col)
        {
            var cell = GridLayout.Row(row)[col];
            return gbits.test(in bits[cell.BitPos.SegIdx], cell.BitPos.BitOffset);                    
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit value)
        {
            var cell = GridLayout.Row(row)[col];
            gbits.set(ref bits[cell.BitPos.SegIdx], cell.BitPos.BitOffset, value);
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row, col, value);
        }            

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.RowCount;
        }

        /// <summary>
        /// The (padded) length of a primal span/array required to store a row of grid data.
        /// </summary>
        public int RowSegCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.RowSegments;
        }
        
        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public int ColCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.ColCount;
        }

        /// <summary>
        /// Provides direct access to the underlying bitstore
        /// </summary>
        public Span<T> Bits
            => bits;
        
        [MethodImpl(Inline)]
        int RowOffset(int row)        
            => GridLayout.Row(row)[0].BitPos.SegIdx;
                
        [MethodImpl(Inline)]
        Span<T> RowData(int row)
            => bits.Slice(RowOffset(row), GridLayout.RowSegments);

        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="index">The 0-based row index</param>
        [MethodImpl(Inline)]
        public BitVector<N,T> Row(int index)                    
            => new BitVector<N,T>(RowData(index));                

        [MethodImpl(Inline)]
        public void ReplaceCol(int colix, BitVector<M,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,colix] = src[row];
        }

        [MethodImpl(Inline)]
        public BitVector<M,T> Col(int colix)
        {
            var col = default(BitVector<M,T>);
            for(var row=0; row < RowCount; row++)
                col[row] = this[row, colix];
            return col;
        }

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<Bit> Unpack()
            => bits.AsBytes().Unpack(out Span<Bit> dst);


        public BitLayout<T> Layout
            => GridLayout;

       [MethodImpl(Inline)]
        public string Format()
            => Bits.AsBytes().FormatMatrixBits(ColCount);

        public BitMatrix<N,M,T> Transpose()
        {
            var dst = BitMatrix.Define<N,M,T>();
            for(var row = 0; row < RowCount; row++)
                dst.ReplaceCol(row, Row(row));            
            return dst;
        }

        public static ref BitMatrix<M,N,T> And(ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
        {
            gbits.and(lhs.bits, rhs.bits, lhs.Bits);
            return ref lhs;
        }

    }
}