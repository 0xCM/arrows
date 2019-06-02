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

    public static class AddInX256D
    {
        public static Metrics<T> Add<T>(this InXDConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                    return config.Add(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.Add(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.Add(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.Add(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                    return config.Add(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.Add(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Add(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.Add(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return config.Add(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return config.Add(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Add(this InXDConfig256 config, ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<byte> Add(this InXDConfig256 config, ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs)
        {
            var opid = Id<byte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<short> Add(this InXDConfig256 config, ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs)
        {
            var opid = Id<short>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ushort> Add(this InXDConfig256 config,ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<int> Add(this InXDConfig256 config,ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs)
        {
            var opid = Id<int>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<uint> Add(this InXDConfig256 config, ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs)
        {
            var opid = Id<uint>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<long> Add(this InXDConfig256 config, ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs)
        {
            var opid = Id<long>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ulong> Add(this InXDConfig256 config, ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<float> Add(this InXDConfig256 config, ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs)
        {
            var opid = Id<float>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<double> Add(this InXDConfig256 config, ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs)
        {
            var opid = Id<double>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs,rhs, ref dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        } 
    }
}
