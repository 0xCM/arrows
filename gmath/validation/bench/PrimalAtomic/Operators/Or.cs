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
        public IBenchComparison OrI8()
        {
            var opid = Id<sbyte>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU8()
        {
            var opid = Id<byte>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrI16()
        {
            var opid = Id<short>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU16()
        {
            var opid = Id<ushort>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrI32()
        {
            var opid = Id<int>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU32()
        {
            var opid = Id<uint>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrI64()
        {
            var opid = Id<long>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU64()
        {
            var opid = Id<ulong>(OpKind.Or);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dor(dst.Left)), 
                Measure(~opid, () => gor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        OpMeasure gor<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = gmath.or(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(short[] dst)
        {
            var opid = Id<short>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(int[] dst)
        {
            var opid = Id<int>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Or);            
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(long[] dst)
        {
            var opid = Id<long>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dor(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Or);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.or(src.Left[it],src.Right[it]);
            return(SampleSize, snapshot(sw));
        }
    }
}