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

    partial class InXVecBench
    {

        public static Metrics<T> Sub<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
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

        public static Metrics<sbyte> Sub(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<byte> Sub(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<short> Sub(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<ushort> Sub(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<int> Sub(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<uint> Sub(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<long> Sub(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<ulong> Sub(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<float> Sub(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<double> Sub(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }
 


    }

}