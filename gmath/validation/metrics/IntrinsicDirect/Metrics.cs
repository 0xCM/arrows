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

    public static partial class IntrinsicDirect
    {
        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.PrimalGeneric<T>(NumericKind.Native);

        static InXMetricConfig<N> Configure<N>(InXMetricConfig<N> config)
            where N : ITypeNat, new()
            => config ?? InXMetricConfig<N>.Default;

        static InXMetricConfig128 Configure(InXMetricConfig128 config)
            => config ?? InXMetricConfig128.Default;

        static InXMetricConfig256 Configure(InXMetricConfig256 config)
            => config ?? InXMetricConfig256.Default;

        static int Cycles(InXMetricConfig128 config)
                => Configure(config).Cycles;

        static int Cycles<N>(InXMetricConfig256 config)
            where N : ITypeNat, new()
                => Configure(config).Cycles;

        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        static Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => zfunc.alloc<T>(length(lhs,rhs));

        static Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => zfunc.alloc<T>(src.Length);

        static OpMetrics<T> metrics<T>(in OpId<T> OpId, InXMetricConfig config, Duration WorkTime, Span128<T> results)
            where T : struct
                => Metrics.Define(OpId, config.Cycles*results.Length, WorkTime, results.Unblock());

        public static OpMetrics<T> Run<T>(OpKind op, InXMetricConfig128 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span128<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan128<T>(config.Samples) : random.Span128<T>(config.Samples);
            
            var metrics = Metrics.Zero<T>();

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Run<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static OpMetrics<T> Run<T>(OpKind op, InXMetricConfig256 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span256<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan256<T>(config.Samples) : random.Span256<T>(config.Samples);
            
            var metrics = Metrics.Zero<T>();

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Run<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static OpMetrics<T> Run<T>(OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var metrics = OpMetrics<T>.Zero;
            config = Configure(config);

            switch(op)
            {
                case OpKind.Add:
                    metrics = Add<T>(lhs, rhs, config);   
                break;
                default: 
                    throw unsupported(op);
            }
            return metrics;
        }

        public static OpMetrics<T> Run<T>(OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            var metrics = OpMetrics<T>.Zero;
            config = Configure(config);

            switch(op)
            {
                default: 
                    throw unsupported(op);
            }
            //return metrics;
        }

        public static IOpMetrics Run(OpKind op, PrimalKind prim, InXMetricConfig128 config, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return Run<sbyte>(op, config, random);
                case PrimalKind.uint8:
                    return Run<byte>(op, config, random);
                case PrimalKind.int16:
                    return Run<short>(op, config, random);
                case PrimalKind.uint16:
                    return Run<ushort>(op, config, random);
                case PrimalKind.int32:
                    return Run<int>(op, config, random);
                case PrimalKind.uint32:
                    return Run<uint>(op, config, random);
                case PrimalKind.int64:
                    return Run<long>(op, config, random);
                case PrimalKind.uint64:
                    return Run<ulong>(op, config, random);
                case PrimalKind.float32:
                    return Run<float>(op, config, random);
                case PrimalKind.float64:                    
                    return Run<double>(op, config, random);
                default:
                    throw unsupported(op, prim);
            }
        }

        public static IOpMetrics Run(OpKind op, PrimalKind prim, InXMetricConfig256 config, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return Run<sbyte>(op, config, random);
                case PrimalKind.uint8:
                    return Run<byte>(op, config, random);
                case PrimalKind.int16:
                    return Run<short>(op, config, random);
                case PrimalKind.uint16:
                    return Run<ushort>(op, config, random);
                case PrimalKind.int32:
                    return Run<int>(op, config, random);
                case PrimalKind.uint32:
                    return Run<uint>(op, config, random);
                case PrimalKind.int64:
                    return Run<long>(op, config, random);
                case PrimalKind.uint64:
                    return Run<ulong>(op, config, random);
                case PrimalKind.float32:
                    return Run<float>(op, config, random);
                case PrimalKind.float64:                    
                    return Run<double>(op, config, random);
                default:
                    throw unsupported(op, prim);
            }
        }

        public static OpMetrics<T> Add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Add(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Add(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Add(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Add(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Add(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Add(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Add(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Add(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Add(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Add(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }
   }
}