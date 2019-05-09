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
        public IBenchComparison AndI8()
        {
            var opid = Id<sbyte>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU8()
        {
            var opid = Id<byte>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU16()
        {
            var opid = Id<ushort>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison AndU32()
        {
            var opid = Id<uint>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU64()
        {
            var opid = Id<ulong>(OpKind.And);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dand(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        OpMeasure gand<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = gmath.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(byte[] dst)
        {
            var opid = Id<byte>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(short[] dst)
        {
            var opid = Id<short>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(int[] dst)
        {
            var opid = Id<int>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(uint[] dst)
        {
            var opid = Id<uint>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(long[] dst)
        {
            var opid = Id<long>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dand(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.And);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.and(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }
    }
}