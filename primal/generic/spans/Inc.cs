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
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.inc(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.inc(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.inc(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.inc(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.inc(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.inc(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.inc(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.inc(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.inc(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.inc(float64(src), float64(dst));
            else
                 throw unsupported<T>();                
            return dst;
        }

        public static ref Span<T> inc<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.inc(int8(io));
            else if(typeof(T) == typeof(byte))
                math.inc(uint8(io));
            else if(typeof(T) == typeof(short))
                math.inc(int16(io));
            else if(typeof(T) == typeof(ushort))
                math.inc(uint16(io));
            else if(typeof(T) == typeof(int))
                math.inc(int32(io));
            else if(typeof(T) == typeof(uint))
                math.inc(uint32(io));
            else if(typeof(T) == typeof(long))
                math.inc(int64(io));
            else if(typeof(T) == typeof(ulong))
                math.inc(uint64(io));
            else if(typeof(T) == typeof(float))
                math.inc(float32(io));
            else if(typeof(T) == typeof(double))
                math.inc(float64(io));
            else
                 throw unsupported<T>();                
           
            return ref io;
        }
    }
}