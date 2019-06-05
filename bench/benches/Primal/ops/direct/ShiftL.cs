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
    using static PrimalDMetrics;

    public static class ShiftLDMetrics
    {
        public static Metrics<T> ShiftL<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.ShiftL(int8(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(byte))
                return config.ShiftL(uint8(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(short))
                return config.ShiftL(int16(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.ShiftL(uint16(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(int))
                return config.ShiftL(int32(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.ShiftL(uint32(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(long))
                return config.ShiftL(int64(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.ShiftL(uint64(lhs), rhs).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> ShiftL(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<sbyte>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> ShiftL(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<byte>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> ShiftL(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<short>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> ShiftL(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ushort>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> ShiftL(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> ShiftL(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<uint>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> ShiftL(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<long>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> ShiftL(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ulong>(OpKind.ShiftL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.shiftl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}