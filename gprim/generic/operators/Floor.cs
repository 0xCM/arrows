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
        public static T ceil<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return ceilF32(src);
            else if(typeof(T) == typeof(double))
                return ceilF64(src);
            else
                throw unsupported(PrimalKinds.kind<T>());
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

        [MethodImpl(Inline)]
        static T ceilF32<T>(T src)
            => generic<T>(MathF.Ceiling(float32(src)));

        [MethodImpl(Inline)]
        static T ceilF64<T>(T src)
            => generic<T>(Math.Ceiling(float64(src)));
 
    }
}