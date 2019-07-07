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

    public static class BitBench    
    {   
        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var ops = items(OpKind.Toggle, OpKind.Pop, OpKind.Enable, OpKind.Disable, OpKind.Test);
            var prims = PrimalKinds.IntList;
            var optypes =from o in ops from p in prims select OpType.Define(o,p);
            var config = MetricConfig.Define(MetricKind.BitG, runs: Pow2.T03, cycles: Pow2.T12, samples: Pow2.T11);
            var context = BitGContext.Define(config, Random(null));
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  context.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;
        }

        static MetricComparisonRecord RunComparison(this BitGContext ctxG, OpType op, bool silent = false)
        {
            var ctxD = new BitDContext(ctxG.Config, Random(null));            
            var m1 = ctxD.Run(MetricKind.BitD, false, op.Op, op.Primitive);
            var m2 = ctxG.Run(MetricKind.BitG, true, op.Op, op.Primitive);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }

        public static IMetrics Run(this BitDContext context, MetricKind metric, bool generic, OpKind op, PrimalKind prim)              
        {
            switch(prim)
            {
                case PrimalKind.int8:
                    return context.Run<sbyte>(metric, generic, op);
                case PrimalKind.uint8:
                    return context.Run<byte>(metric, generic, op);
                case PrimalKind.int16:
                    return context.Run<short>(metric, generic, op);
                case PrimalKind.uint16:
                    return context.Run<ushort>(metric, generic, op);
                case PrimalKind.int32:
                    return context.Run<int>(metric, generic, op);
                case PrimalKind.uint32:
                    return context.Run<uint>(metric, generic, op);
                case PrimalKind.int64:
                    return context.Run<long>(metric, generic, op);
                case PrimalKind.uint64:
                    return context.Run<ulong>(metric, generic, op);
                default:
                    throw unsupported(op,prim);
            }
            
            throw unsupported(op,prim);
        }
        
        static IMetrics Run(this BitGContext context, MetricKind metric, bool generic, OpKind op, PrimalKind prim)
        {

            switch(prim)
            {
                case PrimalKind.int8:
                    return context.Run<sbyte>(metric, generic, op);
                case PrimalKind.uint8:
                    return context.Run<byte>(metric, generic, op);
                case PrimalKind.int16:
                    return context.Run<short>(metric, generic, op);
                case PrimalKind.uint16:
                    return context.Run<ushort>(metric, generic, op);
                case PrimalKind.int32:
                    return context.Run<int>(metric, generic, op);
                case PrimalKind.uint32:
                    return context.Run<uint>(metric, generic, op);
                case PrimalKind.int64:
                    return context.Run<long>(metric, generic, op);
                case PrimalKind.uint64:
                    return context.Run<ulong>(metric, generic, op);
                default:
                    throw unsupported(op,prim);
            }
            
            throw unsupported(op,prim);
        }

    }

}
