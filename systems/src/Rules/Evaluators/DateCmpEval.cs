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


    readonly struct DateCmpEval
    {
        public static readonly DateCmpEval TheOnly = default;
        
        public bool Satisfies(DateCmpExpr rule, LiteralExpr<Date> test)
            => (rule.Kind == TimeMarker.Before && test.Value < rule.Param1.Value)
            || (rule.Kind == TimeMarker.After && test.Value > rule.Param1.Value)
            || (rule.Kind == TimeMarker.Matches &&  test.Value == rule.Param1.Value)
            || (rule.Kind == TimeMarker.Between && test.Value >= rule.Param1.Value && test.Value <= rule.Param2.Value.Value)
            
            ;                
        
    }


}