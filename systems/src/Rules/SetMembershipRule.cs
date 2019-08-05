//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    public enum ItemMembership : byte
    {
        IsMember,

        IsNotMember
    }

    public readonly struct DiscreteMembershipRule<T> : IRule<HashSet<T>, ItemMembership>
        where T : struct
    {
        public readonly HashSet<T> Subject;

        public readonly ItemMembership MemberDisposition;

        ItemMembership IRule<HashSet<T>, ItemMembership>.Param1 
            => throw new NotImplementedException();

        HashSet<T> IRule<HashSet<T>>.Subject 
            => Subject;
    }


    readonly struct DiscreteMembershipEvalutor<T> :  IRuleEvaluator<T, DiscreteMembershipRule<T>,  LiteralExpr<T>>
        where T : struct
    {
        public static readonly DateOrientationEvalutor TheOnly = default;

        public bool Satisfies(DiscreteMembershipRule<T> rule, LiteralExpr<T> test)
            => (rule.MemberDisposition == ItemMembership.IsMember && rule.Subject.Contains(test.Value))
            || (rule.MemberDisposition == ItemMembership.IsNotMember && !rule.Subject.Contains(test.Value));
    }
    
}