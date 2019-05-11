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

    partial class PrimalGenericBench
    {
        OpMetrics eq<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Eq);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.eq(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison EqI8()
        {
            var opid = Id<sbyte>(OpKind.Eq);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<sbyte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU8()
        {
            var opid = Id<byte>(OpKind.Eq);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }
            
            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<byte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqI16()
        {
            var opid = Id<short>(OpKind.Eq);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<short>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU16()
        {
            var opid = Id<ushort>(OpKind.Eq);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<ushort>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }


        public IBenchComparison EqI32()
        {
            var opid = Id<int>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<int>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU32()
        {
            var opid = Id<uint>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<uint>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqI64()
        {
            var opid = Id<long>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<long>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqU64()
        {
            var opid = Id<ulong>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<ulong>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqF32()
        {
            var opid = Id<float>(OpKind.Eq);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<float>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison EqF64()
        {
            var opid = Id<double>(OpKind.Eq);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] == src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => eq<double>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

    }
}