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
        public static T inc<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(int8(src) + 1);
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint8(src) + 1);
            else if(typeof(T) == typeof(short))
                return generic<T>(int16(src) + 1);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(uint16(src) + 1);
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) + 1);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) + 1);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) + 1);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) + 1);
            else if(typeof(T) == typeof(float))
                return generic<T>(float32(src) + 1);
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(src) + 1);
            else            
                 throw unsupported<T>();                
       }           

        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.inc(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.inc(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.inc(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.inc(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.inc(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.inc(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.inc(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.inc(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.inc(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.inc(ref float64(ref src));
            else            
                 throw unsupported<T>();                

            return ref src;
        }           

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