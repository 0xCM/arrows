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
    /// Correlates a bit position with a grid row and column
    /// </summary>
    public readonly struct CellMap<T>
        where T : struct
    {   
        public CellMap(CellIndex<T> BitPos, int Row, int Col)
        {
            this.Segment = BitPos.Segment;
            this.Offset = BitPos.Offset;
            this.Row =Row;
            this.Col = Col;
            this.LinearIndex = BitPos.LinearIndex;
        }
        

        public CellMap(ushort Segment, byte Offset, int LinearIndex, int Row, int Col)
        {
            this.Segment = Segment;
            this.Offset = Offset;
            this.Row =Row;
            this.Col = Col;
            this.LinearIndex = LinearIndex;
        }
        /// <summary>
        /// The container-relative index of the storage segment containing the bit
        /// </summary>
        public readonly ushort Segment;
        
        /// <summary>
        /// The segment-relative bit offset
        /// </summary>
        public readonly byte Offset;

        /// <summary>
        /// The index of the cell containing the bit
        /// </summary>
        public readonly int LinearIndex;

        /// <summary>
        /// The absolute row index
        /// </summary>
        public readonly int Row;

        /// <summary>
        /// The absolute column index
        /// </summary>
        public readonly int Col;

        public string Format()
            => $"(Bit = {LinearIndex}, Segment = {Segment}, Row = {Row}, Col = {Col}, Offset = {Offset})";
    }
}