//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;

    /// <summary>
    /// Defines a row of text parttioned into a sequence of cells
    /// </summary>
    public sealed class TextRow
    {        
        TextCell[] CellData;

        public TextRow(params TextCell[] CellData)
        {
            this.CellData = CellData;
        }

        /// <summary>
        /// The cells that comprise the row
        /// </summary>
        public ReadOnlySpan<TextCell> Cells
            => CellData;

        /// <summary>
        /// Joins the enclosed cells to produce a line of text
        /// </summary>
        /// <param name="delimiter">The separator to apply to delimit the cell data in the line </param>
        public string Format(char? delimiter = null)
            => string.Join(delimiter ?? AsciSym.Pipe,CellData.Select(x => x.CellValue));
        
        public override string ToString()
            => Format();
    }

}