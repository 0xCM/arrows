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


    readonly struct ScalarComparisonEvaluator<T> 
        where T : struct
    {
        public static readonly ScalarComparisonEvaluator<T> TheOnly = default;

        public bool Satisfies(ScalarComparison<T> rule, LiteralExpr<T> test)
            => (rule.Comparison == ScalarComparisonKind.Eq && gmath.eq(rule.Param, test.Value))
            || (rule.Comparison == ScalarComparisonKind.NEq && gmath.neq(rule.Param, test.Value))
            || (rule.Comparison == ScalarComparisonKind.Lt && gmath.lt(rule.Param, test.Value))
            || (rule.Comparison == ScalarComparisonKind.LtEq && gmath.lteq(rule.Param, test.Value))
            || (rule.Comparison == ScalarComparisonKind.Gt && gmath.gt(rule.Param, test.Value))
            || (rule.Comparison == ScalarComparisonKind.GtEq && gmath.gteq(rule.Param, test.Value))
            ;
        
    }
}