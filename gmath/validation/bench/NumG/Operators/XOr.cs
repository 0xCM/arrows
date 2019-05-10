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
        OpMetrics xor<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid =  Id<T>(OpKind.XOr);
            var src = Sampled(opid);
            var lhs = Number.many(src.Left);
            var rhs = Number.many(src.Right);

            var sw = stopwatch();
            var it = -1;
            while(++it < SampleSize)
                dst[it] = lhs[it] ^ rhs[it];
            return(SampleSize, snapshot(sw));
        }

        public IBenchComparison XOrI8()
        {
            var opid =  Id<sbyte>(OpKind.And);

            OpMetrics baseline(sbyte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(src.Left[it] ^ src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);
            return Finish(comparison);
        }

        public IBenchComparison XOrU8()
        {
            var opid =  Id<byte>(OpKind.And);

            OpMetrics baseline(byte[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(src.Left[it] ^ src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrI16()
        {
            var opid = Id<short>(OpKind.And);

            OpMetrics baseline(short[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(src.Left[it] ^ src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrU16()
        {
            var opid = Id<ushort>(OpKind.And);

            OpMetrics baseline(ushort[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(src.Left[it] ^ src.Right[it]);
                return(SampleSize, snapshot(sw));
            }
                        
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrI32()
        {
            var opid = Id<int>(OpKind.And);

            OpMetrics baseline(int[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] ^ src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrU32()
        {
            var opid = Id<uint>(OpKind.And);
            
            OpMetrics baseline(uint[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] ^ src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrI64()
        {
            var opid = Id<long>(OpKind.And);
            
            OpMetrics baseline(long[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] ^ src.Right[it];
                return(SampleSize, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison XOrU64()
        {
            var opid = Id<ulong>(OpKind.And);
 
            OpMetrics baseline(ulong[] dst)
            {
                var src = Sampled(opid);
                var sw = stopwatch();
                
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] ^ src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(~opid, () => baseline(dst.Left)), 
                Measure(opid, () => xor(dst.Right)));

            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }
    }
}