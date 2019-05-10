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
        OpMetrics gt<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Gt);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.gt(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison GtI8()
        {
            var opid = Id<sbyte>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<sbyte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtU8()
        {
            var opid = Id<byte>(OpKind.Gt);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }
            
            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<byte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtI16()
        {
            var opid = Id<short>(OpKind.Gt);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<short>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtU16()
        {
            var opid = Id<ushort>(OpKind.Gt);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<ushort>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }


        public IBenchComparison GtI32()
        {
            var opid = Id<int>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<int>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtU32()
        {
            var opid = Id<uint>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<uint>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtI64()
        {
            var opid = Id<long>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<long>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtU64()
        {
            var opid = Id<ulong>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<ulong>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtF32()
        {
            var opid = Id<float>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<float>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison GtF64()
        {
            var opid = Id<double>(OpKind.Gt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] > src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gt<double>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

    }
}