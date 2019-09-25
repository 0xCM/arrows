//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static As;

    public static class Vec128Cmp
    {
        [MethodImpl(Inline)]
        public static Vec128Cmp<T> Define<T>(Bit[] Results)
            where T : struct
                => new Vec128Cmp<T>(Results);

        public static Vec128Cmp<T> Define<T>(Vector128<T> result)                
            where T : unmanaged
        {
            var count = Vec128<T>.Length;
            Span<T> cells = stackalloc T[count];
            ginx.store(result, ref head(cells));
            
            var dst = new Bit[count];
            for(var i = 0; i< count; i++)
                dst[i] = gmath.nonzero(cells[i]);

            return Define<T>(dst);
        }
    }


}