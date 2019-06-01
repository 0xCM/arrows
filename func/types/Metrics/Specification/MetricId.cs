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

    public readonly struct MetricId
    {
        public static MetricId Define(MetricKind Classifier, PrimalKind Primitive, OpKind Operator)
            => new MetricId(Classifier, Primitive, Operator);
        
        public static implicit operator (MetricKind Classifier, PrimalKind Primitive, OpKind Operator)(MetricId metric) 
            => (metric.Classifier, metric.Primitive, metric.Operator);

        public MetricId(MetricKind Classifier, PrimalKind Primitive, OpKind Operator)
        {
            this.Classifier = Classifier;
            this.Primitive = Primitive;
            this.Operator = Operator;
        }
        
        public readonly MetricKind Classifier;

        public readonly PrimalKind Primitive;

        public readonly OpKind Operator;
    }


}