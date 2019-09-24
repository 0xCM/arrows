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

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T floor<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.floor(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.floor(float64(src)));
            else
                throw unsupported<T>();
        }        

        [MethodImpl(Inline)]
        public static ref T floor<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.floor(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.floor(ref float64(ref src));
            else
                throw unsupported<T>();
            return ref src;
        }        

    }
}