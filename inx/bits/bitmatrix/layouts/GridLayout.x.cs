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

    public static class BitGridExtensions
    {
        /// <summary>
        /// Computes the length of a primal span/array that is required to store a row of data
        /// </summary>
        /// <param name="spec">The characterizing specification</param>
        public static int RowSegLength(this BitGridSpec spec)
        {
            if(spec.PrimalSize >= spec.ColCount)
                return 1;
            else
            {
                var qr = math.quorem(spec.ColCount, spec.PrimalSize);
                return qr.Remainder == 0 ? qr.Quotient : qr.Quotient + 1;
            }
        }

        /// <summary>
        /// Computes the total length of a primal array/span required to store a matrix of data
        /// </summary>
        /// <param name="spec">The characterizing specification</param>
        /// <returns></returns>
        public static int TotalSegLength(this BitGridSpec spec)
            => spec.RowCount * spec.RowSegLength();

        public static IReadOnlyDictionary<int, BitGridCell[]> CreateRowIndex(this IEnumerable<BitGridCell> Cells)
            => Cells.GroupBy(x => x.Row).Select(x => (x.Key, x.OrderBy(u => u.BitPos).ToArray())).ToDictionary();

        static IEnumerable<BitGridCell> GridCellsOld(this BitGridSpec spec)
        {                    
            var bitcount = spec.RowCount * spec.ColCount;
            var rowSegLen = spec.RowSegLength();
            for(int i=0, col=0, seg = 0, row = 0 ; i< bitcount; i++, col++)
            {
                if(i != 0)
                {
                    bool rowFinished = (i % spec.ColCount) == 0;

                    if((i % spec.PrimalSize) == 0 || rowFinished)
                        seg++;

                    if(rowFinished)
                    {
                        col = 0;
                        row++;
                    }
                }
                yield return (i, seg, row, col,0);
            }
        }        

        public static IEnumerable<BitGridCell> GridCells(this BitGridSpec spec)
        {                                                        
            var bit = 0;
            var seg = 0;
            var segbits = spec.PrimalSize;

            for(int row = 0, rowbit = 0; row < spec.RowCount; row++)
            {
                for(var col = 0; col < spec.ColCount; col++, bit++, rowbit++, segbits--)
                {
                    if(segbits == 0)
                    {
                        seg++;
                        segbits = spec.PrimalSize;
                    }
                   
                   yield return (bit, seg, row, col, spec.PrimalSize - segbits);
                }

                seg++;
                segbits = spec.PrimalSize;
            }
          
            
        }

        public static BitGridLayout CalcLayout(this BitGridSpec spec)
            => new BitGridLayout(spec, spec.GridCells());

        public static string Format(this BitGridLayout layout)
        {
            var format = sbuild();
            format.Append($"RowCount = {layout.RowCount}, ");
            format.Append($"ColCount = {layout.ColCount}, ");
            format.Append($"CellCount = {layout.CellCount}, ");
            format.Append($"RowSegLength = {layout.RowSegments}");
            format.AppendLine();
            for(var row = 0; row<layout.RowCount; row++)
            {
                var rowData = layout.Row(row);
                for(var i=0; i<rowData.Length; i++)
                    format.AppendLine(rowData[i].Format());
            }
            return format.ToString();

        }
    
    }

}