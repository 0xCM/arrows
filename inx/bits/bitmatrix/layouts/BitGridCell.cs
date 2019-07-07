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
        public static implicit operator BitGridCell((int Index, int Segment, int Row, int Col) x)
            => new BitGridCell(x.Index, x.Segment, x.Row, x.Col);

        public BitGridCell(int Index, int Segment, int Row, int Col)
        {
            this.Index = Index;
            this.Segment = Segment;
            this.Row =Row;
            this.Col = Col;
        }
        
        public readonly int Index;

        public readonly int Segment;

        public readonly int Row;

        public readonly int Col;

        public string Format()
            => $"(Bit = {Index}, Segment = {Segment}, Row = {Row}, Col = {Col})";
    }


}