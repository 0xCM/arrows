//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    readonly struct DiscreteMembershipEvalutor<T>
        where T : struct
    {
        public static readonly DateOrientationEvalutor TheOnly = default;

        public bool Satisfies(DiscreteMembership<T> rule, LiteralExpr<T> test)
            => (rule.MemberDisposition == ItemMembership.IsMember && rule.Param.Contains(test.Value))
            || (rule.MemberDisposition == ItemMembership.IsNotMember && !rule.Param.Contains(test.Value));
    }


}