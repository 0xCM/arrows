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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static long dot(Vec256<int> lhs, Vec256<int> rhs)
        {
            var product = mul(lhs,rhs);
            var sum = add(lo(product),hi(product));
            var span = sum.ToSpan128();
            return span[0] + span[1];
            
        }
    }

}