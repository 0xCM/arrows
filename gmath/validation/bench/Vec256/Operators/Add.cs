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
        OpMeasure gadd<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = RightSrc.Sampled(head(dst));
            var sw = stopwatch();
            ginx.add(lhs, rhs, dst.ToSpan256());
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<byte> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<sbyte> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            Claim.nonzero(lhs.Length);

            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<short> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<ushort> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<int> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<uint> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<long> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<ulong> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<float> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }

        OpMeasure dadd(Span256<double> dst)
        {
            var lhs = LeftSrc.Sampled(dst.Head);
            var rhs = RightSrc.Sampled(dst.Head);
            var sw = stopwatch();
            dinx.add(lhs, rhs, ref dst);
            return(lhs.Length, snapshot(sw));
        }


        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU8()        
        {
            var opid = Id<byte>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid = Id<short>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU16()        
        {
            var opid = Id<ushort>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI32()
        {
            var opid = Id<int>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU326()        
        {
            var opid = Id<uint>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid = Id<long>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddU64()        
        {
            var opid = Id<ulong>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison AddF32()        
        {
            var opid = Id<float>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison AddF64()        
        {
            var opid = Id<double>(OpKind.Add);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(opid, () => dadd(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }



    }

}