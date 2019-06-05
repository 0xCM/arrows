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
    using static InXDMetrics128;

    public static class ShiftLInX128D
    {
        public static Metrics<T> ShiftL<T>(this InXDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(int))
                return context.ShiftL(int32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.ShiftL(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return context.ShiftL(int64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.ShiftL(uint64(lhs), uint64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<int> ShiftL(this InXDContext128 context, ReadOnlySpan128<int> lhs, ReadOnlySpan128<uint> rhs)
        {
            var opid = context.Id<int>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<uint> ShiftL(this InXDContext128 context, ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs)
        {
            var opid = context.Id<uint>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<long> ShiftL(this InXDContext128 context, ReadOnlySpan128<long> lhs, ReadOnlySpan128<ulong> rhs)
        {
            var opid = context.Id<long>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<ulong> ShiftL(this InXDContext128 context, ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
        {
            var opid = context.Id<ulong>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}