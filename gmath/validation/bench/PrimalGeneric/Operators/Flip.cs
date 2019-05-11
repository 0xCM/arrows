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

    partial class PrimalGenericBench
    {
        OpMetrics flip<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Flip);
            var lhs = LeftSample(opid);
            var rhs = RightSample(opid);
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.flip(lhs[it]);
            return(dst.Length, snapshot(sw));
        }

        public IBenchComparison FlipI8()
        {
            var opid = Id<sbyte>(OpKind.Flip);

            OpMetrics baseline(sbyte[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(~ lhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipU8()
        {
            var opid = Id<byte>(OpKind.Flip);

            OpMetrics baseline(byte[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(~ lhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipI16()
        {
            var opid = Id<short>(OpKind.Flip);

            OpMetrics baseline(short[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(~ lhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipU16()
        {
            var opid = Id<ushort>(OpKind.Flip);

            OpMetrics baseline(ushort[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(~ lhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipI32()
        {
            var opid = Id<int>(OpKind.Flip);

            OpMetrics baseline(int[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = ~ lhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison FlipU32()
        {
            var opid = Id<uint>(OpKind.Flip);

            OpMetrics baseline(uint[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = ~ lhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipI64()
        {
            var opid = Id<long>(OpKind.Flip);

            OpMetrics baseline(long[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = ~ lhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison FlipU64()
        {
            var opid = Id<ulong>(OpKind.Flip);
 
            OpMetrics baseline(ulong[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = ~ lhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => flip(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        } 

 
    }
}