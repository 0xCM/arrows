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
        public static T negate<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.negate(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.negate(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.negate(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.negate(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.negate(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.negate(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.negate(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.negate(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.negate(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.negate(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T negate<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.negate(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.negate(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.negate(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.negate(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.negate(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.negate(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.negate(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.negate(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.negate(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.negate(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.negate(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.negate(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.negate(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.negate(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.negate(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.negate(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.negate(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.negate(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.negate(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.negate(float64(src), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> negate<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.negate(int8(io));
            else if(typeof(T) == typeof(byte))
                math.negate(uint8(io));
            else if(typeof(T) == typeof(short))
                math.negate(int16(io));
            else if(typeof(T) == typeof(ushort))
                math.negate(uint16(io));
            else if(typeof(T) == typeof(int))
                math.negate(int32(io));
            else if(typeof(T) == typeof(uint))
                math.negate(uint32(io));
            else if(typeof(T) == typeof(long))
                math.negate(int64(io));
            else if(typeof(T) == typeof(ulong))
                math.negate(uint64(io));
            else if(typeof(T) == typeof(float))
                math.negate(float32(io));
            else if(typeof(T) == typeof(double))
                math.negate(float64(io));
            else
                throw unsupported<T>();
            return ref io;

        }
    
    }
}