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
    using static InXMetrics;


    
    public static partial class InXDirectVec
    {
        static OpId<T> Id<T>(OpKind op, InXMetricConfig128 config)
            where T : struct
                => op.InXId<T>(config, false);

        static OpId<T> Id<T>(OpKind op, InXMetricConfig256 config)
            where T : struct
                => op.InXId<T>(config, false);

        public static Metrics<T> Run<T>(OpKind op, InXMetricConfig128 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan128<T>(config.Blocks) : random.Span128<T>(config.Blocks);            
            var metrics = Metrics.Zero<T>();

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Branch<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static Metrics<T> Run<T>(OpKind op, InXMetricConfig256 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan256<T>(config.Blocks) : random.Span256<T>(config.Blocks);            
            var metrics = Metrics.Zero<T>();

            GC.Collect();            
            for(var i=0; i < config.Runs; i++)
                metrics += Branch<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static IMetrics Run(OpKind op, PrimalKind prim, InXMetricConfig128 config, IRandomizer random = null)
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

        public static IMetrics Run(OpKind op, PrimalKind prim, InXMetricConfig256 config, IRandomizer random = null)
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
   }
}