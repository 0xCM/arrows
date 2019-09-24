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
    using static AsIn;


    public static partial class mathspan
    {
        
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            for(var i=0; i< length(lhs,rhs); i++)
                dst[i] = gmath.add(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<T> add<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct        
        {
            for(var i=0; i< length(lhs,rhs); i++)
                gmath.add(ref lhs[i],rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Adds a scalar value to each element of the source span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static Span<T> add<T>(Span<T> src, T scalar)
            where T : struct
        {
            for(var i=0; i< src.Length; i++)
                gmath.add(ref src[i],scalar);
            return src;
        }

        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(int8(src),int8(dst));
            else if(typeof(T) == typeof(short))
                math.abs(int16(src),int16(dst));
            else if(typeof(T) == typeof(int))
                math.abs(int32(src),int32(dst));
            else if(typeof(T) == typeof(long))
                math.abs(int64(src),int64(dst));
            else if(typeof(T) == typeof(float))
                fmath.fabs(float32(src),float32(dst));
            else if(typeof(T) == typeof(double))
                fmath.fabs(float64(src),float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

    }

}