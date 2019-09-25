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
        
    using static As;
    using static zfunc;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T round<T>(T src, int scale)
            where T : struct
        {

            if(typeof(T) == typeof(float))
                return generic<T>(fmath.round(float32(src), scale));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.round(float64(src), scale));
            else
                return src;
        }
    }
}