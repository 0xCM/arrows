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
            this.RowStorageLength = CalcRowStorageLength(CellSize, ColCount);
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
        /// The total length of a primal array/span required to store a grid of data
        /// </summary>
        public readonly int RowStorageLength;


        /// <summary>
        /// Computes the total length of a primal array/span required to store a grid of data
        /// </summary>
        /// <param name="spec">The characterizing specification</param>
        [MethodImpl(Inline)]
        public int TotalStorageLength()
            => RowCount * RowStorageLength;

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
                var qr = math.quorem(ColCount, CellSize);
                return qr.Remainder == 0 ? qr.Quotient : qr.Quotient + 1;
            }
        }

        public string Format()
            => (CellSize, RowCount, ColCount).Format();
    }
}