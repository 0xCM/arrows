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
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Or(int8(lhs), int8(rhs), context).As<T>();
                case PrimalKind.uint8:
                    return Or(uint8(lhs), uint8(rhs), context).As<T>();
                case PrimalKind.int16:
                    return Or(int16(lhs), int16(rhs), context).As<T>();
                case PrimalKind.uint16:
                    return Or(uint16(lhs), uint16(rhs), context).As<T>();
                case PrimalKind.int32:
                    return Or(int32(lhs), int32(rhs), context).As<T>();
                case PrimalKind.uint32:
                    return Or(uint32(lhs), uint32(rhs), context).As<T>();
                case PrimalKind.int64:
                    return Or(int64(lhs), int64(rhs), context).As<T>();
                case PrimalKind.uint64:
                    return Or(uint64(lhs), uint64(rhs), context).As<T>();
                case PrimalKind.float32:
                    return Or(float32(lhs), float32(rhs), context).As<T>();
                case PrimalKind.float64:                    
                    return Or(float64(lhs), float64(rhs), context).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<sbyte> Or(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<sbyte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<byte> Or(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<byte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<short> Or(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<short>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<ushort> Or(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<ushort>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<int> Or(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<int>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<uint> Or(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<uint>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<long> Or(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<long>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<ulong> Or(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<ulong>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<float> Or(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<float>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }

        public static Metrics<double> Or(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXDContext128 context = null)
        {
            var opid = context.Id<double>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return context.CaptureMetrics(opid, time, dst);
        }
 


    }

}