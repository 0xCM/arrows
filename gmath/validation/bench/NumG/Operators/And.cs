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

        OpMeasure gand<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = Number.many(LeftSrc.Sampled(head(dst)));
            var rhs = Number.many(RightSrc.Sampled(head(dst)));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] & rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dand(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (sbyte)(lhs[it] & rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dand(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (byte)(lhs[it] & rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dand(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (short)(lhs[it] & rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dand(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (ushort)(lhs[it] & rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dand(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] & rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dand(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] & rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dand(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] & rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dand(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] & rhs[it];
            return(dst.Length, snapshot(sw));
        }


        public IBenchComparison AndI8()
        {
            var opid =  Id<sbyte>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AndU8()
        {
            var opid =  Id<byte>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AndU16()
        {
            var opid = Id<ushort>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison AndU32()
        {
            var opid = Id<uint>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AndU64()
        {
            var opid = Id<ulong>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dand(dst.Left)), 
                Measure(opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }




    }

}