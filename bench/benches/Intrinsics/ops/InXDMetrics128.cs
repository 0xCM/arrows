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
    using static Span128;

    class InXDMetrics128 : InXMetrics
    {
        public static Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => Span128.alloc<T>(src.BlockCount);
    }

    public sealed class InXDContext128 : InXContext<InXDConfig128>
    {
        public InXDContext128(InXDConfig128 config, IRandomSource random = null)
            : base(config, random)
        {

        }

        public OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec128, 
                        generic: Genericity.Direct, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

       public Metrics<T> Run<T>(OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
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
                case OpKind.Max:
                    metrics = context.Max(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }
    }

    public sealed class InXNumDContext128 : BenchContext<BlockedConfig128>
    {
        public InXNumDContext128(BlockedConfig128 config, IRandomSource random = null)
            : base(config, random)
        {

        }

        public OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Num128, 
                        generic: Genericity.Direct, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );
                        
        public int Blocks 
            => Config.Blocks;

        public Metrics<T> CaptureMetrics<T>(OpId<T> OpId, Duration WorkTime, Span128<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)Config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());
    }
}