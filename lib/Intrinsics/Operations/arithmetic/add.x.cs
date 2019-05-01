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
    
    using static zcore;
    using static inxfunc;
    using static vec128;


    partial class InXX
    {
        [MethodImpl(Inline)]
        public static Index<T> AddG<T>(this Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => InXFusionOps.add(lhs,rhs);
                 
        
    }
}