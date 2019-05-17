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

    partial class Vec128Bench
    {   
        IOpMetrics And<T>(OpId<T> opid, T[] dst)
            where T : struct
        {
            var lhs = LeftSample(opid);
            var rhs = RightSample(opid);
            
            var sw = stopwatch();
            ginx.and(lhs, rhs, dst.ToSpan128());
            return Metrics.Define(opid, lhs.Length, snapshot(sw),dst);
        }

        public IBenchComparison AndI8()
        {
            var opid = Id<sbyte>(OpKind.And);
            
            IOpMetrics baseline(Span128<sbyte> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU8()        
        {
            var opid = Id<byte>(OpKind.And);

            IOpMetrics baseline(Span128<byte> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);
        
            IOpMetrics baseline(Span128<short> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU16()        
        {
            var opid = Id<ushort>(OpKind.And);
            
            IOpMetrics baseline(Span128<ushort> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);
            
            IOpMetrics baseline(Span128<int> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU326()        
        {
            var opid = Id<uint>(OpKind.And);
            
            IOpMetrics baseline(Span128<uint> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);

            IOpMetrics baseline(Span128<long> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU64()        
        {
            var opid = Id<ulong>(OpKind.And);
            
            IOpMetrics baseline(Span128<ulong> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndF32()        
        {
            var opid = Id<float>(OpKind.And);
            
            IOpMetrics baseline(Span128<float> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndF64()        
        {
            var opid = Id<double>(OpKind.And);
 
            IOpMetrics baseline(Span128<double> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                 Measure(~opid, () => And(opid, dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
       }

    }

}