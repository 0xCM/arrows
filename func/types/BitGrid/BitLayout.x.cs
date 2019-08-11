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

    public static class BitLayoutX
    {
        /// <summary>
        /// Associates grid cell row-column coordinates with contiguous T-memory
        /// </summary>
        /// <param name="bitPos">The bit position relative to contiguous T-memory</param>
        /// <param name="row">The grid row</param>
        /// <param name="col">The grid column</param>
        /// <typeparam name="T">The cell storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitGridCell<T> GridCell<T>(this BitPos<T> bitPos, int row, int col)
            where T : struct
                => new BitGridCell<T>(bitPos, row, col);

        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitGridLayout<T> CalcLayout<T>(this BitGridSpec<T> spec)
            where T: struct
                => new BitGridLayout<T>(spec, spec.GridCells());

        static IEnumerable<BitGridCell<T>> GridCells<T>(this BitGridSpec<T> spec)
            where T: struct
        {                                                        
            var bit = 0;
            var seg = 0;
            var segbits = spec.CellSize;

            for(int row = 0, rowbit = 0; row < spec.RowCount; row++)
            {
                for(var col = 0; col < spec.ColCount; col++, bit++, rowbit++, segbits--)
                {
                    if(segbits == 0)
                    {
                        seg++;
                        segbits = spec.CellSize;
                    }
                   
                   var offset = (byte)(spec.CellSize - segbits).Bits;
                   var pos = BitPos<T>.Define((ushort)seg,offset);
                   yield return pos.GridCell(row, col);
                }

                seg++;
                segbits = spec.CellSize;
            }                    
        }   
    }
}