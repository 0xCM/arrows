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

    public readonly struct HexString
    {
        [MethodImpl(Inline)]
        public static HexString operator +(HexString hi, HexString lo)
            => Define(hi.content + lo.content);

        [MethodImpl(Inline)]
        public static implicit operator HexString(string src)                
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator string(HexString src)                
            => src.content;

        [MethodImpl(Inline)]
        public static HexString Define(string content)                
            => new HexString(content);
            
        readonly string content;

        [MethodImpl(Inline)]
        public HexString(string content)
        {
            this.content  = content;
        }

        public override string ToString()
            => content;

    }

}