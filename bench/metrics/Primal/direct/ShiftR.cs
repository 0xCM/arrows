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
    using static PrimalDMetrics;

    public static class ShiftRDMetrics
    {
        public static Metrics<T> ShiftR<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.ShiftR(int8(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(byte))
                return config.ShiftR(uint8(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(short))
                return config.ShiftR(int16(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.ShiftR(uint16(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(int))
                return config.ShiftR(int32(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.ShiftR(uint32(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(long))
                return config.ShiftR(int64(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.ShiftR(uint64(lhs), rhs).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> ShiftR(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<sbyte>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> ShiftR(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<byte>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> ShiftR(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<short>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> ShiftR(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ushort>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> ShiftR(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> ShiftR(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<uint>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> ShiftR(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<long>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> ShiftR(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ulong>(OpKind.ShiftR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}