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

    public class BitGridLayout<T>
        where T : struct
    {        
        public BitGridLayout(BitGridSpec<T> spec, IEnumerable<BitGridCell<T>> Cells)
        {
            this.GridSpec = spec;
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.CellCount = spec.RowCount * spec.ColCount;
            this.RowSegments = spec.RowStorageLength;
            this.TotalSegments = RowSegments * spec.RowCount;
            this.RowLayout = CreateLayoutIndex(Cells);
            require(spec.RowCount == RowLayout.Count);
            require(spec.ColCount == RowLayout.First().Value.Length);                         
        }

        /// <summary>
        /// The specification from which the layout was calculated
        /// </summary>
        public readonly BitGridSpec<T> GridSpec;
        
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

        readonly IReadOnlyDictionary<int, BitGridCell<T>[]> RowLayout;
       
        [MethodImpl(Inline)]
        public Span<BitGridCell<T>> Row(int row)
            => RowLayout[row];            

        [MethodImpl(Inline)]
        public BitGridCell<T> Cell(int row, int col)
            => RowLayout[row][col];            

        public Span<BitGridCell<T>> this[int row]
        {
            [MethodImpl(Inline)]
            get => Row(row);
        }

        public BitGridCell<T> this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => Cell(row, col);
        }

        public string Format()
        {
            var format = sbuild();
            format.Append($"RowCount = {RowCount}, ");
            format.Append($"ColCount = {ColCount}, ");
            format.Append($"CellCount = {CellCount}, ");
            format.Append($"RowSegLength = {RowSegments}");
            format.AppendLine();
            for(var row = 0; row<RowCount; row++)
            {
                var rowData = Row(row);
                for(var i=0; i<rowData.Length; i++)
                    format.AppendLine(rowData[i].Format());
            }
            return format.ToString();
        }

        public override string ToString()
            => Format();    
 
         static IReadOnlyDictionary<int, BitGridCell<T>[]> CreateLayoutIndex(IEnumerable<BitGridCell<T>> Cells)
                => Cells.GroupBy(x => x.Row).Select(x => (x.Key, x.OrderBy(u => u.BitPos.LinearIndex).ToArray())).ToDictionary();

    }
}