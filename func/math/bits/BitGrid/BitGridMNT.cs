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
    /// Defines a bitgrid of natural dimensions over a primal type
    /// </summary>
    public ref struct BitGrid<M,N,T>
        where M : ITypeNat, new()        
        where N : ITypeNat, new()
        where T : struct
    {        
        Span<T> bits;

        /// <summary>
        /// Specifies the MxN matrix dimension
        /// </summary>
        static readonly Dim<M,N> Dim = default;

        static readonly BitGridSpec<T> GridSpec = (bitsize<T>(), (int)Dim.I, (int)Dim.J);
        
        public static readonly BitGridLayout<T> GridLayout = GridSpec.CalcLayout();

        /// <summary>
        /// Allocates a Zero-filled mxn matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Zeros()
            => new BitGrid<M, N, T>(new T[GridLayout.TotalCellCount]);

        /// <summary>
        /// Allocates a One-filled mxn matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Ones()
        {
            Span<T> data = new T[GridLayout.TotalCellCount];
            var length = BitSize.Size<T>();
            for(var i=0; i<data.Length; i++)
                for(var j = 0; j< length; j++)
                    BitMaskG.enable(ref data[i], j);
            return new BitGrid<M, N, T>(data);
        }


        [MethodImpl(Inline)]
        public BitGrid(Span<T> src)
        {
            require(src.Length == GridLayout.TotalCellCount, 
                $"A span of length {src.Length} was provided which differs from the required segment count of {GridLayout.TotalCellCount}");
            this.bits = src;
        }

        [MethodImpl(Inline)]
        public BitGrid(ReadOnlySpan<T> src)
        {
            require(src.Length == GridLayout.TotalCellCount, 
                $"A span of length {src.Length} was provided which differs from the required segment count of {GridLayout.TotalCellCount}");
            this.bits = src.Replicate();
        }

        [MethodImpl(Inline)]
        Bit GetBit(int row, int col)
        {
            var cell = GridLayout.Row(row)[col];
            return BitMaskG.test(in bits[cell.BitPos.SegIdx], cell.BitPos.BitOffset);                    
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit value)
        {
            var cell = GridLayout.Row(row)[col];
            BitMaskG.set(ref bits[cell.BitPos.SegIdx], cell.BitPos.BitOffset, value);
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
            get => GridLayout.RowCellCount;
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
                
        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="index">The 0-based row index</param>
        [MethodImpl(Inline)]
        public Span<N,T> Row(int index)                    
            => bits.Slice(RowOffset(index), GridLayout.RowCellCount);

        public BitGridLayout<T> Layout
            => GridLayout;


    }
}