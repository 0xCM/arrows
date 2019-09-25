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
        public static T mul<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.mul(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.mul(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.mul(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                fmath.mul(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

    }

}