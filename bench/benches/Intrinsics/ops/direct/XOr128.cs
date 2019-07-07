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

    public static class XOrInX128D
    {

        public static Metrics<T> XOr<T>(this InXDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.XOr(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.XOr(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return context.XOr(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.XOr(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))                
                return context.XOr(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.XOr(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return context.XOr(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.XOr(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return context.XOr(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return context.XOr(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        static Metrics<sbyte> XOr(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<sbyte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<byte> XOr(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<byte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<short> XOr(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<short>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<ushort> XOr(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<ushort>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<int> XOr(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<int>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<uint> XOr(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<uint>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<long> XOr(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<long>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<ulong> XOr(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<ulong>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<float> XOr(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<float>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<double> XOr(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXDContext128 context)
        {
            
            var opid = context.Id<double>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }
 


    }

}