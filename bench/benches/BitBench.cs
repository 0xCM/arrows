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

    public static class BitBench    
    {   
        public static IMetrics Run(this BitDConfig config, MetricKind metric, bool generic, OpKind op, PrimalKind prim, IRandomizer random)              
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
        public static IMetrics Run(this BitGConfig config, MetricKind metric, bool generic, OpKind op, PrimalKind prim,  IRandomizer random)
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

        static Metrics<T> Run<T>(MetricKind metric, bool generic, OpKind op, BitDConfig config, IRandomizer random)
            where T : struct
        {
            switch(op)
            {
                case OpKind.ToggleBit:
                    return new ToggleDMetrics().Measure<T>(config, random);
                case OpKind.Pop:
                    return new PopDMetrics().Measure<T>(config, random);
                default:
                    throw unsupported(op);

            }            

        }

        static Metrics<T> Run<T>(MetricKind metric, bool generic, OpKind op, BitGConfig config, IRandomizer random)
            where T : struct
        {
            switch(op)
            {
                case OpKind.ToggleBit:
                    return new ToggleGMetrics().Measure<T>(config, random);                            
                case OpKind.Pop:
                    return new PopGMetrics().Measure<T>(config, random);                            ;
                default:
                    throw unsupported(op);

            }            
        }

    }

}
