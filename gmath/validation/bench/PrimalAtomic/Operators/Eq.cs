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
        public IBenchComparison EqI8()
        {
            var opid = Id<sbyte>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<sbyte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU8()
        {
            var opid = Id<byte>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<byte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqI16()
        {
            var opid = Id<short>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<ushort>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU16()
        {
            var opid = Id<ushort>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<ushort>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }


        public IBenchComparison EqI32()
        {
            var opid = Id<int>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<int>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU32()
        {
            var opid = Id<uint>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<uint>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqI64()
        {
            var opid = Id<long>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<long>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU64()
        {
            var opid = Id<ulong>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<ulong>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqF32()
        {
            var opid = Id<float>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<float>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqF64()
        {
            var opid = Id<double>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMeasure eqLeft(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = It.Define(0, SampleSize);
                while(++it)
                    dst[it] = math.eq(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => eqLeft(dst.Left)), 
                Measure(~opid, () => eqRight<double>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        OpMeasure eqRight<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Eq);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = gmath.eq(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }
    }
}