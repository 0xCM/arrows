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
       OpMetrics add<T>(T[] dst)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);
            
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] + rhs[it];
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);

            OpMetrics baseline(sbyte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU8()
        {
            var opid =  Id<byte>(OpKind.Add);

            OpMetrics baseline(byte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid =  Id<short>(OpKind.Add);

            OpMetrics baseline(short[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU16()
        {
            var opid =  Id<ushort>(OpKind.Add);
            OpMetrics baseline(ushort[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison AddI32()
        {
            var opid =  Id<int>(OpKind.Add);
            
            OpMetrics baseline(int[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU32()
        {
            var opid =  Id<uint>(OpKind.Add);
            
            OpMetrics baseline(uint[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid =  Id<long>(OpKind.Add);

            OpMetrics baseline(long[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU64()
        {
            var opid =  Id<ulong>(OpKind.Add);
            
            OpMetrics baseline(ulong[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddF32()
        {
            var opid =  Id<float>(OpKind.Add);

            OpMetrics baseline(float[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddF64()
        {
            var opid =  Id<double>(OpKind.Add);
            
            OpMetrics baseline(double[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => add(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        } 
    }
}