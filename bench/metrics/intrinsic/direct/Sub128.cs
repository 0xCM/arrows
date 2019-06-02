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
    using static InXDMetrics128;

    public static class SubInX128D
    {
        public static Metrics<T> Sub<T>(this InXDConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                    return config.Sub(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.Sub(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.Sub(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.Sub(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                    return config.Sub(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.Sub(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Sub(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.Sub(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return config.Sub(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return config.Sub(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Sub(this InXDConfig128 config, ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<byte> Sub(this InXDConfig128 config, ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs)
        {
            var opid = Id<byte>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<short> Sub(this InXDConfig128 config, ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs)
        {
            var opid = Id<short>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ushort> Sub(this InXDConfig128 config,ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<int> Sub(this InXDConfig128 config,ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs)
        {
            var opid = Id<int>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<uint> Sub(this InXDConfig128 config, ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs)
        {
            var opid = Id<uint>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<long> Sub(this InXDConfig128 config, ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs)
        {
            var opid = Id<long>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ulong> Sub(this InXDConfig128 config, ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<float> Sub(this InXDConfig128 config, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = Id<float>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<double> Sub(this InXDConfig128 config, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = Id<double>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.sub(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        } 
    }
}
