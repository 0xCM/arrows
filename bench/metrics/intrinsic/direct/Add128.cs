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

    public static class AddInX128D
    {
        public static Metrics<T> AddD<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                =>  config.Add(lhs,rhs);

        static Metrics<T> Add<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return config.Add(int8(lhs), int8(rhs)).As<T>();
                case PrimalKind.uint8:
                    return config.Add(uint8(lhs), uint8(rhs)).As<T>();
                case PrimalKind.int16:
                    return Add(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Add(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Add(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Add(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Add(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return config.Add(uint64(lhs), uint64(rhs)).As<T>();
                case PrimalKind.float32:
                    return config.Add(float32(lhs), float32(rhs)).As<T>();
                case PrimalKind.float64:                    
                    return config.Add(float64(lhs), float64(rhs)).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<sbyte> Add(InXConfig128 config, ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<byte> Add(InXConfig128 config, ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs)
        {
            var opid = Id<byte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<short> Add(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXConfig128 config)
        {
            var opid = Id<short>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<ushort> Add(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXConfig128 config)
        {
            var opid = Id<ushort>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<int> Add(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXConfig128 config)
        {
            var opid = Id<int>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<uint> Add(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXConfig128 config)
        {
            var opid = Id<uint>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<long> Add(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXConfig128 config)
        {
            var opid = Id<long>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<ulong> Add(this InXConfig128 config, ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<float> Add(this InXConfig128 config, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = Id<float>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> Add(this InXConfig128 config, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = Id<double>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(config, time, dst);
        } 
    }

}
