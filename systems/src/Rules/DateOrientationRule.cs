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

    /// <summary>
    /// Classifies the chronological disposition of one date with respect to another
    /// </summary>
    public enum DateOrientation : byte
    {
        /// <summary>
        /// Indicates a subject date is strictly less than the comperand
        /// </summary>
        Precedes,
        
        /// <summary>
        /// Indicates a subject date is identical to the comperand
        /// </summary>
        Matches,
        
        /// <summary>
        /// Indicates a subject date is strictly greater than the comperand
        /// </summary>
        Follows
    }

    /// <summary>
    /// Defines a rule that is satisfied when a comperand precedes, matches
    /// or follows a subject according to the orientation parameter
    /// </summary>
    public readonly struct DateOrientationRule : IRule<Date, DateOrientation>
    {
        public readonly Date Subject;

        public readonly DateOrientation Orientation;

        public DateOrientation Param1 
            => Orientation;

        Date IRule<Date>.Subject 
            => Subject;
    }

    readonly struct DateOrientationEvalutor : IRuleEvaluator<Date, DateOrientationRule,  LiteralExpr<Date>>
    {
        public static readonly DateOrientationEvalutor TheOnly = default;
        
        public bool Satisfies(DateOrientationRule rule, LiteralExpr<Date> test)
            => (rule.Orientation == DateOrientation.Precedes && test.Value < rule.Subject)
            || (rule.Orientation == DateOrientation.Follows && test.Value > rule.Subject)
            || (rule.Orientation == DateOrientation.Matches &&  test.Value == rule.Subject);                
        
    }
}