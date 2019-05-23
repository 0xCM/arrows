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

    public static class ReadOnlySpanPair
    {
            
    }

    
    public static class NumGMetrics
    {
        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.NumG<T>();

        static MetricConfig Configure(MetricConfig config)
            => config ?? MetricConfig.Default;

        static int Cycles(MetricConfig config)
            => Configure(config).Cycles;

        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        static num<T>[] alloc<T>(int len)
            where T : struct
                => zfunc.alloc<num<T>>(len);
                
        static ReadOnlySpan<num<T>> Numbers<T>(ReadOnlySpan<T> src)
            where T : struct
                => Num.many(src);
        static ReadOnlySpanPair<num<T>> Numbers<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => Num.many(lhs).PairWith(Num.many(rhs));

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
                metrics += Run<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static IMetrics Run(OpKind op, PrimalKind prim, MetricConfig config = null, IRandomizer random = null)
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

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = Abs<T>(src, config);   
                    break;
                case OpKind.Negate:
                    metrics = Abs<T>(src, config);   
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


        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
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
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] + src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] - src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] * src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] / src.Right[sample];                   
            var time = snapshot(sw);
                    
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] % src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> And<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] & src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] | src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> XOr<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var src = Numbers(lhs,rhs);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] ^ src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

       public static Metrics<T> Flip<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var numSrc = Numbers(src);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = ~ numSrc[sample];
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Negate<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var numSrc = Numbers(src);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = -numSrc[sample];
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

       public static Metrics<T> Inc<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var numSrc = Numbers(src);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                {
                    var x = numSrc[sample];
                    dst[sample] = ++x;
                }
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

       public static Metrics<T> Dec<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var numSrc = Numbers(src);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                {
                    var x = numSrc[sample];
                    dst[sample] = --x;
                }
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Abs<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var numSrc = Numbers(src);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = Num.abs(numSrc[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }
 
        public static Metrics<T> Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var src = Numbers(lhs,rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] == src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, 
                map(dst, x => x ? gmath.one<T>() : gmath.zero<T>()));
        }

        public static Metrics<T> Gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var src = Numbers(lhs,rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] > src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
                
        }

        public static Metrics<T> GtEq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.GtEq);
            var src = Numbers(lhs,rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] >= src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static Metrics<T> Lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Lt);
            var src = Numbers(lhs,rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] < src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static Metrics<T> LtEq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.LtEq);
            var src = Numbers(lhs,rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] <= src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }
    }
}