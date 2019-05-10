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
        OpMetrics Lt<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Lt);
            var src = Sampled(opid);

            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.lt(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison LtI8()
        {
            var opid = Id<sbyte>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<sbyte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtU8()
        {
            var opid = Id<byte>(OpKind.Lt);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }
            
            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<byte>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtI16()
        {
            var opid = Id<short>(OpKind.Lt);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<short>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtU16()
        {
            var opid = Id<ushort>(OpKind.Lt);

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets<bool>();
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<ushort>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }


        public IBenchComparison LtI32()
        {
            var opid = Id<int>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<int>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtU32()
        {
            var opid = Id<uint>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<uint>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtI64()
        {
            var opid = Id<long>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<long>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtU64()
        {
            var opid = Id<ulong>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<ulong>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtF32()
        {
            var opid = Id<float>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<float>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison LtF64()
        {
            var opid = Id<double>(OpKind.Lt);
            var dst = Targets<bool>();

            OpMetrics baseline(bool[] dst)
            {
                var src = Sampled(opid);

                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] < src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => Lt<double>(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

    }
}