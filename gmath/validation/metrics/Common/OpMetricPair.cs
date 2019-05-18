//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    public class OpMetricPair
    {
        public static OpMetricPair Define(OpMetricSpec LeftMetric, OpMetricSpec RightMetric)
            => new OpMetricPair(LeftMetric, RightMetric);
        
        public OpMetricPair(OpMetricSpec LeftMetric, OpMetricSpec RightMetric)
        {
            this.LeftMetric = LeftMetric;
            this.RightMetric = RightMetric;
        }
        
        public OpMetricSpec LeftMetric {get;}

        public OpMetricSpec RightMetric {get;}

    }

}