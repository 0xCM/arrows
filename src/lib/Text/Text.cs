//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;
    using static Operative;


    public readonly struct Text : Concatenable<string>
    {
        [MethodImpl(Inline)]
        public string concat(string lhs, string rhs)
            => lhs + rhs;
    }



}