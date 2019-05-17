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

    partial class Vec256Bench 
    {   
        IOpMetrics gsub<T>(T[] dst)
            where T : struct
        {
            var opid = Id<T>(OpKind.Sub);
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            ginx.sub(lhs, rhs, dst.ToSpan256());
            return Metrics.Define(opid, lhs.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<byte> dst)
        {
            var opid = Id<byte>(OpKind.Sub);
            var lhs = LeftSrc.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<sbyte> dst)
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var lhs = LeftSrc.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<short> dst)
        {
            var opid = Id<short>(OpKind.Sub);
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<ushort> dst)
        {
            var opid = Id<ushort>(OpKind.Sub);
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<int> dst)
        {
            var opid = Id<int>(OpKind.Sub);
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<uint> dst)
        {
           var opid = Id<uint>(OpKind.Sub);
             var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<long> dst)
        {
           var opid = Id<long>(OpKind.Sub);
             var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<ulong> dst)
        {
           var opid = Id<ulong>(OpKind.Sub);
             var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<float> dst)
        {
           var opid = Id<float>(OpKind.Sub);
             var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }

        IOpMetrics dsub(Span256<double> dst)
        {
           var opid = Id<double>(OpKind.Sub);
             var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return Metrics.Define(opid,dst.Length, snapshot(sw), dst);
        }


        public IBenchComparison SubI8()
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubU8()        
        {
            var opid = Id<byte>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI16()
        {
            var opid = Id<short>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU16()        
        {
            var opid = Id<ushort>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI32()
        {
            var opid = Id<int>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU326()        
        {
            var opid = Id<uint>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI64()
        {
            var opid = Id<long>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU64()        
        {
            var opid = Id<ulong>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison SubF32()        
        {
            var opid = Id<float>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubF64()        
        {
            var opid = Id<double>(OpKind.Sub);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dsub(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }
    }

}