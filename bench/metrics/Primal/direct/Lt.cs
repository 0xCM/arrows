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

    public static class LtDMetrics
    {
        public static Metrics<T> Lt<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Lt(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Lt(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Lt(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Lt(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Lt(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Lt(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Lt(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Lt(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Lt(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Lt(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<sbyte> Lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<byte> Lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<byte>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<short> Lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, PrimalDConfig config = null)
        {
            var opid = Id<short>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<ushort> Lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<int> Lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, PrimalDConfig config = null)
        {
            var opid = Id<int>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<uint> Lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, PrimalDConfig config = null)
        {
            var opid = Id<uint>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<long> Lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, PrimalDConfig config = null)
        {
            var opid = Id<long>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<ulong> Lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<float> Lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, PrimalDConfig config = null)
        {
            var opid = Id<float>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<double> Lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, PrimalDConfig config = null)
        {
            var opid = Id<double>(OpKind.Lt);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] < rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }
    }
}