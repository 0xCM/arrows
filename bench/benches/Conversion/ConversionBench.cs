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
    using static BenchRunner;


    public static class ConversionBench
    {
        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var comparison in ConversionBench.Iter())
                comparisons.Add(comparison);
            return comparisons;
        }

        static IEnumerable<MetricComparisonRecord> Iter(bool silent = false)
        {
            var random = Random(null);
            var sources = PrimalKinds.All;
            var targets = items(PrimalKind.int32, PrimalKind.float64, PrimalKind.int64, PrimalKind.uint64);
            var runs = Pow2.T04;
            var cycles = Pow2.T09;
            var samples = Pow2.T09;
            foreach(var src in sources)
            {
                foreach(var dst in targets)
                {
                    GC.Collect();            
                    var dConfig = new ConversionConfig(MetricKind.ConvertD, runs, cycles, samples, src, dst);
                    var dResult = dConfig.Run(random);

                    GC.Collect();            
                    var gConfig = new ConversionConfig(MetricKind.ConvertG, runs, cycles, samples, src, dst);
                    var gResult = gConfig.Run(random);
                    
                    var comparison = dResult.Compare(gResult).ToRecord();            
                    if(!silent)
                        print(comparison.FormatMessage());
                    yield return comparison;
                }
            }            
        }

        

        static Metrics<int> ToI32<S>(this ConversionConfig config, ReadOnlySpan<S> src)
            where S : struct
        {
            var dst = alloc<int>(src.Length);
            var metric = config.Metric;
            var opid =  config.Id<S,int>();
            var opCount = config.Cycles * config.Samples;            

            if(metric == MetricKind.ConvertG)
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    convert(src[sample], out dst[sample]);
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);
            }
            else
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    dst[sample] = (int)Convert.ToInt64(src[sample]);                
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);                
            }                    
        }
        
        public static Metrics<long> ToI64<S>(this ConversionConfig config, ReadOnlySpan<S> src)
            where S : struct
        {
            var dst = alloc<long>(src.Length);
            var metric = config.Metric;
            var opid =  config.Id<S,long>();
            var opCount = config.Cycles * config.Samples;            

            if(metric == MetricKind.ConvertG)
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    convert(src[sample], out dst[sample]);
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);
            }
            else
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    dst[sample] = Convert.ToInt64(src[sample]);                
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);                
            }                    
        }

        public static Metrics<ulong> ToU64<S>(this ConversionConfig config, ReadOnlySpan<S> src)
            where S : struct
        {
            var dst = alloc<ulong>(src.Length);
            var metric = config.Metric;
            var opid =  config.Id<S,ulong>();
            var opCount = config.Cycles * config.Samples;            

            if(metric == MetricKind.ConvertG)
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    convert(src[sample], out dst[sample]);
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);
            }
            else
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    dst[sample] = 0;
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);                
            }                    
        }

        public static Metrics<double> ToFloat64<S>(this ConversionConfig config, ReadOnlySpan<S> src)
            where S : struct
        {
            var dst = alloc<double>(src.Length);
            var metric = config.Metric;
            var opid =  config.Id<S,double>();
            var opCount = config.Cycles * config.Samples;            

            if(metric == MetricKind.ConvertG)
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    convert(src[sample], out dst[sample]);
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);
            }
            else
            {
                var sw = stopwatch();
                for(var cycle = 1; cycle <= config.Cycles; cycle++)
                for(var sample = 0; sample < config.Samples; sample++)
                    dst[sample] = Convert.ToDouble(src[sample]);                
                return opid.CaptureMetrics(opCount, snapshot(sw), dst);                
            }                    
        }


        public static IMetrics Run(this ConversionConfig config, IRandomSource random)        
        {            
            switch(config.SrcType)
            {
                case PrimalKind.int8:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<sbyte>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<sbyte>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<sbyte>(config.Samples, closed<sbyte>(1,SByte.MaxValue));
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<sbyte>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                }
                break;

                case PrimalKind.uint8:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<byte>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<byte>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<byte>(config.Samples);
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<byte>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.int16:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<short>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<short>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<short>(config.Samples, closed<short>(1,short.MaxValue));
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<short>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.uint16:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<ushort>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<ushort>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<ushort>(config.Samples);
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<ushort>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.int32:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<int>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<int>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<int>(config.Samples, closed<int>(1, int.MaxValue));
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<int>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.uint32:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<uint>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<uint>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<uint>(config.Samples);
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<uint>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.int64:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<long>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<long>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<long>(config.Samples, closed<long>(1, long.MaxValue));
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<long>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.uint64:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<ulong>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<ulong>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<ulong>(config.Samples);
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<ulong>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                    
                }
                break;

                case PrimalKind.float32:
                {
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<float>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<float>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<float>(config.Samples);
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<float>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                }
                break;

                case PrimalKind.float64:
                {                    
                    switch(config.DstType)    
                    {
                        case PrimalKind.int8:
                            break;  
                        case PrimalKind.uint8:
                            break;  
                        case PrimalKind.int16:
                            break;  
                        case PrimalKind.uint16:
                            break;  
                        case PrimalKind.int32:
                        {
                            var src = random.ReadOnlySpan<double>(config.Samples);
                            var metrics = Metrics<int>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI32(src);
                            return metrics;            
                        }
                        case PrimalKind.uint32:
                            break;  
                        case PrimalKind.int64:
                        {
                            var src = random.ReadOnlySpan<double>(config.Samples);
                            var metrics = Metrics<long>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToI64(src);
                            return metrics;            
                        }
                        case PrimalKind.uint64:
                        {
                            var src = random.ReadOnlySpan<double>(config.Samples);
                            var metrics = Metrics<ulong>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToU64(src);
                            return metrics;            
                        }
                        case PrimalKind.float32:
                            break;  
                        case PrimalKind.float64:
                        {
                            var src = random.ReadOnlySpan<double>(config.Samples);
                            var metrics = Metrics<double>.Zero;                            
                            for(var i=0; i<config.Runs; i++)
                                metrics += config.ToFloat64(src);
                            return metrics;            
                        }
                    }
                }
                break;
                
            }            

            throw unsupported(config.SrcType, config.DstType);
        }
        
    }
}
