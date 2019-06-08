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
    using static PrimalGMetrics;

    public static class PrimalGOps
    {

        public static Metrics<T> Negate<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.negate(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Inc<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.inc(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Dec<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.dec(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Square<T>(this PrimalGConfig config, ReadOnlySpan<T> src )
            where T : struct
        {
            var opid =  Id<T>(OpKind.Square);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.square(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Max<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Max);
            var dst = alloc<T>(1);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.max(src);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Min<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Min);
            var dst = alloc<T>(1);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.min(src);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Parse<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Parse);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.parse<T>(src[sample].ToString());
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Add<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;            
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.add(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.mul(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mod<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.mod(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Sqrt<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sqrt);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sqrt(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Flip<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.flip(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Abs<T>(this PrimalGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc(src);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.abs(src[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.xor(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Sub<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sub(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Eq<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gt(lhs[sample], rhs[sample]);            
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> Lt<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Lt);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.lt(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> LtEq<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.LtEq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.lteq(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

         public static Metrics<T> Gt<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gt(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> GtEq<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.GtEq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.gteq(lhs[sample], rhs[sample]);     
            var time = snapshot(sw);       
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> And<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.and(lhs[sample], rhs[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Or<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.or(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> ShiftL<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.ShiftR);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.shiftl(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> ShiftR<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.ShiftR);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.shiftr(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> RotL<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.RotL);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gbits.rotl(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> RotR<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.RotR);
            var dst = alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gbits.rotr(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Div<T>(this PrimalGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var dst = alloc(lhs,rhs);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.div(lhs[sample], rhs[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }          
    }
}