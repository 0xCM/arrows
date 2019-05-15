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
        OpMetrics and<T>(T[] dst)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);
            var sw = stopwatch();
            
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] & rhs[it];
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison AndI8()
        {
            var opid =  Id<sbyte>(OpKind.And);

            OpMetrics baseline(sbyte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(src.Left[it] & src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);
            return Finish(comparison);
        }

        public IBenchComparison AndU8()
        {
            var opid =  Id<byte>(OpKind.And);

            OpMetrics baseline(byte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(src.Left[it] & src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);

            OpMetrics baseline(short[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(src.Left[it] & src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU16()
        {
            var opid = Id<ushort>(OpKind.And);

            OpMetrics baseline(ushort[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(src.Left[it] & src.Right[it]);
                return(SampleSize, snapshot(sw));
            }
                        
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);

            OpMetrics baseline(int[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] & src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU32()
        {
            var opid = Id<uint>(OpKind.And);
            
            OpMetrics baseline(uint[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] & src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);
            
            OpMetrics baseline(long[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] & src.Right[it];
                return(SampleSize, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU64()
        {
            var opid = Id<ulong>(OpKind.And);
 
            OpMetrics baseline(ulong[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] & src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => and(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }
    }
}