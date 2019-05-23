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
        public  static Metrics<sbyte> Add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte)(lhs[it] + rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> Add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)(lhs[it] + rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)(lhs[it] + rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> Add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)(lhs[it] + rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> Add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] + rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> Add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] + rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] + rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> Add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] + rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Add(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] + rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Add(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Add);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.add(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] + rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

    }
}