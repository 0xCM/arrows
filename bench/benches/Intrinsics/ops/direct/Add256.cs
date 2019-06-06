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
    using static InXDMetrics256;
    using Z0.Bench;

    public static class AddInX256D
    {
        public static Metrics<T> Add<T>(this InXDContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                    return context.Add(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return context.Add(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return context.Add(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return context.Add(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                    return context.Add(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return context.Add(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Add(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Add(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return context.Add(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return context.Add(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Add(this InXDContext256 context, ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs)
        {
            var opid = context.Id<sbyte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<byte> Add(this InXDContext256 context, ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs)
        {
            var opid = context.Id<byte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<short> Add(this InXDContext256 context, ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs)
        {
            var opid = context.Id<short>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ushort> Add(this InXDContext256 context,ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs)
        {
            var opid = context.Id<ushort>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<int> Add(this InXDContext256 context,ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs)
        {
            var opid = context.Id<int>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<uint> Add(this InXDContext256 context, ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs)
        {
            var opid = context.Id<uint>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<long> Add(this InXDContext256 context, ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs)
        {
            var opid = context.Id<long>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ulong> Add(this InXDContext256 context, ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
        {
            var opid = context.Id<ulong>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<float> Add(this InXDContext256 context, ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs)
        {
            var opid = context.Id<float>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Add(this InXDContext256 context, ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs)
        {
            var opid = context.Id<double>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.add(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        } 
    }
}