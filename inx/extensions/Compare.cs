//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    


    public static class CompareX
    {
        [MethodImpl(Inline)]
        public static Vec128Cmp<T> Gt<T>(in this Vec128<T> lhs, in Vec128<T> rhs )
            where T : struct
                => ginx.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256Cmp<T> Gt<T>(in this Vec256<T> lhs, in Vec256<T> rhs )
            where T : struct
                => ginx.gt(lhs,rhs);

    }

}