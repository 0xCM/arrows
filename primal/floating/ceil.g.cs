//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T ceil<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.ceil(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.ceil(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T ceil<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.ceil(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.ceil(ref float64(ref src));
            else
                throw unsupported<T>();
            return ref src;
        }        

    }
}