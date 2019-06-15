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
    using System.IO;
    
    using static zfunc;

    public readonly struct BitString
    {
        public static BitString Define(string content)                
            => new BitString(content);
            
        readonly string content;

        public BitString(string content)
        {
            this.content  = content;
        }

        public override string ToString()
            => content;

    }

}