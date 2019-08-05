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

    public enum IntComparisonKind
    {
        Eq,
        
        NEq,

        Lt,
        
        LtEq,

        Gt,
        
        GtEq
    }

    public readonly struct IntComparisonRule<T> : IRule<T, IntComparisonKind>
        where T : struct
    {
        
        public IntComparisonRule(T Subject, IntComparisonKind Comparison)
        {
            this.Subject = Subject;
            this.Comparison = Comparison;
        }
        
        public readonly T Subject;

        public readonly IntComparisonKind Comparison;

        T IRule<T>.Subject 
            => Subject;

        IntComparisonKind IRule<T, IntComparisonKind>.Param1 
            => Comparison;
    }

    readonly struct IntComparisonEvaluator<T> : IRuleEvaluator<T, IntComparisonRule<T>,  LiteralExpr<T>>
        where T : struct
    {
        public static readonly IntComparisonEvaluator<T> TheOnly = default;

        public bool Satisfies(IntComparisonRule<T> rule, LiteralExpr<T> test)
            => (rule.Comparison == IntComparisonKind.Eq && gmath.eq(rule.Subject, test.Value))
            || (rule.Comparison == IntComparisonKind.NEq && gmath.neq(rule.Subject, test.Value))
            || (rule.Comparison == IntComparisonKind.Lt && gmath.lt(rule.Subject, test.Value))
            || (rule.Comparison == IntComparisonKind.LtEq && gmath.lteq(rule.Subject, test.Value))
            || (rule.Comparison == IntComparisonKind.Gt && gmath.gt(rule.Subject, test.Value))
            || (rule.Comparison == IntComparisonKind.GtEq && gmath.gteq(rule.Subject, test.Value))
            ;
        
    }
}