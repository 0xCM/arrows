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

    public sealed class TextRow
    {
        
        TextCell[] CellData;

        public TextRow(params TextCell[] CellData)
        {
            this.CellData = CellData;
        }

        public ReadOnlySpan<TextCell> Cells
            => CellData;

        public override string ToString()
        {
            return string.Join(AsciSym.Pipe,CellData.Select(x => x.CellValue));
        }            
    }

}