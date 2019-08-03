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
    

    public sealed class TextHeader
    {        
        string[] Names;

        public TextHeader(params string[] Names)
        {
            this.Names = Names;
        }

        public ReadOnlySpan<string> HeaderNames
            => Names;

        public override string ToString()
            => string.Join(AsciSym.Pipe, Names);
    }

}