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

    /// <summary>
    /// A rule that is satisfied when an element is/is not a member of a specified set
    /// as determined by the membership test
    /// </summary>
    public readonly struct MembershipExpr<T> : IRuleExpr<HashSet<T>>
    {
        public MembershipExpr(MembershipTest test, HashSet<T> Value)
        {
            this.Test = test;
            this.Value = Value;
        }
        
        public readonly MembershipTest Test;

        public HashSet<T> Value {get;}

    }
    
}