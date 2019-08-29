//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zfunc;    
    using static As;


    public static class Vec256Cmp
    {
        [MethodImpl(Inline)]
        public static Vec256Cmp<T> Define<T>(Bit[] Results)
            where T : struct
                => new Vec256Cmp<T>(Results);

        public static Vec256Cmp<T> Define<T>(in Vec256<T> result)                
            where T : unmanaged
        {
            var count = Vec256<T>.Length;
            Span<T> cells = stackalloc T[count];
            ginx.store(in result, ref head(cells));
            
            var dst = new Bit[count];
            for(var i = 0; i< count; i++)
                dst[i] = gmath.nonzero(cells[i]);

            return Define<T>(dst);

        }
    }


}