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
        OpMetrics mul<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid =  Id<T>(OpKind.Mul);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);
            var sw = stopwatch();
            
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] * rhs[it];
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison MulI8()
        {
            var opid = Id<sbyte>(OpKind.Mul);
            
            OpMetrics baseline(sbyte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(src.Left[it] * src.Right[it]);
                return(SampleSize, snapshot(sw));
            }
            
            var dst = ArrayTargets<sbyte>();
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulU8()
        {
            var opid = Id<byte>(OpKind.Mul);

            OpMetrics baseline(byte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(src.Left[it] * src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulI16()
        {
            var opid = Id<short>(OpKind.Mul);

            OpMetrics baseline(short[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(src.Left[it] * src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulU16()
        {
            var opid = Id<ushort>(OpKind.Mul);

            OpMetrics baseline(ushort[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(src.Left[it] * src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }


        public IBenchComparison MulI32()
        {
            var opid = Id<int>(OpKind.Mul);

            OpMetrics baseline(int[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] * src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulU32()
        {
            var opid = Id<uint>(OpKind.Mul);

            OpMetrics baseline(uint[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] * src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulI64()
        {
            var opid = Id<long>(OpKind.Mul);

            OpMetrics baseline(long[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] * src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulU64()
        {
            var opid = Id<ulong>(OpKind.Mul);
            
            OpMetrics baseline(ulong[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] * src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison MulF32()
        {
            var opid = Id<float>(OpKind.Mul);
            
            OpMetrics baseline(float[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] * src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison MulF64()
        {
            var opid = Id<double>(OpKind.Mul);
            
            OpMetrics baseline(double[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] * src.Right[it];
                return(SampleSize, snapshot(sw));
            }
    
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => mul(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }
    }
}