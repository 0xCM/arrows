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
        public static T floor<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return floorF32(src);
            else if(typeof(T) == typeof(double))
                return floorF64(src);
            else
                throw unsupported(PrimalKinds.kind<T>());
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
        static T floorF32<T>(T src)
            => generic<T>(MathF.Floor(float32(src)));

        [MethodImpl(Inline)]
        static T floorF64<T>(T src)
            => generic<T>(Math.Floor(float64(src)));
 
    }
}