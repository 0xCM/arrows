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
        public static OpMetrics<T> Sub<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Sub(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Sub(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Sub(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Sub(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Sub(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Sub(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Sub(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Sub(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Sub(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Sub(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static OpMetrics<sbyte> Sub(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<byte> Sub(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<short> Sub(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<ushort> Sub(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<int> Sub(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<uint> Sub(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<long> Sub(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.Sub, config);
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<ulong> Sub(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<float> Sub(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static OpMetrics<double> Sub(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }
    }
}