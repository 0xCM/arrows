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
    using static InX256DMetrics;

    public static class OrInX256D
    {
        public static Metrics<T> OrD<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct        
                => Or(lhs,rhs,config);

        static Metrics<T> Or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXConfig256 config = null)
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

        public static Metrics<sbyte> Or(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<sbyte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<byte> Or(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<byte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<short> Or(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<short>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<ushort> Or(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ushort>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<int> Or(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<int>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<uint> Or(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<uint>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<long> Or(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<long>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<ulong> Or(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<ulong>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<float> Or(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<double> Or(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.or(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }
 


    }

}