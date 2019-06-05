//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;

    public static class SubInX128D
    {
        public static Metrics<T> Sub<T>(this InXDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                    return context.Sub(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return context.Sub(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return context.Sub(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return context.Sub(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                    return context.Sub(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return context.Sub(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Sub(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Sub(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return context.Sub(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return context.Sub(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Sub(this InXDContext128 context, ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs)
        {
            var opid = context.Id<sbyte>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<byte> Sub(this InXDContext128 context, ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs)
        {
            var opid = context.Id<byte>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<short> Sub(this InXDContext128 context, ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs)
        {
            var opid = context.Id<short>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ushort> Sub(this InXDContext128 context,ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs)
        {
            var opid = context.Id<ushort>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<int> Sub(this InXDContext128 context,ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs)
        {
            var opid = context.Id<int>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<uint> Sub(this InXDContext128 context, ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs)
        {
            var opid = context.Id<uint>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<long> Sub(this InXDContext128 context, ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs)
        {
            var opid = context.Id<long>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ulong> Sub(this InXDContext128 context, ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
        {
            var opid = context.Id<ulong>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<float> Sub(this InXDContext128 context, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = context.Id<float>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Sub(this InXDContext128 context, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = context.Id<double>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        } 
    }
}
