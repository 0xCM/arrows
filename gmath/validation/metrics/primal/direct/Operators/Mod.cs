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
        public  static Metrics<sbyte> Mod(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte)(lhs[it] % rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> Mod(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)(lhs[it] % rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Mod(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)(lhs[it] % rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> Mod(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)(lhs[it] % rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> Mod(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] % rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> Mod(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] % rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Mod(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] % rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> Mod(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] % rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Mod(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] % rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Mod(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Mod);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mod(lhs[it],rhs[it]);
            else
               for(var cycle = 0; cycle < cycles; cycle++)
               for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] % rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

    }
}