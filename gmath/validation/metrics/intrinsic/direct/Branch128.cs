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
    using static As;
    using static InXMetrics;

    partial class InXDirectVec
    {

       public static OpMetrics<T> Branch<T>(OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var metrics = OpMetrics<T>.Zero;
            config = Configure(config);

            switch(op)
            {
                case OpKind.Add:
                    metrics = Add<T>(lhs, rhs, config);   
                break;
                case OpKind.Sub:
                    metrics = Sub<T>(lhs, rhs, config);   
                break;
                case OpKind.Mul:
                    metrics = Mul<T>(lhs, rhs, config);   
                break;
                case OpKind.Div:
                    metrics = Div<T>(lhs, rhs, config);   
                break;
                case OpKind.And:
                    metrics = And<T>(lhs, rhs, config);   
                break;
                case OpKind.Or:
                    metrics = Or<T>(lhs, rhs, config);   
                break;
                case OpKind.XOr:
                    metrics = XOr<T>(lhs, rhs, config);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }


    }

}