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
    using static NumGMetrics;

    public static class NumGOps
    {
        public static Metrics<T> Abs<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = Num.abs(numSrc[sample]);
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
 


        public static Metrics<T> Add<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] + src.Right[sample];                               
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Flip<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                 dst[sample] = ~ numSrc[sample];
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> GtEq<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.GtEq);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] >= src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static Metrics<T> Div<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] / src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mod<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] % src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Negate<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = -numSrc[sample];
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

       public static Metrics<T> Dec<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
            {
                var x = numSrc[sample];
                dst[sample] = --x;
            }

            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Gt<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] > src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());                
        }

        public static Metrics<T> Eq<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] == src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

       public static Metrics<T> Inc<T>(this NumGConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
            {
                var x = numSrc[sample];
                dst[sample] = ++x;
            }
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] ^ src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Lt<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Lt);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] < src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }

        public static Metrics<T> Sub<T>(this NumGConfig config,ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] - src.Right[sample];                               
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

 
         public static Metrics<T> LtEq<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.LtEq);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] <= src.Right[sample];                   
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
        }
 
         public static Metrics<T> Or<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] | src.Right[sample];                                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this NumGConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = config.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = src.Left[sample] * src.Right[sample];                   
            return opid.DefineMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

         
    }

}
