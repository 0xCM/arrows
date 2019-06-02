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

    public static class FlipDMetrics
    {

       public static Metrics<T> Flip<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return Flip(int8(src), config).As<T>();
                case PrimalKind.uint8:
                    return Flip(uint8(src), config).As<T>();
                case PrimalKind.int16:
                    return Flip(int16(src), config).As<T>();
                case PrimalKind.uint16:
                    return Flip(uint16(src), config).As<T>();
                case PrimalKind.int32:
                    return Flip(int32(src), config).As<T>();
                case PrimalKind.uint32:
                    return Flip(uint32(src), config).As<T>();
                case PrimalKind.int64:
                    return Flip(int64(src), config).As<T>();
                case PrimalKind.uint64:
                    return Flip(uint64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public  static Metrics<sbyte> Flip(ReadOnlySpan<sbyte> src, PrimalDConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = Configure(config).DirectOps;
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (sbyte)~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> Flip(ReadOnlySpan<byte> src, PrimalDConfig config = null)
        {
            var opid = Id<byte>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = Configure(config).DirectOps;
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Flip(ReadOnlySpan<short> src, PrimalDConfig config = null)
        {
            var opid = Id<short>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);

            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> Flip(ReadOnlySpan<ushort> src, PrimalDConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }


        public static Metrics<int> Flip(ReadOnlySpan<int> src, PrimalDConfig config = null)
        {
            var opid = Id<int>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = ~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<uint> Flip(ReadOnlySpan<uint> src, PrimalDConfig config = null)
        {
            var opid = Id<uint>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = ~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Flip(ReadOnlySpan<long> src, PrimalDConfig config = null)
        {
            var opid = Id<long>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = ~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> Flip(ReadOnlySpan<ulong> src, PrimalDConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Flip);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.flip(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = ~ src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

    }
}