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

    using static zfunc;
    using static As;

    public static partial class RngX
    {            
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IRandomSource random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeArray(length);
         


    }

}