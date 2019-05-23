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

        public static Metrics<T> And<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return And(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return And(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return And(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return And(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return And(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return And(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return And(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return And(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return And(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return And(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<sbyte> And(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<byte> And(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<short> And(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<ushort> And(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<int> And(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<uint> And(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<long> And(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<ulong> And(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<float> And(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<double> And(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }
 


    }

}