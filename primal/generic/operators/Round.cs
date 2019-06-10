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
        public static T round<T>(T src, int scale)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.round(float32(src), scale));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.round(float64(src), scale));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                math.round(float32(src), scale, float32(dst));
            else if(typeof(T) == typeof(double))
                math.round(float64(src), scale, float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale)
            where T : struct
                => round(src, scale, span<T>(src.Length));

        [MethodImpl(Inline)]
        public static ref Span<T> round<T>(ref Span<T> io, int scale)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                math.round(float32(io), scale);
            else if(typeof(T) == typeof(double))
                math.round(float64(io), scale);
            else
                throw unsupported<T>();
            return ref io;        
        }

    }

}