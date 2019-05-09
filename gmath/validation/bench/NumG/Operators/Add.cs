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

        OpMeasure gadd<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = Number.many(LeftSrc.Sampled(head(dst)));
            var rhs = Number.many(RightSrc.Sampled(head(dst)));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dadd(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (sbyte)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dadd(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (byte)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dadd(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (short)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dadd(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (ushort)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dadd(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dadd(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dadd(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dadd(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dadd(float[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dadd(double[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        public IBenchComparison AddI8()
        {
            var opid =  Id<sbyte>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU8()
        {
            var opid =  Id<byte>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid =  Id<short>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU16()
        {
            var opid =  Id<ushort>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison AddI32()
        {
            var opid =  Id<int>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison AddU32()
        {
            var opid =  Id<uint>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid =  Id<long>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU64()
        {
            var opid =  Id<ulong>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddF32()
        {
            var opid =  Id<float>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddF64()
        {
            var opid =  Id<double>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dadd(dst.Left)), 
                Measure(opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

    }
}