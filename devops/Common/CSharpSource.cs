//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public class CSharpSource : SourceCode<CSharpSource>
    {
        public CSharpSource()
            : base(string.Empty)
        {}

        public CSharpSource(string Text)
            : base(Text)
        {

        }
    }
}