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
        
    using static zfunc;
    using static Bench;
    using static NumGMetrics;

    public static class NumGBench
    {            
        const MetricKind Metric = MetricKind.NumG;

        public static IMetrics Run(this NumGConfig config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            config = Metric.Configure(config);    
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
                    throw unsupported(prim);
            }
        }

       static Metrics<T> Run<T>(this NumGConfig config, OpKind op, IRandomizer random)        
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

        static Metrics<T> Run<T>(this NumGConfig config, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = config.Abs<T>(src);   
                    break;
                case OpKind.Negate:
                    metrics = config.Negate<T>(src);   
                    break;
                case OpKind.Flip:
                    metrics = config.Flip<T>(src);   
                    break;
                default: 
                    throw unsupported(op);
            }
            print(metrics.Describe());

            return metrics;
        }

        static Metrics<T> Run<T>(this NumGConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add<T>(lhs, rhs);   
                    break;
                case OpKind.Sub:
                    metrics = config.Sub<T>(lhs, rhs);   
                    break;                
                case OpKind.Mul:
                    metrics = config.Mul<T>(lhs, rhs);   
                    break;                
                case OpKind.Div:
                    metrics = config.Div<T>(lhs, rhs);   
                    break;                
                case OpKind.Mod:
                    metrics = config.Mod<T>(lhs, rhs);   
                    break;                
                case OpKind.And:
                    metrics = config.And<T>(lhs, rhs);   
                    break;                
                case OpKind.Or:
                    metrics = config.Or<T>(lhs, rhs);   
                    break;                
                case OpKind.XOr:
                    metrics = config.XOr<T>(lhs, rhs);   
                    break;                
                case OpKind.Eq:
                    metrics = config.Eq<T>(lhs, rhs);   
                    break;                
                case OpKind.Lt:
                    metrics = config.Lt<T>(lhs, rhs);   
                    break;                
                case OpKind.LtEq:
                    metrics = config.LtEq<T>(lhs, rhs);   
                    break;                
                case OpKind.Gt:
                    metrics = config.Gt<T>(lhs, rhs);   
                    break;                
                case OpKind.GtEq:
                    metrics = config.GtEq<T>(lhs, rhs );   
                    break;                
                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }
 
        public static Metrics<T> Abs<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = Num.abs(numSrc[sample]);
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
 

         public static Metrics<T> And<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] & src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Add<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] + src.Right[sample];                               
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Flip<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                 dst[sample] = ~ numSrc[sample];
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> GtEq<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.GtEq);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] >= src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static Metrics<T> Div<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] / src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mod<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] % src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Negate<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = -numSrc[sample];
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Dec<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
            {
                var x = numSrc[sample];
                dst[sample] = --x;
            }

            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Gt<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] > src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> Eq<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] == src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

       public static Metrics<T> Inc<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
            {
                var x = numSrc[sample];
                dst[sample] = ++x;
            }
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] ^ src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Lt<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Lt);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] < src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static Metrics<T> Sub<T>(this NumGConfig config,ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] - src.Right[sample];                               
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

 
         public static Metrics<T> LtEq<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.LtEq);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] <= src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }
 
         public static Metrics<T> Or<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] | src.Right[sample];                                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] * src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

    }
}