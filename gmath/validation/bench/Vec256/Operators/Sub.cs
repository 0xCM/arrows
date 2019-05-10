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
        OpMetrics gsub<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            ginx.sub(lhs, rhs, dst.ToSpan256());
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<byte> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<sbyte> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<short> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<ushort> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<int> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<uint> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<long> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<ulong> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<float> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMetrics dsub(Span256<double> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.sub(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public IBenchComparison SubI8()
        {
            var opid = OpKind.Sub.Vec256OpId<sbyte>();
            (var lDst, var rDst) = Targets<sbyte>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU8()        
        {
            var opid = OpKind.Sub.Vec256OpId<byte>();
            (var lDst, var rDst) = Targets<byte>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI16()
        {
            var opid = OpKind.Sub.Vec256OpId<short>();
            (var lDst, var rDst) = Targets<short>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU16()        
        {
            var opid = OpKind.Sub.Vec256OpId<ushort>();
            (var lDst, var rDst) = Targets<ushort>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI32()
        {
            var opid = OpKind.Sub.Vec256OpId<int>();
            (var lDst, var rDst) = Targets<int>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU326()        
        {
            var opid = OpKind.Sub.Vec256OpId<uint>();
            (var lDst, var rDst) = Targets<uint>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubI64()
        {
            var opid = OpKind.Sub.Vec256OpId<long>();
            (var lDst, var rDst) = Targets<long>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubU64()        
        {
            var opid = OpKind.Sub.Vec256OpId<ulong>();
            (var lDst, var rDst) = Targets<ulong>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }


        public IBenchComparison SubF32()        
        {
            var opid = OpKind.Sub.Vec256OpId<float>();
            (var lDst, var rDst) = Targets<float>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }

        public IBenchComparison SubF64()        
        {
            var opid = OpKind.Sub.Vec256OpId<double>();
            (var lDst, var rDst) = Targets<double>();

            var comparison = Run(opid, 
                Measure(opid, () => dsub(lDst)), 
                Measure(~opid, () => gsub(rDst)));            

            Claim.eq(lDst, rDst);        
            
            return Finish(comparison);
        }



    }

}