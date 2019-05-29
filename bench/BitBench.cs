//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Measure
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    
    public static class BitBench    
    {     
        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);





        public static IMetrics Run(MetricKind metric, bool generic, OpKind op, PrimalKind prim,  MetricConfig config, IRandomizer random)
        {

            switch(prim)
            {
                case PrimalKind.int8:
                    return Run<sbyte>(metric, generic, op, config, random);
                case PrimalKind.uint8:
                    return Run<byte>(metric, generic, op, config, random);
                case PrimalKind.int16:
                    return Run<short>(metric, generic, op, config, random);
                case PrimalKind.uint16:
                    return Run<ushort>(metric, generic, op, config, random);
                case PrimalKind.int32:
                    return Run<int>(metric, generic, op, config, random);
                case PrimalKind.uint32:
                    return Run<uint>(metric, generic, op, config, random);
                case PrimalKind.int64:
                    return Run<long>(metric, generic, op, config, random);
                case PrimalKind.uint64:
                    return Run<ulong>(metric, generic, op, config, random);
                default:
                    throw unsupported(op,prim);
            }
            
            throw unsupported(op,prim);
        }

        static Metrics<T> Run<T>(MetricKind metric, bool generic, OpKind op, MetricConfig config, IRandomizer random)
            where T : struct
        {
            var metrics = default(IOpMetric);       
            switch(metric)
            {

                case MetricKind.BitD:
                    switch(op)
                    {
                        case OpKind.ToggleBit:
                            metrics = new ToggleDMetrics();
                            break;
                        case OpKind.Pop:
                            metrics = new PopDMetrics();
                            break;
                        default:
                            throw unsupported(op);
                    }
                break;
                case MetricKind.BitG:
                {
                    switch(op)
                    {
                        case OpKind.ToggleBit:
                            metrics = new ToggleGMetrics();                            
                        break;
                        case OpKind.Pop:
                            metrics = new PopGMetrics();
                            break;
                        default:
                            throw unsupported(op);
                    }
                }
                break;
                default:
                    throw unsupported(metric);
            }
            return metrics.Measure<T>(config, random);
        }

    }

}
