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

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T sin<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.sin(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.sin(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T asin<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.asin(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.asin(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T cos<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.cos(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.cos(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T acos<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.acos(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.acos(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T tan<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.tan(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.tan(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T atan<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.atan(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.atan(float64(src)));
            else
                throw unsupported<T>();
        }
 
    }

}