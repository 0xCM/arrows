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

    partial class NumGBench
    {
       OpMetrics negate<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid =  Id<T>(OpKind.Negate);
            var src = Number.many(Sampled(opid).Left);            
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = - src[it];
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison NegateI8()
        {
            var opid = Id<sbyte>(OpKind.Negate);

            OpMetrics baseline(sbyte[] dst)
            {
                var src = Sampled(opid).Left;
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(- src[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => negate(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison NegateI16()
        {
            var opid =  Id<short>(OpKind.Negate);

            OpMetrics baseline(short[] dst)
            {
                var src = Sampled(opid).Left;
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(- src[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => negate(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison NegateI32()
        {
            var opid =  Id<int>(OpKind.Negate);
            
            OpMetrics baseline(int[] dst)
            {
                var src = Sampled(opid).Left;
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = - src[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => negate(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison NegateI64()
        {
            var opid =  Id<long>(OpKind.Negate);

            OpMetrics baseline(long[] dst)
            {
                var src = Sampled(opid).Left;
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = - src[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => negate(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison NegateF32()
        {
            var opid =  Id<float>(OpKind.Negate);

            OpMetrics baseline(float[] dst)
            {
                var src = Sampled(opid).Left;
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = - src[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => negate(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison NegateF64()
        {
            var opid =  Id<double>(OpKind.Negate);
            
            OpMetrics baseline(double[] dst)
            {
                var src = Sampled(opid).Left;
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = - src[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => negate(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        } 
    }
}