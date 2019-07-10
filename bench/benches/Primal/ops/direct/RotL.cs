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

    public static class RotLDMetrics
    {
        public static Metrics<T> RotL<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return config.RotL(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.RotL(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.RotL(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.RotL(uint64(lhs), uint64(rhs)).As<T>();
            else
                throw unsupported<T>();
        }


        static Metrics<byte> RotL(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var opid = Id<byte>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = Bits.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        
        static Metrics<ushort> RotL(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = Bits.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> RotL(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var opid = Id<uint>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = Bits.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> RotL(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = Bits.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}