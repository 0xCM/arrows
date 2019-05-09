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

        OpMeasure gmod<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = Number.many(LeftSrc.Sampled(head(dst)));
            var rhs = Number.many(NonZeroSrc.Sampled(head(dst)));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmod(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (sbyte)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmod(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (byte)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmod(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (short)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmod(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (ushort)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmod(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure dmod(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmod(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmod(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmod(float[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure dmod(double[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        public IBenchComparison ModI8()
        {
            var opid = Id<sbyte>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModU8()
        {
            var opid = Id<byte>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModI16()
        {
            var opid = Id<short>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModU16()
        {
            var opid =  Id<ushort>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison ModI32()
        {
            var opid = Id<int>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison ModU32()
        {
            var opid =  Id<uint>(OpKind.Mod);
            var dst = ArrayTargets<uint>();

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModI64()
        {
            var opid = Id<long>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModU64()
        {
            var opid = Id<ulong>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModF32()
        {
            var opid = Id<float>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModF64()
        {
            var opid = Id<double>(OpKind.Mod);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => dmod(dst.Left)), 
                Measure(opid, () => gmod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

    }
}