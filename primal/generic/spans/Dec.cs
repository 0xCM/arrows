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
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.dec(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.dec(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.dec(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.dec(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.dec(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.dec(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.dec(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.dec(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.dec(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.dec(float64(src), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static ref Span<T> dec<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.dec(int8(io));
            else if(typeof(T) == typeof(byte))
                math.dec(uint8(io));
            else if(typeof(T) == typeof(short))
                math.dec(int16(io));
            else if(typeof(T) == typeof(ushort))
                math.dec(uint16(io));
            else if(typeof(T) == typeof(int))
                math.dec(int32(io));
            else if(typeof(T) == typeof(uint))
                math.dec(uint32(io));
            else if(typeof(T) == typeof(long))
                math.dec(int64(io));
            else if(typeof(T) == typeof(ulong))
                math.dec(uint64(io));
            else if(typeof(T) == typeof(float))
                math.dec(float32(io));
            else if(typeof(T) == typeof(double))
                math.dec(float64(io));
            else
                 throw unsupported<T>();                
           
            return ref io;
        }


    }

}