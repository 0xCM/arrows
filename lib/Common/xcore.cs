//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;


    using static zcore;

    partial class xcore
    {
        [MethodImpl(Inline)]   
        public static  IEnumerable<T> Unwrap<T>(this IEnumerable<T> wrapped)
            where T : Wrapped<T>
                => wrapped.Select(x => x.unwrap());
    }

}