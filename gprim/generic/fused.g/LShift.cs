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

    public static partial class fused
    {


        [MethodImpl(Inline)]
        public static ref Span<T> lshift<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, ref Span<T> dst)
            where T : struct
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.lshift(lhs[i],rhs[i]);
            return ref dst;
        }

    }

}