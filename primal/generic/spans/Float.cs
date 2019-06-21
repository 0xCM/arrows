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

        public static Span<T> floor<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = floor(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : struct
            => floor(src, span<T>(src.Length));

        public static ref Span<T> floor<T>(ref Span<T> io)
            where T : struct
        {
            for(var i =0; i<io.Length; i++)
                io[i] = floor(io[i]);
            return ref io;
        } 

        public static Span<T> ceil<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = ceil(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> ceil<T>(ReadOnlySpan<T> src)
            where T : struct
            => ceil(src, span<T>(src.Length));

        public static ref Span<T> ceil<T>(ref Span<T> io)
            where T : struct
        {
            for(var i =0; i<io.Length; i++)
                io[i] = ceil(io[i]);
            return ref io;
        }

        public static ref Span<T> sqrt<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sqrt(int8(io));
            else if(typeof(T) == typeof(byte))
                math.sqrt(uint8(io));
            else if(typeof(T) == typeof(short))
                math.sqrt(int16(io));
            else if(typeof(T) == typeof(ushort))
                math.sqrt(uint16(io));
            else if(typeof(T) == typeof(int))
                math.sqrt(int32(io));
            else if(typeof(T) == typeof(uint))
                math.sqrt(uint32(io));
            else if(typeof(T) == typeof(long))
                math.sqrt(int64(io));
            else if(typeof(T) == typeof(ulong))
                math.sqrt(uint64(io));
            else if(typeof(T) == typeof(float))
                math.sqrt(float32(io));
            else if(typeof(T) == typeof(double))
                math.sqrt(float64(io));
            else
                 throw unsupported<T>();                
           
            return ref io;
        }

    }

}