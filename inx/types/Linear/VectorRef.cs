//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    public static class VectorRef
    {
        [MethodImpl(Inline)]
        public static ref Covector<N,T> Add<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.add(ref x, y);
            return ref lhs;
        }

    }


}