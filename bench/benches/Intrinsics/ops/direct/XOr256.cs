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

    public static class XOrInX256D
    {

        public static Metrics<T> XOr<T>(this InXDContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
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

        static Metrics<sbyte> XOr(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<sbyte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<byte> XOr(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<byte>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<short> XOr(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<short>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<ushort> XOr(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<ushort>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<int> XOr(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<int>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<uint> XOr(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<uint>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<long> XOr(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<long>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<ulong> XOr(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<ulong>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<float> XOr(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXDContext256 context = null)
        {
            
            var opid = context.Id<float>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.XOr(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        static Metrics<double> XOr(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXDContext256 context = null)
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