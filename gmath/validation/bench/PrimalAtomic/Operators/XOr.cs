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
        public IBenchComparison XOrI8()
        {
            var opid = Id<sbyte>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrU8()
        {
            var opid = Id<byte>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison XOrI16()
        {
            var opid = Id<short>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrU16()
        {
            var opid = Id<ushort>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison XOrI32()
        {
            var opid = Id<int>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison XOrU32()
        {
            var opid = Id<uint>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrI64()
        {
            var opid = Id<long>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrU64()
        {
            var opid = Id<ulong>(OpKind.XOr);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dxor(dst.Left)), 
                Measure(~opid, () => gxor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        OpMetrics gxor<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.xor(lhs[it],rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (sbyte)(lhs[it] ^ rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (byte)(lhs[it] ^ rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (short)(lhs[it] ^ rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = (ushort)(lhs[it] ^ rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] ^ rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] ^ rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] ^ rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dxor(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] ^ rhs[it];
            return(dst.Length, snapshot(sw));
        }
    }
}