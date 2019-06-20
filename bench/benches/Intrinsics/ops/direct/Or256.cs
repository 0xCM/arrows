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

    public static class OrInX256D
    {

        public static Metrics<T> Or<T>(this InXDContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
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

        static Metrics<sbyte> Or(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXDContext256 context)
        {
            var opid = context.Id<sbyte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<byte> Or(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXDContext256 context)
        {
            var opid = context.Id<byte>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<short> Or(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXDContext256 context)
        {
            var opid = context.Id<short>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ushort> Or(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXDContext256 context)
        {
            var opid = context.Id<ushort>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<int> Or(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXDContext256 context)
        {
            var opid = context.Id<int>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<uint> Or(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXDContext256 context)
        {
            var opid = context.Id<uint>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<long> Or(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXDContext256 context)
        {
            var opid = context.Id<long>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ulong> Or(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXDContext256 context)
        {
            var opid = context.Id<ulong>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<float> Or(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXDContext256 context)
        {
            var opid = context.Id<float>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Or(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXDContext256 context)
        {
            var opid = context.Id<double>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinxx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}