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
        public static T parse<T>(string src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.parse(src, out sbyte x));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.parse(src, out byte x));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.parse(src, out short x));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.parse(src, out ushort x));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.parse(src, out int x));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.parse(src, out uint x));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.parse(src, out long x));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.parse(src, out ulong x));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.parse(src, out float x));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.parse(src, out double x));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T parse<T>(string src, out T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(math.parse(src, out sbyte x));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(math.parse(src, out byte x));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(math.parse(src, out short x));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(math.parse(src, out ushort x));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(math.parse(src, out int x));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(math.parse(src, out uint x));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(math.parse(src, out long x));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(math.parse(src, out ulong x));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(math.parse(src, out float x));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(math.parse(src, out double x));
            else            
                throw unsupported<T>();
            return ref dst;
        }
    }
}