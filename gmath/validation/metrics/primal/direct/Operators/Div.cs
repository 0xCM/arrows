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

    partial class PrimalDMetrics
    {

        public  static Metrics<sbyte> Div(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Div);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (sbyte)(lhs[it] / rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> Div(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.Div);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (byte)(lhs[it] / rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Div(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Div);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (short)(lhs[it] / rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> Div(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Div);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (ushort)(lhs[it] / rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> Div(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Div);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] / rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> Div(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.Div);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] / rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Div(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Div);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] / rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> Div(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Div);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] / rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Div(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Div);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] / rhs[it];
                var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Div(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Div);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.div(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] / rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

    }
}