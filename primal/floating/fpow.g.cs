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
    using static AsIn;

    partial class gfp
    {

        [MethodImpl(Inline)]
        public static T fpow<T>(T b, uint exp)
            where T : struct
        {
            if(typeof(T) == typeof(float))
               return generic<T>(fmath.pow(ref float32(ref b), exp));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.pow(ref float64(ref b), exp));
            else            
               throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static ref T fpow<T>(ref T b, uint exp)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.pow(ref float32(ref b), exp);
            else if(typeof(T) == typeof(double))
                fmath.pow(ref float64(ref b), exp);
            else            
               throw unsupported<T>();
            
            return ref b;

        }

        [MethodImpl(Inline)]
        public static Span<T> fpow<T>(Span<T> lhs, uint exp)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.pow(float32(lhs), exp);
            else if(typeof(T) == typeof(ulong))
                fmath.pow(float64(lhs), exp);
            else
                throw unsupported<T>();
            return lhs;
        }
    }

}