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

    public static class TextDocReader
    {

        public static Option<TextDoc> ReadTextDoc(this FilePath src, TextFormat? format = null)
        {
            return src.ParseDocument(format, message => print(message));
        }

    }


}