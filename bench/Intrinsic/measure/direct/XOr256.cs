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
    using static As;
    using static InXMetrics;
    using static InX256DMetrics;

    public static class XOrInX256D
    {

        public static Metrics<T> XOr<T>(this InXMetricConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct        
                => XOr(lhs,rhs,config);

        public static Metrics<T> XOr<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return XOr(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return XOr(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return XOr(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return XOr(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return XOr(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return XOr(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return XOr(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return XOr(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return XOr(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return XOr(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<sbyte> XOr(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<byte> XOr(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<short> XOr(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<ushort> XOr(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<int> XOr(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<uint> XOr(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<long> XOr(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<ulong> XOr(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<float> XOr(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        static Metrics<double> XOr(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }
 


    }

}