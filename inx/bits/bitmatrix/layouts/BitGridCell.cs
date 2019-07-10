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
    /// Defines a coordinate for a grid cell to facilitate efficient
    /// correlation and lookup
    /// </summary>
    public readonly struct BitGridCell
    {   
        public static implicit operator BitGridCell((int BitPos, int SegPos, int Row, int Col, int Offset) x)
            => new BitGridCell(x.BitPos, x.SegPos, x.Row, x.Col, x.Offset);

        public BitGridCell(int BitPos, int SegPos, int Row, int Col, int Offset)
        {
            this.BitPos = BitPos;
            this.SegPos = SegPos;
            this.Row =Row;
            this.Col = Col;
            this.Offset = Offset;
        }
        
        /// <summary>
        /// The absolute bit position
        /// </summary>
        public readonly int BitPos;
        
        public readonly int SegPos;

        /// <summary>
        /// The absolute row index
        /// </summary>
        public readonly int Row;

        /// <summary>
        /// The absolute column index
        /// </summary>
        public readonly int Col;

        /// <summary>
        /// The segment-relative column offset
        /// </summary>
        public readonly int Offset;

        public string Format()
            => $"(Bit = {BitPos}, Segment = {SegPos}, Row = {Row}, Col = {Col}, Offset = {Offset})";
    }


}