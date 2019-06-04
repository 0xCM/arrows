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
    using Z0.Metrics;
    
    using static zfunc;
    using static As;
    using static BenchRunner;
    
    public static class InXDBench
    {
        public static Metrics<T> Run<T>(this InXDConfig128 config, OpKind op, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan128<T>(config.Blocks) 
                : random.Span128<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.Measure<T>(op, lhs, rhs);
            return metrics;            
        }

        public static Metrics<T> Run<T>(this InXDConfig256 config, OpKind op, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan256<T>(config.Blocks) 
                : random.Span256<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i < config.Runs; i++)
                metrics += config.Measure<T>(op, lhs, rhs);
            return metrics;            
        }

        public static IMetrics Run(this InXDConfig128 config, OpKind op, PrimalKind prim, IRandomizer random = null)
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

        public static IMetrics Run(this InXDConfig256 config, OpKind op, PrimalKind prim, IRandomizer random = null)
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


    }


}
