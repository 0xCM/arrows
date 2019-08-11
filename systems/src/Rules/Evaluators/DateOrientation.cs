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


    readonly struct DateOrientationEvalutor
    {
        public static readonly DateOrientationEvalutor TheOnly = default;
        
        public bool Satisfies(DateOrientation rule, LiteralExpr<Date> test)
            => (rule.Orientation == TimeMarker.Before && test.Value < rule.Param1.Value)
            || (rule.Orientation == TimeMarker.After && test.Value > rule.Param1.Value)
            || (rule.Orientation == TimeMarker.Matches &&  test.Value == rule.Param1.Value)
            || (rule.Orientation == TimeMarker.Between && test.Value >= rule.Param1.Value && test.Value <= rule.Param2.Value.Value)
            
            ;                
        
    }


}