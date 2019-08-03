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
    

    public sealed class TextDoc
    {
        TextRow[] LineData;        

        public TextDoc(TextFormat format, Option<TextHeader> header,  uint TotalLineCount, params TextRow[] LineData)
        {
            this.LineData = LineData;
            this.Header = header;
            this.Format = format;
            this.TotalLineCount = TotalLineCount;
        }

        public TextFormat Format {get;}

        public Option<TextHeader> Header {get;}
        
        public ReadOnlySpan<TextRow> Rows
            => LineData;
        
        public uint TotalLineCount {get;}
        
        public uint DataLineCount
            => (uint)Rows.Length;
        
        public uint HeaderLineCount
            => Header.IsSome() ? 1u : 0u;
    }

}