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

        OpMetrics sub<T>(T[] dst)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);

            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(SampleSize, snapshot(sw));
        }

        OpMetrics dsub(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = (sbyte)(lhs[it] - rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dsub(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = (byte)(lhs[it] - rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dsub(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = (short)(lhs[it] - rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dsub(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = (ushort)(lhs[it] - rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dsub(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMetrics dsub(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMetrics dsub(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMetrics dsub(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMetrics dsub(float[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMetrics dsub(double[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] - rhs[it];
            return(dst.Length, snapshot(sw));
        }

        public IBenchComparison SubI8()
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU8()
        {
            var opid = Id<byte>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI16()
        {
            var opid = Id<short>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU16()
        {
            var opid = Id<ushort>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison SubI32()
        {
            var opid = Id<int>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison SubU32()
        {
            var opid = Id<uint>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI64()
        {
            var opid = Id<long>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU64()
        {
            var opid = Id<ulong>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubF32()
        {
            var opid = Id<float>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubF64()
        {
            var opid = Id<double>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dsub(dst.Left)), 
                Measure(opid, () => sub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

 

    }

}