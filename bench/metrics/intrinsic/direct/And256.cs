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
    using static InXDMetrics256;

    public static class AndInX256D
    {

        public static Metrics<T> And<T>(this InXDConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
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

        static Metrics<sbyte> And(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<sbyte>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<byte> And(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<byte>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<short> And(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<short>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<ushort> And(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<ushort>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<int> And(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<int>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<uint> And(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<uint>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<long> And(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<long>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<ulong> And(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<ulong>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<float> And(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<float>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> And(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXDConfig256 config = null)
        {
            
            var opid = Id<double>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }
 


    }

}