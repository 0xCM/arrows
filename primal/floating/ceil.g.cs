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
        public static T ceil<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.ceil(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.ceil(float64(src)));
            else
                throw unsupported<T>();
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

        public static Span<T> ceil<T>(Span<T> io)
            where T : struct
        {
            for(var i =0; i<io.Length; i++)
                io[i] = ceil(io[i]);
            return io;
        }

    }
}