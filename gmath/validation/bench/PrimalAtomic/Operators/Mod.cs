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
        OpMetrics mod<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Div);                 
            var lhs = LeftSample(opid);
            var rhs = NonZeroSample(opid);
            var sw = stopwatch();

            var it = -1;
            while(++it < SampleSize)
                dst[it] = gmath.mod(lhs[it], rhs[it]);
            return(dst.Length, snapshot(sw));
        } 

        public IBenchComparison ModI8()
        {
            var opid = Id<sbyte>(OpKind.Mod);

            OpMetrics baseline(sbyte[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(lhs[it] % rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison ModU8()
        {
            var opid = Id<byte>(OpKind.Mod);
            OpMetrics baseline(byte[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(lhs[it] % rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison ModI16()
        {
            var opid = Id<short>(OpKind.Mod);

            OpMetrics baseline(short[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();
    
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(lhs[it] % rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));
            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison ModU16()
        {
            var opid = Id<ushort>(OpKind.Mod);

            OpMetrics baseline(ushort[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(lhs[it] % rhs[it]);
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison ModI32()
        {
            var opid = Id<int>(OpKind.Mod);

            OpMetrics baseline(int[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] % rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison ModU32()
        {
            var opid = Id<uint>(OpKind.Mod);

            OpMetrics baseline(uint[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();
    
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] % rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }
 
        public IBenchComparison ModI64()
        {
            var opid = Id<long>(OpKind.Mod);

            OpMetrics baseline(long[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] % rhs[it];
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison ModU64()
        {
            var opid = Id<ulong>(OpKind.Mod);

            OpMetrics baseline(ulong[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] % rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison ModF32()
        {
            var opid = Id<float>(OpKind.Mod);
 
            OpMetrics baseline(float[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();

                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] % rhs[it];
                return(dst.Length, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison ModF64()
        {
            var opid = Id<double>(OpKind.Mod);
 
            OpMetrics baseline(double[] dst)
            {
                var lhs = LeftSample(opid);
                var rhs = NonZeroSample(opid);
                var sw = stopwatch();
    
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] % rhs[it];
                return(dst.Length, snapshot(sw));
            } 
    
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => mod(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        } 
    }
}