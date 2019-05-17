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

    public static class PrimalGMetrics
    {
        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.PrimalGeneric<T>(NumericKind.Native);

        static MetricConfig Configure(MetricConfig config)
            => config ?? MetricConfig.Default;

        static int Cycles(MetricConfig config)
            => Configure(config).Cycles;

        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);


        public static OpMetrics<T> Run<T>(OpKind op, MetricConfig config = null, IRandomizer random = null)        
            where T : struct
        {
            config = Configure(config);    
            random = Random(random);
            var lhs = random.Span<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan<T>(config.Samples) : random.Span<T>(config.Samples);
            
            var metrics = Metrics.Zero<T>();

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Run<T>(op, lhs, rhs, config);
            return metrics;            
        }


        public static IOpMetrics Run(OpKind op, PrimalKind prim, MetricConfig config = null, IRandomizer random = null)
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
                    throw unsupported(op, prim);
            }
        }

        public static OpMetrics<T> Run<T>(OpKind op, ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var metrics = OpMetrics<T>.Zero;
            switch(op)
            {
                case OpKind.Flip:
                    metrics = Flip<T>(src, config);   
                    break;
                case OpKind.Abs:
                    metrics = Abs<T>(src, config);   
                    break;
                case OpKind.Negate:
                    metrics = Abs<T>(src, config);   
                    break;
                case OpKind.Inc:
                    metrics = Inc<T>(src, config);   
                    break;
                case OpKind.Dec:
                    metrics = Inc<T>(src, config);   
                    break;
                case OpKind.Min:
                    metrics = Min<T>(src, config);   
                    break;
                case OpKind.Max:
                    metrics = Max<T>(src, config);   
                    break;
                case OpKind.Square:
                    metrics = Square<T>(src, config);   
                    break;
                case OpKind.Sqrt:
                    metrics = Sqrt<T>(src, config);   
                    break;
                default: 
                    throw unsupported<T>(op, PrimalKinds.kind<T>());
            }
            print(metrics.Describe());

            return metrics;
        }

        public static OpMetrics<T> Run<T>(OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var metrics = OpMetrics<T>.Zero;
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
                case OpKind.Lt:
                    metrics = Lt<T>(lhs, rhs, config);   
                    break;                
                case OpKind.LtEq:
                    metrics = LtEq<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Gt:
                    metrics = Gt<T>(lhs, rhs, config);   
                    break;                
                case OpKind.GtEq:
                    metrics = GtEq<T>(lhs, rhs, config);   
                    break;                
                default: 
                    throw unsupported<T>(op, PrimalKinds.kind<T>());
            }            

            print(metrics.Describe());

            return metrics;
        }

        public static OpMetrics<T> Add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.add(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sub(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.mul(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.div(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
                    
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.mod(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> And<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.and(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.or(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> XOr<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.xor(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

       public static OpMetrics<T> Flip<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.flip(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.eq(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, 
                map(dst, x => x ? gmath.one<T>() : gmath.zero<T>()));
        }

        public static OpMetrics<T> Gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gt(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
                
        }

        public static OpMetrics<T> GtEq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.GtEq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                    dst[sample] = gmath.gteq(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static OpMetrics<T> Lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Lt);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                    dst[sample] = gmath.lt(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static OpMetrics<T> LtEq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.LtEq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                    dst[sample] = gmath.lteq(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static OpMetrics<T> Negate<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.negate(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Inc<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.inc(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Dec<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.dec(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Abs<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.abs(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }
 
        public static OpMetrics<T> Sqrt<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sqrt);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sqrt(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Square<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Square);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.square(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Max<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Max);
            var dst = alloc<T>(1);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.max(src);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Min<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Min);
            var dst = alloc<T>(1);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.min(src);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static OpMetrics<T> Parse<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Parse);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.parse<T>(src[sample].ToString());
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }
    }
}