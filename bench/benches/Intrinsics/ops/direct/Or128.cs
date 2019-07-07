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

    public static class OrInX128D
    {
        public static Metrics<T> Or<T>(this InXDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.Or(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.Or(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return context.Or(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.Or(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                return context.Or(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.Or(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Or(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Or(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return context.Or(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return context.Or(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        public static Metrics<sbyte> Or(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<sbyte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<byte> Or(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<byte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<short> Or(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<short>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<ushort> Or(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<ushort>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<int> Or(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<int>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<uint> Or(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<uint>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<long> Or(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<long>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<ulong> Or(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<ulong>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<float> Or(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<float>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<double> Or(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<double>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }
 


    }

}