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

    public static class RotRDMetrics
    {
        public static Metrics<T> RotR<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return config.RotR(uint8(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.RotR(uint16(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.RotR(uint32(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.RotR(uint64(lhs), rhs).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<byte> RotR(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<byte>(OpKind.RotR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    
        static Metrics<ushort> RotR(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ushort>(OpKind.RotR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> RotR(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<uint>(OpKind.RotR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> RotR(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ulong>(OpKind.RotR);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotr(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}