//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct BitGridSpec<T>
        where T : struct
    {
        public static implicit operator BitGridSpec<T>((BitSize PrimalSize, BitSize RowCount, BitSize ColCount) x)
            => new BitGridSpec<T>(x.PrimalSize, x.RowCount, x.ColCount);
            
        public BitGridSpec(BitSize CellSize, BitSize RowCount, BitSize ColCount)
        {
            this.CellSize = CellSize;
            this.RowCount = RowCount;
            this.ColCount = ColCount;

            this.RowCellCount = CalcRowStorageLength(CellSize, ColCount);
        }
        
        /// <summary>
        /// The bit size of the underlying storage type
        /// </summary>
        public readonly BitSize CellSize;
        
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly BitSize RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly BitSize ColCount;

        /// <summary>
        /// The number of bits stored in the grid, given by <see cref='RowCount'/> * <see cref='ColCount'/>
        /// </summary>
        public readonly BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        /// <summary>
        /// The minimum number of a cells in a primal array/span required to store a row of data 
        /// </summary>
        public readonly int RowCellCount;

        /// <summary>
        /// Computes the minimum number of cells required to store a grid of data
        /// </summary>
        /// <param name="spec">The characterizing specification</param>
        public int TotalCellCount
        {
            [MethodImpl(Inline)]
            get => RowCount * RowCellCount;
        }

        /// <summary>
        /// The minimum number of bytes required to store the grid data
        /// </summary>
        public ByteSize StorageBytes
        {
            [MethodImpl(Inline)]
            get => Unsafe.SizeOf<T>() * TotalCellCount;
        }

        /// <summary>
        /// Computes the length of a primal span/array that is required to store a row of data
        /// </summary>
        [MethodImpl(Inline)]
        static int CalcRowStorageLength(BitSize CellSize, BitSize ColCount)
        {
            if(CellSize >= ColCount)
                return 1;
            else
            {
                var q = Math.DivRem(ColCount, CellSize, out int r);                
                return r == 0 ? q : q + 1;
            }
        }

        public string Format()
            => (CellSize, RowCount, ColCount).Format();
    }
}