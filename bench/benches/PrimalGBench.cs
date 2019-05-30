//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Metrics;

    using static PrimalGMetrics;

    using static Bench;
    using static zfunc;

    public static class PrimalGBench
    {
        public static IMetrics Run(this PrimalGConfig config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return config.Run<sbyte>(op, random);
                case PrimalKind.uint8:
                    return config.Run<byte>(op, random);
                case PrimalKind.int16:
                    return config.Run<short>(op, random);
                case PrimalKind.uint16:
                    return config.Run<ushort>(op, random);
                case PrimalKind.int32:
                    return config.Run<int>(op, random);
                case PrimalKind.uint32:
                    return config.Run<uint>(op, random);
                case PrimalKind.int64:
                    return config.Run<long>(op, random);
                case PrimalKind.uint64:
                    return config.Run<ulong>(op, random);
                case PrimalKind.float32:
                    return config.Run<float>(op, random);
                case PrimalKind.float64:                    
                    return config.Run<double>(op, random);
                default:
                    throw unsupported(op, prim);
            }
        }


        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, generic: Genericity.Generic);

        const MetricKind Metric = MetricKind.PrimalG;

        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, IRandomizer random)        
            where T : struct
        {
            var lhs = random.Span<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan<T>(config.Samples) : random.Span<T>(config.Samples);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.Run<T>(op, lhs, rhs);
            return metrics;            
        }

        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Flip:
                    metrics = config.Flip(src);   
                    break;
                case OpKind.Abs:
                    metrics = config.Abs(src);   
                    break;
                case OpKind.Negate:
                    metrics = config.Negate(src);   
                    break;
                case OpKind.Inc:
                    metrics = config.Inc(src);   
                    break;
                case OpKind.Dec:
                    metrics = config.Dec(src);   
                    break;
                case OpKind.Min:
                    metrics = config.Min(src);   
                    break;
                case OpKind.Max:
                    metrics = config.Max(src);   
                    break;
                case OpKind.Square:
                    metrics = config.Square(src);   
                    break;
                case OpKind.Sqrt:
                    metrics = config.Sqrt(src);   
                    break;
                default: 
                    throw unsupported(op, PrimalKinds.kind<T>());
            }
            print(metrics.Describe());

            return metrics;
        }

        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add(lhs, rhs);   
                    break;
                case OpKind.Sub:
                    metrics = config.Sub(lhs, rhs);   
                    break;                
                case OpKind.Mul:
                    metrics = config.Mul(lhs, rhs);   
                    break;                
                case OpKind.Div:
                    metrics = config.Div(lhs, rhs);   
                    break;                
                case OpKind.Mod:
                    metrics = config.Mod(lhs, rhs);   
                    break;                
                case OpKind.And:
                    metrics = config.And(lhs, rhs);   
                    break;                
                case OpKind.Or:
                    metrics = config.Or(lhs, rhs);   
                    break;                
                case OpKind.XOr:
                    metrics = config.XOr(lhs, rhs);   
                    break;                
                case OpKind.Eq:
                    metrics = config.Eq(lhs, rhs);   
                    break;                
                case OpKind.Lt:
                    metrics = config.Lt(lhs, rhs);   
                    break;                
                case OpKind.LtEq:
                    metrics = config.LtEq(lhs, rhs);   
                    break;                
                case OpKind.Gt:
                    metrics = config.Gt(lhs, rhs);   
                    break;                
                case OpKind.GtEq:
                    metrics = config.GtEq(lhs, rhs);   
                    break;                
                default: 
                    throw unsupported(op, PrimalKinds.kind<T>());
            }            

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Negate<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.negate(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Inc<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.inc(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Dec<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.dec(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Square<T>(this PrimalGConfig config, ReadOnlySpan<T> src )
            where T : struct
        {
            var opid =  Id<T>(OpKind.Square);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.square(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Max<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Max);
            var dst = alloc<T>(1);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.max(src);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Min<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Min);
            var dst = alloc<T>(1);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.min(src);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Parse<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Parse);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.parse<T>(src[sample].ToString());
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Add<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;            
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.add(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.mul(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mod<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.mod(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Sqrt<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sqrt);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sqrt(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Flip<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.flip(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Abs<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.abs(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.xor(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Sub<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sub(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Eq<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gt(lhs[sample], rhs[sample]);            
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> Lt<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Lt);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.lt(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> LtEq<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.LtEq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.lteq(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

         public static Metrics<T> Gt<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gt(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> GtEq<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.GtEq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gteq(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> And<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.and(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Or<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.or(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Div<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.div(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }         
    }
}