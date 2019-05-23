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

    public static partial class PrimalDMetrics
    {
        
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.PrimalDirect<T>(NumericKind.Native);        
        
        static T[] alloc<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => zfunc.alloc<T>(length(lhs,rhs));

        static T[] alloc<T>(ReadOnlySpan<T> src)
            where T : struct
                => zfunc.alloc<T>(src.Length);

        static int Cycles(MetricConfig config)
            => (config ?? MetricConfig.Default).Cycles;

        static bool DirectOps(MetricConfig config)
            => Configure(config).DirectOps;

        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        static MetricConfig Configure(MetricConfig config)
            => config ?? MetricConfig.Default;

        static T[] ToScalars<T>(this bool[] src, OpId<T> opid)
            where T : struct
                => src.ToScalars<T>();

        public static Metrics<T> Run<T>(OpKind op, MetricConfig config = null, IRandomizer random = null)        
            where T : struct
        {
            config = Configure(config);
            random = Random(random);
            var lhs = random.Span<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan<T>(config.Samples) : random.Span<T>(config.Samples);
            var metrics = Metrics.Zero<T>();

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Run<T>(op, lhs,rhs,config);
            return metrics;            
        }

        public static IMetrics Run(OpKind op, PrimalKind prim,  MetricConfig config = null, IRandomizer random = null)
        {
            config = Configure(config);
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
                    throw unsupported(prim);
            }
        }

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Configure(config);
            switch(op)
            {
                case OpKind.Add:
                    metrics = Add<T>(lhs,rhs, config);   
                break;
                case OpKind.Sub:
                    metrics = Sub<T>(lhs,rhs, config);   
                break;
                case OpKind.Mul:
                    metrics = Mul<T>(lhs,rhs, config);   
                break;
                case OpKind.Div:
                    metrics = Div<T>(lhs,rhs, config);   
                break;
                case OpKind.Mod:
                    metrics = Mod<T>(lhs, rhs, config);   
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
                case OpKind.Eq:
                    metrics = Eq<T>(lhs, rhs, config);   
                break;
                case OpKind.Gt:
                    metrics = Gt<T>(lhs, rhs, config);   
                break;
                case OpKind.GtEq:
                    metrics = GtEq<T>(lhs, rhs, config);   
                break;
                case OpKind.Lt:
                    metrics = Lt<T>(lhs, rhs, config);   
                break;
                case OpKind.LtEq:
                    metrics = LtEq<T>(lhs, rhs, config);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            config = Configure(config);
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = Abs<T>(src, config);   
                break;
                case OpKind.Negate:
                    metrics = Negate<T>(src, config);   
                break;
                case OpKind.Flip:
                    metrics = Flip<T>(src, config);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }


        public static Metrics<T> Add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
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

        public static Metrics<T> Sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Sub(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Sub(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Sub(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Sub(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Sub(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Sub(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Sub(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Sub(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Sub(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Sub(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Mul(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Mul(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Mul(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Mul(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Mul(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Mul(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Mul(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Mul(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Mul(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Mul(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Div(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Div(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Div(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Div(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Div(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Div(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Div(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Div(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Div(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Div(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Mod(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Mod(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Mod(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Mod(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Mod(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Mod(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Mod(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Mod(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Mod(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Mod(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> And<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return And(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return And(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return And(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return And(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return And(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return And(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return And(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return And(uint64(lhs), uint64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Or(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Or(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Or(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Or(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Or(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Or(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Or(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Or(uint64(lhs), uint64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }


        public static Metrics<T> Negate<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Negate(int8(src), config).As<T>();
                case PrimalKind.int16:
                    return Negate(int16(src), config).As<T>();
                case PrimalKind.int32:
                    return Negate(int32(src), config).As<T>();
                case PrimalKind.int64:
                    return Negate(int64(src), config).As<T>();
                case PrimalKind.float32:
                    return Negate(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Negate(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> XOr<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return XOr(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return XOr(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return XOr(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return XOr(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return XOr(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return XOr(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return XOr(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return XOr(uint64(lhs), uint64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Eq(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Eq(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Eq(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Eq(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Eq(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Eq(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Eq(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Eq(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Eq(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Eq(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Gt(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Gt(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Gt(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Gt(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Gt(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Gt(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Gt(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Gt(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Gt(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Gt(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> GtEq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return GtEq(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return GtEq(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return GtEq(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return GtEq(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return GtEq(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return GtEq(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return GtEq(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return GtEq(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return GtEq(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return GtEq(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Lt(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Lt(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Lt(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Lt(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Lt(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Lt(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Lt(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Lt(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Lt(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Lt(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> LtEq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return LtEq(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return LtEq(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return LtEq(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return LtEq(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return LtEq(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return LtEq(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return LtEq(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return LtEq(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return LtEq(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return LtEq(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<T> Abs<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Abs(int8(src), config).As<T>();
                case PrimalKind.int16:
                    return Abs(int16(src), config).As<T>();
                case PrimalKind.int32:
                    return Abs(int32(src), config).As<T>();
                case PrimalKind.int64:
                    return Abs(int64(src), config).As<T>();
                case PrimalKind.float32:
                    return Abs(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Abs(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

       public static Metrics<T> Flip<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return Flip(int8(src), config).As<T>();
                case PrimalKind.uint8:
                    return Flip(uint8(src), config).As<T>();
                case PrimalKind.int16:
                    return Flip(int16(src), config).As<T>();
                case PrimalKind.uint16:
                    return Flip(uint16(src), config).As<T>();
                case PrimalKind.int32:
                    return Flip(int32(src), config).As<T>();
                case PrimalKind.uint32:
                    return Flip(uint32(src), config).As<T>();
                case PrimalKind.int64:
                    return Flip(int64(src), config).As<T>();
                case PrimalKind.uint64:
                    return Flip(uint64(src), config).As<T>();
                case PrimalKind.float32:
                    return Flip(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Flip(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }
    }

}