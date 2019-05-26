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
    using static As;
    using static Spans;
    using static InXMetrics;
    
    public static class InXMetrics
    {
        static NumericKind InferInXNumKind<N>(bool scalar)
            where N : ITypeNat, new()
        {
            var size = new N().value;
            if(scalar)
            {
                if(size == 128)
                    return NumericKind.Num128;
                else if(size == 256)
                    return NumericKind.Num256;                
            }
            else 
            {
                if(size == 128)
                    return NumericKind.Vec128;
                else if(size == 256)
                    return NumericKind.Vec256;                
            }
            var @class = scalar ? "Num" : "Vec";
            throw unsupported($"Intrinsic {@class}[{size}]");
        }

        static OpId<T> IntrinsicDirect<N,T>(OpKind kind,  bool scalar = false)
            where N : ITypeNat, new()
            where T : struct
                => kind.OpId<T>(NumKind : InferInXNumKind<N>(scalar), generic: false, system: NumericSystem.Intrinsic, operandSize : new N().value/8);

        static OpId<T> IntrinsicGeneric<N,T>(OpKind kind,  bool scalar = false)
            where N : ITypeNat, new()
            where T : struct
                => kind.OpId<T>(NumKind : InferInXNumKind<N>(scalar), generic : true, system: NumericSystem.Intrinsic, operandSize : new N().value/8);

        public static OpId<T> InXId<T>(this OpKind op, InXMetricConfig config = null, bool generic = false)
            where T : struct
                => (config is InXMetricConfig256) 
                  ? (generic ? IntrinsicGeneric<N256,T>(op) :  IntrinsicDirect<N256, T>(op))
                  : (generic ? IntrinsicGeneric<N128,T>(op) :  IntrinsicDirect<N128, T>(op));

        public static InXMetricConfig128 Configure(InXMetricConfig128 config)
            => config ?? InXMetricConfig128.Default;

        public static InXMetricConfig256 Configure(InXMetricConfig256 config)
            => config ?? InXMetricConfig256.Default;

        public static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        public static Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => Span128.alloc<T>(length(lhs,rhs));

        public static Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => Span128.alloc<T>(src.BlockCount);

        public static Span128<T> alloc128<T>(int blocks)
            where T : struct
                => Span128.alloc<T>(blocks);

        public static Span256<T> alloc256<T>(int blocks)
            where T : struct
                => Span256.alloc<T>(blocks);

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => Span256.alloc<T>(lhs.BlockCount);

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => Span256.alloc<T>(src.BlockCount);

        public static Metrics<T> Capture<T>(in OpId<T> OpId, InXMetricConfig config, Duration WorkTime, Span128<T> results)
            where T : struct
                => Metrics.Capture(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());

        public static Metrics<T> Capture<T>(in OpId<T> OpId, InXMetricConfig config, Duration WorkTime, Span256<T> results)
            where T : struct
                => Metrics.Capture(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());
    }
}