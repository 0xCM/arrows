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
    /// Corrlates a bit position with a grid row and column
    /// </summary>
    public readonly struct BitGridCell<T>
        where T : struct
    {   
        public BitGridCell(BitPos<T> BitPos, int Row, int Col)
        {
            this.BitPos = BitPos;
            this.Row =Row;
            this.Col = Col;
        }

        /// <summary>
        /// The position of the cell relative to contiguous T-memory
        /// </summary>
        public readonly BitPos<T> BitPos;

        /// <summary>
        /// The absolute row index
        /// </summary>
        public readonly int Row;

        /// <summary>
        /// The absolute column index
        /// </summary>
        public readonly int Col;

        public string Format()
            => $"(Bit = {BitPos}, Segment = {BitPos.SegIdx}, Row = {Row}, Col = {Col}, Offset = {BitPos.BitOffset})";
    }
}