//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static mfunc;
    using static As;
    using static zfunc;

    partial class mathx
    {
        public static T[] ToScalars<T>(this bool[] src)
            where T : struct
                => map(src, x => x ? gmath.one<T>() : gmath.zero<T>());


    }


}