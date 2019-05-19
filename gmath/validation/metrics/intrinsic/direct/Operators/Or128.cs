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

    partial class InXDirectVec
    {

        public static OpMetrics<T> Or<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Or(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Or(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Or(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Or(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Or(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Or(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Or(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Or(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Or(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Or(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static OpMetrics<sbyte> Or(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<byte> Or(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<short> Or(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<ushort> Or(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<int> Or(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<uint> Or(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<long> Or(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<ulong> Or(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<float> Or(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<double> Or(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }
 


    }

}