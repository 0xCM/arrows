//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    class InXGMetrics256 : InXMetrics
    { 
        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec256, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );
    }

    public sealed class InXGContext256 : InXContext<InXGConfig256>         
    {

        public OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec256, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );


        public InXGContext256(InXGConfig256 config, IRandomSource random = null)
            : base(config, random)
        {

        }

        public Metrics<T> Run<T>(OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            var context = this;
            switch(op)
            {
                case OpKind.Add:
                    metrics = context.Add<T>(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = context.Sub<T>(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = context.Mul<T>(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = context.Div<T>(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = context.And<T>(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = context.Or<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = context.XOr<T>(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());
            return metrics;
        }
    }
}