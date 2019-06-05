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
        public static Metrics<T> RotL<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return config.RotL(uint8(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.RotL(uint16(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.RotL(uint32(lhs), rhs).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.RotL(uint64(lhs), rhs).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }


        static Metrics<byte> RotL(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<byte>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        
        static Metrics<ushort> RotL(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ushort>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> RotL(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<uint>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> RotL(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<ulong>(OpKind.RotL);            
            var cycles = config.Cycles;
            var dst = alloc(lhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.rotl(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}