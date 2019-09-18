//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {

        public static Span<T> and<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            for(var i=0; i<lhs.Length; i++)
                and(in lhs[i],in rhs, ref lhs[i]);
            return lhs;
        }

        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                and(in lhs[i], in rhs[i], ref dst[i]);
            return dst;
        }

        public static Span<T> and<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                and(in lhs[i], in rhs[i], ref lhs[i]);
            return lhs;
        }


    }
}