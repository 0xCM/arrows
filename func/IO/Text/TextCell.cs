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
    
    public sealed class TextCell
    {
        
        public TextCell(uint LineNumber, uint ColumnIndex, string CellValue)
        {
            this.LineNumber = LineNumber;
            this.ColumnIndex = ColumnIndex;
            this.CellValue = CellValue;
        }
        
        public uint LineNumber {get;}

        public uint ColumnIndex {get;}

        public string CellValue {get;}

    }




}