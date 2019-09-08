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
    public readonly struct GridSpec<T>
        where T : struct
    {
        public static implicit operator GridSpec<T>((BitSize PrimalSize, int RowCount, int ColCount) x)
            => new GridSpec<T>(x.PrimalSize, x.RowCount, x.ColCount);
            
        public GridSpec(BitSize CellSize, int RowCount, int ColCount)
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
        public readonly int RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly int ColCount;

        /// <summary>
        /// The minimum number of a cells in a primal array/span required to store a row of data 
        /// </summary>
        public readonly int RowCellCount;

        /// <summary>
        /// The number of bits stored in the grid, given by <see cref='RowCount'/> * <see cref='ColCount'/>
        /// </summary>
        public readonly BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

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
        /// Computes the length of a primal span/array that is required to store a row of data
        /// </summary>
        [MethodImpl(Inline)]
        static int CalcRowStorageLength(BitSize CellSize, int ColCount)
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