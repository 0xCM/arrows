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
        public  static Metrics<sbyte> Mul(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte)(lhs[it] * rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> Mul(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)(lhs[it] * rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Mul(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)(lhs[it] * rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> Mul(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)(lhs[it] * rhs[it]);
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> Mul(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] * rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> Mul(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] * rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Mul(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
                if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] * rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> Mul(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] * rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Mul(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] * rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Mul(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Mul);            
            var cycles = Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(lhs,rhs);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.mul(lhs[it],rhs[it]);
            else                
               for(var cycle = 0; cycle < cycles; cycle++)
               for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] * rhs[it];
            var time = snapshot(sw);

            return Metrics.Define(opid, cycles*dst.Length, time, dst);
        }
    }
}