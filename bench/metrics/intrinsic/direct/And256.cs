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
            if(typeof(T) == typeof(sbyte))
                return config.And(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return config.And(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return config.And(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.And(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                return config.And(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.And(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.And(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.And(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return config.And(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return config.And(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());

        }

        static Metrics<sbyte> And(this InXDConfig256 config, ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<byte> And(this InXDConfig256 config, ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs)
        {
            var opid = Id<byte>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<short> And(this InXDConfig256 config, ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs)
        {
            var opid = Id<short>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ushort> And(this InXDConfig256 config, ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<int> And(this InXDConfig256 config, ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs)
        {
            var opid = Id<int>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<uint> And(this InXDConfig256 config, ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs)
        {
            var opid = Id<uint>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<long> And(this InXDConfig256 config, ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs)
        {
            var opid = Id<long>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ulong> And(this InXDConfig256 config, ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<float> And(this InXDConfig256 config, ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs)
        {
            var opid = Id<float>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<double> And(this InXDConfig256 config, ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs)
        {
            var opid = Id<double>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.and(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }
    }
}