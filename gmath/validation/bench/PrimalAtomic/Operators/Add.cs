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
        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddU8()
        {
            var opid = Id<byte>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid = Id<short>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU16()
        {
            var opid = Id<ushort>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }


        public IBenchComparison AddI32()
        {
            var opid = Id<int>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU32()
        {
            var opid = Id<uint>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid = Id<long>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU64()
        {
            var opid = Id<ulong>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddF32()
        {
            var opid = Id<float>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddF64()
        {
            var opid = Id<double>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        OpMeasure gadd<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = gmath.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(short[] dst)
        {
            var opid = Id<short>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(int[] dst)
        {
            var opid = Id<int>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(long[] dst)
        {
            var opid = Id<long>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(float[] dst)
        {            
            var opid = Id<float>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        OpMeasure dadd(double[] dst)
        {
            var opid = Id<double>(OpKind.Add);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, SampleSize);
            while(++it)
                dst[it] = math.add(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

    }
}