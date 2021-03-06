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

    public class GridLayout<T>
        where T : struct
    {        
        public GridLayout(GridSpec<T> spec, IEnumerable<CellMap<T>> Cells)
        {
            this.GridSpec = spec;
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.BitCount = spec.BitCount;
            this.RowCellCount = spec.RowCellCount;
            this.TotalCellCount = spec.TotalCellCount;
            this.RowLayout = CreateLayoutIndex(Cells);
            this.CellSize = spec.CellSize;
            require(spec.RowCount == RowLayout.Count);
            require(spec.ColCount == RowLayout.First().Value.Length);                         
        }

        readonly IReadOnlyDictionary<int, CellMap<T>[]> RowLayout;
       
        /// <summary>
        /// The specification from which the layout was calculated
        /// </summary>
        public readonly GridSpec<T> GridSpec;

        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public readonly int RowCount;
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public readonly int ColCount;

        /// <summary>
        /// The number of bits stored in the grid, given by <see cref='RowCount'/> * <see cref='ColCount'/>
        /// </summary>
        public readonly BitSize BitCount;

        /// <summary>
        /// The number of bits in a cell
        /// </summary>
        public readonly BitSize CellSize;

        /// <summary>
        /// The minimum number of cells sufficient to store a row of grid data
        /// </summary>
        public readonly int RowCellCount;

        /// <summary>
        /// The length of a span required to store all cells
        /// </summary>
        public readonly int TotalCellCount;

        
        [MethodImpl(Inline)]
        public Span<CellMap<T>> Row(int row)
            => RowLayout[row];            

        [MethodImpl(Inline)]
        public CellMap<T> Cell(int row, int col)
            => RowLayout[row][col];            

        public Span<CellMap<T>> this[int row]
        {
            [MethodImpl(Inline)]
            get => Row(row);
        }

        public CellMap<T> this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => Cell(row, col);
        }

        public string Format()
        {
            var format = sbuild();
            format.Append($"RowCount = {RowCount}, ");
            format.Append($"ColCount = {ColCount}, ");
            format.Append($"CellCount = {BitCount}, ");
            format.Append($"RowSegLength = {RowCellCount}");
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
 
         static IReadOnlyDictionary<int, CellMap<T>[]> CreateLayoutIndex(IEnumerable<CellMap<T>> Cells)
                => Cells.GroupBy(x => x.Row).Select(x => (x.Key, x.OrderBy(u => u.LinearIndex).ToArray())).ToDictionary();

    }
}