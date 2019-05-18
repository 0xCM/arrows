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

    public class OpMetricSpec
    {        
        public static OpMetricSpec Define (OpKind OpKind, NumericSystem NumSystem, NumericKind NumKind, 
            PrimalKind OperandType, OpVariance Variance, ByteSize OperandSize)
                => new OpMetricSpec(OpKind, NumSystem, NumKind, OperandType, Variance, OperandSize);

        public static OpMetricSpec<T> Define<T>(OpKind OpKind, NumericSystem NumSystem, NumericKind NumKind, 
            OpVariance Variance, ByteSize OperandSize)
                where T : struct
                => new OpMetricSpec<T>(OpKind, NumSystem, NumKind, Variance, OperandSize);

        public OpMetricSpec(OpKind OpKind, NumericSystem NumSystem, NumericKind NumKind, PrimalKind OperandType, 
            OpVariance Variance, ByteSize OperandSize)
        {
            this.OpKind = OpKind;
            this.NumSystem = NumSystem;
            this.NumKind = NumKind;
            this.OperandType = OperandType;
            this.Variance = Variance;
            this.OperandSize = OperandSize;
        }
        
        public OpKind OpKind {get;}

        public NumericSystem NumSystem {get;}

        public NumericKind NumKind {get;}

        public PrimalKind OperandType {get;}

        public OpVariance Variance {get;}

        public ByteSize OperandSize {get;}
       
    }

    public class OpMetricSpec<T> : OpMetricSpec
        where T : struct
    {
        public OpMetricSpec(OpKind OpKind, NumericSystem NumSystem, NumericKind NumKind, OpVariance Variance, ByteSize OperandSize)
            : base(OpKind, NumSystem, NumKind, PrimalKinds.kind<T>(), Variance, OperandSize)
        {
        }

    }
}