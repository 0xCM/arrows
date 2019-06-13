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
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;


    partial class UniformRandom
    {


        public static T[] Array<T>(this IRandomSource random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.UniformStream(domain,filter).TakeArray(length);
         
        [MethodImpl(Inline)]
        public static T[] NonZeroArray<T>(this IRandomSource random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);        

    }

}