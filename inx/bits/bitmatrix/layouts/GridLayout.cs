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

    public readonly struct BitGridLayout
    {        
        public BitGridLayout(BitGridSpec spec, IEnumerable<BitGridCell> Cells)
        {
            this.GridSpec = spec;
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.CellCount = spec.RowCount * spec.ColCount;
            this.RowSegments = spec.RowSegLength();
            this.TotalSegments = RowSegments * spec.RowCount;
            this.RowLayout = Cells.CreateRowIndex();
            Claim.eq(spec.RowCount, RowLayout.Count);
            Claim.eq(spec.ColCount, RowLayout.First().Value.Length);                         
        }

        readonly IReadOnlyDictionary<int, BitGridCell[]> RowLayout;

        /// <summary>
        /// The specification from which the layout was calculated
        /// </summary>
        public readonly BitGridSpec GridSpec;
        
        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public readonly BitSize RowCount;
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public readonly BitSize ColCount;

        /// <summary>
        /// The Total number of bits accounted for in the layout
        /// and is equal to <see cref='RowCount'/> * <see cref='ColCount'/>
        /// </summary>
        public readonly BitSize CellCount;

        /// <summary>
        /// The minimal length of a primal span sufficient to store a row of grid data
        /// </summary>
        public readonly int RowSegments;

        /// <summary>
        /// The length of a span required to store all cells, padded as determined by the
        /// <see cref='RowSegments'/>
        /// </summary>
        public readonly int TotalSegments;
        
        public Span<BitGridCell> Row(int index)
            => RowLayout[index];            
    }
}