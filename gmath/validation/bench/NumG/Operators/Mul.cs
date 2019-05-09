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

        OpMeasure gmul<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = Number.many(LeftSrc.Sampled(head(dst)));
            var rhs = Number.many(RightSrc.Sampled(head(dst)));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmul(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (sbyte)(lhs[it] * rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmul(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (byte)(lhs[it] * rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmul(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (short)(lhs[it] * rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmul(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (ushort)(lhs[it] * rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmul(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmul(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmul(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmul(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmul(float[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmul(double[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] * rhs[it];
            return(dst.Length, snapshot(sw));
        }

        public IBenchComparison MulI8()
        {
            var opid = Id<sbyte>(OpKind.Mul);
            var dst = ArrayTargets<sbyte>();

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulU8()
        {
            var opid = Id<byte>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulI16()
        {
            var opid = Id<short>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulU16()
        {
            var opid = Id<ushort>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison MulI32()
        {
            var opid = Id<int>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison MulU32()
        {
            var opid = Id<uint>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulI64()
        {
            var opid = Id<long>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulU64()
        {
            var opid = Id<ulong>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulF32()
        {
            var opid = Id<float>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison MulF64()
        {
            var opid = Id<double>(OpKind.Mul);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmul(dst.Left)), 
                Measure(opid, () => gmul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }
    }
}