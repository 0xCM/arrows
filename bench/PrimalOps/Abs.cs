//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static mfunc;

    partial class PrimalDBench
    {

        public  static Metrics<sbyte> Abs(ReadOnlySpan<sbyte> src, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Abs);            
            var cycles = Cycles(config);
            var dOps = Configure(config).DirectOps;
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = Math.Abs(src[it]);
                var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Abs(ReadOnlySpan<short> src, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Abs);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);

            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }


        public static Metrics<int> Abs(ReadOnlySpan<int> src, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Abs);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Abs(ReadOnlySpan<long> src, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Abs);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Abs(ReadOnlySpan<float> src, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Abs);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = MathF.Abs(src[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Abs(ReadOnlySpan<double> src, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Abs);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }
    }
}