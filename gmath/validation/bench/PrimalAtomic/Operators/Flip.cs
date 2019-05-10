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

    partial class PrimalAtomicBench
    {
        public IBenchComparison FlipI8()
        {
            var opid = Id<sbyte>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipU8()
        {
            var opid = Id<byte>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison FlipI16()
        {
            var opid = Id<short>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipU16()
        {
            var opid = Id<ushort>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison FlipI32()
        {
            var opid = Id<int>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison FlipU32()
        {
            var opid = Id<uint>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipI64()
        {
            var opid = Id<long>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison FlipU64()
        {
            var opid = Id<ulong>(OpKind.Flip);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dflip(dst.Left)), 
                Measure(~opid, () => gflip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        } 

        OpMetrics gflip<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.flip(lhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dflip(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (sbyte)(~ lhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dflip(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (byte)(~ lhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dflip(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (short)(~ lhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dflip(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (ushort)(~ lhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dflip(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            
            var it = -1;
            while(++it < SampleSize)
                dst[it] = ~ lhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dflip(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            
            var it = -1;
            while(++it < SampleSize)
                dst[it] = ~ lhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMetrics dflip(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            
            var it = -1;
            while(++it < SampleSize)
                dst[it] = ~ lhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMetrics dflip(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            
            var it = -1;
            while(++it < SampleSize)
                dst[it] = ~ lhs[it];
            return(dst.Length, snapshot(sw));
        }

    }
}