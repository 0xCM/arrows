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

    public static class ShiftLInX256D
    {

        public static Metrics<T> ShiftL<T>(this InXDConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(int))
                return config.ShiftL(int32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.ShiftL(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.ShiftL(int64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.ShiftL(uint64(lhs), uint64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<int> ShiftL(this InXDConfig256 config, ReadOnlySpan256<int> lhs, ReadOnlySpan256<uint> rhs)
        {
            var opid = Id<int>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<uint> ShiftL(this InXDConfig256 config, ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs)
        {
            var opid = Id<uint>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<long> ShiftL(this InXDConfig256 config, ReadOnlySpan256<long> lhs, ReadOnlySpan256<ulong> rhs)
        {
            var opid = Id<long>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<ulong> ShiftL(this InXDConfig256 config, ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.ShiftL);            
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.shiftl(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }
    }
}