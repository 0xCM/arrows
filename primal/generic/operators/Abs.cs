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
        public static T abs<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.abs(int8(src)));
            else if(typeof(T) == typeof(byte))
                return src;
            else if(typeof(T) == typeof(short))
                return generic<T>(math.abs(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return src;
            else if(typeof(T) == typeof(int))
                return generic<T>(math.abs(int32(src)));
            else if(typeof(T) == typeof(uint))
                return src;
            else if(typeof(T) == typeof(long))
                return generic<T>(math.abs(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return src;
            else if(typeof(T) == typeof(float))
                return generic<T>(math.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.abs(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                return ref src;
            else if(typeof(T) == typeof(short))
                math.abs(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                return ref src;
            else if(typeof(T) == typeof(int))
                math.abs(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                return ref src;
            else if(typeof(T) == typeof(long))
                math.abs(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                return ref src;
            else if(typeof(T) == typeof(float))
                math.abs(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.abs(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;                
        }           

        [MethodImpl(Inline)]
        public static ref readonly Span<T> abs<T>(in ReadOnlySpan<T> src, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(src).Abs(int8(dst));
            else if(typeof(T) == typeof(short))
                int16(src).Abs(int16(dst));
            else if(typeof(T) == typeof(int))
                int32(src).Abs(int32(dst));
            else if(typeof(T) == typeof(long))
                int64(src).Abs(int64(dst));
            else if(typeof(T) == typeof(float))
                float32(src).Abs(float32(dst));
            else if(typeof(T) == typeof(double))
                float64(src).Abs(float64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        public static ref readonly Span<T> abs<T>(in Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(io).Abs();
            else if(typeof(T) == typeof(short))
                int16(io).Abs();
            else if(typeof(T) == typeof(int))
                int32(io).Abs();
            else if(typeof(T) == typeof(long))
                int64(io).Abs();
            else if(typeof(T) == typeof(float))
                float32(io).Abs();
            else if(typeof(T) == typeof(double))
                float64(io).Abs();
            else
                throw unsupported<T>();
            return ref io;
        }
    }
}