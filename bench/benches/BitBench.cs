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
    
    using static BenchTools;

    public static class BitBench    
    {   
        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, BitDConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(metric, false, op, prim, Random(random));

        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, BitGConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(metric, true, op, prim, Random(random));

        public static MetricComparisonRecord RunComparison(this BitGConfig config, OpType op, bool silent = false)
        {
            var m1 = MetricKind.BitD.Measure(op.Op, op.Primitive, config.ToDirect());
            var m2 = MetricKind.BitG.Measure(op.Op, op.Primitive, config);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }


        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var ops = items(OpKind.Toggle, OpKind.Pop);
            var prims = PrimalKinds.Integral;
            var optypes =from o in ops from p in prims select OpType.Define(o,p);
            var config = BitGConfig.Define(MetricKind.BitG, runs: Pow2.T03, cycles: Pow2.T12, samples: Pow2.T11);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;
        }

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
                case OpKind.Toggle:
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
                case OpKind.Toggle:
                    return new ToggleGMetrics().Measure<T>(config, random);                            
                case OpKind.Pop:
                    return new PopGMetrics().Measure<T>(config, random);                            ;
                default:
                    throw unsupported(op);

            }            
        }

    }

}
