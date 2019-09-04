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

    readonly struct PrimalCmpEval<T> 
        where T : struct
    {
        public static readonly PrimalCmpEval<T> TheOnly = default;

        public bool Satisfies(PrimalCmpExpr<T> rule, LiteralExpr<T> test)
            => (rule.Kind == PrimalCmpKind.Eq && gmath.eq(rule.Value, test.Value))
            || (rule.Kind == PrimalCmpKind.NEq && gmath.neq(rule.Value, test.Value))
            || (rule.Kind == PrimalCmpKind.Lt && gmath.lt(rule.Value, test.Value))
            || (rule.Kind == PrimalCmpKind.LtEq && gmath.lteq(rule.Value, test.Value))
            || (rule.Kind == PrimalCmpKind.Gt && gmath.gt(rule.Value, test.Value))
            || (rule.Kind == PrimalCmpKind.GtEq && gmath.gteq(rule.Value, test.Value))
            ;
        
    }
}