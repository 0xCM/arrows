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
    
    using static zfunc;
    using static As;
    using static InX128DMetrics;

    public static class XOrInX128D
    {
        public static Metrics<T> XOrD<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                =>  config.XOr(lhs,rhs);

        static Metrics<T> XOr<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
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

        static Metrics<sbyte> XOr(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<byte> XOr(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<short> XOr(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<ushort> XOr(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<int> XOr(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<uint> XOr(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<long> XOr(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<ulong> XOr(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<float> XOr(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> XOr(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXConfig128 config)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.xor(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }
 


    }

}