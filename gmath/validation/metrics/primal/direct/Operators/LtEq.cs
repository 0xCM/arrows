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
        public static Metrics<sbyte> LtEq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        public static Metrics<byte> LtEq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<short> LtEq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<ushort> LtEq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<int> LtEq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<uint> LtEq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<long> LtEq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<ulong> LtEq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<float> LtEq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<double> LtEq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.LtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] <= rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }
    }
}