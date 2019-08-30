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

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T floor<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.floor(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.floor(float64(src)));
            else
                throw unsupported<T>();
        }        

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
        
 
        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sqrt(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sqrt(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        static ref T sqrtF32<T>(ref T src)
        {
            fmath.sqrt(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtF64<T>(ref T src)
        {
            fmath.sqrt(ref float64(ref src));            
            return ref src;
        }

    }
}