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
        OpMetrics or<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.or(src.Left[it], src.Right[it]);
            return(SampleSize, snapshot(sw));
        } 

        public IBenchComparison OrI8()
        {
            var opid = Id<sbyte>(OpKind.Or);
            
            OpMetrics baseline(sbyte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(src.Left[it] | src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU8()
        {
            var opid = Id<byte>(OpKind.Or);

            OpMetrics baseline(byte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(src.Left[it] | src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrI16()
        {
            var opid = Id<short>(OpKind.Or);

            OpMetrics baseline(short[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(src.Left[it] | src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU16()
        {
            var opid = Id<ushort>(OpKind.Or);

            OpMetrics baseline(ushort[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(src.Left[it] | src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison OrI32()
        {
            var opid = Id<int>(OpKind.Or);
            OpMetrics baseline(int[] dst)
            {
                var src = Sampled(opid);                
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] | src.Right[it];
                return(SampleSize, snapshot(sw));
            }
            
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU32()
        {
            var opid = Id<uint>(OpKind.Or);

            OpMetrics baseline(uint[] dst)
            {
                var src = Sampled(opid);                
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] | src.Right[it];
                return(SampleSize, snapshot(sw));
            }


            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrI64()
        {
            var opid = Id<long>(OpKind.Or);
            OpMetrics baseline(long[] dst)
            {
                var src = Sampled(opid);                
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] | src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison OrU64()
        {
            var opid = Id<ulong>(OpKind.Or);

            OpMetrics baseline(ulong[] dst)
            {
                var src = Sampled(opid);                
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] | src.Right[it];
                return(SampleSize, snapshot(sw));
            }
    
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => or(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }
    }
}