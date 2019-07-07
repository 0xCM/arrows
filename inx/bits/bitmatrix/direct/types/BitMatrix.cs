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

        static readonly BitGridSpec GridSpec = (SizeOf<T>.BitSize, (int)Dim.j, (int)Dim.i);
        
        public static readonly BitGridLayout GridLayout = GridSpec.CalcLayout();

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
            var matrix = new BitMatrix<M, N, T>(data);
            for(var i=0; i< GridLayout.RowCount; i++)
                for(var j=0; j<GridLayout.ColCount; j++)
                    matrix[i,j] = Bit.On;
            return matrix;
        }
            

        [MethodImpl(Inline)]
        Bit GetBit(int row, int col)
        {
            var cell = GridLayout.Row(row)[col];
            return gbits.test(in bits[cell.Segment], cell.Col);                    
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit value)
        {
            var cell = GridLayout.Row(row)[col];
            gbits.set(ref bits[cell.Segment], cell.Col, value);
        }

        [MethodImpl(Inline)]
        public BitMatrix(Span<T> src)
        {
            require(src.Length == GridLayout.TotalSegments);
            this.bits = src;
        }

        [MethodImpl(Inline)]
        public BitMatrix(ReadOnlySpan<T> src)
        {
            require(src.Length == GridLayout.TotalSegments);
            this.bits = src.Replicate();
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
            => GridSpec.RowCount;

        /// <summary>
        /// The (padded) length of a primal span/array required to store a row of grid data.
        /// </summary>
        public int RowSegCount
            => GridLayout.RowSegments;
        
        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public int ColCount
            => GridSpec.ColCount;

        /// <summary>
        /// Provides direct access to the underlying bitstore
        /// </summary>
        public Span<T> Bits
            => bits;
        
        [MethodImpl(Inline)]
        int RowOffset(int row)        
            => GridLayout.Row(row)[0].Segment;
        
        [MethodImpl(Inline)]
        Span<T> RowData(int row)
            =>bits.Slice(RowOffset(row), GridLayout.RowSegments);

        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        [MethodImpl(Inline)]
        public BitVector<M,T> RowVector(int row)                    
            => new BitVector<M,T>(RowData(row));        
        


    }
}