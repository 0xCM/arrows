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

        OpMetrics div<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid =  Id<T>(OpKind.Div);
            var lhs = Num.many(LeftSrc.Sampled(opid));
            var rhs = Num.many(NonZeroSrc.Sampled(opid));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] / rhs[it];
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison DivI8()
        {
            var opid = Id<sbyte>(OpKind.Div);

            OpMetrics baseline(sbyte[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(lhs[it] / rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivU8()
        {
            var opid = Id<byte>(OpKind.Div);

            OpMetrics baseline(byte[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(lhs[it] / rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison DivI16()
        {
            var opid = Id<short>(OpKind.Div);

            OpMetrics baseline(short[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(lhs[it] / rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivU16()
        {
            var opid =  Id<ushort>(OpKind.Div);

            OpMetrics baseline(ushort[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(lhs[it] / rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison DivI32()
        {
            var opid = Id<int>(OpKind.Div);

            OpMetrics baseline(int[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] / rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison DivU32()
        {
            var opid =  Id<uint>(OpKind.Div);

            OpMetrics baseline(uint[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] / rhs[it];
                return(dst.Length, snapshot(sw));
            }


            var dst = ArrayTargets<uint>();
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison DivI64()
        {
            var opid = Id<long>(OpKind.Div);

            OpMetrics baseline(long[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] / rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison DivU64()
        {
            var opid = Id<ulong>(OpKind.Div);

            OpMetrics baseline(ulong[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] / rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison DivF32()
        {
            var opid = Id<float>(OpKind.Div);

            OpMetrics baseline(float[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] / rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison DivF64()
        {
            var opid = Id<double>(OpKind.Div);
            
            OpMetrics baseline(double[] dst)
            {
                var lhs = LeftSrc.Sampled(head(dst));
                var rhs = NonZeroSrc.Sampled(head(dst));
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] / rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => div(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }
    }
}