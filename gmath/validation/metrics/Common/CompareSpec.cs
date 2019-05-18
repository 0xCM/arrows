//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static mfunc;


    public readonly struct MetricComparisonSpec
    {
        public static MetricComparisonSpec Define<T>(MetricKind Baseline, MetricKind Bench, PrimalKind Primitive, OpKind Operator)
            where T : struct
                => new MetricComparisonSpec(Baseline, Bench, PrimalKinds.kind<T>(), Operator);

        public static MetricComparisonSpec Define(MetricKind Baseline, MetricKind Bench, PrimalKind Primitive, OpKind Operator)
            => new MetricComparisonSpec(Baseline, Bench, Primitive, Operator);

        public MetricComparisonSpec(MetricKind Baseline, MetricKind Bench, PrimalKind Primitive, OpKind Operator)        
        {
            this.BaseKind = Baseline;
            this.BenchKind = Bench;
            this.Primitive= Primitive;
            this.Operator = Operator;
        }
        
        public readonly MetricKind BaseKind {get;} 

        public readonly MetricKind BenchKind {get;}

        public readonly PrimalKind Primitive {get;}

        public readonly OpKind Operator {get;}

        public MetricId BaselineId
            => BaseKind.Identify(Primitive, Operator);
        
        public MetricId BenchId
            => BenchKind.Identify(Primitive, Operator);    
    }

}