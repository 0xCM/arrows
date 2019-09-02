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
        public static T min<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((Math.Min(int8(lhs), int8(rhs))));
            else if(typeof(T) == typeof(byte))
                return generic<T>((Math.Min(uint8(lhs), uint8(rhs))));
            else if(typeof(T) == typeof(short))
                return generic<T>((Math.Min(int16(lhs), int16(rhs))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((Math.Min(uint16(lhs), uint16(rhs))));
            else if(typeof(T) == typeof(int))
                return generic<T>((Math.Min(int32(lhs), int32(rhs))));
            else if(typeof(T) == typeof(uint))
                return generic<T>((Math.Min(uint32(lhs), uint32(rhs))));
            else if(typeof(T) == typeof(long))
                return generic<T>((Math.Min(int64(lhs), int64(rhs))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>((Math.Min(uint64(lhs), uint64(rhs))));
            else if(typeof(T) == typeof(float))
             return generic<T>((MathF.Min(float32(lhs), float32(rhs))));
          else if(typeof(T) == typeof(double))
             return generic<T>((Math.Min(float64(lhs), float64(rhs))));
            else            
                throw unsupported<T>();
        }           
 
        [MethodImpl(Inline)]
        public static T min<T>(in T lhs, in T rhs)
            where T : struct
                => min(lhs,rhs);

        public static T min<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.min(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.min(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.min(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.min(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.min(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.min(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.min(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.min(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.min(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.min(float64(src)));
            else
                throw unsupported<T>();
            
        }

    }
}