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
    using static As;
    using static Span256;


    class InXDMetrics256 : InXMetrics
    {

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                =>  Span256.alloc<T>(lhs, rhs);

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => Span256.alloc<T>(src.BlockCount);
    }

    public sealed class InXDContext256 : InXContext<InXDConfig256>         
    {
        public OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec256, 
                        generic: Genericity.Direct, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public InXDContext256(InXDConfig256 config, IRandomizer random = null)
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
                    metrics = context.Add(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = context.Sub(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = context.Mul(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = context.Div(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = context.And(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = context.Or(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = context.XOr(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;        
        }
    }

}