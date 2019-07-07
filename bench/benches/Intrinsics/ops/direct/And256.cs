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

    public static class AndInX256D
    {
        public static Metrics<T> And<T>(this InXDContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.And(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.And(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return context.And(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.And(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                return context.And(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.And(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return context.And(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.And(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return context.And(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return context.And(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported<T>();

        }

        static Metrics<sbyte> And(this InXDContext256 context, ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs)
        {
            var opid = context.Id<sbyte>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<byte> And(this InXDContext256 context, ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs)
        {
            var opid = context.Id<byte>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<short> And(this InXDContext256 context, ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs)
        {
            var opid = context.Id<short>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ushort> And(this InXDContext256 context, ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs)
        {
            var opid = context.Id<ushort>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<int> And(this InXDContext256 context, ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs)
        {
            var opid = context.Id<int>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<uint> And(this InXDContext256 context, ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs)
        {
            var opid = context.Id<uint>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<long> And(this InXDContext256 context, ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs)
        {
            var opid = context.Id<long>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ulong> And(this InXDContext256 context, ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
        {
            var opid = context.Id<ulong>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<float> And(this InXDContext256 context, ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs)
        {
            var opid = context.Id<float>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> And(this InXDContext256 context, ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs)
        {
            var opid = context.Id<double>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}