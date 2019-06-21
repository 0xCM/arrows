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
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T floor<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.floor(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.floor(float64(src)));
            else
                throw unsupported<T>();
        }        

        
 
    }
}