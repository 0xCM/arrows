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
    
    using static zfunc;
    using static As;
    using static InX256GMetrics;

    abstract class InXMetricContext : IMetricConfig
    {
        public IRandomizer Random {get;}

        protected InXMetricContext(IRandomizer random)
        {
            this.Random = Random(random);
        }

        protected abstract InXConfig UntypedConfig {get;}

        public MetricKind Metric 
            => UntypedConfig.Metric;
        
        public int Blocks 
            => UntypedConfig.Blocks;
        
        public int Runs
            => UntypedConfig.Runs;

        public int Cycles
            => UntypedConfig.Cycles;

        public int Samples
            => UntypedConfig.Samples;


    }
    
    class InXMetricContext<T> : InXMetricContext
        where T : InXConfig
    {

        public InXMetricContext(T Config, IRandomizer random = null)
            : base(random)
        {
            this.Config = Config;      
        }
        
        public T Config {get;}

        protected override InXConfig UntypedConfig
            => Config;

    }

    public static class InX256GOps
    {
        static InXMetricContext<T> DefineContext<T>(this T config, IRandomizer random = null)
            where T : InXConfig
                => new InXMetricContext<T>(config, random);
        public static IMetrics RunG(this InXConfig256 config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return config.Run<sbyte>(random, op);
                case PrimalKind.uint8:
                    return config.Run<byte>(random, op);
                case PrimalKind.int16:
                    return config.Run<short>(random, op);
                case PrimalKind.uint16:
                    return config.Run<ushort>(random, op);
                case PrimalKind.int32:
                    return config.Run<int>(random, op);
                case PrimalKind.uint32:
                    return config.Run<uint>(random, op);
                case PrimalKind.int64:
                    return config.Run<long>(random, op);
                case PrimalKind.uint64:
                    return config.Run<ulong>(random, op);
                case PrimalKind.float32:
                    return config.Run<float>(random, op);
                case PrimalKind.float64:                    
                    return config.Run<double>(random, op);
                default:
                    throw unsupported(op, prim);
            }
        }


        static Metrics<T> Run<T>(this InXConfig256 config, IRandomizer random,  OpKind op)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan256<T>(config.Blocks) : random.Span256<T>(config.Blocks);
            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.RunG<T>(op, lhs, rhs);
            return metrics;            
        }

        static Metrics<T> RunG<T>(this InXConfig256 config, OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;

            switch(op)
            {
                case OpKind.Add:
                    metrics = config.AddG<T>(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.SubG<T>(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.MulG<T>(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.DivG<T>(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.AndG<T>(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.OrG<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOrG<T>(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());
            return metrics;

        }

        static Metrics<T> AddAtomicG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block < dst.BlockCount; block++)
                Vec256.store(ginx.add(single(lhs, block),single(rhs, block)), ref dst.Block(block));            
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<T> AddG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.add(lhs, rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<T> SubG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.sub(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<T> MulG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.mul(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<T> DivG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.div(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<T> AndG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

       static Metrics<T> OrG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.or(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

      static Metrics<T> XOrG<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
      {
            var opid = Id<T>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.xor(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
      }

    }
}